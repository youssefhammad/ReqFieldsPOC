namespace ReqFieldsPOC.Model
{
    public class Allergies
    {
        public string AllergyName { get; set; }
        public string AllergyCode { get; set; }
        public string AllergySeverity { get; set; }
        public string DateofRecordingtheallergy { get; set; }
        public RecordingProviderInformation RecordingProviderInformation { get; set; }

    }
}