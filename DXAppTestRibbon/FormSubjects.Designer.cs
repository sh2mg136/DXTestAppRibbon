namespace DXAppTestRibbon
{
    partial class FormSubjects
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnAddSubject = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddAccount = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnIdAccount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnAccountName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDeleteAccount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDeleteAccount = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumnAccountCurrency = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnAddSubject,
            this.btnDelete,
            this.btnAddAccount});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(611, 142);
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.Caption = "Add Subject";
            this.btnAddSubject.Glyph = global::DXAppTestRibbon.Properties.Resources.add_32;
            this.btnAddSubject.Id = 1;
            this.btnAddSubject.LargeGlyph = global::DXAppTestRibbon.Properties.Resources.add_32;
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddSubject_ItemClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Delete Subject";
            this.btnDelete.Glyph = global::DXAppTestRibbon.Properties.Resources.remov_32;
            this.btnDelete.Id = 2;
            this.btnDelete.LargeGlyph = global::DXAppTestRibbon.Properties.Resources.remov_32;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Caption = "Add account";
            this.btnAddAccount.Glyph = global::DXAppTestRibbon.Properties.Resources.businessman_add;
            this.btnAddAccount.Id = 3;
            this.btnAddAccount.LargeGlyph = global::DXAppTestRibbon.Properties.Resources.businessman_add;
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddAccount_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAddSubject);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDelete);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAddAccount, true);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Operations";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 142);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnDeleteAccount});
            this.gridControl1.Size = new System.Drawing.Size(611, 252);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnId,
            this.gridColumnName,
            this.gridColumnIdAccount,
            this.gridColumnAccountName,
            this.gridColumnAccountCurrency,
            this.gridColumnDeleteAccount});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnId
            // 
            this.gridColumnId.Caption = "Id";
            this.gridColumnId.FieldName = "Id";
            this.gridColumnId.Name = "gridColumnId";
            this.gridColumnId.Visible = true;
            this.gridColumnId.VisibleIndex = 0;
            // 
            // gridColumnName
            // 
            this.gridColumnName.Caption = "Subject Name";
            this.gridColumnName.FieldName = "Name";
            this.gridColumnName.Name = "gridColumnName";
            this.gridColumnName.Visible = true;
            this.gridColumnName.VisibleIndex = 1;
            this.gridColumnName.Width = 195;
            // 
            // gridColumnIdAccount
            // 
            this.gridColumnIdAccount.Caption = "IdAccount";
            this.gridColumnIdAccount.FieldName = "IdAccount";
            this.gridColumnIdAccount.Name = "gridColumnIdAccount";
            // 
            // gridColumnAccountName
            // 
            this.gridColumnAccountName.Caption = "AccountName";
            this.gridColumnAccountName.FieldName = "AccountName";
            this.gridColumnAccountName.Name = "gridColumnAccountName";
            this.gridColumnAccountName.Visible = true;
            this.gridColumnAccountName.VisibleIndex = 2;
            this.gridColumnAccountName.Width = 264;
            // 
            // gridColumnDeleteAccount
            // 
            this.gridColumnDeleteAccount.ColumnEdit = this.btnDeleteAccount;
            this.gridColumnDeleteAccount.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.gridColumnDeleteAccount.Name = "gridColumnDeleteAccount";
            this.gridColumnDeleteAccount.ToolTip = "Delete account";
            this.gridColumnDeleteAccount.Visible = true;
            this.gridColumnDeleteAccount.VisibleIndex = 4;
            this.gridColumnDeleteAccount.Width = 57;
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.AutoHeight = false;
            this.btnDeleteAccount.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, global::DXAppTestRibbon.Properties.Resources.remov_16, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnDeleteAccount.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnDeleteAccount_ButtonPressed);
            // 
            // gridColumnAccountCurrency
            // 
            this.gridColumnAccountCurrency.Caption = "Currency";
            this.gridColumnAccountCurrency.FieldName = "CurrencyCode";
            this.gridColumnAccountCurrency.Name = "gridColumnAccountCurrency";
            this.gridColumnAccountCurrency.Visible = true;
            this.gridColumnAccountCurrency.VisibleIndex = 3;
            // 
            // FormSubjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 394);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "FormSubjects";
            this.Text = "FormSubjects";
            this.Load += new System.EventHandler(this.FormSubjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnAddSubject;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnAddAccount;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnIdAccount;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnAccountName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDeleteAccount;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnDeleteAccount;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnAccountCurrency;
    }
}