namespace Password_Manager_.NET_6.UI.BaseDialog
{
    partial class FrmBaseDialogTitelBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBaseDialogTitelBar));
            this.PnlTitelBar = new System.Windows.Forms.Panel();
            this.lblTitel = new System.Windows.Forms.Label();
            this.PbIcon = new System.Windows.Forms.PictureBox();
            this.BtnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.PnlTitelBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // _btAccept
            // 
            this._btAccept.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._btAccept.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this._btAccept.Location = new System.Drawing.Point(288, 5);
            this._btAccept.Size = new System.Drawing.Size(82, 27);
            // 
            // _btAbort
            // 
            this._btAbort.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._btAbort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this._btAbort.Location = new System.Drawing.Point(376, 6);
            this._btAbort.Size = new System.Drawing.Size(84, 26);
            // 
            // PnlTitelBar
            // 
            this.PnlTitelBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.PnlTitelBar.Controls.Add(this.lblTitel);
            this.PnlTitelBar.Controls.Add(this.PbIcon);
            this.PnlTitelBar.Controls.Add(this.BtnMin);
            this.PnlTitelBar.Controls.Add(this.btnMax);
            this.PnlTitelBar.Controls.Add(this.BtnClose);
            this.PnlTitelBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitelBar.Location = new System.Drawing.Point(0, 0);
            this.PnlTitelBar.Name = "PnlTitelBar";
            this.PnlTitelBar.Size = new System.Drawing.Size(463, 34);
            this.PnlTitelBar.TabIndex = 20;
            this.PnlTitelBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitelBar_MouseDown);
            // 
            // lblTitel
            // 
            this.lblTitel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitel.Location = new System.Drawing.Point(29, 0);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(317, 34);
            this.lblTitel.TabIndex = 23;
            this.lblTitel.Text = "lblTitel";
            this.lblTitel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitelBar_MouseDown);
            // 
            // PbIcon
            // 
            this.PbIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.PbIcon.Image = ((System.Drawing.Image)(resources.GetObject("PbIcon.Image")));
            this.PbIcon.Location = new System.Drawing.Point(0, 0);
            this.PbIcon.Name = "PbIcon";
            this.PbIcon.Size = new System.Drawing.Size(29, 34);
            this.PbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PbIcon.TabIndex = 22;
            this.PbIcon.TabStop = false;
            this.PbIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitelBar_MouseDown);
            // 
            // BtnMin
            // 
            this.BtnMin.BackColor = System.Drawing.Color.Transparent;
            this.BtnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnMin.FlatAppearance.BorderSize = 0;
            this.BtnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnMin.ForeColor = System.Drawing.Color.White;
            this.BtnMin.Location = new System.Drawing.Point(346, 0);
            this.BtnMin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(38, 34);
            this.BtnMin.TabIndex = 21;
            this.BtnMin.Text = "─";
            this.BtnMin.UseVisualStyleBackColor = false;
            this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.BackColor = System.Drawing.Color.Transparent;
            this.btnMax.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMax.ForeColor = System.Drawing.Color.White;
            this.btnMax.Image = global::Password_Manager_.NET_6.Properties.Resources.icons8_maximize_button_16px2;
            this.btnMax.Location = new System.Drawing.Point(384, 0);
            this.btnMax.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(39, 34);
            this.btnMax.TabIndex = 20;
            this.btnMax.UseVisualStyleBackColor = false;
            this.btnMax.Click += new System.EventHandler(this.BtnMax_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.AccessibleDescription = "";
            this.BtnClose.AccessibleName = "";
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.Location = new System.Drawing.Point(423, 0);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(40, 34);
            this.BtnClose.TabIndex = 19;
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FrmBaseDialogSizable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 256);
            this.Controls.Add(this.PnlTitelBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBaseDialogSizable";
            this.Text = "FrmBaseDialogSizable";
            this.Resize += new System.EventHandler(this.FrmBaseDialogSizable_Resize);
            this.Controls.SetChildIndex(this.PnlTitelBar, 0);
            this.PnlTitelBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PnlTitelBar;
        private Button BtnMin;
        private Button btnMax;
        private Button BtnClose;
        private PictureBox PbIcon;
        private Label lblTitel;
    }
}