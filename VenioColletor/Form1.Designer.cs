namespace VenioColletor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.VCNotification = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblStatus = new System.Windows.Forms.Label();
            this.VCNotificationCMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdExit = new System.Windows.Forms.ToolStripMenuItem();
            this.VCNotificationCMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // VCNotification
            // 
            this.VCNotification.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.VCNotification.BalloonTipText = "Collected 100 documents in 3 folders";
            this.VCNotification.BalloonTipTitle = "Collecting documents......";
            this.VCNotification.ContextMenuStrip = this.VCNotificationCMenu;
            this.VCNotification.Icon = ((System.Drawing.Icon)(resources.GetObject("VCNotification.Icon")));
            this.VCNotification.Text = "Venio Collector";
            this.VCNotification.Visible = true;
            this.VCNotification.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.VCNotification_MouseDoubleClick);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(36, 64);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(35, 13);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "label1";
            // 
            // VCNotificationCMenu
            // 
            this.VCNotificationCMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmRestore,
            this.cmdExit});
            this.VCNotificationCMenu.Name = "VCNotificationCMenu";
            this.VCNotificationCMenu.Size = new System.Drawing.Size(153, 70);
            this.VCNotificationCMenu.Click += new System.EventHandler(this.VCNotificationCMenu_Click);
            // 
            // cmRestore
            // 
            this.cmRestore.Name = "cmRestore";
            this.cmRestore.Size = new System.Drawing.Size(152, 22);
            this.cmRestore.Text = "Restore";
            this.cmRestore.Click += new System.EventHandler(this.cmRestore_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(152, 22);
            this.cmdExit.Text = "Exit";
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 246);
            this.Controls.Add(this.lblStatus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.VCNotificationCMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon VCNotification;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ContextMenuStrip VCNotificationCMenu;
        private System.Windows.Forms.ToolStripMenuItem cmRestore;
        private System.Windows.Forms.ToolStripMenuItem cmdExit;
    }
}

