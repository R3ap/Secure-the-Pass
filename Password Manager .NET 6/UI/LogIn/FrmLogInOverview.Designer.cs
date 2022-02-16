namespace Password_Manager_.NET_6.UI.LogIn
{
    partial class FrmLogInOverview
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
            this.PassProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.PnlContent = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PassProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // _btAccept
            // 
            this._btAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btAccept.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._btAccept.Location = new System.Drawing.Point(480, 3);
            this._btAccept.Size = new System.Drawing.Size(84, 30);
            this._btAccept.Text = "&Login";
            this._btAccept.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // _btAbort
            // 
            this._btAbort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btAbort.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._btAbort.Location = new System.Drawing.Point(474, 0);
            this._btAbort.Size = new System.Drawing.Size(90, 30);
            this._btAbort.Text = "&OK";
            // 
            // PassProvider
            // 
            this.PassProvider.ContainerControl = this;
            // 
            // PnlContent
            // 
            this.PnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContent.Location = new System.Drawing.Point(2, 36);
            this.PnlContent.Name = "PnlContent";
            this.PnlContent.Size = new System.Drawing.Size(505, 222);
            this.PnlContent.TabIndex = 21;
            // 
            // FrmLogInOverview
            // 
            this.AbortText = "&OK";
            this.AcceptText = "&Login";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(509, 295);
            this.Controls.Add(this.PnlContent);
            this.DialogType = Password_Manager_.NET_6.UI.BaseDialog.enumDialogType.Ok;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = true;
            this.MaximumSize = new System.Drawing.Size(509, 295);
            this.MinimizeBox = true;
            this.Name = "FrmLogInOverview";
            this.ShowIcon = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogIn";
            this.Load += new System.EventHandler(this.FrmLogIn_Load);
            this.Controls.SetChildIndex(this.PnlContent, 0);
            ((System.ComponentModel.ISupportInitialize)(this.PassProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider PassProvider;
        private Panel PnlContent;
    }
}