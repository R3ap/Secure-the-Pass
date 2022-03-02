
namespace Password_Manager_.NET_6
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCleanAcc = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.cboFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SettingProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSignOut = new System.Windows.Forms.Button();
            this.SettingsView = new System.Windows.Forms.TreeView();
            this.PnlActions.SuspendLayout();
            this.PnlActionsBase.SuspendLayout();
            this.PnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingProvider)).BeginInit();
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
            this.PnlContent.Controls.Add(this.SettingsView);
            this.PnlContent.Controls.Add(this.btnCleanAcc);
            this.PnlContent.Controls.Add(this.label6);
            this.PnlContent.Controls.Add(this.btnSave);
            this.PnlContent.Controls.Add(this.btnDeleteUser);
            this.PnlContent.Controls.Add(this.cboFilter);
            this.PnlContent.Controls.Add(this.label1);
            this.PnlContent.Controls.Add(this.txtPWlengt);
            this.PnlContent.Controls.Add(this.btnSignOut);
            this.PnlContent.Size = new System.Drawing.Size(793, 519);
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
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.Lime;
            this.btnSave.Location = new System.Drawing.Point(583, 454);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(170, 54);
            this.btnSave.TabIndex = 7;
            this.btnSave.Tag = "";
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCleanAcc
            // 
            this.btnCleanAcc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCleanAcc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCleanAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCleanAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCleanAcc.ForeColor = System.Drawing.Color.Red;
            this.btnCleanAcc.Location = new System.Drawing.Point(37, 393);
            this.btnCleanAcc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCleanAcc.Name = "btnCleanAcc";
            this.btnCleanAcc.Size = new System.Drawing.Size(170, 54);
            this.btnCleanAcc.TabIndex = 8;
            this.btnCleanAcc.Tag = "";
            this.btnCleanAcc.Text = "Clean Account";
            this.btnCleanAcc.UseVisualStyleBackColor = true;
            this.btnCleanAcc.Click += new System.EventHandler(this.btnCleanAcc_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteUser.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteUser.Location = new System.Drawing.Point(37, 454);
            this.btnDeleteUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(170, 54);
            this.btnDeleteUser.TabIndex = 9;
            this.btnDeleteUser.Tag = "";
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
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
            this.cboFilter.Location = new System.Drawing.Point(419, 126);
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
            this.label1.Location = new System.Drawing.Point(37, 118);
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
            // btnSignOut
            // 
            this.btnSignOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSignOut.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSignOut.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSignOut.Location = new System.Drawing.Point(225, 454);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(170, 54);
            this.btnSignOut.TabIndex = 44;
            this.btnSignOut.Tag = "";
            this.btnSignOut.Text = "Sign out";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
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
            this.SettingsView.Size = new System.Drawing.Size(264, 183);
            this.SettingsView.TabIndex = 45;
            this.SettingsView.BeforeCheck += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeCheck);
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(793, 519);
            this.DialogType = Password_Manager_.NET_6.UI.BaseDialog.enumDialogType.None;
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
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnCleanAcc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboFilter;
        private System.Windows.Forms.ErrorProvider SettingProvider;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.TreeView SettingsView;
    }
}