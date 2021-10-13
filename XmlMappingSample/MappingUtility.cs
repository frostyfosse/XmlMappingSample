using Newtonsoft.Json;
using System;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
using XmlMappingSample.Models;
using System.Linq;

namespace XmlMappingSample
{
    public static class MappingUtility
    {
        #region Dynamic Pattern
        //https://stackoverflow.com/questions/987135/how-to-remove-all-namespaces-from-xml-with-c
        static XElement RemoveAllNamespaces(XElement old)
        {
            XElement element = null;

            if (old.HasElements)
            {
                var elements = old.Elements().Select(x => RemoveAllNamespaces(x));
                element = new XElement(old.Name.LocalName, elements);
            }
            else
            {
                element = new XElement(old.Name.LocalName);
                element.Value = old.Value;
            }

            foreach (XAttribute attr in old.Attributes())
            {
                if (attr.IsNamespaceDeclaration)
                    continue;
                else if (attr.Name.LocalName.EndsWith("schemaLocation"))
                    continue;

                element.Add(attr);
            }

            return element;
        }

        static void MapMetadataDynamic(dynamic dynMetadata, ISPSubmission submission)
        {
            if (dynMetadata == null)
                return;

            var messageId = dynMetadata.MessageIdentification?.IdentificationID;
            var ori = dynMetadata.MessageSubmittingOrganization?
                                 .OrganizationAugmentation?
                                 .OrganizationORIIdentification?
                                 .IdentificationID;
            var version = Convert.ToDecimal(dynMetadata.MessageImplementationVersion);
            string dateTimeText = dynMetadata.MessageDateTime;
            DateTime? dateTime = null;

            if (DateTime.TryParse(dateTimeText, out DateTime newDateTime))
                dateTime = newDateTime;

            submission.MessageMetadata = new MessageMetadata()
            {
                MessageIdentification = new MessageMetadataMessageIdentification()
                {
                    IdentificationID = messageId
                },
                MessageDateTime = dateTime,
                MessageImplementationVersion = version,
                MessageSubmittingOrganization = new MessageMetadataMessageSubmittingOrganization()
                {
                    OrganizationAugmentation = new OrganizationAugmentation()
                    {
                        OrganizationORIIdentification = new OrganizationAugmentationOrganizationORIIdentification()
                        {
                            IdentificationID = ori
                        }
                    }
                }
            };
        }

        static void MapReportDynamic(dynamic dynReport, ISPSubmission submission)
        {
            if (dynReport == null)
                return;

            var report = submission.Report = new Report();

            MapReportHeaderDynamic(dynReport.ReportHeader, report);
        }

        static void MapReportHeaderDynamic(dynamic dynHeader, Report report)
        {
            if (dynHeader == null)
                return;

            report.ReportHeader = new ReportReportHeader()
            {
                NIBRSReportCategoryCode = dynHeader.NIBRSReportCategoryCode,
                ReportActionCategoryCode = dynHeader.ReportActionCategoryCode,
                ReportDate = new ReportReportHeaderReportDate()
                {
                    YearMonthDate = dynHeader.ReportDate?.YearMonthDate
                },
                ReportingAgency = new ReportReportHeaderReportingAgency()
                {
                    OrganizationAugmentation = new OrganizationAugmentation()
                    {
                        OrganizationORIIdentification = new OrganizationAugmentationOrganizationORIIdentification()
                        {
                            IdentificationID = dynHeader.ReportingAgency?
                                                                    .OrganizationAugmentation?
                                                                    .OrganizationORIIdentification?
                                                                    .IdentificationID
                        }
                    }
                }
            };
        }

        static dynamic DeserializeAsDynamic(string xml)
        {
            var element = RemoveAllNamespaces(XElement.Parse(xml));
            var newJson = JsonConvert.SerializeXNode(element);
            dynamic dynSubmission = JsonConvert.DeserializeObject<JObject>(newJson);

            return dynSubmission;
        }

