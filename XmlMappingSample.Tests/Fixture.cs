using System;
using System.IO;
using XmlMappingSample.Models;
using Xunit;

namespace XmlMappingSample.Tests
{
    public class Fixture
    {
        #region Helper methods
        string GetXmlData()
        {
            var path = Path.Combine(Environment.CurrentDirectory, 
                                    "Samples", 
                                    "IN0710100_0208190536_1967.xml");
            var xml = File.ReadAllText(path);

            return xml;
        }

        void ValidateResults(ISPSubmission submission)
        {
            var metadata = submission.MessageMetadata;
            var header = submission.Report.ReportHeader;

            Assert.NotNull(metadata);
            Assert.NotNull(header);

            //Metadata
            DateTime? messageDateTime = DateTime.Parse("2019-02-08T05:34:37");

            Assert.Equal(messageDateTime, metadata.MessageDateTime);
            Assert.Equal("24A83979-9BBD-4F83-85C5-6829F783D83F", metadata.MessageIdentification?.IdentificationID);
            Assert.Equal(Convert.ToDecimal(4.2), metadata.MessageImplementationVersion);
            Assert.Equal("IN0710100", metadata.MessageSubmittingOrganization?
                                              .OrganizationAugmentation?
                                              .OrganizationORIIdentification?
                                              .IdentificationID);

            //Report
            Assert.Equal("GROUP A INCIDENT REPORT", header.NIBRSReportCategoryCode);
            Assert.Equal("I", header.ReportActionCategoryCode);
            Assert.Equal("2019-02", header.ReportDate?.YearMonthDate);
            Assert.Equal("IN0710100", header.ReportingAgency?
                                            .OrganizationAugmentation?
                                            .OrganizationORIIdentification?
                                            .IdentificationID);
        }
        #endregion

        [Fact]
        public void TestTraditional()
        {
            ValidateResults(MappingUtility.GetSubmissionTraditionally(GetXmlData()));
        }

        [Fact]
        public void TestDynamic()
        {
            ValidateResults(MappingUtility.GetSubmissionDynamically(GetXmlData()));
        }
    }
}
