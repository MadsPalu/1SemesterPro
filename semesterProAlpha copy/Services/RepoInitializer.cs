using semester1Website.Models;
using semester1Website.Services;

public static class RepoInitializer
{
    #region Properties
    public static GenericRepo<Boat> boatRepo;
    public static GenericRepo<Member> memberRepo;
    static string basePath = AppDomain.CurrentDomain.BaseDirectory;
    static string boatPath = Path.Combine(basePath, "boatData.json");
    static string memberPath = Path.Combine(basePath, "memberData.json");
    #endregion

    #region Constructors
    static RepoInitializer()
    {
        boatRepo = new GenericRepo<Boat>(boatPath, boat => boat.Id);
        Boat.IdCounter = boatRepo.JsonHandler.Counter;
        memberRepo = new GenericRepo<Member>(memberPath, Member => Member.MemberNumber);
        Member.MemberNumberCounter = memberRepo.JsonHandler.Counter;
    }

    #endregion
}