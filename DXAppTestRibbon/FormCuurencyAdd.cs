using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXAppTestRibbon
{
    public partial class FormCuurencyAdd : Form
    {
        public FormCuurencyAdd()
        {
            InitializeComponent();
        }

        private void btnOk_Click( object sender, EventArgs e )
        {
            if (string.IsNullOrWhiteSpace( txtCode.Text ))
            {
                MessageBox.Show( "Укажите код" );
                return;
            }
            else if (txtCode.Text.Trim().Length != 3)
            {
                MessageBox.Show( "Код должен быть 3-х значным" );
                return;
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;

        }
    }
}
