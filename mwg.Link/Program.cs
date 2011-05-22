using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace mwg.Link {
	class Argument{
		public string xmlfile=@"C:\Documents and Settings\koichi\デスクトップ\Graduate\Papers\papers.xml";

		public string DataFile{
			get{return this.xmlfile;}
		}
		public string DataDirectory{
			get{return System.IO.Path.GetDirectoryName(this.xmlfile);}
		}

		public Argument(){}
	}
	static class Program{
		internal static Argument args;

		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
		/// </summary>
		[STAThread]
		static void Main(){
			args=new Argument();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			//Application.Run(new Form1());
			Application.Run(new Form2());
		}
	}
}
