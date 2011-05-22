using Gen=System.Collections.Generic;

namespace mwg.Link{
	class HtGenerator{
		private Argument args;
		private System.Xml.XmlDocument data=null;
		public HtGenerator(Argument args){
			this.args=args;
			this.loadData();
		}

		void loadData(){
			data=new System.Xml.XmlDocument();
			try{
				data.Load(Program.args.DataFile);
			}catch{
				data.LoadXml(@"<papers></papers>");
			}
		}

		private Gen::IEnumerable<System.Xml.XmlElement> childElems(){
			foreach(System.Xml.XmlNode elem_ in data.DocumentElement.ChildNodes){
				System.Xml.XmlElement elem=elem_ as System.Xml.XmlElement;
				if(elem==null)continue;
				yield return elem;
			}
		}

		public string htLinks(){
			System.Text.StringBuilder html=new System.Text.StringBuilder();

			foreach(System.Xml.XmlElement elem in this.childElems()){
				switch(elem.Name){
					case "paper":
						html.Append("<p class=\"paper\">");
						html.Append("<a href=\"");
						html.Append(getText(elem,"url")??"");
						html.Append("\">");
						html.Append(getText(elem,"title")??"&lt;notitle&gt;");
						html.Append("</a>");
						html.Append("</p>\r\n");
						break;
					case "list":
						html.Append("<p class=\"list\">");
						html.Append(getText(elem,"title")??"&lt;notitle&gt;");
						html.Append("</p>\r\n");
						break;
					case "keywords":
						html.Append("<p>keywords</p>\r\n");
						break;
					default:
						html.Append("<p>&lt;unknown&gt;</p>\r\n");
						break;
				}
			}

			return html.ToString();
		}

		private string getText(System.Xml.XmlElement elem,string elemName){
			System.Xml.XmlNodeList list=elem.GetElementsByTagName(elemName);
			if(list.Count==0)return null;
			string t=list[0].InnerText;
			if(t.Length==0)return null;
			return t;
		}
	}
}