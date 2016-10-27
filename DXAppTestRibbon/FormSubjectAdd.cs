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
    public partial class FormSubjectAdd : DevExpress.XtraEditors.XtraForm
    {
        public FormSubjectAdd()
        {
            InitializeComponent();
        }

        private void btnOk_Click( object sender, EventArgs e )
        {
            if (string.IsNullOrWhiteSpace( txtSubjectName.Text ))
            {
                MessageBox.Show("Введите наименование");
                return;
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}