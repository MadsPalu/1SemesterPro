namespace semester1Website.Models
{
    public class Member
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
        {
            MemberNumber = MemberNumberCounter++;
            MemberName = memberName;
            Mobile = mobile;
            Address = address;
        }
        #endregion

        #region Methods
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
        #endregion
    }
}
