
namespace WinFileManager
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.twDir = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cbView = new System.Windows.Forms.ComboBox();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPath = new System.Windows.Forms.Button();
            this.btnPaste = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnCut = new System.Windows.Forms.Button();
            this.btnFolder = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnup = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pathMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.tbName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // twDir
            // 
            this.twDir.ImageIndex = 2;
            this.twDir.ImageList = this.imageList1;
            this.twDir.LabelEdit = true;
            this.twDir.Location = new System.Drawing.Point(1, 150);
            this.twDir.Name = "twDir";
            this.twDir.SelectedImageIndex = 0;
            this.twDir.Size = new System.Drawing.Size(182, 404);
            this.twDir.TabIndex = 0;
            this.twDir.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.twDir_BeforeExpand);
            this.twDir.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.twDir_AfterSelect);
            this.twDir.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.twDir_NodeMouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Hardrive.png");
            this.imageList1.Images.SetKeyName(1, "Folder.png");
            this.imageList1.Images.SetKeyName(2, "Network.png");
            this.imageList1.Images.SetKeyName(3, "Folder Grey.png");
            this.imageList1.Images.SetKeyName(4, "Blank.png");
            this.imageList1.Images.SetKeyName(5, "Lock.png");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.cbView);
            this.groupBox1.Controls.Add(this.cbSort);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnPath);
            this.groupBox1.Controls.Add(this.btnPaste);
            this.groupBox1.Controls.Add(this.btnCopy);
            this.groupBox1.Controls.Add(this.btnCut);
            this.groupBox1.Controls.Add(this.btnFolder);
            this.groupBox1.Location = new System.Drawing.Point(1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(795, 75);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(693, 34);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(96, 20);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "dark theme";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbView
            // 
            this.cbView.Items.AddRange(new object[] {
            "Large Icon",
            "Small Icon",
            "List",
            "Details",
            "Tile"});
            this.cbView.Location = new System.Drawing.Point(528, 32);
            this.cbView.Name = "cbView";
            this.cbView.Size = new System.Drawing.Size(157, 24);
            this.cbView.TabIndex = 9;
            this.cbView.SelectedIndexChanged += new System.EventHandler(this.cbView_SelectedIndexChanged);
            // 
            // cbSort
            // 
            this.cbSort.Items.AddRange(new object[] {
            "None",
            "By name (A-Z)",
            "By name (Z-A)",
            "Extended"});
            this.cbSort.Location = new System.Drawing.Point(355, 32);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(167, 24);
            this.cbSort.TabIndex = 8;
            this.cbSort.SelectedIndexChanged += new System.EventHandler(this.cbSort_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::WinFileManager.Properties.Resources.icons8_мусор_48;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.Location = new System.Drawing.Point(298, 21);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(51, 48);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPath
            // 
            this.btnPath.BackgroundImage = global::WinFileManager.Properties.Resources.icons8_file_path_48;
            this.btnPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPath.Location = new System.Drawing.Point(241, 21);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(51, 48);
            this.btnPath.TabIndex = 4;
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.BackgroundImage = global::WinFileManager.Properties.Resources.icons8_вставить_48;
            this.btnPaste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPaste.Location = new System.Drawing.Point(184, 21);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(51, 48);
            this.btnPaste.TabIndex = 3;
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.BackgroundImage = global::WinFileManager.Properties.Resources.icons8_скопировать_48;
            this.btnCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCopy.Location = new System.Drawing.Point(124, 21);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(54, 48);
            this.btnCopy.TabIndex = 2;
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnCut
            // 
            this.btnCut.BackgroundImage = global::WinFileManager.Properties.Resources.icons8_вырезать_48;
            this.btnCut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCut.Location = new System.Drawing.Point(66, 21);
            this.btnCut.Name = "btnCut";
            this.btnCut.Size = new System.Drawing.Size(52, 48);
            this.btnCut.TabIndex = 1;
            this.btnCut.UseVisualStyleBackColor = true;
            this.btnCut.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // btnFolder
            // 
            this.btnFolder.BackColor = System.Drawing.Color.Transparent;
            this.btnFolder.BackgroundImage = global::WinFileManager.Properties.Resources.icons8_добавить_папку_48;
            this.btnFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFolder.Location = new System.Drawing.Point(11, 21);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(49, 48);
            this.btnFolder.TabIndex = 0;
            this.btnFolder.UseVisualStyleBackColor = false;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnReload);
            this.groupBox2.Controls.Add(this.btnup);
            this.groupBox2.Location = new System.Drawing.Point(1, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 63);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // btnReload
            // 
            this.btnReload.BackgroundImage = global::WinFileManager.Properties.Resources.icons8_reload_32;
            this.btnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReload.Location = new System.Drawing.Point(126, 12);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(52, 51);
            this.btnReload.TabIndex = 8;
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnup
            // 
            this.btnup.BackgroundImage = global::WinFileManager.Properties.Resources.icons8_вверх_48;
            this.btnup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnup.Location = new System.Drawing.Point(11, 12);
            this.btnup.Name = "btnup";
            this.btnup.Size = new System.Drawing.Size(52, 51);
            this.btnup.TabIndex = 7;
            this.btnup.UseVisualStyleBackColor = true;
            this.btnup.Click += new System.EventHandler(this.btnup_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(617, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(189, 112);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(422, 22);
            this.tbPath.TabIndex = 4;
            this.tbPath.TextChanged += new System.EventHandler(this.tbPath_Enter);
            this.tbPath.Enter += new System.EventHandler(this.Form1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 560);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Path:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(614, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Search:";
            // 
            // listView1
            // 
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.imageList2;
            this.listView1.Location = new System.Drawing.Point(189, 150);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(607, 404);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyMenuItem,
            this.pasteMenuItem,
            this.cutMenuItem,
            this.deleteMenuItem,
            this.pathMenuItem,
            this.propertiesMenuItem,
            this.renameToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(147, 172);
            // 
            // copyMenuItem
            // 
            this.copyMenuItem.Name = "copyMenuItem";
            this.copyMenuItem.Size = new System.Drawing.Size(146, 24);
            this.copyMenuItem.Text = "Copy";
            this.copyMenuItem.Click += new System.EventHandler(this.copyMenuItem_Click);
            // 
            // pasteMenuItem
            // 
            this.pasteMenuItem.Name = "pasteMenuItem";
            this.pasteMenuItem.Size = new System.Drawing.Size(146, 24);
            this.pasteMenuItem.Text = "Paste";
            this.pasteMenuItem.Click += new System.EventHandler(this.pasteMenuItem_Click);
            // 
            // cutMenuItem
            // 
            this.cutMenuItem.Name = "cutMenuItem";
            this.cutMenuItem.Size = new System.Drawing.Size(146, 24);
            this.cutMenuItem.Text = "Cut";
            this.cutMenuItem.Click += new System.EventHandler(this.cutMenuItem_Click);
            // 
            // deleteMenuItem
            // 
            this.deleteMenuItem.Name = "deleteMenuItem";
            this.deleteMenuItem.Size = new System.Drawing.Size(146, 24);
            this.deleteMenuItem.Text = "Delete";
            this.deleteMenuItem.Click += new System.EventHandler(this.deleteMenuItem_Click);
            // 
            // pathMenuItem
            // 
            this.pathMenuItem.Name = "pathMenuItem";
            this.pathMenuItem.Size = new System.Drawing.Size(146, 24);
            this.pathMenuItem.Text = "Copy path";
            this.pathMenuItem.Click += new System.EventHandler(this.pathMenuItem_Click);
            // 
            // propertiesMenuItem
            // 
            this.propertiesMenuItem.Name = "propertiesMenuItem";
            this.propertiesMenuItem.Size = new System.Drawing.Size(146, 24);
            this.propertiesMenuItem.Text = "Properties";
            this.propertiesMenuItem.Click += new System.EventHandler(this.propertiesMenuItem_Click);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.renameToolStripMenuItem.Text = "Rename";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "Folder.png");
            this.imageList2.Images.SetKeyName(1, "_blank.png");
            this.imageList2.Images.SetKeyName(2, "_page.png");
            this.imageList2.Images.SetKeyName(3, "aac.png");
            this.imageList2.Images.SetKeyName(4, "ai.png");
            this.imageList2.Images.SetKeyName(5, "aiff.png");
            this.imageList2.Images.SetKeyName(6, "avi.png");
            this.imageList2.Images.SetKeyName(7, "bmp.png");
            this.imageList2.Images.SetKeyName(8, "c.png");
            this.imageList2.Images.SetKeyName(9, "cpp.png");
            this.imageList2.Images.SetKeyName(10, "css.png");
            this.imageList2.Images.SetKeyName(11, "csv.png");
            this.imageList2.Images.SetKeyName(12, "dat.png");
            this.imageList2.Images.SetKeyName(13, "dmg.png");
            this.imageList2.Images.SetKeyName(14, "doc.png");
            this.imageList2.Images.SetKeyName(15, "dotx.png");
            this.imageList2.Images.SetKeyName(16, "dwg.png");
            this.imageList2.Images.SetKeyName(17, "dxf.png");
            this.imageList2.Images.SetKeyName(18, "eps.png");
            this.imageList2.Images.SetKeyName(19, "exe.png");
            this.imageList2.Images.SetKeyName(20, "flv.png");
            this.imageList2.Images.SetKeyName(21, "gif.png");
            this.imageList2.Images.SetKeyName(22, "h.png");
            this.imageList2.Images.SetKeyName(23, "hpp.png");
            this.imageList2.Images.SetKeyName(24, "html.png");
            this.imageList2.Images.SetKeyName(25, "ics.png");
            this.imageList2.Images.SetKeyName(26, "iso.png");
            this.imageList2.Images.SetKeyName(27, "java.png");
            this.imageList2.Images.SetKeyName(28, "jpg.png");
            this.imageList2.Images.SetKeyName(29, "js.png");
            this.imageList2.Images.SetKeyName(30, "key.png");
            this.imageList2.Images.SetKeyName(31, "less.png");
            this.imageList2.Images.SetKeyName(32, "mid.png");
            this.imageList2.Images.SetKeyName(33, "mp3.png");
            this.imageList2.Images.SetKeyName(34, "mp4.png");
            this.imageList2.Images.SetKeyName(35, "mpg.png");
            this.imageList2.Images.SetKeyName(36, "odf.png");
            this.imageList2.Images.SetKeyName(37, "ods.png");
            this.imageList2.Images.SetKeyName(38, "odt.png");
            this.imageList2.Images.SetKeyName(39, "otp.png");
            this.imageList2.Images.SetKeyName(40, "ots.png");
            this.imageList2.Images.SetKeyName(41, "ott.png");
            this.imageList2.Images.SetKeyName(42, "pdf.png");
            this.imageList2.Images.SetKeyName(43, "php.png");
            this.imageList2.Images.SetKeyName(44, "png.png");
            this.imageList2.Images.SetKeyName(45, "ppt.png");
            this.imageList2.Images.SetKeyName(46, "psd.png");
            this.imageList2.Images.SetKeyName(47, "py.png");
            this.imageList2.Images.SetKeyName(48, "qt.png");
            this.imageList2.Images.SetKeyName(49, "rar.png");
            this.imageList2.Images.SetKeyName(50, "rb.png");
            this.imageList2.Images.SetKeyName(51, "rtf.png");
            this.imageList2.Images.SetKeyName(52, "sass.png");
            this.imageList2.Images.SetKeyName(53, "scss.png");
            this.imageList2.Images.SetKeyName(54, "sql.png");
            this.imageList2.Images.SetKeyName(55, "tga.png");
            this.imageList2.Images.SetKeyName(56, "tgz.png");
            this.imageList2.Images.SetKeyName(57, "tiff.png");
            this.imageList2.Images.SetKeyName(58, "txt.png");
            this.imageList2.Images.SetKeyName(59, "wav.png");
            this.imageList2.Images.SetKeyName(60, "xls.png");
            this.imageList2.Images.SetKeyName(61, "xlsx.png");
            this.imageList2.Images.SetKeyName(62, "xml.png");
            this.imageList2.Images.SetKeyName(63, "yml.png");
            this.imageList2.Images.SetKeyName(64, "zip.png");
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(415, 560);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(301, 22);
            this.tbName.TabIndex = 12;
            this.tbName.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 563);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Enter name:";
            this.label4.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(721, 560);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 585);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.twDir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "File Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView twDir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnup;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnCut;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbView;
        private System.Windows.Forms.ComboBox cbSort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolStripMenuItem copyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pathMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertiesMenuItem;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

