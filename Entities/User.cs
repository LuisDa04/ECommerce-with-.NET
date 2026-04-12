namespace ProyectoTestNET.Entities
{
    public class User
    {
        public int UserId { get; set; }

        //Required
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Type { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}