using Microsoft.Extensions.Options;
using System.Reflection;
using System.Text.Json;
using System.Xml.Linq;

namespace semester1Website.Models
{
    public class Member
    {
        public static int MemberNumberCounter { get; set; } = 1;
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public int MemberNumber { get; set; }

        public Member(string name, string mobile, string address)
        {
            MemberNumber = MemberNumberCounter++;
            Name = name;
            Mobile = mobile;
            Address = address;
        }

        //eventuelt bare lav override på tostring
        public override string ToString()
        {
            return $"Name: {Name}, Mobile: {Mobile} address: {Address}";
        }

        public int GetMemberNumber()
        {
            return MemberNumber;
        }

        public void ChangeName(string name)
        {
            Name = name;
        }

        public void ChangeMobile(string mobile)
        {
            Mobile = mobile;
        }

        public void ChangeAddress(string address)
        {
            Address = address;
        }

        //når både klasse er lavet, lav list over både som medlem eger

        //lav bool tjek, (er ude og sejle)
    }
}
