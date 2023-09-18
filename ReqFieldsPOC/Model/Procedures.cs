namespace ReqFieldsPOC.Model
{
    public class Procedures
    {
        public string ProcedureName { get; set; }
        public string TypeofProcedure { get; set; }
        public string DateofAdmission { get; set; }
        public string DateofDischarge { get; set; }
        public string CompletionStatus { get; set; }
        public string BodySite { get; set; }
        public Performer Performer { get; set; }

    }
}