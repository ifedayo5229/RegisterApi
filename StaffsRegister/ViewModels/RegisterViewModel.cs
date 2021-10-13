using System.ComponentModel.DataAnnotations;

namespace StaffsRegister.Models  
{
    public class RegisterViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Salary { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}