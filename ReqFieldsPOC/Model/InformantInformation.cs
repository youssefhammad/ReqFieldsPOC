namespace ReqFieldsPOC.Model
{
    public class InformantInformation
    {
        public OrganizationofAffiliationAddress OrganizationofAffiliationAddress { get; set; }
        public RelationToInformant RelationToInformant { get; set; }
        public Name Name { get; set; }
        public bool IsPerson { get; set; }
    }
}