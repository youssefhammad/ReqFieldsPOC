using ReqFieldsPOC.Validations;

namespace ReqFieldsPOC.Model
{
    public class PatientContacts
    {
        public string LandLineTelephone { get; set; }

        [RequiredFieldPath]
        public string MobilePhone { get; set; }
        public string Mail { get; set; }
    }
}