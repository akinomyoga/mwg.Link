using Gen=System.Collections.Generic;
using CM=System.ComponentModel;
using Gdi=System.Drawing;
using Forms=System.Windows.Forms;

namespace mwg.Link {
	public partial class Form2:Forms::Form{
		public Form2(){
			InitializeComponent();
		}

		private void button1_Click(object sender,System.EventArgs e) {
			if(Forms::DialogResult.OK!=this.openFileDialog1.ShowDialog(this))return;
			string html=System.IO.File.ReadAllText(this.openFileDialog1.FileName);
			afh.HTML.HTMLDocument document=afh.HTML.HTMLDocument.Parse(html);
			Bookmark.BookmarkTree tree=mwg.Link.Bookmark.BookmarkTree.CreateFromBookmarkHtml(document);

			BookmarkTreeNode root=new BookmarkTreeNode(tree.RootNode);
			root.SetupAutoDD();
			this.treeView1.Nodes.Add(root);
		}
	}

	class BookmarkTreeNode:afh.Forms.TreeTreeNode<Bookmark.BookmarkNode>{
		public BookmarkTreeNode(Bookmark.BookmarkNode node):base(node,GetNodeName(node)){}

		static string GetNodeName(Bookmark.BookmarkNode node){
			Bookmark.BookmarkLink node2=node as Bookmark.BookmarkLink;
			if(node2!=null)return node2.name;

			Bookmark.BookmarkDir node3=node as Bookmark.BookmarkDir;
			if(node3!=null)return node3.name;

			return "-";
		}

		protected override void InitializeNodes(afh.Forms.TreeNodeCollection nodes){
			foreach(Bookmark.BookmarkNode child in this.Value.Nodes){
				BookmarkTreeNode childNode=new BookmarkTreeNode(child);
				if(this.DDBehaviorInherit==afh.Forms.TreeNodeInheritType.Custom)
					childNode.DDBehavior=this.DDBehavior;
				nodes.Add(childNode);
			}
		}
	}

}
