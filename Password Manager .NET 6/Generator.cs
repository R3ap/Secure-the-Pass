using System.Text;

namespace Password_Manager_.NET_6
{
    public class Generator
    {
        public string GetPW(int Länge)
        {
            StringBuilder SB = new StringBuilder();
            string Content = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvw!§$%&/()=?*#-";
            Random rnd = new Random();
            for (int i = 0; i < Länge; i++)
                SB.Append(Content[rnd.Next(Content.Length)]);
            return SB.ToString();
        }
    }
}
