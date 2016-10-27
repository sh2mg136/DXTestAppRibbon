using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.ComponentModel;
using System.Drawing.Design;
using System.Drawing;
using System.Collections.Specialized;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using DXAppTestRibbon.Base;

public sealed class App
{
    private static string sProfiles = Path.Combine( Environment.CurrentDirectory, "Profiles" );
    private static string sUserNameShort = Path.Combine( sProfiles, Environment.UserName );
    private static string ConfigFileName = Path.Combine( sProfiles, "View.ini" );

    public static Config cfg = new Config();

    public static bool LoadConfig( string sRegKeyMainKey, out string sOutMessage )
    {
        bool bRetCod = true;
        object o = (object)cfg;
        sOutMessage = string.Empty;

        try
        {

            cfg.RegKeyMainKey = sRegKeyMainKey;

            if (File.Exists( ConfigFileName ))
            {
                if (FrmLibrary.SaveLoadConfig.Load( ref o, ConfigFileName ))
                {
                    cfg = (Config)o;
                    cfg.RegKeyMainKey = sRegKeyMainKey;

                }
            }

        }
        catch (Exception ex)
        {
            bRetCod = false;
            sOutMessage = ex.Message;
        }
        return bRetCod;
    }


    public Config Cfg
    {
        get
        {
            return cfg;
        }
    }


    public static string ConnectionString
    {
        get
        {
            if (App.cfg == null)
                return string.Empty;

            if (App.cfg.TrustedConnection)
            {
                return string.Format( "server={0}; database={1}; trusted_connection=true",
                    cfg.Server ?? string.Empty,
                    cfg.DataBase ?? string.Empty );
            }
            else
            {
                return string.Format( "server={0}; database={1}; user={2}; password={3}",
                    cfg.Server ?? string.Empty,
                    cfg.DataBase ?? string.Empty,
                    cfg.UserName ?? string.Empty,
                    cfg.Password ?? string.Empty );
            }
        }
    }


    public static void ShowConfig()
    {
        FrmLibrary.FormDialogConfig f = new FrmLibrary.FormDialogConfig( cfg.RegKeyMainKey );
        try
        {
            object o = (object)cfg;
            f.SelectedObject = cfg.Clone();
            if (f.ShowDialog() == DialogResult.OK)
            {
                cfg = (Config)f.SelectedObject;
                o = cfg;
                FrmLibrary.SaveLoadConfig.Save( ref o, ConfigFileName );
            }
        }
        catch
        {
            MessageBox.Show( "Ошибка сохранения файла конфигурации: " + ConfigFileName, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error );
        }
    }
}
