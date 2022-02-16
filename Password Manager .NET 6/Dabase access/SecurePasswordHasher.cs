﻿using System;
using System.Security.Cryptography;
using System.Text;

namespace Password_Manager_.NET_6
{
    public static class SecurePasswordHasher
    {
        private static readonly string hash = "f0xle@rn";
        public static string GetEncryptString(string nothashed)
        {
            try
            {
                byte[] data = UTF8Encoding.UTF8.GetBytes(nothashed);
                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                {
                    byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                    using (TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                    {
                        ICryptoTransform transform = tripleDES.CreateEncryptor();
                        byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                        return Convert.ToBase64String(results, 0, results.Length);
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandler errorHandler = new ErrorHandler();
                errorHandler.ShowDialog(ex);
                return "";
            }
        }

        public static string GetDecryptString(string hashed)
        {
            try
            {
                byte[] data = Convert.FromBase64String(hashed);
                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                {
                    byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                    using (TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                    {
                        ICryptoTransform transform = tripleDES.CreateDecryptor();
                        byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                        return UTF8Encoding.UTF8.GetString(results);
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandler errorHandler = new ErrorHandler();
                errorHandler.ShowDialog(ex);
                return "";
            }
        }

        public static bool Verify(string hasehd, string nothashed)
        {
            return GetDecryptString(hasehd) == nothashed;
        }
    }
}