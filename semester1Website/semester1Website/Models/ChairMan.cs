using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;


namespace semester1Website.Models
{
    public class ChairMan 
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public bool IsLoggedIn { get; set; }
        public Dictionary<int, ChairMan> chairManLog = new Dictionary<int, ChairMan>();
        public ChairMan(int id, string name)
        {
            Id = id;
            Name = name;
        }

        /*public ChairMan GetChairmanLog(int id)
        {
            string chairMan = "";
            Console.WriteLine("Chairman:");
            foreach (KeyValuePair<int, ChairMan> chairman in chairManLog)
            {
                chairMan += ($"{chairman.Value.ToString()} ");
            }
            return chairManLog[id];
        }*/

        public string GetChairmanInfo()
        {
            return $"Name : {Name}, ID : {Id}";
        }
        
        public Member ChairManLogIn(string id, string name)
        {
            if (id == null) throw new ArgumentNullException(nameof(id), "ID cannot be null");
            if (name == null) throw new ArgumentNullException(nameof(name), "Name cannot be null");

            if (!int.TryParse(id, out int memberId))
            throw new ArgumentException("ID is required and must be a number");

            Member member = MemberRepository.GetMember(memberId);
            if (member == null) throw new Exception("Member not found");

            member.IsLoggedIn = true;
            return member;
        }
    }        
}