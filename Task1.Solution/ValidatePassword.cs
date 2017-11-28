﻿using System;
using System.Linq;

namespace Task1.Solution
{
    public class ValidatePassword
    {
        public static void Validate(string password)
        {
            if (password == null)
                throw new ArgumentException($"{password} is null arg");

            if (password == string.Empty)
                throw new ArgumentException($"{password} is empty");

            // check if length more than 7 chars 
            if (password.Length <= 7)
                throw new ArgumentException($"{password} length too short");

            // check if length more than 10 chars for admins
            if (password.Length >= 15)
                throw new ArgumentException($"{password} length too long");

            // check if password conatins at least one alphabetical character 
            if (!password.Any(char.IsLetter))
                throw new ArgumentException($"{password} hasn't alphanumerical chars");

            // check if password conatins at least one digit character 
            if (!password.Any(char.IsNumber))
                throw new ArgumentException($"{password} hasn't digits");

        }
    }
}
