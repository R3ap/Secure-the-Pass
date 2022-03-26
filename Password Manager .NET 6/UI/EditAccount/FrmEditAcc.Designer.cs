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
            this.passwordManagerTextBox1 = new Secure_The_Pass.UI.Controls.PasswordManagerTextBox();
            this.passwordManagerTextBox2 = new Secure_The_Pass.UI.Controls.PasswordManagerTextBox();
            this.passwordManagerTextBox3 = new Secure_The_Pass.UI.Controls.PasswordManagerTextBox();
            this.passwordManagerTextBox4 = new Secure_The_Pass.UI.Controls.PasswordManagerTextBox();
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
            this.PnlContent.Controls.Add(this.passwordManagerTextBox4);
            this.PnlContent.Controls.Add(this.passwordManagerTextBox3);
            this.PnlContent.Controls.Add(this.passwordManagerTextBox2);
            this.PnlContent.Controls.Add(this.passwordManagerTextBox1);
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
            // passwordManagerTextBox1
            // 
            this.passwordManagerTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordManagerTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.passwordManagerTextBox1.BorderFocusColor = System.Drawing.SystemColors.Highlight;
            this.passwordManagerTextBox1.BorderSize = 2;
            this.passwordManagerTextBox1.ErroText = "";
            this.passwordManagerTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwordManagerTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.passwordManagerTextBox1.IsInvalid = false;
            this.passwordManagerTextBox1.Location = new System.Drawing.Point(292, 74);
            this.passwordManagerTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.passwordManagerTextBox1.Multiline = false;
            this.passwordManagerTextBox1.Name = "passwordManagerTextBox1";
            this.passwordManagerTextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.passwordManagerTextBox1.PlaceholderText = "";
            this.passwordManagerTextBox1.SetInfoText = "";
            this.passwordManagerTextBox1.Size = new System.Drawing.Size(357, 36);
            this.passwordManagerTextBox1.TabIndex = 39;
            this.passwordManagerTextBox1.UnderlinedStyle = true;
            this.passwordManagerTextBox1.UseSystemPasswordChar = false;
            // 
            // passwordManagerTextBox2
            // 
            this.passwordManagerTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordManagerTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.passwordManagerTextBox2.BorderFocusColor = System.Drawing.SystemColors.Highlight;
            this.passwordManagerTextBox2.BorderSize = 2;
            this.passwordManagerTextBox2.ErroText = "";
            this.passwordManagerTextBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwordManagerTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.passwordManagerTextBox2.IsInvalid = false;
            this.passwordManagerTextBox2.Location = new System.Drawing.Point(292, 129);
            this.passwordManagerTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.passwordManagerTextBox2.Multiline = false;
            this.passwordManagerTextBox2.Name = "passwordManagerTextBox2";
            this.passwordManagerTextBox2.Padding = new System.Windows.Forms.Padding(7);
            this.passwordManagerTextBox2.PlaceholderText = "";
            this.passwordManagerTextBox2.SetInfoText = "";
            this.passwordManagerTextBox2.Size = new System.Drawing.Size(357, 36);
            this.passwordManagerTextBox2.TabIndex = 40;
            this.passwordManagerTextBox2.UnderlinedStyle = true;
            this.passwordManagerTextBox2.UseSystemPasswordChar = false;
            // 
            // passwordManagerTextBox3
            // 
            this.passwordManagerTextBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordManagerTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.passwordManagerTextBox3.BorderFocusColor = System.Drawing.SystemColors.Highlight;
            this.passwordManagerTextBox3.BorderSize = 2;
            this.passwordManagerTextBox3.ErroText = "";
            this.passwordManagerTextBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwordManagerTextBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.passwordManagerTextBox3.IsInvalid = false;
            this.passwordManagerTextBox3.Location = new System.Drawing.Point(292, 182);
            this.passwordManagerTextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.passwordManagerTextBox3.Multiline = false;
            this.passwordManagerTextBox3.Name = "passwordManagerTextBox3";
            this.passwordManagerTextBox3.Padding = new System.Windows.Forms.Padding(7);
            this.passwordManagerTextBox3.PlaceholderText = "";
            this.passwordManagerTextBox3.SetInfoText = "";
            this.passwordManagerTextBox3.Size = new System.Drawing.Size(357, 36);
            this.passwordManagerTextBox3.TabIndex = 41;
            this.passwordManagerTextBox3.UnderlinedStyle = true;
            this.passwordManagerTextBox3.UseSystemPasswordChar = false;
            // 
            // passwordManagerTextBox4
            // 
            this.passwordManagerTextBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordManagerTextBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.passwordManagerTextBox4.BorderFocusColor = System.Drawing.SystemColors.Highlight;
            this.passwordManagerTextBox4.BorderSize = 2;
            this.passwordManagerTextBox4.ErroText = "";
            this.passwordManagerTextBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwordManagerTextBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.passwordManagerTextBox4.IsInvalid = false;
            this.passwordManagerTextBox4.Location = new System.Drawing.Point(292, 232);
            this.passwordManagerTextBox4.Margin = new System.Windows.Forms.Padding(4);
            this.passwordManagerTextBox4.Multiline = false;
            this.passwordManagerTextBox4.Name = "passwordManagerTextBox4";
            this.passwordManagerTextBox4.Padding = new System.Windows.Forms.Padding(7);
            this.passwordManagerTextBox4.PlaceholderText = "";
            this.passwordManagerTextBox4.SetInfoText = "";
            this.passwordManagerTextBox4.Size = new System.Drawing.Size(357, 36);
            this.passwordManagerTextBox4.TabIndex = 42;
            this.passwordManagerTextBox4.UnderlinedStyle = true;
            this.passwordManagerTextBox4.UseSystemPasswordChar = false;
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
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWebsite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private Controls.PasswordManagerTextBox passwordManagerTextBox4;
        private Controls.PasswordManagerTextBox passwordManagerTextBox3;
        private Controls.PasswordManagerTextBox passwordManagerTextBox2;
        private Controls.PasswordManagerTextBox passwordManagerTextBox1;
    }
}