namespace ReqFieldsPOC.Validations
{
    public class ValidationResult
    {
        public bool IsValid { get; set; }
        public List<string> MissingFields { get; set; }
    }
}
