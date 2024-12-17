using semester1Website.Models;

public static class RepoinItialiser
{
    public static GenericRepo<Boat> boatRepo;
    public static GenericRepo<Member> memberRepo;

    static RepoinItialiser()
    {
        boatRepo = new GenericRepo<Boat>("boatData.json", boat => boat.Id);
        Boat.IdCounter = boatRepo.JsonHandler.Counter;
        memberRepo = new GenericRepo<Member>("memberData.json", Member => Member.MemberNumber);
        Member.MemberNumberCounter = boatRepo.JsonHandler.Counter;
    }
}