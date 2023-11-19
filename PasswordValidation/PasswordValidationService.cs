using PasswordValidation.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PasswordValidation.Services
{
    public class PasswordValidationService : IPasswordValidationService
    {
        public int GetLenghOfTheInputPasswordValue(string passWord) => passWord.Length;
        public int GetNumberOfNumericsInInputPasswordValue(string passWord)
        {
            return  Regex.Matches(passWord,"[0-9]").Count;
            
        }
        public string CheckForValidPassword(string passWord)
        {
            int passWordLength = GetLenghOfTheInputPasswordValue(passWord);
            if (passWordLength >= 8)
            {
                int numericInPassword = GetNumberOfNumericsInInputPasswordValue(passWord);
                if (numericInPassword < 2)
                {
                    return "Password must be at least 8 characters.The password must contain at least 2 numbers.";
                }
                return "Valid Passowrd";
            }

            return "Password must be at least 8 characters.";

        }
    }
}
