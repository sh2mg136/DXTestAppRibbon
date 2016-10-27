namespace DXAppTestRibbon
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if (disposing && ( components != null ))
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnCloseApp = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonGroup1 = new DevExpress.XtraBars.BarButtonGroup();
            this.btnCurrencies = new DevExpress.XtraBars.BarButtonItem();
            this.btnAccounts = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogon = new DevExpress.XtraBars.BarButtonItem();
            this.barCurrenciesAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnSettings = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.mdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdiManager)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnCloseApp,
            this.barButtonGroup1,
            this.btnCurrencies,
            this.btnAccounts,
            this.btnLogon,
            this.barCurrenciesAdd,
            this.btnSettings});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(838, 144);
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.Caption = "Exit";
            this.btnCloseApp.Glyph = global::DXAppTestRibbon.Properties.Resources.Dele32;
            this.btnCloseApp.Id = 2;
            this.btnCloseApp.LargeGlyph = global::DXAppTestRibbon.Properties.Resources.Dele32;
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barClose_ItemClick);
            // 
            // barButtonGroup1
            // 
            this.barButtonGroup1.Caption = "barButtonGroup1";
            this.barButtonGroup1.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barButtonGroup1.Id = 3;
            this.barButtonGroup1.Name = "barButtonGroup1";
            // 
            // btnCurrencies
            // 
            this.btnCurrencies.Caption = "Currencies";
            this.btnCurrencies.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnCurrencies.Glyph = global::DXAppTestRibbon.Properties.Resources._2;
            this.btnCurrencies.Id = 4;
            this.btnCurrencies.LargeGlyph = global::DXAppTestRibbon.Properties.Resources._2;
            this.btnCurrencies.Name = "btnCurrencies";
            this.btnCurrencies.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCurrencies_ItemClick);
            // 
            // btnAccounts
            // 
            this.btnAccounts.Caption = "Accounts";
            this.btnAccounts.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnAccounts.Glyph = global::DXAppTestRibbon.Properties.Resources.briefcase;
            this.btnAccounts.Id = 5;
            this.btnAccounts.LargeGlyph = global::DXAppTestRibbon.Properties.Resources.briefcase;
            this.btnAccounts.Name = "btnAccounts";
            this.btnAccounts.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAccounts_ItemClick);
            // 
            // btnLogon
            // 
            this.btnLogon.Caption = "Logon";
            this.btnLogon.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnLogon.Glyph = global::DXAppTestRibbon.Properties.Resources.locked;
            this.btnLogon.Id = 6;
            this.btnLogon.LargeGlyph = global::DXAppTestRibbon.Properties.Resources.locked;
            this.btnLogon.Name = "btnLogon";
            this.btnLogon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogon_ItemClick);
            // 
            // barCurrenciesAdd
            // 
            this.barCurrenciesAdd.Caption = "Add";
            this.barCurrenciesAdd.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barCurrenciesAdd.Glyph = global::DXAppTestRibbon.Properties.Resources.add_32;
            this.barCurrenciesAdd.Id = 7;
            this.barCurrenciesAdd.LargeGlyph = global::DXAppTestRibbon.Properties.Resources.add_32;
            this.barCurrenciesAdd.Name = "barCurrenciesAdd";
            // 
            // btnSettings
            // 
            this.btnSettings.Caption = "Settings";
            this.btnSettings.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.btnSettings.Glyph = global::DXAppTestRibbon.Properties.Resources.apps_32;
            this.btnSettings.Id = 8;
            this.btnSettings.LargeGlyph = global::DXAppTestRibbon.Properties.Resources.apps_32;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSettings_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup2,
            this.ribbonPageGroup1,
            this.ribbonPageGroup5,
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnLogon);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Account";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnAccounts);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnCurrencies);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Tools";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Operations";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnSettings);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Settings";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnCloseApp);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Exit";
            // 
            // mdiManager
            // 
            this.mdiManager.MdiParent = this;
            // 
            // FormMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 515);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "FormMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdiManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnCloseApp;
        private DevExpress.XtraBars.BarButtonGroup barButtonGroup1;
        private DevExpress.XtraBars.BarButtonItem btnCurrencies;
        private DevExpress.XtraBars.BarButtonItem btnAccounts;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager mdiManager;
        private DevExpress.XtraBars.BarButtonItem btnLogon;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barCurrenciesAdd;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnSettings;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
    }
}

