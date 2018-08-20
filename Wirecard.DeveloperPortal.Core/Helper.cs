using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Wirecard.DeveloperPortal.Core
{
    public class Helper
    {
        

        /// <summary>
        ///success url sayfası içerisinde HashParam  değerinin doğruluğunu kontrol etmek amacıyla oluşturulan  Verilen string'i SHA1 ile hashleyip Base64 formatına çeviren fonksiyondur. 
        /// CreateToken'dan farklı olarak token oluşturmaz sadece hassh hesaplar
        /// </summary>
        /// <param name="hashString"></param>
        /// <returns></returns>
        public static string ComputeHash(string hashString)
        {
            System.Security.Cryptography.SHA1 sha = new System.Security.Cryptography.SHA1CryptoServiceProvider();
            byte[] hashbytes = System.Text.Encoding.GetEncoding("ISO-8859-9").GetBytes(hashString);
            byte[] inputbytes = sha.ComputeHash(hashbytes);
            return Convert.ToBase64String(inputbytes);
        }

    }
}
