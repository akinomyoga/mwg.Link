namespace mwg.Link {
	partial class Form2 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.button1 = new System.Windows.Forms.Button();
			this.treeView1 = new afh.Forms.TreeView();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.SuspendLayout();
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.Filter = "HTML Document (*.html;*.htm)|*.html;*.htm|すべてのファイル (*)|*";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(366,12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(147,26);
			this.button1.TabIndex = 1;
			this.button1.Text = "open bookmarks.html";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// treeView1
			// 
			this.treeView1.AllowDrop = true;
			this.treeView1.AutoScroll = true;
			this.treeView1.BackColor = System.Drawing.SystemColors.Window;
			this.treeView1.DefaultNodeParams.BackColor = System.Drawing.Color.White;
			this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
			this.treeView1.Location = new System.Drawing.Point(0,0);
			this.treeView1.MultiSelect = true;
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(217,383);
			this.treeView1.TabIndex = 0;
			this.treeView1.Text = "treeView1";
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(217,0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(3,383);
			this.splitter1.TabIndex = 2;
			this.splitter1.TabStop = false;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F,12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(525,383);
			this.Controls.Add(this.splitter1);
			this.Controls.Add(this.treeView1);
			this.Controls.Add(this.button1);
			this.Name = "Form2";
			this.Text = "Form2";
			this.ResumeLayout(false);

		}

		#endregion

		private afh.Forms.TreeView treeView1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Splitter splitter1;
	}
}