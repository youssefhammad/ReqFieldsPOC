namespace ReqFieldsPOC.Model
{
    public class Medications
    {

        public string MedicationName { get; set; }
        public string MedicationSeverity { get; set; }
        public string Dateandtimestampofprescription { get; set; }
        public PrescribingProviderInformation PrescribingProviderInformation { get; set; }

    }
}