namespace Password_Manager_.NET_6
{
    partial class ErrorHandler
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
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.errorBox = new System.Windows.Forms.PictureBox();
            this.txtErrorMessage = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCopy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnCopy.Location = new System.Drawing.Point(529, 5);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(131, 46);
            this.btnCopy.TabIndex = 29;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Visible = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDetails.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnDetails.Location = new System.Drawing.Point(31, 5);
            this.btnDetails.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(131, 46);
            this.btnDetails.TabIndex = 30;
            this.btnDetails.Text = "More Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContinue.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnContinue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnContinue.Location = new System.Drawing.Point(667, 5);
            this.btnContinue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(131, 46);
            this.btnContinue.TabIndex = 33;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCopy);
            this.panel2.Controls.Add(this.btnDetails);
            this.panel2.Controls.Add(this.btnContinue);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 150);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(820, 65);
            this.panel2.TabIndex = 36;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.errorBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(820, 149);
            this.panel3.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Location = new System.Drawing.Point(185, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Something went wrong...";
            // 
            // errorBox
            // 
            this.errorBox.Image = global::Password_Manager_.NET_6.Properties.Resources.failed;
            this.errorBox.Location = new System.Drawing.Point(62, 57);
            this.errorBox.Name = "errorBox";
            this.errorBox.Size = new System.Drawing.Size(72, 62);
            this.errorBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.errorBox.TabIndex = 0;
            this.errorBox.TabStop = false;
            // 
            // txtErrorMessage
            // 
            this.txtErrorMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.txtErrorMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtErrorMessage.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtErrorMessage.Location = new System.Drawing.Point(0, 149);
            this.txtErrorMessage.Multiline = true;
            this.txtErrorMessage.Name = "txtErrorMessage";
            this.txtErrorMessage.Size = new System.Drawing.Size(820, 66);
            this.txtErrorMessage.TabIndex = 38;
            // 
            // ErrorHandler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(824, 219);
            this.DialogType = Password_Manager_.NET_6.UI.BaseDialog.enumDialogType.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.Name = "ErrorHandler";
            this.ShowIcon = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fehler";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ErrorHandler_MouseDown);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private TextBox txtErrorMessage;
        private Label label1;
        private PictureBox errorBox;
    }
}