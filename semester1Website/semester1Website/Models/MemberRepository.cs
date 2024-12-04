using Microsoft.Extensions.Options;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;

namespace semester1Website.Models
{
    public static class MemberRepository
    {
        private static Dictionary<int, Member> MemberList = new Dictionary<int, Member>();
        private static string FilePath = "memberData.json";


        //lav exeption member allerede i liste.
        public static void AddMember(Member member) 
        {
            MemberList.Add(member.GetMemberNumber(), member);
            SaveToFile();
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
            SaveToFile();
        }

        //kalder den i add og remove member så den opdater json listen ved ændring.
        public static void SaveToFile()
        {
            //laver en Json Serializer der kan lave klassen til Json
            string json = JsonSerializer.Serialize(MemberList);
            //Gemmer Json data ved file pathen, laver ny fil hvis den ikke findes.
            File.WriteAllText(FilePath, json);
        }

        //bliver kaldt i program.cs
        public static void LoadFromFile()
        {
            if (File.Exists(FilePath))
            {
                //læser document ved pathen.
                string json = File.ReadAllText(FilePath);
                //ændre json texten tilbage til C# og propper det tilbage i MemberRepoet 
                MemberList = JsonSerializer.Deserialize<Dictionary<int, Member>>(json);

                //Gemmer tæleren til membercounter, ved at tælle antelet af keys i memberlisten efter den er loaded fra json
                if (MemberList.Count > 0) {     
                    Member.MemberNumberCounter = MemberList.Keys.Max() + 1;
                }
            }
        }
    }
}

