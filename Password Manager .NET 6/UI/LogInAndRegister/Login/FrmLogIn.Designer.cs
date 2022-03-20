namespace Password_Manager_.NET_6.UI.LogIn
{
    partial class FrmLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogIn));
            this.ChkRememberMe = new System.Windows.Forms.CheckBox();
            this.lbllForgotPassword = new System.Windows.Forms.LinkLabel();
            this.PassProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.TxtEmail = new Password_Manager_.NET_6.UI.Controls.PasswordManagerTextBox();
            this.txtPassword = new Password_Manager_.NET_6.UI.Controls.PasswordManagerTextBox();
            this.PnlActions.SuspendLayout();
            this.PnlActionsBase.SuspendLayout();
            this.PnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PassProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // _btAccept
            // 
            this._btAccept.Size = new System.Drawing.Size(76, 31);
            // 
            // _btAbort
            // 
            this._btAbort.Location = new System.Drawing.Point(85, 3);
            this._btAbort.Size = new System.Drawing.Size(75, 31);
            this._btAbort.Text = "&Close";
            // 
            // PnlActions
            // 
            this.PnlActions.Location = new System.Drawing.Point(0, 407);
            this.PnlActions.Size = new System.Drawing.Size(800, 43);
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
            this.PnlContent.Controls.Add(this.txtPassword);
            this.PnlContent.Controls.Add(this.TxtEmail);
            this.PnlContent.Controls.Add(this.ChkRememberMe);
            this.PnlContent.Controls.Add(this.lbllForgotPassword);
            this.PnlContent.Size = new System.Drawing.Size(413, 187);
            // 
            // ChkRememberMe
            // 
            this.ChkRememberMe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChkRememberMe.AutoSize = true;
            this.ChkRememberMe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChkRememberMe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.ChkRememberMe.Location = new System.Drawing.Point(237, 134);
            this.ChkRememberMe.Margin = new System.Windows.Forms.Padding(4);
            this.ChkRememberMe.Name = "ChkRememberMe";
            this.ChkRememberMe.Size = new System.Drawing.Size(140, 25);
            this.ChkRememberMe.TabIndex = 35;
            this.ChkRememberMe.Text = "Remember Me";
            this.ChkRememberMe.UseVisualStyleBackColor = true;
            // 
            // lbllForgotPassword
            // 
            this.lbllForgotPassword.AutoSize = true;
            this.lbllForgotPassword.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lbllForgotPassword.Location = new System.Drawing.Point(34, 135);
            this.lbllForgotPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbllForgotPassword.Name = "lbllForgotPassword";
            this.lbllForgotPassword.Size = new System.Drawing.Size(169, 21);
            this.lbllForgotPassword.TabIndex = 34;
            this.lbllForgotPassword.TabStop = true;
            this.lbllForgotPassword.Text = "Forgot your Password?";
            this.lbllForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlblForgotPw_LinkClicked);
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
            this.TxtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TxtEmail.Location = new System.Drawing.Point(34, 45);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.TxtEmail.Multiline = false;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.PlaceholderText = "Email";
            this.TxtEmail.Size = new System.Drawing.Size(343, 29);
            this.TxtEmail.TabIndex = 36;
            this.TxtEmail.UnderlinedStyle = true;
            this.TxtEmail.UseSystemPasswordChar = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.txtPassword.BorderFocusColor = System.Drawing.SystemColors.Highlight;
            this.txtPassword.BorderSize = 2;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPassword.Location = new System.Drawing.Point(34, 95);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.Size = new System.Drawing.Size(343, 29);
            this.txtPassword.TabIndex = 37;
            this.txtPassword.UnderlinedStyle = true;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // FrmLogIn
            // 
            this.AbortText = "&Close";
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(413, 187);
            this.DialogType = Password_Manager_.NET_6.UI.BaseDialog.enumDialogType.None;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmLogIn";
            this.Load += new System.EventHandler(this.FrmLogIn_Load);
            this.PnlActions.ResumeLayout(false);
            this.PnlActions.PerformLayout();
            this.PnlActionsBase.ResumeLayout(false);
            this.PnlActionsBase.PerformLayout();
            this.PnlContent.ResumeLayout(false);
            this.PnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PassProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CheckBox ChkRememberMe;
        private LinkLabel lbllForgotPassword;
        private ErrorProvider PassProvider;
        private Controls.PasswordManagerTextBox txtPassword;
        private Controls.PasswordManagerTextBox TxtEmail;
    }
}
