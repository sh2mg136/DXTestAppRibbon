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

namespace DXAppTestRibbon.Base
{

    [Serializable()]
    [XmlRootAttribute( "App Configuration" )]
    public class Config
    {
        private string _RegKeyMainKey = string.Empty;

        [XmlIgnore, Browsable( false )]

        public string RegKeyMainKey
        {
            get
            {
                return _RegKeyMainKey;
            }
            set
            {
                _RegKeyMainKey = value;
            }
        }

        public Config Clone()
        {
            return (Config)this.MemberwiseClone();
        }

        [Category( "Настройка" ),
        Description( "Настройка параметров" ),
        DisplayName( "Сервер" ),
        RefreshProperties( RefreshProperties.All )]
        public string Server
        {
            get
            {
                return _server;
            }
            set
            {
                _server = value;
            }
        } string _server = "";

        [Category( "Настройка" ),
        Description( "Настройка параметров" ),
        DisplayName( "База данных" ),
        RefreshProperties( RefreshProperties.All )]
        public string DataBase
        {
            get
            {
                return _database;
            }
            set
            {
                _database = value;
            }
        } string _database = "AppTestDB";

        [Category( "Настройка" ),
          Description( "Настройка параметров" ),
          DisplayName( "Имя входа" ),
          RefreshProperties( RefreshProperties.All )]
        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                _userName = value;
            }
        } string _userName = "sa";


        [Category( "Настройка" ),
        Description( "Настройка параметров" ),
        DisplayName( "Пароль" ),
        PasswordPropertyText( true ),
        RefreshProperties( RefreshProperties.All )]
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        } string _password = "";


        [Category( "Настройка" ),
        Description( "Настройка параметров" ),
        DisplayName( "Windows аутентификация" ),
        RefreshProperties( RefreshProperties.All )]
        public bool TrustedConnection
        {
            get
            {
                return _trustedConnection;
            }
            set
            {
                _trustedConnection = value;
            }
        } bool _trustedConnection = true;

    }

}

namespace TemplateEditor
{

    public class ComPortNameConvert : StringConverter
    {
        public override bool GetStandardValuesSupported( ITypeDescriptorContext context )
        {
            return true;
        }

        public override StandardValuesCollection GetStandardValues( ITypeDescriptorContext context )
        {
            List<string> ComPorts = new List<string>();
            foreach (string ComName in System.IO.Ports.SerialPort.GetPortNames())
                ComPorts.Add( ComName );

            return new StandardValuesCollection( ComPorts );
        }
    }

    public class PrinterNameConvert : StringConverter
    {
        public override bool GetStandardValuesSupported( ITypeDescriptorContext context )
        {
            return true;
        }

        public override StandardValuesCollection GetStandardValues( ITypeDescriptorContext context )
        {
            List<string> printers = new List<string>();
            foreach (string printerName in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
                printers.Add( printerName );

            return new StandardValuesCollection( printers );
        }
    }

    public class Config
    {

        private string _Processname;
        private string _Subdivision;

        public string Processname
        {
            get
            {
                return _Processname;
            }
            set
            {
                _Processname = value;
            }
        }

        public string Subdivision
        {
            get
            {
                return _Subdivision;
            }
            set
            {
                _Subdivision = value;
            }
        }

    }
}
