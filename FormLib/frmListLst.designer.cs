namespace QXEditProInterface.Base
{
    partial class frmListLst
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListLst));
            this.barAndDockingController1 = new DevExpress.XtraBars.BarAndDockingController(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPath = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnAppend = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTreeListBlending1 = new DevExpress.XtraTreeList.Blending.XtraTreeListBlending();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            this.SuspendLayout();
            // 
            // barAndDockingController1
            // 
            this.barAndDockingController1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.barAndDockingController1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.barAndDockingController1.PropertiesBar.AllowLinkLighting = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.treeList1);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAppend);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnOk);
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Location = new System.Drawing.Point(4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 374);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // treeList1
            // 
            this.treeList1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("treeList1.BackgroundImage")));
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colName,
            this.colPath});
            this.treeList1.HorzScrollVisibility = DevExpress.XtraTreeList.ScrollVisibility.Never;
            this.treeList1.Location = new System.Drawing.Point(6, 15);
            this.treeList1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.treeList1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsSelection.InvertSelection = true;
            this.treeList1.OptionsView.EnableAppearanceEvenRow = true;
            this.treeList1.OptionsView.ShowButtons = false;
            this.treeList1.OptionsView.ShowFocusedFrame = false;
            this.treeList1.OptionsView.ShowHorzLines = false;
            this.treeList1.OptionsView.ShowIndicator = false;
            this.treeList1.OptionsView.ShowRoot = false;
            this.treeList1.OptionsView.ShowVertLines = false;
            this.treeList1.Size = new System.Drawing.Size(212, 353);
            this.treeList1.TabIndex = 0;
            this.treeList1.VertScrollVisibility = DevExpress.XtraTreeList.ScrollVisibility.Always;
            this.treeList1.DoubleClick += new System.EventHandler(this.treeList1_DoubleClick);
            this.treeList1.Click += new System.EventHandler(this.treeList1_Click);
            // 
            // colName
            // 
            this.colName.Caption = "Название";
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 170;
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.OptionsColumn.AllowMove = false;
            this.colName.OptionsColumn.AllowMoveToCustomizationForm = false;
            this.colName.OptionsColumn.FixedWidth = true;
            this.colName.OptionsColumn.ReadOnly = true;
            this.colName.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.colName.SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Sum;
            this.colName.UnboundType = DevExpress.XtraTreeList.Data.UnboundColumnType.String;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 194;
            // 
            // colPath
            // 
            this.colPath.Caption = "Путь";
            this.colPath.FieldName = "Path";
            this.colPath.Name = "colPath";
            // 
            // btnDelete
            // 
            this.btnDelete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(224, 155);
            this.btnDelete.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.btnDelete.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAppend
            // 
            this.btnAppend.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnAppend.Location = new System.Drawing.Point(224, 115);
            this.btnAppend.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.btnAppend.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnAppend.Name = "btnAppend";
            this.btnAppend.Size = new System.Drawing.Size(75, 23);
            this.btnAppend.TabIndex = 3;
            this.btnAppend.Text = "Добавить";
            this.btnAppend.Click += new System.EventHandler(this.btnAppend_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(224, 53);
            this.btnCancel.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.btnCancel.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Enabled = false;
            this.btnOk.Location = new System.Drawing.Point(224, 15);
            this.btnOk.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.btnOk.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(174, -84);
            this.simpleButton1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.simpleButton1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Ok";
            // 
            // xtraTreeListBlending1
            // 
            this.xtraTreeListBlending1.TreeListControl = this.treeList1;
            // 
            // frmListLst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 382);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListLst";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Список заголовков и примечаний";
            this.Load += new System.EventHandler(this.frmListLst_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarAndDockingController barAndDockingController1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnAppend;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPath;
        private DevExpress.XtraTreeList.Blending.XtraTreeListBlending xtraTreeListBlending1;

    }
}

