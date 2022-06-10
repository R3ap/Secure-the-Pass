namespace Secure_The_Pass.UI
{
    partial class FrmAddAcc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtWebsite = new Secure_The_Pass.UI.Controls.PasswordManagerTextBox();
            this.TxtEmail = new Secure_The_Pass.UI.Controls.PasswordManagerTextBox();
            this.TxtUsername = new Secure_The_Pass.UI.Controls.PasswordManagerTextBox();
            this.TxtPassword = new Secure_The_Pass.UI.Controls.PasswordManagerTextBox();
            this.PnlActions.SuspendLayout();
            this.PnlActionsBase.SuspendLayout();
            this.PnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // _btAccept
            // 
            this._btAccept.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._btAccept.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this._btAccept.Size = new System.Drawing.Size(165, 45);
            this._btAccept.Text = "&Save Account";
            // 
            // _btAbort
            // 
            this._btAbort.Location = new System.Drawing.Point(174, 3);
            this._btAbort.Size = new System.Drawing.Size(83, 29);
            this._btAbort.Text = "&OK";
            // 
            // PnlActions
            // 
            this.PnlActions.Location = new System.Drawing.Point(0, 431);
            this.PnlActions.Size = new System.Drawing.Size(714, 57);
            // 
            // PnlActionsBase
            // 
            this.PnlActionsBase.Location = new System.Drawing.Point(536, 3);
            this.PnlActionsBase.Size = new System.Drawing.Size(175, 51);
            // 
            // PnlActionsExtension
            // 
            this.PnlActionsExtension.Location = new System.Drawing.Point(480, 3);
            // 
            // PnlContent
            // 
            this.PnlContent.Controls.Add(this.TxtPassword);
            this.PnlContent.Controls.Add(this.TxtUsername);
            this.PnlContent.Controls.Add(this.TxtEmail);
            this.PnlContent.Controls.Add(this.TxtWebsite);
            this.PnlContent.Size = new System.Drawing.Size(714, 431);
            // 
            // TxtWebsite
            // 
            this.TxtWebsite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtWebsite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.TxtWebsite.BorderFocusColor = System.Drawing.SystemColors.Highlight;
            this.TxtWebsite.BorderSize = 2;
            this.TxtWebsite.ErrorText = "";
            this.TxtWebsite.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtWebsite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.TxtWebsite.IsInvalid = false;
            this.TxtWebsite.Location = new System.Drawing.Point(13, 165);
            this.TxtWebsite.Margin = new System.Windows.Forms.Padding(4);
            this.TxtWebsite.Multiline = false;
            this.TxtWebsite.Name = "TxtWebsite";
            this.TxtWebsite.Padding = new System.Windows.Forms.Padding(7);
            this.TxtWebsite.PlaceholderText = "Website";
            this.TxtWebsite.SetInfoText = "";
            this.TxtWebsite.Size = new System.Drawing.Size(691, 36);
            this.TxtWebsite.TabIndex = 30;
            this.TxtWebsite.UnderlinedStyle = true;
            this.TxtWebsite.UseSystemPasswordChar = false;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.TxtEmail.BorderFocusColor = System.Drawing.SystemColors.Highlight;
            this.TxtEmail.BorderSize = 2;
            this.TxtEmail.ErrorText = "";
            this.TxtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.TxtEmail.IsInvalid = false;
            this.TxtEmail.Location = new System.Drawing.Point(13, 224);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.TxtEmail.Multiline = false;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Padding = new System.Windows.Forms.Padding(7);
            this.TxtEmail.PlaceholderText = "Email";
            this.TxtEmail.SetInfoText = "";
            this.TxtEmail.Size = new System.Drawing.Size(691, 36);
            this.TxtEmail.TabIndex = 31;
            this.TxtEmail.UnderlinedStyle = true;
            this.TxtEmail.UseSystemPasswordChar = false;
            // 
            // TxtUsername
            // 
            this.TxtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.TxtUsername.BorderFocusColor = System.Drawing.SystemColors.Highlight;
            this.TxtUsername.BorderSize = 2;
            this.TxtUsername.ErrorText = "";
            this.TxtUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.TxtUsername.IsInvalid = false;
            this.TxtUsername.Location = new System.Drawing.Point(13, 282);
            this.TxtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUsername.Multiline = false;
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Padding = new System.Windows.Forms.Padding(7);
            this.TxtUsername.PlaceholderText = "Username";
            this.TxtUsername.SetInfoText = "";
            this.TxtUsername.Size = new System.Drawing.Size(691, 36);
            this.TxtUsername.TabIndex = 32;
            this.TxtUsername.UnderlinedStyle = true;
            this.TxtUsername.UseSystemPasswordChar = false;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.TxtPassword.BorderFocusColor = System.Drawing.SystemColors.Highlight;
            this.TxtPassword.BorderSize = 2;
            this.TxtPassword.ErrorText = "";
            this.TxtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.TxtPassword.IsInvalid = false;
            this.TxtPassword.Location = new System.Drawing.Point(13, 343);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPassword.Multiline = false;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Padding = new System.Windows.Forms.Padding(7);
            this.TxtPassword.PlaceholderText = "Password";
            this.TxtPassword.SetInfoText = "";
            this.TxtPassword.Size = new System.Drawing.Size(691, 36);
            this.TxtPassword.TabIndex = 33;
            this.TxtPassword.UnderlinedStyle = true;
            this.TxtPassword.UseSystemPasswordChar = false;
            // 
            // FrmAddAcc
            // 
            this.AbortText = "&OK";
            this.AcceptText = "&Save Account";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(714, 488);
            this.DialogType = Secure_The_Pass.UI.BaseDialog.enumDialogType.Ok;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmAddAcc";
            this.Text = "FrmAddAcc";
            this.Load += new System.EventHandler(this.FrmAddAcc_Load);
            this.PnlActions.ResumeLayout(false);
            this.PnlActions.PerformLayout();
            this.PnlActionsBase.ResumeLayout(false);
            this.PnlActionsBase.PerformLayout();
            this.PnlContent.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.PasswordManagerTextBox TxtPassword;
        private Controls.PasswordManagerTextBox TxtUsername;
        private Controls.PasswordManagerTextBox TxtEmail;
        private Controls.PasswordManagerTextBox TxtWebsite;
    }
}