namespace TeamPerFerryContract
{
    public class UserDTO
    {
        public long UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DockDTO HomeDock { get; set; }
    }
    }
}