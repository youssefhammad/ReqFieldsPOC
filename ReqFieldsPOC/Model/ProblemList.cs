namespace ReqFieldsPOC.Model
{
    public class ProblemList
    {
        public string ProblemName { get; set; }
        public string ProblemSeverity { get; set; }
        public string DateofRecording { get; set; }
        public RecordingProviderInformation RecordingProviderInformation { get; set; }
    }
}