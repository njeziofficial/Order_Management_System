using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OMS.API.Utilities
{
    public class Utility
    {
        public static string PasswordEncoder(string password)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(password);
            var sha1 = new SHA1CryptoServiceProvider();
            var sha1data = sha1.ComputeHash(buffer);
            return Convert.ToBase64String(sha1data);
        }
    }
}
