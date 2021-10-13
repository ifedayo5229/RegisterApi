using System;
using System.Collections.Generic;

#nullable disable

namespace StaffsRegister.Models
{
    public partial class StaffsRegister
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Salary { get; set; }
        public string Email { get; set; }
        public string NetIncome { get; set; }
        public string GrossIncome { get; set; }
        public string PhoneNumber { get; set; }
    }
}
