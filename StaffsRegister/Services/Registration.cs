using Microsoft.EntityFrameworkCore;
using StaffsRegister.Entities;
using StaffsRegister.Models;
using StaffsRegister.Services.Interfaces;

namespace StaffsRegister.Services
{
    public class Registration : IRegister
    {

           private readonly  StaffSDbContext  _options;

        public Registration( StaffSDbContext options)
        {
            _options = options; 
        }

        public void RegisterNewUser(RegisterViewModel model)
        {
           var GrossIncome= model.Salary*12;
           var tax = Tax ( model.Salary, 25);
           decimal annualTax=tax*12;

           decimal netSalary= GrossIncome-annualTax;

           var entry = new  ApplicationUser
           {
                GrossIncome=GrossIncome.ToString(),
                NetIncome=netSalary.ToString(),
                Salary=model.Salary.ToString(),
                FirstName=model.FirstName,
                LastName=model.LastName,
                Email=model.Email,
               
                
           };

              _options.Add(entry);
              _options.SaveChanges();

        }

        private decimal Tax(decimal SalaryAmount , int Percentage)
        {
            decimal tax= Percentage/100*SalaryAmount;
            return tax;       
         }

    }
}