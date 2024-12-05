using Microsoft.Extensions.Options;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;

namespace semester1Website.Models
{
    public static class MemberRepository
    {
        private static string FilePath = "memberData.json";
        public static JsonHandler<Member> JsonHandler = new JsonHandler<Member>(FilePath);
        private static Dictionary<int, Member> MemberList = JsonHandler.LoadFromFile();

        //lav exeption member allerede i liste.
        public static void AddMember(Member member) 
        {
            MemberList.Add(member.GetMemberNumber(), member);
            JsonHandler.SaveToFile(MemberList);
        }

        public static string PrintList() 
        {
            string membersliste ="";
            Console.WriteLine("memberslist:");
            foreach (KeyValuePair<int, Member> member in MemberList)
            {
                membersliste += ($"{member.Value.ToString()} membersnumber: {member.Key} ");
            }
            return membersliste;
        }

        //lav exeption, member not found.
        public static Member GetMember(int id) 
        {
            return MemberList[id];
        }

        //tjek exeption i Getmember, også gælder her
        public static void RemoveMember(int id) 
        {
            MemberList.Remove(id);
            JsonHandler.SaveToFile(MemberList);
        }
    }
}

