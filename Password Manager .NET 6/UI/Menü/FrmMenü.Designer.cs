﻿
namespace Password_Manager_.NET_6
{
    partial class FrmMenü
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenü));
            this.panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnNewAcc = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnAccounts = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlFormload = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.PnlTitelBar = new System.Windows.Forms.Panel();
            this.panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PnlTitelBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel.Controls.Add(this.panel1);
            this.panel.Controls.Add(this.panel2);
            this.panel.Location = new System.Drawing.Point(0, 32);
            this.panel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(217, 575);
            this.panel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.btnNewAcc);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnAccounts);
            this.panel1.Location = new System.Drawing.Point(0, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 410);
            this.panel1.TabIndex = 0;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 0);
            this.pnlNav.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(4, 115);
            this.pnlNav.TabIndex = 17;
            // 
            // btnNewAcc
            // 
            this.btnNewAcc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewAcc.FlatAppearance.BorderSize = 0;
            this.btnNewAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewAcc.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNewAcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnNewAcc.Image = global::Password_Manager_.NET_6.Properties.Resources.icons8_add_24px;
            this.btnNewAcc.Location = new System.Drawing.Point(0, 48);
            this.btnNewAcc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNewAcc.Name = "btnNewAcc";
            this.btnNewAcc.Size = new System.Drawing.Size(217, 48);
            this.btnNewAcc.TabIndex = 3;
            this.btnNewAcc.TabStop = false;
            this.btnNewAcc.Text = "      Add Account";
            this.btnNewAcc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewAcc.UseVisualStyleBackColor = true;
            this.btnNewAcc.Click += new System.EventHandler(this.btnNewAcc_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSettings.Image = global::Password_Manager_.NET_6.Properties.Resources.settings;
            this.btnSettings.Location = new System.Drawing.Point(0, 365);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(217, 45);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.TabStop = false;
            this.btnSettings.Text = "      Settings";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnAccounts
            // 
            this.btnAccounts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccounts.FlatAppearance.BorderSize = 0;
            this.btnAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccounts.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAccounts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAccounts.Image = global::Password_Manager_.NET_6.Properties.Resources.home;
            this.btnAccounts.Location = new System.Drawing.Point(0, 0);
            this.btnAccounts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAccounts.Name = "btnAccounts";
            this.btnAccounts.Size = new System.Drawing.Size(217, 48);
            this.btnAccounts.TabIndex = 2;
            this.btnAccounts.TabStop = false;
            this.btnAccounts.Text = "      Accounts";
            this.btnAccounts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccounts.UseVisualStyleBackColor = true;
            this.btnAccounts.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblUsername);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 166);
            this.panel2.TabIndex = 0;
            // 
            // lblUsername
            // 
            this.lblUsername.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblUsername.Location = new System.Drawing.Point(0, 120);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(217, 46);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Password_Manager_.NET_6.Properties.Resources.Untitled_111;
            this.pictureBox1.Location = new System.Drawing.Point(63, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.AccessibleDescription = "";
            this.btnClose.AccessibleName = "";
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(919, -2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 37);
            this.btnClose.TabIndex = 14;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlFormload
            // 
            this.pnlFormload.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFormload.Location = new System.Drawing.Point(217, 85);
            this.pnlFormload.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlFormload.Name = "pnlFormload";
            this.pnlFormload.Size = new System.Drawing.Size(738, 510);
            this.pnlFormload.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblTitle.Location = new System.Drawing.Point(13, 4);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(58, 25);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "Titel";
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.Location = new System.Drawing.Point(845, -1);
            this.btnMin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(40, 35);
            this.btnMin.TabIndex = 18;
            this.btnMin.Text = "─";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.BackColor = System.Drawing.Color.Transparent;
            this.btnMax.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMax.ForeColor = System.Drawing.Color.White;
            this.btnMax.Image = global::Password_Manager_.NET_6.Properties.Resources.icons8_maximize_button_16px2;
            this.btnMax.Location = new System.Drawing.Point(881, -1);
            this.btnMax.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(40, 35);
            this.btnMax.TabIndex = 17;
            this.btnMax.UseVisualStyleBackColor = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // PnlTitelBar
            // 
            this.PnlTitelBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.PnlTitelBar.Controls.Add(this.btnMin);
            this.PnlTitelBar.Controls.Add(this.btnMax);
            this.PnlTitelBar.Controls.Add(this.lblTitle);
            this.PnlTitelBar.Controls.Add(this.btnClose);
            this.PnlTitelBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitelBar.Location = new System.Drawing.Point(0, 0);
            this.PnlTitelBar.Name = "PnlTitelBar";
            this.PnlTitelBar.Size = new System.Drawing.Size(959, 34);
            this.PnlTitelBar.TabIndex = 19;
            this.PnlTitelBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlTitelBar_MouseDown);
            // 
            // FrmMenü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(959, 607);
            this.Controls.Add(this.PnlTitelBar);
            this.Controls.Add(this.pnlFormload);
            this.Controls.Add(this.panel);
            this.DialogType = Password_Manager_.NET_6.UI.BaseDialog.enumDialogType.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(959, 607);
            this.Name = "FrmMenü";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDashboard";
            this.Titel = "FrmDashboard";
            this.Load += new System.EventHandler(this.FrmMenü_Load);
            this.SizeChanged += new System.EventHandler(this.FrmMenü_SizeChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMenü_MouseDown);
            this.Resize += new System.EventHandler(this.FrmMenü_Resize);
            this.Controls.SetChildIndex(this.panel, 0);
            this.Controls.SetChildIndex(this.pnlFormload, 0);
            this.Controls.SetChildIndex(this.PnlTitelBar, 0);
            this.panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PnlTitelBar.ResumeLayout(false);
            this.PnlTitelBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnAccounts;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNewAcc;
        private System.Windows.Forms.Panel pnlFormload;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
        private Panel PnlTitelBar;
        private Panel panel1;
        private Label lblUsername;
    }
}