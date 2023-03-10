namespace WebApplication3.Models
{
    public class UserViewModel
    {
        public string UserId { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string? Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? PhoneNumber { get; set; }
        public string? BirthPlace { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public IEnumerable<string> Roles { get; set; }
        public uint Age { get { return (uint)(DateTime.Now.Year - DateOfBirth.Year); } }
        public string FullName
        {
            get
            {
                var FullName = LastName + " " + FirstName;
                return FullName;
            }
        }
    }
}
