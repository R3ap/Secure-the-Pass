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
            this.passwordTextBox1 = new CustomControls.RJControls.PasswordTextBox();
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
            this.PnlContent.Controls.Add(this.passwordTextBox1);
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
            // passwordTextBox1
            // 
            this.passwordTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.passwordTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.passwordTextBox1.BorderFocusColor = System.Drawing.SystemColors.Highlight;
            this.passwordTextBox1.BorderSize = 2;
            this.passwordTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.passwordTextBox1.Location = new System.Drawing.Point(40, 19);
            this.passwordTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextBox1.Multiline = false;
            this.passwordTextBox1.Name = "passwordTextBox1";
            this.passwordTextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.passwordTextBox1.PasswordChar = false;
            this.passwordTextBox1.PlaceholderText = "";
            this.passwordTextBox1.Size = new System.Drawing.Size(250, 31);
            this.passwordTextBox1.TabIndex = 36;
            this.passwordTextBox1.UnderlinedStyle = false;
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
            this.Load += new System.EventHandler(this.CtrlLogIn_Load);
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
        private CustomControls.RJControls.PasswordTextBox passwordTextBox1;
    }
}
