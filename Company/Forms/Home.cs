﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.Controls;

namespace Company.Forms
{
    public partial class Home : SfForm
    {
        TabPageAdv st = new TabPageAdv();

        public Home()
        {
            InitializeComponent();
            initTabManager();
        }

        private void initTabManager()
        {
            IsMdiContainer = true;
            tabbedGroupedMDIManager1.AttachToMdiContainer(this);
            tabbedGroupedMDIManager1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2016Colorful);

            Form dashboardForm = new Dashboard();
            dashboardForm.MdiParent = this;
            dashboardForm.Text = "Dashboard";
            Console.WriteLine("here");

            tabbedGroupedMDIManager1.ShowCloseButtonForForm(dashboardForm, false);
            dashboardForm.Show();

        }

        private void materialRecievingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form materialRecievingForm = new FormMaterialReceiving();
            materialRecievingForm.MdiParent = this;
            materialRecievingForm.Text = "Material recieving";
            materialRecievingForm.Show();
        }

        void tabbedMdIManager_TabControlAdded(object sender, TabbedMDITabControlEventArgs args)
        {
            args.TabControl.SelectedIndexChanged += new EventHandler(TabControl_SelectedIndexChange);
        }

        void TabControl_SelectedIndexChange(object sender, EventArgs e)
        {

            st = (sender as MDITabPanel).SelectedTab;

        }

        void ContextMenuItem_BeforePopup(object sender, CancelEventArgs e)
        {
            Console.WriteLine("here");
            if (st.Text == "Dashboard") { e.Cancel = true; }
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void materialIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form materialIssueForm = new FormMaterialIssue();
            materialIssueForm.MdiParent = this;
            materialIssueForm.Text = "Material Issue";
            materialIssueForm.Show();
        }

        private void materialTransferOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form materialOutForm = new FormMaterialOut();
            materialOutForm.MdiParent = this;
            materialOutForm.Text = "Material Out";
            materialOutForm.Show();
        }

        private void materialTransferInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form materialInForm = new FormMaterialIn();
            materialInForm.MdiParent = this;
            materialInForm.Text = "Material In";
            materialInForm.Show();
        }

        private void materialRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form MaterialRequestForm = new FormMaterialRequest();
            MaterialRequestForm.MdiParent = this;
            MaterialRequestForm.Text = "Material Request";
            MaterialRequestForm.Show();
        }

        private void purchaseRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form PurchaseRequestForm = new FormPurchaseRequestNote();
            PurchaseRequestForm.MdiParent = this;
            PurchaseRequestForm.Text = "Purchase Request";
            PurchaseRequestForm.Show();
        }
    }
}
