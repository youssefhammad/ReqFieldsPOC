namespace ReqFieldsPOC.Validations
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class RequiredFieldPathAttribute : Attribute
    {
        public string Path { get; }
        public string ErrorMessage { get; set; } = "This field is required.";

        public RequiredFieldPathAttribute(string path = null)
        {
            Path = path;
        }
    }
}
