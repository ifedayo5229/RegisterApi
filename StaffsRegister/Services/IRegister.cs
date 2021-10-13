using StaffsRegister.Models;

namespace StaffsRegister.Services.Interfaces
{
    public interface IRegister
    {
     void  RegisterNewUser (RegisterViewModel model); 
     
    }
}