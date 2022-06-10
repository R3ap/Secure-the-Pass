using Secure_The_Pass.UI.BaseDialog;

namespace Secure_The_Pass.UI.Settings
{
    partial class FrmSettings
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Show Password");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Copy to Clipboard");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Remember me");
            this.label6 = new System.Windows.Forms.Label();
            this.SettingProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.SettingsView = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPasswordLength = new Secure_The_Pass.UI.Controls.PasswordManagerTextBox();
            this.TxtAllowedCharacters = new Secure_The_Pass.UI.Controls.PasswordManagerTextBox();
            this.CboCopyToClipboard = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PnlActions.SuspendLayout();
            this.PnlActionsBase.SuspendLayout();
            this.PnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // _btAccept
            // 
            this._btAccept.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._btAccept.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this._btAccept.Size = new System.Drawing.Size(118, 46);
            this._btAccept.Text = "&Save";
            // 
            // _btAbort
            // 
            this._btAbort.Location = new System.Drawing.Point(127, 3);
            this._btAbort.Text = "&OK";
            // 
            // PnlActions
            // 
            this.PnlActions.Location = new System.Drawing.Point(0, 461);
            this.PnlActions.Size = new System.Drawing.Size(793, 58);
            // 
            // PnlActionsBase
            // 
            this.PnlActionsBase.Location = new System.Drawing.Point(662, 3);
            this.PnlActionsBase.Size = new System.Drawing.Size(128, 52);
            // 
            // PnlActionsExtension
            // 
            this.PnlActionsExtension.Location = new System.Drawing.Point(606, 3);
            // 
            // PnlContent
            // 
            this.PnlContent.Controls.Add(this.label4);
            this.PnlContent.Controls.Add(this.CboCopyToClipboard);
            this.PnlContent.Controls.Add(this.label3);
            this.PnlContent.Controls.Add(this.TxtAllowedCharacters);
            this.PnlContent.Controls.Add(this.TxtPasswordLength);
            this.PnlContent.Controls.Add(this.label2);
            this.PnlContent.Controls.Add(this.SettingsView);
            this.PnlContent.Controls.Add(this.label6);
            this.PnlContent.Size = new System.Drawing.Size(793, 461);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label6.Location = new System.Drawing.Point(37, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 29);
            this.label6.TabIndex = 28;
            this.label6.Text = "Password length";
            // 
            // SettingProvider
            // 
            this.SettingProvider.ContainerControl = this;
            // 
            // SettingsView
            // 
            this.SettingsView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.SettingsView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SettingsView.CheckBoxes = true;
            this.SettingsView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SettingsView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.SettingsView.FullRowSelect = true;
            this.SettingsView.Location = new System.Drawing.Point(37, 274);
            this.SettingsView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SettingsView.Name = "SettingsView";
            treeNode1.Name = "ShowPass";
            treeNode1.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            treeNode1.Text = "Show Password";
            treeNode2.Name = "CopyToClipboard";
            treeNode2.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            treeNode2.Text = "Copy to Clipboard";
            treeNode3.Name = "RememberMe";
            treeNode3.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            treeNode3.Text = "Remember me";
            this.SettingsView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.SettingsView.Size = new System.Drawing.Size(248, 84);
            this.SettingsView.TabIndex = 45;
            this.SettingsView.BeforeCheck += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeCheck);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label2.Location = new System.Drawing.Point(37, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 29);
            this.label2.TabIndex = 47;
            this.label2.Text = "Allowed characters";
            // 
            // TxtPasswordLength
            // 
            this.TxtPasswordLength.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPasswordLength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.TxtPasswordLength.BorderFocusColor = System.Drawing.SystemColors.Highlight;
            this.TxtPasswordLength.BorderSize = 2;
            this.TxtPasswordLength.ErrorText = "";
            this.TxtPasswordLength.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtPasswordLength.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.TxtPasswordLength.IsInvalid = false;
            this.TxtPasswordLength.Location = new System.Drawing.Point(419, 59);
            this.TxtPasswordLength.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPasswordLength.Multiline = false;
            this.TxtPasswordLength.Name = "TxtPasswordLength";
            this.TxtPasswordLength.Padding = new System.Windows.Forms.Padding(7);
            this.TxtPasswordLength.PlaceholderText = "";
            this.TxtPasswordLength.SetInfoText = "";
            this.TxtPasswordLength.Size = new System.Drawing.Size(341, 36);
            this.TxtPasswordLength.TabIndex = 48;
            this.TxtPasswordLength.UnderlinedStyle = true;
            this.TxtPasswordLength.UseSystemPasswordChar = false;
            this.TxtPasswordLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPWlengt_KeyPress);
            // 
            // TxtAllowedCharacters
            // 
            this.TxtAllowedCharacters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtAllowedCharacters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.TxtAllowedCharacters.BorderFocusColor = System.Drawing.SystemColors.Highlight;
            this.TxtAllowedCharacters.BorderSize = 2;
            this.TxtAllowedCharacters.ErrorText = "";
            this.TxtAllowedCharacters.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtAllowedCharacters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.TxtAllowedCharacters.IsInvalid = false;
            this.TxtAllowedCharacters.Location = new System.Drawing.Point(418, 115);
            this.TxtAllowedCharacters.Margin = new System.Windows.Forms.Padding(4);
            this.TxtAllowedCharacters.Multiline = false;
            this.TxtAllowedCharacters.Name = "TxtAllowedCharacters";
            this.TxtAllowedCharacters.Padding = new System.Windows.Forms.Padding(7);
            this.TxtAllowedCharacters.PlaceholderText = "";
            this.TxtAllowedCharacters.SetInfoText = "";
            this.TxtAllowedCharacters.Size = new System.Drawing.Size(341, 36);
            this.TxtAllowedCharacters.TabIndex = 49;
            this.TxtAllowedCharacters.UnderlinedStyle = true;
            this.TxtAllowedCharacters.UseSystemPasswordChar = false;
            // 
            // CboCopyToClipboard
            // 
            this.CboCopyToClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CboCopyToClipboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.CboCopyToClipboard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCopyToClipboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CboCopyToClipboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CboCopyToClipboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.CboCopyToClipboard.Items.AddRange(new object[] {
            "Username",
            "Email",
            "Password"});
            this.CboCopyToClipboard.Location = new System.Drawing.Point(419, 187);
            this.CboCopyToClipboard.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CboCopyToClipboard.Name = "CboCopyToClipboard";
            this.CboCopyToClipboard.Size = new System.Drawing.Size(340, 24);
            this.CboCopyToClipboard.TabIndex = 50;
            this.CboCopyToClipboard.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label3.Location = new System.Drawing.Point(37, 182);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 29);
            this.label3.TabIndex = 51;
            this.label3.Text = "Copy to Clipboard";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label4.Location = new System.Drawing.Point(37, 242);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 29);
            this.label4.TabIndex = 52;
            this.label4.Text = "Permission:";
            // 
            // FrmSettings
            // 
            this.AbortText = "&OK";
            this.AcceptText = "&Save";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(793, 519);
            this.DialogType = Secure_The_Pass.UI.BaseDialog.enumDialogType.Ok;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmSettings";
            this.Text = "FrmSettings";
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.PnlActions.ResumeLayout(false);
            this.PnlActions.PerformLayout();
            this.PnlActionsBase.ResumeLayout(false);
            this.PnlActionsBase.PerformLayout();
            this.PnlContent.ResumeLayout(false);
            this.PnlContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider SettingProvider;
        private System.Windows.Forms.TreeView SettingsView;
        private Label label2;
        private Controls.PasswordManagerTextBox TxtAllowedCharacters;
        private Controls.PasswordManagerTextBox TxtPasswordLength;
        private ComboBox CboCopyToClipboard;
        private Label label3;
        private Label label4;
    }
}