using Secure_The_Pass.UI.BaseDialog;

namespace Secure_The_Pass.UI.LogInAndRegister.Register
{
    partial class FrmRegister
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtEmail = new Secure_The_Pass.UI.Controls.PasswordManagerTextBox();
            this.TxtUsername = new Secure_The_Pass.UI.Controls.PasswordManagerTextBox();
            this.TxtPassword = new Secure_The_Pass.UI.Controls.PasswordManagerTextBox();
            this.TxtConfirm = new Secure_The_Pass.UI.Controls.PasswordManagerTextBox();
            this.PnlActions.SuspendLayout();
            this.PnlActionsBase.SuspendLayout();
            this.PnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlActionsBase
            // 
            this.PnlActionsBase.Location = new System.Drawing.Point(793, 3);
            this.PnlActionsBase.Size = new System.Drawing.Size(4, 0);
            // 
            // PnlActionsExtension
            // 
            this.PnlActionsExtension.Location = new System.Drawing.Point(737, 3);
            // 
            // PnlContent
            // 
            this.PnlContent.Controls.Add(this.TxtConfirm);
            this.PnlContent.Controls.Add(this.TxtPassword);
            this.PnlContent.Controls.Add(this.TxtUsername);
            this.PnlContent.Controls.Add(this.TxtEmail);
            this.PnlContent.Size = new System.Drawing.Size(547, 247);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.TxtEmail.BorderFocusColor = System.Drawing.SystemColors.Highlight;
            this.TxtEmail.BorderSize = 2;
            this.TxtEmail.ErroText = "";
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtEmail.ForeColor = System.Drawing.Color.DimGray;
            this.TxtEmail.IsInvalid = false;
            this.TxtEmail.Location = new System.Drawing.Point(25, 23);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.TxtEmail.Multiline = false;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Padding = new System.Windows.Forms.Padding(7);
            this.TxtEmail.PlaceholderText = "Email";
            this.TxtEmail.SetInfoText = "";
            this.TxtEmail.Size = new System.Drawing.Size(495, 35);
            this.TxtEmail.TabIndex = 0;
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
            this.TxtUsername.ErroText = "";
            this.TxtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtUsername.ForeColor = System.Drawing.Color.DimGray;
            this.TxtUsername.IsInvalid = false;
            this.TxtUsername.Location = new System.Drawing.Point(25, 78);
            this.TxtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUsername.Multiline = false;
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Padding = new System.Windows.Forms.Padding(7);
            this.TxtUsername.PlaceholderText = "Username";
            this.TxtUsername.SetInfoText = "";
            this.TxtUsername.Size = new System.Drawing.Size(495, 35);
            this.TxtUsername.TabIndex = 1;
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
            this.TxtPassword.ErroText = "";
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtPassword.ForeColor = System.Drawing.Color.DimGray;
            this.TxtPassword.IsInvalid = false;
            this.TxtPassword.Location = new System.Drawing.Point(25, 133);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPassword.Multiline = false;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Padding = new System.Windows.Forms.Padding(7);
            this.TxtPassword.PlaceholderText = "Password";
            this.TxtPassword.SetInfoText = "";
            this.TxtPassword.Size = new System.Drawing.Size(495, 35);
            this.TxtPassword.TabIndex = 2;
            this.TxtPassword.UnderlinedStyle = true;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // TxtConfirm
            // 
            this.TxtConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.TxtConfirm.BorderFocusColor = System.Drawing.SystemColors.Highlight;
            this.TxtConfirm.BorderSize = 2;
            this.TxtConfirm.ErroText = "";
            this.TxtConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtConfirm.ForeColor = System.Drawing.Color.DimGray;
            this.TxtConfirm.IsInvalid = false;
            this.TxtConfirm.Location = new System.Drawing.Point(25, 186);
            this.TxtConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.TxtConfirm.Multiline = false;
            this.TxtConfirm.Name = "TxtConfirm";
            this.TxtConfirm.Padding = new System.Windows.Forms.Padding(7);
            this.TxtConfirm.PlaceholderText = "Confirm";
            this.TxtConfirm.SetInfoText = "";
            this.TxtConfirm.Size = new System.Drawing.Size(495, 35);
            this.TxtConfirm.TabIndex = 3;
            this.TxtConfirm.UnderlinedStyle = true;
            this.TxtConfirm.UseSystemPasswordChar = true;
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(547, 247);
            this.DialogType = enumDialogType.None;
            this.Name = "FrmRegister";
            this.Load += new System.EventHandler(this.FrmRegister_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtConfirm_KeyDown);
            this.PnlActions.ResumeLayout(false);
            this.PnlActions.PerformLayout();
            this.PnlActionsBase.ResumeLayout(false);
            this.PnlActionsBase.PerformLayout();
            this.PnlContent.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Controls.PasswordManagerTextBox TxtConfirm;
        private Controls.PasswordManagerTextBox TxtPassword;
        private Controls.PasswordManagerTextBox TxtUsername;
        private Controls.PasswordManagerTextBox TxtEmail;
    }
}
