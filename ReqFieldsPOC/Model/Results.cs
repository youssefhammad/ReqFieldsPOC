using System.Xml.Serialization;

namespace ReqFieldsPOC.Model
{
    public class Results
    {
        public string TestName { get; set; }
        [XmlElement(ElementName = "TestResult")]
        public List<TestResult> TestResults { get; set; }
        public string DateAndTime { get; set; }
    }
}
