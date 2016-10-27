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
    public partial class FormSubjects : DevExpress.XtraEditors.XtraForm
    {
        public FormSubjects()
        {
            InitializeComponent();
        }

        private void FormSubjects_Load( object sender, EventArgs e )
        {
            FillData();
        }

        void FillData()
        {
            try
            {
                DB db = new DB( App.ConnectionString );
                gridControl1.DataSource = db.GetSubjects();
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message );
            }
        }

        private void btnAddSubject_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
        {
            FormSubjectAdd frm = new FormSubjectAdd();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    ( new DB( App.ConnectionString ) ).AddSubject( frm.txtSubjectName.Text.Trim() );
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

            if (MessageBox.Show( "Удалить?", "Удаление субъектавалюты", MessageBoxButtons.YesNo, MessageBoxIcon.Question )
                == System.Windows.Forms.DialogResult.No)
                return;

            try
            {
                ( new DB( App.ConnectionString ) ).DeleteSubject( Convert.ToInt32( row["Id"] ) );
                FillData();
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message );
            }
        }


        private void btnAddAccount_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
        {
            if (gridView1.FocusedRowHandle == DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
                return;

            DataRow row = gridView1.GetFocusedDataRow();

            if (row == null)
                return;

            int subjectId = 0;

            try
            {
                subjectId = Convert.ToInt32( row["Id"] );
            }
            catch (Exception ex)
            {
                MessageBox.Show( "Субъект не указан" );
                return;
            }

            FormAccountAdd frm = new FormAccountAdd( subjectId, Convert.ToString( row["Name"] ) );

            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    DB db = new DB( App.ConnectionString );
                    int newAccountId = db.AddAccount( subjectId,
                        frm.txtAccount.Text.Trim(),
                        Convert.ToInt32( frm.lookupCurrency.EditValue ) );

                    FillData();

                    int handle = gridView1.LocateByValue( "IdAccount", newAccountId );
                    gridView1.FocusedRowHandle = handle;

                }
                catch (Exception ex)
                {
                    MessageBox.Show( ex.Message );
                }
            }
        }


        private void btnDeleteAccount_ButtonPressed( object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e )
        {

            if (gridView1.FocusedRowHandle == DevExpress.XtraGrid.GridControl.AutoFilterRowHandle)
                return;

            DataRow row = gridView1.GetFocusedDataRow();

            if (row == null)
                return;

            int subjectId = 0;

            try
            {
                subjectId = Convert.ToInt32( row["Id"] );
            }
            catch (Exception ex)
            {
                MessageBox.Show( "Субъект не указан" );
                return;
            }

            if (row["IdAccount"] == DBNull.Value)
            {
                MessageBox.Show( string.Format( @"У субъекта {0} нет счетов", row["Name"] ) );
                return;
            }

            if (MessageBox.Show( string.Format( @"Удалить аккаунт {0} субъекта {1}", row["AccountName"], row["Name"] ),
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question ) == System.Windows.Forms.DialogResult.No)
                return;

            try
            {
                var accountId = Convert.ToInt32( row["IdAccount"] );
                DB db = new DB( App.ConnectionString );
                db.DeleteAccount( accountId );
                FillData();
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message );
            }

        }

    }

}