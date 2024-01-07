namespace StarDentApi.Entities
{
    public class UserEntity : BaseEntity
    {
        public string Username { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phonenumber { get; set; }
        public string Passwordhash { get; set; }
        public string Passwordsalt { get; set; }
        public string Config { get; set; }
        public int Accessfailcount { get; set; }
    }
}
