using Secure_The_Pass.UI.BaseDialog;

namespace Secure_The_Pass.UI.EditAccount
{
    partial class FrmEditAcc
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
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this._btAccept.Location = new System.Drawing.Point(3, 3);
            this._btAccept.Size = new System.Drawing.Size(96, 42);
            // 
            // _btAbort
            // 
            this._btAbort.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._btAbort.Location = new System.Drawing.Point(105, 3);
            this._btAbort.Size = new System.Drawing.Size(96, 42);
            // 
            // PnlActions
            // 
            this.PnlActions.Location = new System.Drawing.Point(3, 348);
            this.PnlActions.Size = new System.Drawing.Size(659, 54);
            // 
            // PnlActionsBase
            // 
            this.PnlActionsBase.Location = new System.Drawing.Point(448, 3);
            this.PnlActionsBase.Size = new System.Drawing.Size(208, 48);
            // 
            // PnlActionsExtension
            // 
            this.PnlActionsExtension.Location = new System.Drawing.Point(392, 3);
            // 
            // PnlContent
            // 
            this.PnlContent.Controls.Add(this.TxtPassword);
            this.PnlContent.Controls.Add(this.TxtUsername);
            this.PnlContent.Controls.Add(this.TxtEmail);
            this.PnlContent.Controls.Add(this.TxtWebsite);
            this.PnlContent.Controls.Add(this.label2);
            this.PnlContent.Controls.Add(this.label6);
            this.PnlContent.Controls.Add(this.label1);
            this.PnlContent.Controls.Add(this.label3);
            this.PnlContent.Size = new System.Drawing.Size(659, 311);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label6.Location = new System.Drawing.Point(41, 236);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 32);
            this.label6.TabIndex = 35;
            this.label6.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label3.Location = new System.Drawing.Point(41, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 32);
            this.label3.TabIndex = 33;
            this.label3.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(41, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 32);
            this.label1.TabIndex = 31;
            this.label1.Text = "Website";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label2.Location = new System.Drawing.Point(41, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 32);
            this.label2.TabIndex = 38;
            this.label2.Text = "Username";
            // 
            // TxtWebsite
            // 
            this.TxtWebsite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtWebsite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.TxtWebsite.BorderFocusColor = System.Drawing.SystemColors.Highlight;
            this.TxtWebsite.BorderSize = 2;
            this.TxtWebsite.ErrorText = "";
            this.TxtWebsite.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtWebsite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.TxtWebsite.IsInvalid = false;
            this.TxtWebsite.Location = new System.Drawing.Point(292, 74);
            this.TxtWebsite.Margin = new System.Windows.Forms.Padding(4);
            this.TxtWebsite.Multiline = false;
            this.TxtWebsite.Name = "TxtWebsite";
            this.TxtWebsite.Padding = new System.Windows.Forms.Padding(7);
            this.TxtWebsite.PlaceholderText = "";
            this.TxtWebsite.SetInfoText = "";
            this.TxtWebsite.Size = new System.Drawing.Size(357, 36);
            this.TxtWebsite.TabIndex = 39;
            this.TxtWebsite.UnderlinedStyle = true;
            this.TxtWebsite.UseSystemPasswordChar = false;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.TxtEmail.BorderFocusColor = System.Drawing.SystemColors.Highlight;
            this.TxtEmail.BorderSize = 2;
            this.TxtEmail.ErrorText = "";
            this.TxtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.TxtEmail.IsInvalid = false;
            this.TxtEmail.Location = new System.Drawing.Point(292, 129);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.TxtEmail.Multiline = false;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Padding = new System.Windows.Forms.Padding(7);
            this.TxtEmail.PlaceholderText = "";
            this.TxtEmail.SetInfoText = "";
            this.TxtEmail.Size = new System.Drawing.Size(357, 36);
            this.TxtEmail.TabIndex = 40;
            this.TxtEmail.UnderlinedStyle = true;
            this.TxtEmail.UseSystemPasswordChar = false;
            // 
            // TxtUsername
            // 
            this.TxtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.TxtUsername.BorderFocusColor = System.Drawing.SystemColors.Highlight;
            this.TxtUsername.BorderSize = 2;
            this.TxtUsername.ErrorText = "";
            this.TxtUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.TxtUsername.IsInvalid = false;
            this.TxtUsername.Location = new System.Drawing.Point(292, 182);
            this.TxtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUsername.Multiline = false;
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Padding = new System.Windows.Forms.Padding(7);
            this.TxtUsername.PlaceholderText = "";
            this.TxtUsername.SetInfoText = "";
            this.TxtUsername.Size = new System.Drawing.Size(357, 36);
            this.TxtUsername.TabIndex = 41;
            this.TxtUsername.UnderlinedStyle = true;
            this.TxtUsername.UseSystemPasswordChar = false;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.TxtPassword.BorderFocusColor = System.Drawing.SystemColors.Highlight;
            this.TxtPassword.BorderSize = 2;
            this.TxtPassword.ErrorText = "";
            this.TxtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.TxtPassword.IsInvalid = false;
            this.TxtPassword.Location = new System.Drawing.Point(292, 232);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPassword.Multiline = false;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Padding = new System.Windows.Forms.Padding(7);
            this.TxtPassword.PlaceholderText = "";
            this.TxtPassword.SetInfoText = "";
            this.TxtPassword.Size = new System.Drawing.Size(357, 36);
            this.TxtPassword.TabIndex = 42;
            this.TxtPassword.UnderlinedStyle = true;
            this.TxtPassword.UseSystemPasswordChar = false;
            // 
            // FrmEditAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(665, 405);
            this.DialogType = Secure_The_Pass.UI.BaseDialog.enumDialogType.OkAndAbort;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsSizable = false;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.Name = "FrmEditAcc";
            this.ShowIcon = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditAcc";
            this.Load += new System.EventHandler(this.FrmEditAcc_Load);
            this.PnlActions.ResumeLayout(false);
            this.PnlActions.PerformLayout();
            this.PnlActionsBase.ResumeLayout(false);
            this.PnlActionsBase.PerformLayout();
            this.PnlContent.ResumeLayout(false);
            this.PnlContent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Controls.PasswordManagerTextBox TxtPassword;
        private Controls.PasswordManagerTextBox TxtUsername;
        private Controls.PasswordManagerTextBox TxtEmail;
        private Controls.PasswordManagerTextBox TxtWebsite;
    }
}