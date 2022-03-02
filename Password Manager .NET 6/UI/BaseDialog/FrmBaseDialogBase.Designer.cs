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
            this.PnlActions = new Password_Manager_.NET_6.Controls.DerivableFlowLayoutPanel();
            this.PnlActionsBase = new Password_Manager_.NET_6.Controls.DerivableFlowLayoutPanel();
            this.PnlActionsExtension = new Password_Manager_.NET_6.Controls.DerivableFlowLayoutPanel();
            this.PnlContent = new System.Windows.Forms.Panel();
            this.PnlActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlActions
            // 
            this.PnlActions.AutoSize = true;
            this.PnlActions.Controls.Add(this.PnlActionsBase);
            this.PnlActions.Controls.Add(this.PnlActionsExtension);
            this.PnlActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlActions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.PnlActions.Location = new System.Drawing.Point(0, 115);
            this.PnlActions.Name = "PnlActions";
            this.PnlActions.Size = new System.Drawing.Size(344, 26);
            this.PnlActions.TabIndex = 1;
            // 
            // PnlActionsBase
            // 
            this.PnlActionsBase.AutoSize = true;
            this.PnlActionsBase.Location = new System.Drawing.Point(337, 3);
            this.PnlActionsBase.Name = "PnlActionsBase";
            this.PnlActionsBase.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.PnlActionsBase.Size = new System.Drawing.Size(4, 0);
            this.PnlActionsBase.TabIndex = 2;
            // 
            // PnlActionsExtension
            // 
            this.PnlActionsExtension.AutoSize = true;
            this.PnlActionsExtension.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.PnlActionsExtension.Location = new System.Drawing.Point(281, 3);
            this.PnlActionsExtension.MinimumSize = new System.Drawing.Size(50, 20);
            this.PnlActionsExtension.Name = "PnlActionsExtension";
            this.PnlActionsExtension.Size = new System.Drawing.Size(50, 20);
            this.PnlActionsExtension.TabIndex = 1;
            this.PnlActionsExtension.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.PnlActionsExtension_ControlAdded);
            this.PnlActionsExtension.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.PnlActionsExtension_ControlRemoved);
            // 
            // panel1
            // 
            this.PnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContent.Location = new System.Drawing.Point(0, 0);
            this.PnlContent.Name = "panel1";
            this.PnlContent.Size = new System.Drawing.Size(344, 115);
            this.PnlContent.TabIndex = 2;
            // 
            // FrmBaseDialogBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(344, 141);
            this.Controls.Add(this.PnlContent);
            this.Controls.Add(this.PnlActions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBaseDialogBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "baseDialog";
            this.PnlActions.ResumeLayout(false);
            this.PnlActions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected Password_Manager_.NET_6.Controls.DerivableFlowLayoutPanel PnlActions;
        protected Password_Manager_.NET_6.Controls.DerivableFlowLayoutPanel PnlActionsBase;
        protected Password_Manager_.NET_6.Controls.DerivableFlowLayoutPanel PnlActionsExtension;
        public Panel PnlContent;
    }
}