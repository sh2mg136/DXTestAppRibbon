using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DXAppTestRibbon
{
    public partial class FormCurrencies : DevExpress.XtraEditors.XtraForm
    {
        public FormCurrencies()
        {
            InitializeComponent();
        }

        private void FormCurrencies_Load( object sender, EventArgs e )
        {
            FillData();
        }

        void FillData()
        {
            Cursor cursor = Cursor.Current;
            try
            {                
                Cursor.Current = Cursors.WaitCursor;
                DB db = new DB( App.ConnectionString );
                DataTable dt = db.GetCurrencies();
                gridControl1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message );
            }
            finally
            {
                Cursor.Current = cursor;
            }
        }

        private void btnAdd_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
        {
            FormCuurencyAdd frm = new FormCuurencyAdd();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    DB db = new DB( App.ConnectionString );
                    db.AddCurrency( frm.txtCode.Text.Trim() );
                    FillData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show( ex.Message );
                }
            }
        }

        private void btnDelete_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
        {
            if (gridView1.FocusedRowHandle == DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
                return;

            DataRow row = gridView1.GetFocusedDataRow();

            if (row == null)
                return;

            if (MessageBox.Show( "Удалить?", "Удаление валюты", MessageBoxButtons.YesNo, MessageBoxIcon.Question )
                == System.Windows.Forms.DialogResult.No)
                return;

            try
            {
                DB db = new DB( App.ConnectionString );
                db.DeleteCurrency( Convert.ToInt32( row["Id"] ) );
                FillData();
            }
            catch ( Exception ex )
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}