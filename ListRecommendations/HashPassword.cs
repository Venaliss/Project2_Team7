using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ListRecommendations
{
    class HashPassword
    {
        public static string GetMD5Hash(string input)
        {
            MD5 md5 = MD5.Create();
            //Конвертируем полученную строку в byte массив и хешируем ее
            byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            //создаем настраиваемую строку для объеденения массива
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                stringBuilder.Append(data[i].ToString("x2"));
            }
            return stringBuilder.ToString();
        }
    }
}
