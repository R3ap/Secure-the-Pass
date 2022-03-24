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
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Email");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Password");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Username");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Copy to Clipboard", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4});
            this.txtPWlengt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SettingProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.SettingsView = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAllowedCharacters = new System.Windows.Forms.TextBox();
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
            this.PnlContent.Controls.Add(this.label2);
            this.PnlContent.Controls.Add(this.TxtAllowedCharacters);
            this.PnlContent.Controls.Add(this.SettingsView);
            this.PnlContent.Controls.Add(this.label6);
            this.PnlContent.Controls.Add(this.cboFilter);
            this.PnlContent.Controls.Add(this.label1);
            this.PnlContent.Controls.Add(this.txtPWlengt);
            this.PnlContent.Size = new System.Drawing.Size(793, 461);
            // 
            // txtPWlengt
            // 
            this.txtPWlengt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPWlengt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.txtPWlengt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPWlengt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPWlengt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtPWlengt.Location = new System.Drawing.Point(419, 70);
            this.txtPWlengt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPWlengt.Name = "txtPWlengt";
            this.txtPWlengt.Size = new System.Drawing.Size(341, 22);
            this.txtPWlengt.TabIndex = 14;
            this.txtPWlengt.TabStop = false;
            this.txtPWlengt.Text = "40";
            this.txtPWlengt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPWlengt_KeyPress);
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
            // cboFilter
            // 
            this.cboFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.cboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cboFilter.Items.AddRange(new object[] {
            "Username",
            "Website",
            "Email",
            "Password"});
            this.cboFilter.Location = new System.Drawing.Point(419, 152);
            this.cboFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboFilter.Name = "cboFilter";
            this.cboFilter.Size = new System.Drawing.Size(340, 24);
            this.cboFilter.TabIndex = 2;
            this.cboFilter.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label1.Location = new System.Drawing.Point(37, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 29);
            this.label1.TabIndex = 42;
            this.label1.Text = "Filter";
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
            this.SettingsView.Cursor = System.Windows.Forms.Cursors.Default;
            this.SettingsView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SettingsView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.SettingsView.FullRowSelect = true;
            this.SettingsView.HideSelection = false;
            this.SettingsView.Location = new System.Drawing.Point(43, 193);
            this.SettingsView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SettingsView.Name = "SettingsView";
            treeNode1.Name = "ShowPass";
            treeNode1.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            treeNode1.Text = "Show Password";
            treeNode2.Name = "Email";
            treeNode2.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            treeNode2.Text = "Email";
            treeNode3.Name = "Password";
            treeNode3.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            treeNode3.Text = "Password";
            treeNode4.Name = "Username";
            treeNode4.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            treeNode4.Text = "Username";
            treeNode5.Name = "CopyToClipboard";
            treeNode5.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            treeNode5.Text = "Copy to Clipboard";
            this.SettingsView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode5});
            this.SettingsView.Size = new System.Drawing.Size(329, 158);
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
            this.label2.Location = new System.Drawing.Point(37, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 29);
            this.label2.TabIndex = 47;
            this.label2.Text = "Allowed characters";
            // 
            // TxtAllowedCharacters
            // 
            this.TxtAllowedCharacters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtAllowedCharacters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.TxtAllowedCharacters.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtAllowedCharacters.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtAllowedCharacters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.TxtAllowedCharacters.Location = new System.Drawing.Point(419, 111);
            this.TxtAllowedCharacters.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtAllowedCharacters.Name = "TxtAllowedCharacters";
            this.TxtAllowedCharacters.Size = new System.Drawing.Size(341, 22);
            this.TxtAllowedCharacters.TabIndex = 46;
            this.TxtAllowedCharacters.TabStop = false;
            // 
            // FrmSettings
            // 
            this.AbortText = "&OK";
            this.AcceptText = "&Save";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(793, 519);
            this.DialogType = enumDialogType.Ok;
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

        private System.Windows.Forms.TextBox txtPWlengt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboFilter;
        private System.Windows.Forms.ErrorProvider SettingProvider;
        private System.Windows.Forms.TreeView SettingsView;
        private Label label2;
        private TextBox TxtAllowedCharacters;
    }
}