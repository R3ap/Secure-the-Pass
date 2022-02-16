namespace Password_Manager_.NET_6.UI.BaseDialog
{
    partial class FrmBaseDialogBase
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
            this.pnlAction = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlAction
            // 
            this.pnlAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAction.Location = new System.Drawing.Point(0, 121);
            this.pnlAction.Name = "pnlAction";
            this.pnlAction.Size = new System.Drawing.Size(344, 35);
            this.pnlAction.TabIndex = 18;
            this.pnlAction.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.pnlAction_ControlAdded);
            this.pnlAction.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.pnlAction_ControlRemoved);
            // 
            // FrmBaseDialogBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(344, 156);
            this.Controls.Add(this.pnlAction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBaseDialogBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "baseDialog";
            this.ResumeLayout(false);

        }

        #endregion
        private Panel pnlAction;
    }
}