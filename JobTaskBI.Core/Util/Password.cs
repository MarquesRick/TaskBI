﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Core.Util
{
    public class Password
    {
        public static string Create()
        {
            int length = 8;
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        public static Boolean StrongPassword(string password)
        {
            if (password.Length < 6 || password.Length > 12)
                return false;

            if (!password.Any(c => char.IsDigit(c)))
                return false;

            if (!password.Any(c => char.IsUpper(c)))
                return false;

            if (!password.Any(c => char.IsLower(c)))
                return false;

            if (!Regex.IsMatch(password, (@"[!""#$%&'()*+,-./:;?@[\\\]_`{|}~]")))
                return false;

            return true;
        }
    }
}
