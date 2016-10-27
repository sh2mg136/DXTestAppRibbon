using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

using System.Xml.Serialization;
namespace FrmLibrary
{
    public sealed class SaveLoadConfig
    {
        static public bool Load( ref Object k, string fName )
        {
            Object objOld = null;
            Stream InStream = null;
            try
            {
                objOld = k;

                if (!File.Exists( fName )) return false;

                InStream = File.Open( fName, FileMode.Open, FileAccess.Read );
                XmlSerializer formatter = new XmlSerializer( k.GetType() );

                if (k != null) k = null;
                k = formatter.Deserialize( InStream );
                InStream.Close();
            }
            catch (Exception ex)
            {
                k = objOld;
                if (InStream != null) InStream.Close();
                MessageBox.Show( ex.Message, "FrmConfig", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return false;
            }
            return true;
        }

        static public bool Save( ref Object k, string fName )
        {
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo( Path.Combine( Application.StartupPath, "Profiles" ) );
                if ( !dirInfo.Exists )
                {
                    dirInfo.Create();
                }

                using (Stream stream = File.Open( fName, FileMode.Create, FileAccess.Write ))
                {
                    XmlSerializer formatter = new XmlSerializer( k.GetType() );
                    formatter.Serialize( stream, k );
                    stream.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message, "FrmConfig", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return false;
            }
        }
    }
}
