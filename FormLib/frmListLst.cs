using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace QXEditProInterface.Base
{
    public partial class frmListLst : Form
    {
        public string sBuffer;
        public string sTitle;
        public string sInitialDirectory;
        public string sFileSirelization = "List.xml";

        private Cursor currentCursor;

        public frmListLst()
        {
            InitializeComponent();
        }
        
        private void btnAppend_Click(object sender, EventArgs e)
        {
            frmEdit FrmEdit = new frmEdit(System.IO.Path.GetDirectoryName(this.sInitialDirectory));
            try
            {
                this.AddOwnedForm(FrmEdit);
                if (FrmEdit.ShowDialog() == DialogResult.OK)
                {
                    treeList1.BeginUnboundLoad();
                    treeList1.AppendNode(new object[] { FrmEdit.txtEditName.Text, FrmEdit.btnEditPath.Text }, null);
                    treeList1.ExportToXml(sFileSirelization);
                    treeList1.EndUnboundLoad();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FrmEdit.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                treeList1.BeginUnboundLoad();
                treeList1.DeleteNode(treeList1.FocusedNode);
                treeList1.ExportToXml(sFileSirelization);
                treeList1.EndUnboundLoad();

                if (treeList1.Nodes.Count == 0)
                {
                    this.btnDelete.Enabled = false;
                    this.btnOk.Enabled = false;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected void RefreshForm(bool b)
        {
            if (b)
            {
                currentCursor = Cursor.Current;
                Cursor.Current = Cursors.WaitCursor;
                Refresh();
            }
            else
            {
                Cursor.Current = currentCursor;
            }
        }

        private void Load2Buffer()
        {
            FileStream fs = null;
            StreamReader sr = null;

            RefreshForm(true);
            try
            {
                fs = new FileStream(treeList1.FocusedNode.GetValue(1).ToString(), FileMode.Open);
                sr = new StreamReader(fs);
                this.sBuffer = sr.ReadToEnd();
                sr.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                if (sr != null)
                    sr.Close();
                if (fs != null)
                    fs.Close();
                this.DialogResult = DialogResult.Cancel;
                MessageBox.Show(ex.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            RefreshForm(false);
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            Load2Buffer();
            Owner.Focus();

        }

        private void frmListLst_Load(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(sInitialDirectory))
                {
                    sFileSirelization = System.IO.Path.Combine(sInitialDirectory, sFileSirelization);

                    if (File.Exists(sFileSirelization))
                        treeList1.ImportFromXml(sFileSirelization);
                }
                else
                {
                    Directory.CreateDirectory(sInitialDirectory);
                    sFileSirelization = System.IO.Path.Combine(sInitialDirectory, sFileSirelization);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Text = sTitle;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Owner.Focus();
        }

        private void treeList1_Click(object sender, EventArgs e)
        {
            this.btnDelete.Enabled = true;
            this.btnOk.Enabled = true;
        }

        private void treeList1_DoubleClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Load2Buffer();
            Owner.Focus();

        }
              
    }
}