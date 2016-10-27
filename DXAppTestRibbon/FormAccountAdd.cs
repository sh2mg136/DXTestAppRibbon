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
using System.Diagnostics;

namespace DXAppTestRibbon
{
    public partial class FormAccountAdd : DevExpress.XtraEditors.XtraForm
    {

        int _subjectId;
        string _subjectName;
        DB db;

        public FormAccountAdd( int subjectId, string subjectName )
        {
            InitializeComponent();
            _subjectId = subjectId;
            _subjectName = subjectName;
            db = new DB( App.ConnectionString );
        }

        private void FormAccountAdd_Load( object sender, EventArgs e )
        {
            lblSubjectName.Text = _subjectName;

            Debug.Assert( db != null );

            DataTable dt = db.GetCurrencies();

            var currencies = ( from row in dt.AsEnumerable()
                               orderby row.Field<int>( "Id" )
                               select new Currency
                               {
                                   Id = row.Field<int>( "Id" ),
                                   Code = row.Field<string>( "Code" )
                               } ).ToList();

            lookupCurrency.Properties.DataSource = currencies;
            lookupCurrency.Properties.ValueMember = "Id";
            lookupCurrency.Properties.DisplayMember = "Code";

        }

        private void btnOk_Click( object sender, EventArgs e )
        {
            if (string.IsNullOrWhiteSpace( txtAccount.Text ))
            {
                MessageBox.Show( "Укажите наименование счёта" );
                return;
            }

            if (lookupCurrency.EditValue == null)
            {
                MessageBox.Show( "Выберите уже валюту" );
                return;
            }

            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }

    class Currency
    {
        public int Id { get; set; }
        public string Code { get; set; }
    }
}