using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Password_Manager_.NET_6.Model
{
    public class Account
    {
        [Key]
        [Browsable(false)]
        public int ID { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        [ForeignKey(nameof(Email))]
        [Browsable(false)]
        public string Useremail { get; set; }
    }
}
