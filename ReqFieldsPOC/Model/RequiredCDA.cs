using ReqFieldsPOC.Validations;
using System.Xml.Serialization;

namespace ReqFieldsPOC.Model
{
    public class RequiredCDA
    {
        [RequiredFieldPath]
        public string KeyPatientID { get; set; }
        public string ConfidentialityCode { get; set; }

        [RequiredFieldPath]
        public PatientAddress PatientAddress { get; set; }
        [RequiredFieldPath]
        public PatientContacts PatientContacts { get; set; }
        [RequiredFieldPath]
        public PatientPersonalData PatientPersonalData { get; set; }
        public PatientGuardian PatientGuardian { get; set; }
        [XmlElement(ElementName = "LanguagesofCommunication")]
        public List<LanguagesofCommunication> LanguagesofCommunications { get; set; }
        public FirstEncounterDate FirstEncounterDate { get; set; }

        [RequiredFieldPath]
        public ProviderData ProviderData { get; set; }

        [RequiredFieldPath]
        public HealthcareOrganizationData HealthcareOrganizationData { get; set; }
        public Allergies Allergies { get; set; }
        public Medications Medications { get; set; }
        public Procedures Procedures { get; set; }
        public ProblemList ProblemList { get; set; }

        [XmlElement(ElementName = "Results")]
        public List<Results> Results { get; set; }
        public SocialHistory SocialHistory { get; set; }
        public VitalSigns VitalSigns { get; set; }

        [XmlElement(ElementName = "InformantInformation")]
        public List<InformantInformation> InformantInformations { get; set; }

        public Organization Organization { get; set; }
        public DataEnterer DataEnterer { get; set; }
        public Custodian Custodian { get; set; }
        public LegalAuthenticatorInformation LegalAuthenticatorInformation { get; set; }
        public AuthenticatorInformation AuthenticatorInformation { get; set; }
        [XmlElement(ElementName = "AuthorsInformation")]
        public List<AuthorInformation> AuthorsInformations { get; set; }
    }
}
