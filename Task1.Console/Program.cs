﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Solution;

namespace Task1.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var rep = new SqlRepository();
            string s = "23";
            List<IRules> a = new List<IRules>();
            a.Add(new ShortPassRule());
            a.Add(new NullPassRule());
            a.Add(new HasLetterPassRule());
            System.Console.WriteLine(PasswordCheckerService.VerifyPassword(s, rep, a));
        }
    }
}
