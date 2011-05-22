using Gen=System.Collections.Generic;
using CM=System.ComponentModel;
using Gdi=System.Drawing;
using Forms=System.Windows.Forms;
using Wb=mwg.Controls.WebBrowser;

namespace mwg.Link {
	public partial class Form1:Forms::Form{
		public Form1(){
			InitializeComponent();
		}

		private HtGenerator htgen;
		private void Form1_Load(object sender,System.EventArgs e){
			this.htgen=new HtGenerator(Program.args);
			this.webBrowser1.Navigate("about:blank");
			this.webBrowser1.DocumentCompleted+=delegate(object s2,Forms::WebBrowserDocumentCompletedEventArgs e2){
				document.body.innerText="Hello, world!";
				show_links();
			};
		}

		internal Wb::Document document{
			get{
				return new mwg.Controls.WebBrowser.Document(this.webBrowser1.Document);
			}
		}

		void show_links(){
			string s_html=this.htgen.htLinks();

			//document.getElementsByTagName("head")[0].appendChild();
			System.IO.File.WriteAllText(Program.args.DataDirectory+@"\papers.htm",s_html);
			document.body.innerHTML=s_html;
		}
	}
}