        public static ISPSubmission GetSubmissionDynamic(string xml)
        {
            var dynDocument = DeserializeAsDynamic(xml);
            var dynSubmission = dynDocument?.ISPSubmission;
            var submission = new ISPSubmission();

            if (dynSubmission == null)
                return submission;

            MapMetadataDynamic(dynSubmission.MessageMetadata, submission);
            MapReportDynamic(dynSubmission.Report, submission);

            return submission;
        }
        #endregion

        #region Tranditional pattern
        static T Get<T>(string elementName, JToken element)
        {
            if (element == null)
                return default;

            return element.Value<T>(elementName);
        }

        static void MapMetadataTraditional(JToken submissionElement, ISPSubmission submission)
        {
            if (submissionElement == null)
                return;

            var metadata = submission.MessageMetadata = new MessageMetadata();
            var metadataElement = submissionElement[References.Metadata.NodeName];
            var oriElement = metadataElement[References.Metadata.MessageSubmittingOrganization]?
                                            [References.Metadata.OrganizationAugmentation]?
                                            [References.Metadata.OrganizationORIIdentification];
            var messageIdElement = metadataElement[References.Metadata.MessageIdentification];

            metadata.MessageDateTime = Get<DateTime?>(References.Metadata.MessageDateTime, metadataElement);
            metadata.MessageImplementationVersion = Get<decimal>(References.Metadata.MessageImplementationVersion, metadataElement);
            metadata.MessageIdentification = new MessageMetadataMessageIdentification()
            {
                IdentificationID = Get<string>(References.Metadata.IdentificationID, messageIdElement)
            };
            metadata.MessageSubmittingOrganization = new MessageMetadataMessageSubmittingOrganization()
            {
                OrganizationAugmentation = new OrganizationAugmentation()
                {
                    OrganizationORIIdentification = new OrganizationAugmentationOrganizationORIIdentification()
                    {
                        IdentificationID = Get<string>(References.Metadata.IdentificationID, oriElement)
                    }
                }
            };
        }

        static void MapReportTraditional(JToken submissionElement, ISPSubmission submission)
        {
            if (submissionElement == null)
                return;

            var report = submission.Report = new Report();

            MapReportHeaderTraditional(submissionElement[References.Report.NodeName], report);
        }

        static void MapReportHeaderTraditional(JToken reportElement, Report report)
        {
            if (reportElement == null)
                return;

            var headerElement = reportElement[References.Report.ReportHeader.NodeName];
            var header = report.ReportHeader = new ReportReportHeader();

            header.NIBRSReportCategoryCode = headerElement[References.Report.ReportHeader.NIBRSReportCategoryCode]?.ToString();
            header.ReportDate = new ReportReportHeaderReportDate()
            {
                YearMonthDate = headerElement[References.Report.ReportHeader.ReportDate.NodeName]?
                                             [References.Report.ReportHeader.ReportDate.YearMonthDate]?
                                             .ToString()
            };
            header.ReportActionCategoryCode = headerElement[References.Report.ReportHeader.ReportActionCategoryCode].ToString();
            header.ReportingAgency = new ReportReportHeaderReportingAgency()
            {
                OrganizationAugmentation = new OrganizationAugmentation()
                {
                    OrganizationORIIdentification = new OrganizationAugmentationOrganizationORIIdentification()
                    {
                        IdentificationID = headerElement[References.Report.ReportHeader.ReportingAgency.NodeName]?
                                                        [References.Report.ReportHeader.ReportingAgency.OrganizationAugmentation.NodeName]?
                                                        [References.Report.ReportHeader.ReportingAgency.OrganizationAugmentation.OrganizationORIIdentification.NodeName]?
                                                        [References.Report.ReportHeader.ReportingAgency.OrganizationAugmentation.OrganizationORIIdentification.IdentificationID].ToString()
                    }
                }
            };
        }

        public static ISPSubmission GetSubmissionTraditional(string xml)
        {
            var doc = XDocument.Parse(xml);
            var json = JsonConvert.SerializeXNode(doc);
            var element = JsonConvert.DeserializeObject<JObject>(json);

            var submission = new ISPSubmission();
            var submissionElement = element[References.Submission.NodeName];

            MapMetadataTraditional(submissionElement, submission);
            MapReportTraditional(submissionElement, submission);

            return submission;
        }
        #endregion
    }
}
