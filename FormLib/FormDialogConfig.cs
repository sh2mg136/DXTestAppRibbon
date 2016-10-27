using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using DevExpress.XtraEditors;

namespace FrmLibrary
{
    public partial class FormDialogConfig : DevExpress.XtraEditors.XtraForm
    {
        private string sRegKeyMainKey;

        public FormDialogConfig(string sRegKeyMainKey)
        {
            InitializeComponent();
            this.sRegKeyMainKey = sRegKeyMainKey;
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();

        }
        public Object SelectedObject
        {
            get
            {
                return PG.SelectedObject;
            }
            set
            {
                PG.SelectedObject = value;
            }

        }

        private void frmDialogConfig_Load(object sender, EventArgs e)
        {
            GetPosissionSpl();
        }

        private void SavePosission()
        {
            RegistryKey RegKey = Registry.CurrentUser;
            try
            {

                RegKey = RegKey.OpenSubKey(sRegKeyMainKey+"\\DialogConfig", true);
                if (RegKey == null)
                {
                    RegKey = Registry.CurrentUser;
                    RegKey = RegKey.CreateSubKey(sRegKeyMainKey+"\\DialogConfig");
                }

                RegKey.SetValue("Top", this.Top, RegistryValueKind.DWord);
                RegKey.SetValue("Left", this.Left, RegistryValueKind.DWord);
                RegKey.SetValue("Width", this.Width, RegistryValueKind.DWord);
                RegKey.SetValue("Height", this.Height, RegistryValueKind.DWord);
            }
            catch { }
        }

        private void GetPosissionSpl()
        {
            RegistryKey RegKey;
            try
            {

                RegKey = Registry.CurrentUser;
                RegKey = RegKey.OpenSubKey(sRegKeyMainKey+"\\DialogConfig", true);
                if (RegKey != null)
                {
                    this.Top = (int)RegKey.GetValue("Top", this.Top);
                    this.Left = (int)RegKey.GetValue("Left", this.Left);
                    this.Width = (int)RegKey.GetValue("Width", this.Width);
                    this.Height = (int)RegKey.GetValue("Height", this.Height);
                }
            }
            catch { }

        }

        private void frmDialogConfig_FormClosing(object sender, FormClosingEventArgs e)
        {
            SavePosission();
        }
    }
}