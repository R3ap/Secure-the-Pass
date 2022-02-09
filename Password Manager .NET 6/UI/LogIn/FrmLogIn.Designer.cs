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
            this.btnEyePassword = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ChkRememberMe = new System.Windows.Forms.CheckBox();
            this.lbllForgotPassword = new System.Windows.Forms.LinkLabel();
            this.PassProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PassProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // _btAccept
            // 
            this._btAccept.Location = new System.Drawing.Point(143, 3);
            this._btAccept.Size = new System.Drawing.Size(76, 29);
            // 
            // _btAbort
            // 
            this._btAbort.Location = new System.Drawing.Point(72, 3);
            this._btAbort.Size = new System.Drawing.Size(75, 29);
            this._btAbort.Text = "&Close";
            // 
            // btnEyePassword
            // 
            this.btnEyePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEyePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.btnEyePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEyePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEyePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.btnEyePassword.Image = global::Password_Manager_.NET_6.Properties.Resources.icons8_eye_24px;
            this.btnEyePassword.Location = new System.Drawing.Point(487, 115);
            this.btnEyePassword.Margin = new System.Windows.Forms.Padding(4);
            this.btnEyePassword.Name = "btnEyePassword";
            this.btnEyePassword.Size = new System.Drawing.Size(28, 24);
            this.btnEyePassword.TabIndex = 41;
            this.btnEyePassword.UseVisualStyleBackColor = false;
            this.btnEyePassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnEyePassword_MouseDown);
            this.btnEyePassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnEyePassword_MouseUp);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtPassword.Location = new System.Drawing.Point(235, 115);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(258, 24);
            this.txtPassword.TabIndex = 40;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtEmail.Location = new System.Drawing.Point(235, 77);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(280, 24);
            this.txtEmail.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label2.Location = new System.Drawing.Point(32, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 29);
            this.label2.TabIndex = 38;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(32, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 37;
            this.label1.Text = "Email";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblTitle.Location = new System.Drawing.Point(235, 12);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(78, 29);
            this.lblTitle.TabIndex = 36;
            this.lblTitle.Text = "LogIn";
            // 
            // ChkRememberMe
            // 
            this.ChkRememberMe.AutoSize = true;
            this.ChkRememberMe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChkRememberMe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.ChkRememberMe.Location = new System.Drawing.Point(235, 152);
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
            this.lbllForgotPassword.Location = new System.Drawing.Point(32, 156);
            this.lbllForgotPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbllForgotPassword.Name = "lbllForgotPassword";
            this.lbllForgotPassword.Size = new System.Drawing.Size(169, 21);
            this.lbllForgotPassword.TabIndex = 34;
            this.lbllForgotPassword.TabStop = true;
            this.lbllForgotPassword.Text = "Forgot your Password?";
            // 
            // PassProvider
            // 
            this.PassProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.PassProvider.ContainerControl = this;
            this.PassProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("PassProvider.Icon")));
            // 
            // FrmLogIn
            // 
            this.AbortText = "&Close";
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(540, 228);
            this.Controls.Add(this.btnEyePassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ChkRememberMe);
            this.Controls.Add(this.lbllForgotPassword);
            this.DialogType = Password_Manager_.NET_6.UI.BaseDialog.enumDialogType.None;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmLogIn";
            this.Load += new System.EventHandler(this.CtrlLogIn_Load);
            this.Controls.SetChildIndex(this.lbllForgotPassword, 0);
            this.Controls.SetChildIndex(this.ChkRememberMe, 0);
            this.Controls.SetChildIndex(this.lblTitle, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtEmail, 0);
            this.Controls.SetChildIndex(this.txtPassword, 0);
            this.Controls.SetChildIndex(this.btnEyePassword, 0);
            ((System.ComponentModel.ISupportInitialize)(this.PassProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnEyePassword;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label label2;
        private Label label1;
        private Label lblTitle;
        private CheckBox ChkRememberMe;
        private LinkLabel lbllForgotPassword;
        private ErrorProvider PassProvider;
    }
}
