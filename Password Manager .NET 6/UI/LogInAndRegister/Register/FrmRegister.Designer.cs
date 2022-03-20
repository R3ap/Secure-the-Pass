namespace Password_Manager_.NET_6.UI.LogIn
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegister));
            this.PassProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.TxtEmail = new Password_Manager_.NET_6.UI.Controls.PasswordManagerTextBox();
            this.TxtUsername = new Password_Manager_.NET_6.UI.Controls.PasswordManagerTextBox();
            this.TxtPassword = new Password_Manager_.NET_6.UI.Controls.PasswordManagerTextBox();
            this.TxtConfirm = new Password_Manager_.NET_6.UI.Controls.PasswordManagerTextBox();
            this.PnlActions.SuspendLayout();
            this.PnlActionsBase.SuspendLayout();
            this.PnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PassProvider)).BeginInit();
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
            this.PnlContent.Size = new System.Drawing.Size(547, 234);
            // 
            // PassProvider
            // 
            this.PassProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.PassProvider.ContainerControl = this;
            this.PassProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("PassProvider.Icon")));
            // 
            // TxtEmail
            // 
            this.TxtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.TxtEmail.BorderFocusColor = System.Drawing.SystemColors.Highlight;
            this.TxtEmail.BorderSize = 2;
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtEmail.ForeColor = System.Drawing.Color.DimGray;
            this.TxtEmail.Location = new System.Drawing.Point(25, 23);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.TxtEmail.Multiline = false;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Padding = new System.Windows.Forms.Padding(7);
            this.TxtEmail.UseSystemPasswordChar = false;
            this.TxtEmail.PlaceholderText = "Email";
            this.TxtEmail.Size = new System.Drawing.Size(495, 35);
            this.TxtEmail.TabIndex = 0;
            this.TxtEmail.UnderlinedStyle = true;
            // 
            // TxtUsername
            // 
            this.TxtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.TxtUsername.BorderFocusColor = System.Drawing.SystemColors.Highlight;
            this.TxtUsername.BorderSize = 2;
            this.TxtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtUsername.ForeColor = System.Drawing.Color.DimGray;
            this.TxtUsername.Location = new System.Drawing.Point(25, 78);
            this.TxtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUsername.Multiline = false;
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Padding = new System.Windows.Forms.Padding(7);
            this.TxtUsername.UseSystemPasswordChar = false;
            this.TxtUsername.PlaceholderText = "Username";
            this.TxtUsername.Size = new System.Drawing.Size(495, 35);
            this.TxtUsername.TabIndex = 1;
            this.TxtUsername.UnderlinedStyle = true;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.TxtPassword.BorderFocusColor = System.Drawing.SystemColors.Highlight;
            this.TxtPassword.BorderSize = 2;
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtPassword.ForeColor = System.Drawing.Color.DimGray;
            this.TxtPassword.Location = new System.Drawing.Point(25, 133);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPassword.Multiline = false;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Padding = new System.Windows.Forms.Padding(7);
            this.TxtPassword.UseSystemPasswordChar = true;
            this.TxtPassword.PlaceholderText = "Password";
            this.TxtPassword.Size = new System.Drawing.Size(495, 35);
            this.TxtPassword.TabIndex = 2;
            this.TxtPassword.UnderlinedStyle = true;
            // 
            // TxtConfirm
            // 
            this.TxtConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtConfirm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.TxtConfirm.BorderFocusColor = System.Drawing.SystemColors.Highlight;
            this.TxtConfirm.BorderSize = 2;
            this.TxtConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtConfirm.ForeColor = System.Drawing.Color.DimGray;
            this.TxtConfirm.Location = new System.Drawing.Point(25, 186);
            this.TxtConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.TxtConfirm.Multiline = false;
            this.TxtConfirm.Name = "TxtConfirm";
            this.TxtConfirm.Padding = new System.Windows.Forms.Padding(7);
            this.TxtConfirm.UseSystemPasswordChar = true;
            this.TxtConfirm.PlaceholderText = "Confirm";
            this.TxtConfirm.Size = new System.Drawing.Size(495, 35);
            this.TxtConfirm.TabIndex = 3;
            this.TxtConfirm.UnderlinedStyle = true;
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(547, 234);
            this.DialogType = Password_Manager_.NET_6.UI.BaseDialog.enumDialogType.None;
            this.Name = "FrmRegister";
            this.Load += new System.EventHandler(this.FrmRegister_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtConfirm_KeyDown);
            this.PnlActions.ResumeLayout(false);
            this.PnlActions.PerformLayout();
            this.PnlActionsBase.ResumeLayout(false);
            this.PnlActionsBase.PerformLayout();
            this.PnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PassProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ErrorProvider PassProvider;
        private Controls.PasswordManagerTextBox TxtConfirm;
        private Controls.PasswordManagerTextBox TxtPassword;
        private Controls.PasswordManagerTextBox TxtUsername;
        private Controls.PasswordManagerTextBox TxtEmail;
    }
}
