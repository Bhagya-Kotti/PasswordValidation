using PasswordValidation.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordValidation.Services
{
    public class PasswordValidationService : IPasswordValidationService
    {
        public int GetLenghOfTheInputPasswordValue(string passWord) => passWord.Length;
    }
}
