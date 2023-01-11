namespace Company.Forms
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.tabbedGroupedMDIManager1 = new Syncfusion.Windows.Forms.Tools.TabbedGroupedMDIManager();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vouchersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialReceivingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabbedGroupedMDIManager1
            // 
            this.tabbedGroupedMDIManager1.AttachedTo = this;
            this.tabbedGroupedMDIManager1.CloseButtonBackColor = System.Drawing.Color.White;
            this.tabbedGroupedMDIManager1.CloseButtonToolTip = "";
            this.tabbedGroupedMDIManager1.CloseButtonVisible = false;
            this.tabbedGroupedMDIManager1.DropDownButtonToolTip = "";
            this.tabbedGroupedMDIManager1.ImageSize = new System.Drawing.Size(16, 16);
            this.tabbedGroupedMDIManager1.NeedUpdateHostedForm = false;
            this.tabbedGroupedMDIManager1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRenderer3D);
            this.tabbedGroupedMDIManager1.ThemeName = "TabRenderer3D";
            this.tabbedGroupedMDIManager1.TabControlAdded += new Syncfusion.Windows.Forms.Tools.TabbedMDITabControlEventHandler(this.tabbedMdIManager_TabControlAdded);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(2, 2);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1024, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vouchersToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.newToolStripMenuItem.Text = "New";
            // 
            // vouchersToolStripMenuItem
            // 
            this.vouchersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.materialReceivingToolStripMenuItem});
            this.vouchersToolStripMenuItem.Name = "vouchersToolStripMenuItem";
            this.vouchersToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.vouchersToolStripMenuItem.Text = "Vouchers";
            // 
            // materialReceivingToolStripMenuItem
            // 
            this.materialReceivingToolStripMenuItem.Name = "materialReceivingToolStripMenuItem";
            this.materialReceivingToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.materialReceivingToolStripMenuItem.Text = "Material Receiving";
            this.materialReceivingToolStripMenuItem.Click += new System.EventHandler(this.materialRecievingToolStripMenuItem1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 520);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Style.MdiChild.IconHorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TabbedGroupedMDIManager tabbedGroupedMDIManager1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vouchersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materialReceivingToolStripMenuItem;
    }
}

