using Microsoft.Extensions.Options;
using System.Reflection;
using System.Text.Json;
using System.Xml.Linq;


namespace semester1Website.Models
{
    public class Member : ChairMan
    {
        #region Properties
        public static int MemberNumberCounter { get; set; } = 1;
        public string MemberName { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public int MemberNumber { get; set; }
        #endregion

        #region Constructors
        public Member(string memberName, string mobile, string address)
        : base(MemberNumberCounter, memberName)
        {
            MemberNumber = MemberNumberCounter++;
            MemberName = memberName;
            Mobile = mobile;
            Address = address;
        }
        #endregion

        #region Methods
        //eventuelt bare lav override på tostring
        public override string ToString()
        {
            return $"Name: {MemberName}, Mobile: {Mobile} address: {Address}";
        }

        public int GetMemberNumber()
        {
            return MemberNumber;
        }

        public void ChangeName(string memberName)
        {
            MemberName = memberName;
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
        #endregion
    }
}
