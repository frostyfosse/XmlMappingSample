using System;
using System.Collections.Generic;
using System.Text;

namespace XmlMappingSample.Models
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ariesportal.com/isp/isp-nibrs/1.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://ariesportal.com/isp/isp-nibrs/1.0", IsNullable = false)]
    public partial class ISPSubmission
    {

        private MessageMetadata messageMetadataField;

        private Report reportField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://fbi.gov/cjis/2.0")]
        public MessageMetadata MessageMetadata
        {
            get
            {
                return this.messageMetadataField;
            }
            set
            {
                this.messageMetadataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://fbi.gov/cjis/nibrs/4.2")]
        public Report Report
        {
            get
            {
                return this.reportField;
            }
            set
            {
                this.reportField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://fbi.gov/cjis/2.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://fbi.gov/cjis/2.0", IsNullable = false)]
    public partial class MessageMetadata
    {

        private System.DateTime? messageDateTimeField;

        private MessageMetadataMessageIdentification messageIdentificationField;

        private decimal messageImplementationVersionField;

        private MessageMetadataMessageSubmittingOrganization messageSubmittingOrganizationField;

        /// <remarks/>
        public System.DateTime? MessageDateTime
        {
            get
            {
                return this.messageDateTimeField;
            }
            set
            {
                this.messageDateTimeField = value;
            }
        }

        /// <remarks/>
        public MessageMetadataMessageIdentification MessageIdentification
        {
            get
            {
                return this.messageIdentificationField;
            }
            set
            {
                this.messageIdentificationField = value;
            }
        }

        /// <remarks/>
        public decimal MessageImplementationVersion
        {
            get
            {
                return this.messageImplementationVersionField;
            }
            set
            {
                this.messageImplementationVersionField = value;
            }
        }

        /// <remarks/>
        public MessageMetadataMessageSubmittingOrganization MessageSubmittingOrganization
        {
            get
            {
                return this.messageSubmittingOrganizationField;
            }
            set
            {
                this.messageSubmittingOrganizationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://fbi.gov/cjis/2.0")]
    public partial class MessageMetadataMessageIdentification
    {

        private string identificationIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://release.niem.gov/niem/niem-core/3.0/")]
        public string IdentificationID
        {
            get
            {
                return this.identificationIDField;
            }
            set
            {
                this.identificationIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://fbi.gov/cjis/2.0")]
    public partial class MessageMetadataMessageSubmittingOrganization
    {

        private OrganizationAugmentation organizationAugmentationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://release.niem.gov/niem/domains/jxdm/5.2/")]
        public OrganizationAugmentation OrganizationAugmentation
        {
            get
            {
                return this.organizationAugmentationField;
            }
            set
            {
                this.organizationAugmentationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://release.niem.gov/niem/domains/jxdm/5.2/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://release.niem.gov/niem/domains/jxdm/5.2/", IsNullable = false)]
    public partial class OrganizationAugmentation
    {

        private OrganizationAugmentationOrganizationORIIdentification organizationORIIdentificationField;

        /// <remarks/>
        public OrganizationAugmentationOrganizationORIIdentification OrganizationORIIdentification
        {
            get
            {
                return this.organizationORIIdentificationField;
            }
            set
            {
                this.organizationORIIdentificationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://release.niem.gov/niem/domains/jxdm/5.2/")]
    public partial class OrganizationAugmentationOrganizationORIIdentification
    {

        private string identificationIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://release.niem.gov/niem/niem-core/3.0/")]
        public string IdentificationID
        {
            get
            {
                return this.identificationIDField;
            }
            set
            {
                this.identificationIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://fbi.gov/cjis/nibrs/4.2")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://fbi.gov/cjis/nibrs/4.2", IsNullable = false)]
    public partial class Report
    {

        private ReportReportHeader reportHeaderField;

        private Incident incidentField;

        private Offense[] offenseField;

        private Location[] locationField;

        private Item[] itemField;

        private Person[] personField;

        private Victim[] victimField;

        private Subject[] subjectField;

        private Arrestee[] arresteeField;

        private Arrest[] arrestField;

        private ArrestSubjectAssociation[] arrestSubjectAssociationField;

        private OffenseLocationAssociation[] offenseLocationAssociationField;

        private OffenseVictimAssociation[] offenseVictimAssociationField;

        private SubjectVictimAssociation[] subjectVictimAssociationField;

        /// <remarks/>
        public ReportReportHeader ReportHeader
        {
            get
            {
                return this.reportHeaderField;
            }
            set
            {
                this.reportHeaderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://release.niem.gov/niem/niem-core/3.0/")]
        public Incident Incident
        {
            get
            {
                return this.incidentField;
            }
            set
            {
                this.incidentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Offense", Namespace = "http://release.niem.gov/niem/domains/jxdm/5.2/")]
        public Offense[] Offense
        {
            get
            {
                return this.offenseField;
            }
            set
            {
                this.offenseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Location", Namespace = "http://release.niem.gov/niem/niem-core/3.0/")]
        public Location[] Location
        {
            get
            {
                return this.locationField;
            }
            set
            {
                this.locationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Item", Namespace = "http://release.niem.gov/niem/niem-core/3.0/")]
        public Item[] Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Person", Namespace = "http://release.niem.gov/niem/niem-core/3.0/")]
        public Person[] Person
        {
            get
            {
                return this.personField;
            }
            set
            {
                this.personField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Victim", Namespace = "http://release.niem.gov/niem/domains/jxdm/5.2/")]
        public Victim[] Victim
        {
            get
            {
                return this.victimField;
            }
            set
            {
                this.victimField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Subject", Namespace = "http://release.niem.gov/niem/domains/jxdm/5.2/")]
        public Subject[] Subject
        {
            get
            {
                return this.subjectField;
            }
            set
            {
                this.subjectField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Arrestee", Namespace = "http://release.niem.gov/niem/domains/jxdm/5.2/")]
        public Arrestee[] Arrestee
        {
            get
            {
                return this.arresteeField;
            }
            set
            {
                this.arresteeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Arrest", Namespace = "http://release.niem.gov/niem/domains/jxdm/5.2/")]
        public Arrest[] Arrest
        {
            get
            {
                return this.arrestField;
            }
            set
            {
                this.arrestField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ArrestSubjectAssociation", Namespace = "http://release.niem.gov/niem/domains/jxdm/5.2/")]
        public ArrestSubjectAssociation[] ArrestSubjectAssociation
        {
            get
            {
                return this.arrestSubjectAssociationField;
            }
            set
            {
                this.arrestSubjectAssociationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OffenseLocationAssociation", Namespace = "http://release.niem.gov/niem/domains/jxdm/5.2/")]
        public OffenseLocationAssociation[] OffenseLocationAssociation
        {
            get
            {
                return this.offenseLocationAssociationField;
            }
            set
            {
                this.offenseLocationAssociationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OffenseVictimAssociation", Namespace = "http://release.niem.gov/niem/domains/jxdm/5.2/")]
        public OffenseVictimAssociation[] OffenseVictimAssociation
        {
            get
            {
                return this.offenseVictimAssociationField;
            }
            set
            {
                this.offenseVictimAssociationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SubjectVictimAssociation", Namespace = "http://release.niem.gov/niem/domains/jxdm/5.2/")]
        public SubjectVictimAssociation[] SubjectVictimAssociation
        {
            get
            {
                return this.subjectVictimAssociationField;
            }
            set
            {
                this.subjectVictimAssociationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://fbi.gov/cjis/nibrs/4.2")]
    public partial class ReportReportHeader
    {

        private string nIBRSReportCategoryCodeField;

        private string reportActionCategoryCodeField;

        private ReportReportHeaderReportDate reportDateField;

        private ReportReportHeaderReportingAgency reportingAgencyField;

        /// <remarks/>
        public string NIBRSReportCategoryCode
        {
            get
            {
                return this.nIBRSReportCategoryCodeField;
            }
            set
            {
                this.nIBRSReportCategoryCodeField = value;
            }
        }

        /// <remarks/>
        public string ReportActionCategoryCode
        {
            get
            {
                return this.reportActionCategoryCodeField;
            }
            set
            {
                this.reportActionCategoryCodeField = value;
            }
        }

        /// <remarks/>
        public ReportReportHeaderReportDate ReportDate
        {
            get
            {
                return this.reportDateField;
            }
            set
            {
                this.reportDateField = value;
            }
        }

        /// <remarks/>
        public ReportReportHeaderReportingAgency ReportingAgency
        {
            get
            {
                return this.reportingAgencyField;
            }
            set
            {
                this.reportingAgencyField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://fbi.gov/cjis/nibrs/4.2")]
    public partial class ReportReportHeaderReportDate
    {

        private string yearMonthDateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://release.niem.gov/niem/niem-core/3.0/", DataType = "gYearMonth")]
        public string YearMonthDate
        {
            get
            {
                return this.yearMonthDateField;
            }
            set
            {
                this.yearMonthDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://fbi.gov/cjis/nibrs/4.2")]
    public partial class ReportReportHeaderReportingAgency
    {

        private OrganizationAugmentation organizationAugmentationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://release.niem.gov/niem/domains/jxdm/5.2/")]
        public OrganizationAugmentation OrganizationAugmentation
        {
            get
            {
                return this.organizationAugmentationField;
            }
            set
            {
                this.organizationAugmentationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://release.niem.gov/niem/niem-core/3.0/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://release.niem.gov/niem/niem-core/3.0/", IsNullable = false)]
    public partial class Incident
    {

        private IncidentActivityIdentification activityIdentificationField;

        private IncidentActivityDate activityDateField;

        private IncidentAugmentation incidentAugmentationField;

        private IncidentAugmentation1 incidentAugmentation1Field;

        /// <remarks/>
        public IncidentActivityIdentification ActivityIdentification
        {
            get
            {
                return this.activityIdentificationField;
            }
            set
            {
                this.activityIdentificationField = value;
            }
        }

        /// <remarks/>
        public IncidentActivityDate ActivityDate
        {
            get
            {
                return this.activityDateField;
            }
            set
            {
                this.activityDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://fbi.gov/cjis/2.0")]
        public IncidentAugmentation IncidentAugmentation
        {
            get
            {
                return this.incidentAugmentationField;
            }
            set
            {
                this.incidentAugmentationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IncidentAugmentation", Namespace = "http://release.niem.gov/niem/domains/jxdm/5.2/")]
        public IncidentAugmentation1 IncidentAugmentation1
        {
            get
            {
                return this.incidentAugmentation1Field;
            }
            set
            {
                this.incidentAugmentation1Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://release.niem.gov/niem/niem-core/3.0/")]
    public partial class IncidentActivityIdentification
    {

        private ulong identificationIDField;

        /// <remarks/>
        public ulong IdentificationID
        {
            get
            {
                return this.identificationIDField;
            }
            set
            {
                this.identificationIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://release.niem.gov/niem/niem-core/3.0/")]
    public partial class IncidentActivityDate
    {

        private System.DateTime? dateTimeField;

        /// <remarks/>
        public System.DateTime? DateTime
        {
            get
            {
                return this.dateTimeField;
            }
            set
            {
                this.dateTimeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://fbi.gov/cjis/2.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://fbi.gov/cjis/2.0", IsNullable = false)]
    public partial class IncidentAugmentation
    {

        private bool incidentReportDateIndicatorField;

        /// <remarks/>
        public bool IncidentReportDateIndicator
        {
            get
            {
                return this.incidentReportDateIndicatorField;
            }
            set
            {
                this.incidentReportDateIndicatorField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://release.niem.gov/niem/domains/jxdm/5.2/")]
    [System.Xml.Serialization.XmlRootAttribute("IncidentAugmentation", Namespace = "http://release.niem.gov/niem/domains/jxdm/5.2/", IsNullable = false)]
    public partial class IncidentAugmentation1
    {

        private string incidentExceptionalClearanceCodeField;

        /// <remarks/>
        public string IncidentExceptionalClearanceCode
        {
            get
            {
                return this.incidentExceptionalClearanceCodeField;
            }
            set
            {
                this.incidentExceptionalClearanceCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://release.niem.gov/niem/domains/jxdm/5.2/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://release.niem.gov/niem/domains/jxdm/5.2/", IsNullable = false)]
    public partial class Offense
    {

        private string offenseUCRCodeField;

        private Offense1 offense1Field;

        private string offenseFactorBiasMotivationCodeField;

        private OffenseOffenseFactor offenseFactorField;

        private OffenseOffenseForce offenseForceField;

        private bool offenseAttemptedIndicatorField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://fbi.gov/cjis/nibrs/4.2")]
        public string OffenseUCRCode
        {
            get
            {
                return this.offenseUCRCodeField;
            }
            set
            {
                this.offenseUCRCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Offense", Namespace = "http://ariesportal.com/isp/isp-nibrs/1.0")]
        public Offense1 Offense1
        {
            get
            {
                return this.offense1Field;
            }
            set
            {
                this.offense1Field = value;
            }
        }

        /// <remarks/>
        public string OffenseFactorBiasMotivationCode
        {
            get
            {
                return this.offenseFactorBiasMotivationCodeField;
            }
            set
            {
                this.offenseFactorBiasMotivationCodeField = value;
            }
        }

        /// <remarks/>
        public OffenseOffenseFactor OffenseFactor
        {
            get
            {
                return this.offenseFactorField;
            }
            set
            {
                this.offenseFactorField = value;
            }
        }

        /// <remarks/>
        public OffenseOffenseForce OffenseForce
        {
            get
            {
                return this.offenseForceField;
            }
            set
            {
                this.offenseForceField = value;
            }
        }

        /// <remarks/>
        public bool OffenseAttemptedIndicator
        {
            get
            {
                return this.offenseAttemptedIndicatorField;
            }
            set
            {
                this.offenseAttemptedIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://release.niem.gov/niem/structures/3.0/")]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ariesportal.com/isp/isp-nibrs/1.0")]
    [System.Xml.Serialization.XmlRootAttribute("Offense", Namespace = "http://ariesportal.com/isp/isp-nibrs/1.0", IsNullable = false)]
    public partial class Offense1
    {

        private ushort offenseCodeField;

        private string misdemeanorClassField;

        private byte countsField;

        /// <remarks/>
        public ushort OffenseCode
        {
            get
            {
                return this.offenseCodeField;
            }
            set
            {
                this.offenseCodeField = value;
            }
        }

        /// <remarks/>
        public string MisdemeanorClass
        {
            get
            {
                return this.misdemeanorClassField;
            }
            set
            {
                this.misdemeanorClassField = value;
            }
        }

        /// <remarks/>
        public byte Counts
        {
            get
            {
                return this.countsField;
            }
            set
            {
                this.countsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://release.niem.gov/niem/domains/jxdm/5.2/")]
    public partial class OffenseOffenseFactor
    {

        private string offenseFactorCodeField;

        /// <remarks/>
        public string OffenseFactorCode
        {
            get
            {
                return this.offenseFactorCodeField;
            }
            set
            {
                this.offenseFactorCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://release.niem.gov/niem/domains/jxdm/5.2/")]
    public partial class OffenseOffenseForce
    {

        private byte forceCategoryCodeField;

        /// <remarks/>
        public byte ForceCategoryCode
        {
            get
            {
                return this.forceCategoryCodeField;
            }
            set
            {
                this.forceCategoryCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://release.niem.gov/niem/niem-core/3.0/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://release.niem.gov/niem/niem-core/3.0/", IsNullable = false)]
    public partial class Location
    {

        private OffenseLocation offenseLocationField;

        private byte locationCategoryCodeField;

        private string idField;

        private string refField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://ariesportal.com/isp/isp-nibrs/1.0")]
        public OffenseLocation OffenseLocation
        {
            get
            {
                return this.offenseLocationField;
            }
            set
            {
                this.offenseLocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://fbi.gov/cjis/nibrs/4.2")]
        public byte LocationCategoryCode
        {
            get
            {
                return this.locationCategoryCodeField;
            }
            set
            {
                this.locationCategoryCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://release.niem.gov/niem/structures/3.0/")]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://release.niem.gov/niem/structures/3.0/")]
        public string @ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://ariesportal.com/isp/isp-nibrs/1.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://ariesportal.com/isp/isp-nibrs/1.0", IsNullable = false)]
    public partial class OffenseLocation
    {

        private byte houseNumberField;

        private string street1Field;

        private string cityNameField;

        private ushort zipField;

        private byte latField;

        private byte longField;

        /// <remarks/>
        public byte HouseNumber
        {
            get
            {
                return this.houseNumberField;
            }
            set
            {
                this.houseNumberField = value;
            }
        }

        /// <remarks/>
        public string Street1
        {
            get
            {
                return this.street1Field;
            }
            set
            {
                this.street1Field = value;
            }
        }

        /// <remarks/>
        public string CityName
        {
            get
            {
                return this.cityNameField;
            }
            set
            {
                this.cityNameField = value;
            }
        }

        /// <remarks/>
        public ushort Zip
        {
            get
            {
                return this.zipField;
            }
            set
            {
                this.zipField = value;
            }
        }

        /// <remarks/>
        public byte Lat
        {
            get
            {
                return this.latField;
            }
            set
            {
                this.latField = value;
            }
        }

        /// <remarks/>
        public byte Long
        {
            get
            {
                return this.longField;
            }
            set
            {
                this.longField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://release.niem.gov/niem/niem-core/3.0/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://release.niem.gov/niem/niem-core/3.0/", IsNullable = false)]
    public partial class Item
    {

        private ItemItemStatus itemStatusField;

        private ItemItemValue itemValueField;

        private byte itemCategoryNIBRSPropertyCategoryCodeField;

        /// <remarks/>
        public ItemItemStatus ItemStatus
        {
            get
            {
                return this.itemStatusField;
            }
            set
            {
                this.itemStatusField = value;
            }
        }

        /// <remarks/>
        public ItemItemValue ItemValue
        {
            get
            {
                return this.itemValueField;
            }
            set
            {
                this.itemValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://release.niem.gov/niem/domains/jxdm/5.2/")]
        public byte ItemCategoryNIBRSPropertyCategoryCode
        {
            get
            {
                return this.itemCategoryNIBRSPropertyCategoryCodeField;
            }
            set
            {
                this.itemCategoryNIBRSPropertyCategoryCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://release.niem.gov/niem/niem-core/3.0/")]
    public partial class ItemItemStatus
    {

        private string itemStatusCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://fbi.gov/cjis/2.0")]
        public string ItemStatusCode
        {
            get
            {
                return this.itemStatusCodeField;
            }
            set
            {
                this.itemStatusCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://release.niem.gov/niem/niem-core/3.0/")]
    public partial class ItemItemValue
    {

        private ItemItemValueItemValueAmount itemValueAmountField;

        /// <remarks/>
        public ItemItemValueItemValueAmount ItemValueAmount
        {
            get
            {
                return this.itemValueAmountField;
            }
            set
            {
                this.itemValueAmountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://release.niem.gov/niem/niem-core/3.0/")]
    public partial class ItemItemValueItemValueAmount
    {

        private ushort amountField;

        /// <remarks/>
        public ushort Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://release.niem.gov/niem/niem-core/3.0/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://release.niem.gov/niem/niem-core/3.0/", IsNullable = false)]
    public partial class Person
    {

        private PersonPersonAgeMeasure personAgeMeasureField;

        private string personEthnicityCodeField;

        private string personRaceNDExCodeField;

        private string personResidentCodeField;

        private string personSexCodeField;

        private string idField;

        /// <remarks/>
        public PersonPersonAgeMeasure PersonAgeMeasure
        {
            get
            {
                return this.personAgeMeasureField;
            }
            set
            {
                this.personAgeMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://release.niem.gov/niem/domains/jxdm/5.2/")]
        public string PersonEthnicityCode
        {
            get
            {
                return this.personEthnicityCodeField;
            }
            set
            {
                this.personEthnicityCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://release.niem.gov/niem/domains/jxdm/5.2/")]
        public string PersonRaceNDExCode
        {
            get
            {
                return this.personRaceNDExCodeField;
            }
            set
            {
                this.personRaceNDExCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://release.niem.gov/niem/domains/jxdm/5.2/")]
        public string PersonResidentCode
        {
            get
            {
                return this.personResidentCodeField;
            }
            set
            {
                this.personResidentCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://release.niem.gov/niem/domains/jxdm/5.2/")]
        public string PersonSexCode
        {
            get
            {
                return this.personSexCodeField;
            }
            set
            {
                this.personSexCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://release.niem.gov/niem/structures/3.0/")]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://release.niem.gov/niem/niem-core/3.0/")]
    public partial class PersonPersonAgeMeasure
    {

        private PersonPersonAgeMeasureMeasureIntegerRange measureIntegerRangeField;

        private byte measureIntegerValueField;

        private bool measureIntegerValueFieldSpecified;

        /// <remarks/>
        public PersonPersonAgeMeasureMeasureIntegerRange MeasureIntegerRange
        {
            get
            {
                return this.measureIntegerRangeField;
            }
            set
            {
                this.measureIntegerRangeField = value;
            }
        }

        /// <remarks/>
        public byte MeasureIntegerValue
        {
            get
            {
                return this.measureIntegerValueField;
            }
            set
            {
                this.measureIntegerValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MeasureIntegerValueSpecified
        {
            get
            {
                return this.measureIntegerValueFieldSpecified;
            }
            set
            {
                this.measureIntegerValueFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://release.niem.gov/niem/niem-core/3.0/")]
    public partial class PersonPersonAgeMeasureMeasureIntegerRange
    {

        private byte rangeMaximumIntegerValueField;

        private byte rangeMinimumIntegerValueField;

        /// <remarks/>
        public byte RangeMaximumIntegerValue
        {
            get
            {
                return this.rangeMaximumIntegerValueField;
            }
            set
            {
                this.rangeMaximumIntegerValueField = value;
            }
        }

        /// <remarks/>
        public byte RangeMinimumIntegerValue
        {
            get
            {
                return this.rangeMinimumIntegerValueField;
            }
            set
            {
                this.rangeMinimumIntegerValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://release.niem.gov/niem/domains/jxdm/5.2/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://release.niem.gov/niem/domains/jxdm/5.2/", IsNullable = false)]
    public partial class Victim
    {

        private RoleOfPerson roleOfPersonField;

        private byte victimSequenceNumberTextField;

        private VictimVictimInjury victimInjuryField;

        private string victimCategoryCodeField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://release.niem.gov/niem/niem-core/3.0/")]
        public RoleOfPerson RoleOfPerson
        {
            get
            {
                return this.roleOfPersonField;
            }
            set
            {
                this.roleOfPersonField = value;
            }
        }

        /// <remarks/>
        public byte VictimSequenceNumberText
        {
            get
            {
                return this.victimSequenceNumberTextField;
            }
            set
            {
                this.victimSequenceNumberTextField = value;
            }
        }

        /// <remarks/>
        public VictimVictimInjury VictimInjury
        {
            get
            {
                return this.victimInjuryField;
            }
            set
            {
                this.victimInjuryField = value;
            }
        }

        /// <remarks/>
        public string VictimCategoryCode
        {
            get
            {
                return this.victimCategoryCodeField;
            }
            set
            {
                this.victimCategoryCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://release.niem.gov/niem/structures/3.0/")]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://release.niem.gov/niem/niem-core/3.0/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://release.niem.gov/niem/niem-core/3.0/", IsNullable = false)]
    public partial class RoleOfPerson
    {

        private string refField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://release.niem.gov/niem/structures/3.0/")]
        public string @ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://release.niem.gov/niem/domains/jxdm/5.2/")]
    public partial class VictimVictimInjury
    {

        private string injuryCategoryCodeField;

        /// <remarks/>
        public string InjuryCategoryCode
        {
            get
            {
                return this.injuryCategoryCodeField;
            }
            set
            {
                this.injuryCategoryCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://release.niem.gov/niem/domains/jxdm/5.2/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://release.niem.gov/niem/domains/jxdm/5.2/", IsNullable = false)]
    public partial class Subject
    {

        private RoleOfPerson roleOfPersonField;

        private byte subjectSequenceNumberTextField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://release.niem.gov/niem/niem-core/3.0/")]
        public RoleOfPerson RoleOfPerson
        {
            get
            {
                return this.roleOfPersonField;
            }
            set
            {
                this.roleOfPersonField = value;
            }
        }

        /// <remarks/>
        public byte SubjectSequenceNumberText
        {
            get
            {
                return this.subjectSequenceNumberTextField;
            }
            set
            {
                this.subjectSequenceNumberTextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://release.niem.gov/niem/structures/3.0/")]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://release.niem.gov/niem/domains/jxdm/5.2/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://release.niem.gov/niem/domains/jxdm/5.2/", IsNullable = false)]
    public partial class Arrestee
    {

        private RoleOfPerson roleOfPersonField;

        private byte arrestSequenceIDField;

        private string arresteeArmedWithCodeField;

        private string arrestSubjectCountCodeField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://release.niem.gov/niem/niem-core/3.0/")]
        public RoleOfPerson RoleOfPerson
        {
            get
            {
                return this.roleOfPersonField;
            }
            set
            {
                this.roleOfPersonField = value;
            }
        }

        /// <remarks/>
        public byte ArrestSequenceID
        {
            get
            {
                return this.arrestSequenceIDField;
            }
            set
            {
                this.arrestSequenceIDField = value;
            }
        }

        /// <remarks/>
        public string ArresteeArmedWithCode
        {
            get
            {
                return this.arresteeArmedWithCodeField;
            }
            set
            {
                this.arresteeArmedWithCodeField = value;
            }
        }

        /// <remarks/>
        public string ArrestSubjectCountCode
        {
            get
            {
                return this.arrestSubjectCountCodeField;
            }
            set
            {
                this.arrestSubjectCountCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://release.niem.gov/niem/structures/3.0/")]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://release.niem.gov/niem/domains/jxdm/5.2/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://release.niem.gov/niem/domains/jxdm/5.2/", IsNullable = false)]
    public partial class Arrest
    {

        private ActivityIdentification activityIdentificationField;

        private ActivityDate activityDateField;

        private ArrestArrestCharge arrestChargeField;

        private string arrestCategoryCodeField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://release.niem.gov/niem/niem-core/3.0/")]
        public ActivityIdentification ActivityIdentification
        {
            get
            {
                return this.activityIdentificationField;
            }
            set
            {
                this.activityIdentificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://release.niem.gov/niem/niem-core/3.0/")]
        public ActivityDate ActivityDate
        {
            get
            {
                return this.activityDateField;
            }
            set
            {
                this.activityDateField = value;
            }
        }

        /// <remarks/>
        public ArrestArrestCharge ArrestCharge
        {
            get
            {
                return this.arrestChargeField;
            }
            set
            {
                this.arrestChargeField = value;
            }
        }

        /// <remarks/>
        public string ArrestCategoryCode
        {
            get
            {
                return this.arrestCategoryCodeField;
            }
            set
            {
                this.arrestCategoryCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://release.niem.gov/niem/structures/3.0/")]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://release.niem.gov/niem/niem-core/3.0/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://release.niem.gov/niem/niem-core/3.0/", IsNullable = false)]
    public partial class ActivityIdentification
    {

        private string identificationIDField;

        /// <remarks/>
        public string IdentificationID
        {
            get
            {
                return this.identificationIDField;
            }
            set
            {
                this.identificationIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://release.niem.gov/niem/niem-core/3.0/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://release.niem.gov/niem/niem-core/3.0/", IsNullable = false)]
    public partial class ActivityDate
    {

        private System.DateTime? dateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime? Date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://release.niem.gov/niem/domains/jxdm/5.2/")]
    public partial class ArrestArrestCharge
    {

        private string chargeUCRCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://fbi.gov/cjis/nibrs/4.2")]
        public string ChargeUCRCode
        {
            get
            {
                return this.chargeUCRCodeField;
            }
            set
            {
                this.chargeUCRCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://release.niem.gov/niem/domains/jxdm/5.2/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://release.niem.gov/niem/domains/jxdm/5.2/", IsNullable = false)]
    public partial class ArrestSubjectAssociation
    {

        private Activity activityField;

        private ArrestSubjectAssociationSubject subjectField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://release.niem.gov/niem/niem-core/3.0/")]
        public Activity Activity
        {
            get
            {
                return this.activityField;
            }
            set
            {
                this.activityField = value;
            }
        }

        /// <remarks/>
        public ArrestSubjectAssociationSubject Subject
        {
            get
            {
                return this.subjectField;
            }
            set
            {
                this.subjectField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://release.niem.gov/niem/niem-core/3.0/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://release.niem.gov/niem/niem-core/3.0/", IsNullable = false)]
    public partial class Activity
    {

        private string refField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://release.niem.gov/niem/structures/3.0/")]
        public string @ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://release.niem.gov/niem/domains/jxdm/5.2/")]
    public partial class ArrestSubjectAssociationSubject
    {

        private string refField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://release.niem.gov/niem/structures/3.0/")]
        public string @ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://release.niem.gov/niem/domains/jxdm/5.2/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://release.niem.gov/niem/domains/jxdm/5.2/", IsNullable = false)]
    public partial class OffenseLocationAssociation
    {

        private OffenseLocationAssociationOffense offenseField;

        private Location locationField;

        /// <remarks/>
        public OffenseLocationAssociationOffense Offense
        {
            get
            {
                return this.offenseField;
            }
            set
            {
                this.offenseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://release.niem.gov/niem/niem-core/3.0/")]
        public Location Location
        {
            get
            {
                return this.locationField;
            }
            set
            {
                this.locationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://release.niem.gov/niem/domains/jxdm/5.2/")]
    public partial class OffenseLocationAssociationOffense
    {

        private string refField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://release.niem.gov/niem/structures/3.0/")]
        public string @ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://release.niem.gov/niem/domains/jxdm/5.2/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://release.niem.gov/niem/domains/jxdm/5.2/", IsNullable = false)]
    public partial class OffenseVictimAssociation
    {

        private OffenseVictimAssociationOffense offenseField;

        private OffenseVictimAssociationVictim victimField;

        /// <remarks/>
        public OffenseVictimAssociationOffense Offense
        {
            get
            {
                return this.offenseField;
            }
            set
            {
                this.offenseField = value;
            }
        }

        /// <remarks/>
        public OffenseVictimAssociationVictim Victim
        {
            get
            {
                return this.victimField;
            }
            set
            {
                this.victimField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://release.niem.gov/niem/domains/jxdm/5.2/")]
    public partial class OffenseVictimAssociationOffense
    {

        private string refField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://release.niem.gov/niem/structures/3.0/")]
        public string @ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://release.niem.gov/niem/domains/jxdm/5.2/")]
    public partial class OffenseVictimAssociationVictim
    {

        private string refField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://release.niem.gov/niem/structures/3.0/")]
        public string @ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://release.niem.gov/niem/domains/jxdm/5.2/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://release.niem.gov/niem/domains/jxdm/5.2/", IsNullable = false)]
    public partial class SubjectVictimAssociation
    {

        private SubjectVictimAssociationSubject subjectField;

        private SubjectVictimAssociationVictim victimField;

        private string victimToSubjectRelationshipCodeField;

        private string idField;

        /// <remarks/>
        public SubjectVictimAssociationSubject Subject
        {
            get
            {
                return this.subjectField;
            }
            set
            {
                this.subjectField = value;
            }
        }

        /// <remarks/>
        public SubjectVictimAssociationVictim Victim
        {
            get
            {
                return this.victimField;
            }
            set
            {
                this.victimField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://fbi.gov/cjis/nibrs/4.2")]
        public string VictimToSubjectRelationshipCode
        {
            get
            {
                return this.victimToSubjectRelationshipCodeField;
            }
            set
            {
                this.victimToSubjectRelationshipCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://release.niem.gov/niem/structures/3.0/")]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://release.niem.gov/niem/domains/jxdm/5.2/")]
    public partial class SubjectVictimAssociationSubject
    {

        private string refField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://release.niem.gov/niem/structures/3.0/")]
        public string @ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://release.niem.gov/niem/domains/jxdm/5.2/")]
    public partial class SubjectVictimAssociationVictim
    {

        private string refField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://release.niem.gov/niem/structures/3.0/")]
        public string @ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }
    }


}
