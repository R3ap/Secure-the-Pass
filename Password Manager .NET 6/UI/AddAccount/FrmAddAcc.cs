﻿using Secure_The_Pass.UI.BaseDialog;
using Secure_The_Pass.UI.AddAccount;

namespace Secure_The_Pass.UI
{
    public partial class FrmAddAcc : FrmBaseDialog, IAddAcc
    {
        public string Website { get => txtWebsite.Text; set => txtWebsite.Text = value; }
        public string Email { get => txtEmail.Text; set => txtEmail.Text = value; }
        public string Username { get => txtUsername.Text; set => txtUsername.Text = value; }
        public string Password { get => txtPassword.Text; set => txtPassword.Text = value; }
        public FrmAddAcc()
        {
            InitializeComponent();
            
        }

        private void FrmAddAcc_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
            TopLevel = false;
            TopMost = true;
        }

        public void ClearControls()
        {
            txtEmail.Clear();
            txtPassword.Clear();
            txtUsername.Clear();
            txtWebsite.Clear();
        }

        public void SetErrorEmail(string errorMessage)
        {
            AccountProvider.SetError(txtEmail, errorMessage);
        }

        public void SetErrorUsername(string errorMessage)
        {
            AccountProvider.SetError(txtUsername, errorMessage);
        }

        public void SetErrorWebsite(string errorMessage)
        {
            AccountProvider.SetError(txtWebsite, errorMessage);
        }

        public void SetErrorPassword(string errorMessage)
        {
            AccountProvider.SetError(txtPassword, errorMessage);
        }

        public void ClearErrorProvider()
        {
            AccountProvider.Clear();
        }
    }
}
