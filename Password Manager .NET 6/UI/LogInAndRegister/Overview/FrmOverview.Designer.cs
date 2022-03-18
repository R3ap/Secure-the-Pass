namespace Password_Manager_.NET_6.UI.LogIn
{
    partial class FrmOverview
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
            this.PnlActions.SuspendLayout();
            this.PnlActionsBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PassProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // _btAccept
            // 
            this._btAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btAccept.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._btAccept.Location = new System.Drawing.Point(3, 3);
            this._btAccept.Size = new System.Drawing.Size(69, 33);
            this._btAccept.Text = "&Login";
            // 
            // _btAbort
            // 
            this._btAbort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btAbort.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this._btAbort.Location = new System.Drawing.Point(78, 3);
            this._btAbort.Size = new System.Drawing.Size(77, 33);
            // 
            // PnlActions
            // 
            this.PnlActions.Location = new System.Drawing.Point(2, 451);
            this.PnlActions.Size = new System.Drawing.Size(653, 45);
            // 
            // PnlActionsBase
            // 
            this.PnlActionsBase.Location = new System.Drawing.Point(488, 3);
            this.PnlActionsBase.Size = new System.Drawing.Size(162, 39);
            // 
            // PnlActionsExtension
            // 
            this.PnlActionsExtension.Location = new System.Drawing.Point(432, 3);
            // 
            // PnlContent
            // 
            this.PnlContent.Size = new System.Drawing.Size(653, 415);
            // 
            // PassProvider
            // 
            this.PassProvider.ContainerControl = this;
            // 
            // FrmOverview
            // 
            this.AcceptText = "&Login";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(657, 498);
            this.DialogType = Password_Manager_.NET_6.UI.BaseDialog.enumDialogType.OkAndAbort;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.Name = "FrmOverview";
            this.ShowIcon = true;
            this.Text = "FrmLogIn";
            this.Load += new System.EventHandler(this.FrmLogIn_Load);
            this.PnlActions.ResumeLayout(false);
            this.PnlActions.PerformLayout();
            this.PnlActionsBase.ResumeLayout(false);
            this.PnlActionsBase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PassProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider PassProvider;
    }
}