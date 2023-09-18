using System.Xml.Serialization;

namespace ReqFieldsPOC.Model
{
    public class VitalSignsObservations
    {
        public DateTime DateofLATESrecordedVitals { get; set; }
        [XmlElement(ElementName = "VitalSign")]
        public List<VitalSign> VitalSigns { get; set; }
        //public string BloodPressureSystolicandDiastolic { set; get; }
        //public string PulseRate { get; set; }
        //public string Temperature { get; set; }
        //public string RespiratortyRate { get; set; }
        //public string Height { get; set; }
        //public string Weight { get; set; }
        //public string BMI { get; set; }
        //public string SpO2 { get; set; }
    }
}