using ReqFieldsPOC.Validations;
using System.Xml.Linq;

namespace ReqFieldsPOC.Model
{
    public class PatientPersonalData
    {

        [RequiredFieldPath()]
        public string BirthDate { get; set; }
        public BirthPlace BirthPlace { get; set; }

        [RequiredFieldPath()]
        public string Gender { get; set; }

        [RequiredFieldPath()]
        public string MaritalStatus { get; set; }
        [RequiredFieldPath()]
        public string Religion { get; set; }
        [RequiredFieldPath()]
        public string Race { get; set; }
        [RequiredFieldPath()]
        public string Ethnicity { get; set; }
        [RequiredFieldPath]
        public Name Name { get; set; }


    }
}