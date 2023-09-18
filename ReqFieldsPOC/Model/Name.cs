using ReqFieldsPOC.Validations;

namespace ReqFieldsPOC.Model
{
    public class Name
    {
        [RequiredFieldPath]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        [RequiredFieldPath]
        public string LastName { get; set; }
    }
}