using System.Security.Cryptography;
using System.Text;

namespace Services_Core.Extensions
{
    public static class SecurePasswordHasherExtension
    {
        private static readonly string hash = "f0xle@rn";
        public static string GetEncryptString(this string nothashed)
        {
            byte[] data = Encoding.UTF8.GetBytes(nothashed);
            using (MD5CryptoServiceProvider md5 = new())
            {
                byte[] keys = md5.ComputeHash(Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripleDES = new() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripleDES.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return Convert.ToBase64String(results, 0, results.Length);
                }
            }
        }

        public static string GetDecryptString(this string hashed)
        {
            byte[] data = Convert.FromBase64String(hashed);
            using (MD5CryptoServiceProvider md5 = new())
            {
                byte[] keys = md5.ComputeHash(Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripleDES = new() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripleDES.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return Encoding.UTF8.GetString(results);
                }
            }
        }

        public static bool Verify(this string nothashed, string hasehd)
        {
            return hasehd.GetDecryptString() == nothashed;
        }
    }
}
