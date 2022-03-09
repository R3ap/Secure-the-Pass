using Password_Manager_.NET_6.Properties;
using System.Text;

namespace Password_Manager_.NET_6
{
    public class Generator
    {
        public string GetPW()
        {
            int lenght = Settings.Default.PasswordLenght;
            string Content = Settings.Default.AllowedCharacters;
            StringBuilder SB = new();
            Random rnd = new();
            for (int i = 0; i < lenght; i++)
                SB.Append(Content[rnd.Next(Content.Length)]);
            return SB.ToString();
        }
    }
}
