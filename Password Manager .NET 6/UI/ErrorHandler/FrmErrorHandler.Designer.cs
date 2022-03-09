namespace Password_Manager_.NET_6.UI.ErrorHandler
{
    partial class FrmErrorHandler
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblShortDescription = new System.Windows.Forms.Label();
            this.LblText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtMessage = new System.Windows.Forms.TextBox();
            this.PnlActions.SuspendLayout();
            this.PnlActionsBase.SuspendLayout();
            this.PnlContent.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // _btAccept
            // 
            this._btAccept.Location = new System.Drawing.Point(3, 3);
            // 
            // _btAbort
            // 
            this._btAbort.Location = new System.Drawing.Point(91, 3);
            // 
            // PnlActions
            // 
            this.PnlActions.Location = new System.Drawing.Point(2, 155);
            this.PnlActions.Size = new System.Drawing.Size(657, 39);
            // 
            // PnlActionsBase
            // 
            this.PnlActionsBase.Location = new System.Drawing.Point(472, 3);
            // 
            // PnlActionsExtension
            // 
            this.PnlActionsExtension.Location = new System.Drawing.Point(416, 3);
            // 
            // PnlContent
            // 
            this.PnlContent.Controls.Add(this.TxtMessage);
            this.PnlContent.Controls.Add(this.panel1);
            this.PnlContent.Size = new System.Drawing.Size(657, 119);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LblShortDescription);
            this.panel1.Controls.Add(this.LblText);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 124);
            this.panel1.TabIndex = 0;
            // 
            // LblShortDescription
            // 
            this.LblShortDescription.AutoSize = true;
            this.LblShortDescription.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblShortDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.LblShortDescription.Location = new System.Drawing.Point(145, 77);
            this.LblShortDescription.Name = "LblShortDescription";
            this.LblShortDescription.Size = new System.Drawing.Size(0, 25);
            this.LblShortDescription.TabIndex = 2;
            // 
            // LblText
            // 
            this.LblText.AutoSize = true;
            this.LblText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.LblText.Location = new System.Drawing.Point(145, 42);
            this.LblText.Name = "LblText";
            this.LblText.Size = new System.Drawing.Size(237, 25);
            this.LblText.TabIndex = 1;
            this.LblText.Text = "Something went wrong...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Password_Manager_.NET_6.Properties.Resources.failed;
            this.pictureBox1.Location = new System.Drawing.Point(34, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TxtMessage
            // 
            this.TxtMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.TxtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.TxtMessage.Location = new System.Drawing.Point(0, 124);
            this.TxtMessage.Multiline = true;
            this.TxtMessage.Name = "TxtMessage";
            this.TxtMessage.ReadOnly = true;
            this.TxtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtMessage.Size = new System.Drawing.Size(657, 0);
            this.TxtMessage.TabIndex = 1;
            // 
            // FrmErrorHandler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 196);
            this.DialogType = Password_Manager_.NET_6.UI.BaseDialog.enumDialogType.OkAndAbort;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsSizable = false;
            this.Name = "FrmErrorHandler";
            this.Text = "FrmErrorHandler";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmErrorHandler_FormClosed);
            this.PnlActions.ResumeLayout(false);
            this.PnlActions.PerformLayout();
            this.PnlActionsBase.ResumeLayout(false);
            this.PnlActionsBase.PerformLayout();
            this.PnlContent.ResumeLayout(false);
            this.PnlContent.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TxtMessage;
        private Panel panel1;
        private Label LblShortDescription;
        private Label LblText;
        private PictureBox pictureBox1;
    }
}