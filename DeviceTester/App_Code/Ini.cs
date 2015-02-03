using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Ini
{
	/// <summary>
	/// Create a New INI file to store or load data
	/// </summary>
	public class IniFile
	{
		public string _path;

		[DllImport("kernel32")]
		private static extern long WritePrivateProfileString(string section,string key,string val,string filePath);
		[DllImport("kernel32")]
		private static extern int GetPrivateProfileString(string section,string key,string def,StringBuilder retVal,int size,string filePath);

		/// <summary>
		/// INIFile Constructor.
		/// </summary>
		/// <param name="INIPath"></param>
		public IniFile(string INIPath)
		{
			_path = INIPath;
		}

        public IniFile()
        {
            // TODO: Complete member initialization
            _path = System.IO.Path.GetDirectoryName(Application.ExecutablePath)+"\\Start.ini"; 
        }

		/// <summary>
		/// Write Data to the INI File
		/// </summary>
		/// <param name="Section"></param>
		/// Section name
		/// <param name="Key"></param>
		/// Key Name
		/// <param name="Value"></param>
		/// Value Name
		public void IniWriteValue(string Section,string Key,string Value)
		{
			WritePrivateProfileString(Section,Key,Value,this._path);
		}
		
		/// <summary>
		/// Read Data Value From the Ini File
		/// </summary>
		/// <param name="Section"></param>
		/// <param name="Key"></param>
		/// <param name="Path"></param>
		/// <returns></returns>
		public string IniReadValue(string Section,string Key)
		{
            StringBuilder temp = new StringBuilder(255);
			int i = GetPrivateProfileString(Section,Key,"",temp,255,this._path);
			return temp.ToString();

		}

        public static string GetValue(string Section, string Key)
        {
            string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            string filePath = path + "\\Start.ini";
            if (File.Exists(filePath))
            {
                IniFile ini = new IniFile(filePath);
                return ini.IniReadValue(Section, Key);
            }
            else return "Start.ini could not be found.";
        }
	}
}
