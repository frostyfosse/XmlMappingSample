namespace XmlMappingSample
{
    public static class References
    {
        public const string StandardIdentificationID = "nc:IdentificationID";

        public static class Submission
        {
            public const string NodeName = "ispnibrs:ISPSubmission";
        }

        public static class Metadata
        {
            public const string NodeName = "cjis:MessageMetadata";
            public const string MessageDateTime = "cjis:MessageDateTime";
            public const string MessageIdentification = "cjis:MessageIdentification";
            public const string IdentificationID = StandardIdentificationID;
            public const string MessageImplementationVersion = "cjis:MessageImplementationVersion";
            public const string MessageSubmittingOrganization = "cjis:MessageSubmittingOrganization";
            public const string OrganizationAugmentation = "j:OrganizationAugmentation";
            public const string OrganizationORIIdentification = "j:OrganizationORIIdentification";
        }

        public static class Report
        {
            public const string NodeName = "nibrs:Report";

            public static class ReportHeader
            {
                public const string NodeName = "nibrs:ReportHeader";
                public const string NIBRSReportCategoryCode = "nibrs:NIBRSReportCategoryCode";
                public const string ReportActionCategoryCode = "nibrs:ReportActionCategoryCode";

                public static class ReportDate
                {
                    public const string NodeName = "nibrs:ReportDate";
                    public const string YearMonthDate = "nc:YearMonthDate";
                }

                public static class ReportingAgency
                {
                    public const string NodeName = "nibrs:ReportingAgency";

                    public static class OrganizationAugmentation
                    {
                        public const string NodeName = "j:OrganizationAugmentation";

                        public static class OrganizationORIIdentification
                        {
                            public const string NodeName = "j:OrganizationORIIdentification";
                            public const string IdentificationID = StandardIdentificationID;
                        }
                    }
                }
            }
        }
    }
}
