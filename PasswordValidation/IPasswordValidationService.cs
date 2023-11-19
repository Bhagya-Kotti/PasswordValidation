using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordValidation.Service
{
    public interface IPasswordValidationService
    {
        int GetLenghOfTheInputPasswordValue(string passWord);
        int GetNumberOfNumericsInInputPasswordValue(string passWord);
        
    }
}
