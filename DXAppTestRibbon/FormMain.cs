using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace DXAppTestRibbon
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        bool _loggedOn = false;
        string _userName = string.Empty;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault( false );

            string message = "";

            if (!App.LoadConfig( GetRegKey(), out message ))
            {
                MessageBox.Show( message );
                return;
            }
            else if (string.IsNullOrWhiteSpace( App.cfg.Server ))
            {
                MessageBox.Show( @"Не указан адрес сервера базы данных!
Пожалуйста, заполните соответствующее поле",
                    "Configuration error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error );
                App.ShowConfig();
            }


            // Здесь можно показать окно аутентификации 


            Application.Run( new FormMain() );

        }

        public FormMain()
        {
            InitializeComponent();
            mdiManager.MdiParent = this;
        }

        private void FormMain_Load( object sender, EventArgs e )
        {
            LoadConfig();
            Debug.Assert( App.cfg != null );
            Debug.WriteLine( App.cfg.Server );
        }

        private void barClose_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
        {
            Close();
        }

        private void btnCurrencies_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
        {
            FormCurrencies frm = new FormCurrencies();
            mdiManager.FloatForms.Add( frm );
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnLogon_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
        {
            if (_loggedOn)
            {
                _loggedOn = false;
                _userName = string.Empty;
                this.Text = "Not logged on";
                btnLogon.Glyph = Properties.Resources.locked;
                btnLogon.LargeGlyph = Properties.Resources.locked;
                btnLogon.Caption = "Logon";
            }
            else
            {

                DB db = new DB( App.ConnectionString );
                FormAuth frm = new FormAuth();
                if (frm.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                    return;

                bool b = db.Logon( frm.txtUserName.Text.Trim(), frm.txtPassword.Text.Trim() );

                _loggedOn = b;
                _userName = frm.txtUserName.Text.Trim();
                this.Text = "Logged on as " + _userName;
                btnLogon.Glyph = Properties.Resources.opened;
                btnLogon.LargeGlyph = Properties.Resources.opened;
                btnLogon.Caption = "Logoff";
            }

        }

        static private bool LoadConfig()
        {
            bool bRet = true;
            string errorMessage;

            if (!App.LoadConfig( GetRegKey(), out errorMessage ))
            {
                bRet = false;
                MessageBox.Show( errorMessage, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }

            return bRet;
        }

        static public string GetRegKey()
        {

            RegistryKey RegKey = Registry.CurrentUser;

            string RegKeyRedexpress = "Software\\TestApp\\" + Environment.UserName;

            RegKey = RegKey.OpenSubKey( RegKeyRedexpress, true );
            if (RegKey == null)
            {
                RegKey = Registry.CurrentUser;
                RegKey = RegKey.CreateSubKey( RegKeyRedexpress );
            }

            return RegKeyRedexpress;
        }

        private void btnSettings_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
        {
            try
            {
                App.ShowConfig();
            }
            catch (Exception ex)
            {
                AddSysMessage( ex.Message, MessageBoxIcon.Error );
            }
        }

        private void AddSysMessage( string sMessage, MessageBoxIcon MessBoxIcon )
        {
            if (MessBoxIcon == MessageBoxIcon.Error)
                MessageBox.Show( sMessage, this.Text, MessageBoxButtons.OK, MessBoxIcon );
        }

        private void btnAccounts_ItemClick( object sender, DevExpress.XtraBars.ItemClickEventArgs e )
        {
            FormSubjects frm = new FormSubjects();
            frm.MdiParent = this;
            frm.Show();
        }

    }

}
