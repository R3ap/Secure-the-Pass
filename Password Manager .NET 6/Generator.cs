using Secure_The_Pass.Properties;
using System.Text;

namespace Secure_The_Pass
{
    public class Generator
    {
        public string GetPW()
        {
            int lenght = Settings.Default.PasswordLenght;
            string Content = Settings.Default.AllowedCharacters;
            StringBuilder sB = new();
            Random rnd = new();
            for (int i = 0; i < lenght; i++)
            {
                sB.Append(Content[rnd.Next(Content.Length)]);
            }
            return sB.ToString();
        }
    }
}