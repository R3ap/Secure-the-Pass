using Password_Manager_Services_Core.Services.UserServices;
using System.Net;
using System.Net.Mail;

namespace Password_Manager_.NET_6
{
    public partial class FrmForgotPW : Form
    {
        private readonly IUserService _userService = new UserService();
        private string randomcode;
        public static string to;
        private NotifyIcon notify = new NotifyIcon();
        public FrmForgotPW()
        {
            InitializeComponent();
        }

        private void FrmForgotPW_Load(object sender, EventArgs e)
        {


        }

        private void SendEmail()
        {
            string from, pass, messageBody;
            Random rnd = new();
            randomcode = (rnd.Next(999999)).ToString();
            MailMessage mailMessage = new();
            to = txtEmail.Text;
            from = "davidvongarrel2@gmail.com";
            pass = "Lenina00";
            messageBody = $"Your Reset Code {randomcode}";
            mailMessage.To.Add(to);
            mailMessage.From = new MailAddress(from);
            mailMessage.Body = messageBody;
            mailMessage.Subject = "Passwort reseting code";
            SmtpClient smtp = new("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            notify.Visible = true;
            notify.Icon = new Icon("C:\\Users\\David von Garrel\\Desktop\\Icons\\icons8_password_window.ico");
            try
            {
                smtp.Send(mailMessage);
                notify.ShowBalloonTip(1000, "Email sending", "Email sending was successfull", ToolTipIcon.Info);
            }
            catch (Exception ex)
            {
                notify.ShowBalloonTip(1000, "Email sending goes wrong", ex.Message, ToolTipIcon.Error);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!_userService.CheckUser(txtEmail.Text))
            {
                SendEmail();
            }
            else
            {
                notify.Visible = true;
                notify.Icon = new Icon("C:\\Users\\David von Garrel\\Desktop\\Icons\\icons8_password_window.ico");
                notify.ShowBalloonTip(1000, "This Email don't Exist", "Please Sign up", ToolTipIcon.Error);
            }
        }

        private void ResetPWPropertie()
        {
            label1.Text = "Reset Password";
            Size = new Size(419, 233);
            btnSend.Visible = false;
            lblCode.Text = "Password Confirm";
            lblCode.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            lblCode.Location = new Point(lblCode.Location.X, lblCode.Location.Y + 10);
            lblEmail.Text = "Password";
            txtEmail.Text = "";
            txtCode.Text = "";
            btnCheck.Text = "Reset";
            txtCode.PasswordChar = '•';
            txtEmail.PasswordChar = '•';
        }

        private void ResetPw()
        {
            if (txtCode.Text == txtEmail.Text)
            {
                _userService.UpdateUser(txtEmail.Text, to);
                Close();
            }
            else
            {
                ForgotProvider.SetError(txtCode, "The Passwods is not Equal");
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Reset Password")
            {
                ResetPw();
            }
            if (txtCode.Text == randomcode)
            {
                ResetPWPropertie();
            }
            else
            {
                ForgotProvider.SetError(txtCode, "Wrong Code");
            }
        }
    }
}
