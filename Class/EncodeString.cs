﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace netcore.Class
{
    public class EncodeString
    {
        public EncodeString()
        {
            public static string MD5HashCrytograpy(string string2Md5)
                
            {
                MD5 md5 = MD5CryptoServiceProvider.Create();
                byte[] dataMd5 = md5.ComputeHash(Encoding.Default.GetBytes(string2Md5));
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < dataMd5.Length; i++)
                {
                    sb.AppendFormat("{0:x2}", dataMd5[i]);
                }
                string2Md5 = sb.ToString();
                return string2Md5;
            }
            public static string EncodeTo64(String text)
            {
                byte[] toEncode = Encoding.Unicode.GetBytes(text);
                String returnEndode = Convert.ToBase64String(toEncode);
                return returnEndode;

            }


            public static string DecodeFrom64(string text)
            {

                byte[] toDecode = Convert.FromBase64String(text);
                string returnDecode = Encoding.Unicode.GetString(toDecode);
                return returnDecode;

            }
        }
    }
}

