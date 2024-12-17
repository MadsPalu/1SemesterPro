using semester1Website.Models;

public static class RepoinItialiser
{
    #region Properties
    public static GenericRepo<Boat> boatRepo;
    public static GenericRepo<Member> memberRepo;
    #endregion
    
    #region Constructors
    static RepoinItialiser()
    {
        boatRepo = new GenericRepo<Boat>("boatData.json", boat => boat.Id);
        Boat.IdCounter = boatRepo.JsonHandler.Counter;
        memberRepo = new GenericRepo<Member>("memberData.json", Member => Member.MemberNumber);
        Member.MemberNumberCounter = boatRepo.JsonHandler.Counter;
    }
    #endregion
}