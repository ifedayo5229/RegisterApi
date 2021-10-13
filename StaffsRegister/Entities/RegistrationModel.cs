using System.ComponentModel.DataAnnotations;

namespace StaffsRegister.Entities
{
    public class RegistrationModel
    {
        [Required]
         public string FirstName { get; set; }
         
        [Required]
         public string LastName { get; set; }
         
        [Required]
        [EmailAddress]
        public string Email { get; set; }


         [Required]
        [PhoneNumber]
        public int PhoneNumber { get; set; }
     

         [Required]
    
        public decimal Salary { get; set; }
        
         [Required]
    
        public decimal GrossIncome { get; set; }

         [Required]
    
        public decimal NetIncome { get; set; }
    }
}