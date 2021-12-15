using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace WinFileManager
{
    public partial class Form1 : Form
    {
        private string FilePath = "D:";
        private bool isFile = false;
        private string selectedItem = "";
        private string[] columnsForFiles = { "Name", "Type", "Size", "Date of creation", "Date of change" };
        private List<FileSystemInfo> fileSystemItems = new List<FileSystemInfo>();
        public Form1()
        {
            InitializeComponent();
            DriveTreeInit();
            cbView.SelectedIndex = 0;
            cbSort.SelectedIndex = 0;
        }
        #region Events
        private void Form1_Load(object sender, EventArgs e)
        {
            tbPath.Text = FilePath;
            loadFiles();
        }
        #region TreeView
        private void twDir_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            twDir.BeginUpdate();

            foreach (TreeNode node in e.Node.Nodes)
            {
                GetDirs(node);
            }

            twDir.EndUpdate();
        }
        private void twDir_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;
            FilePath = selectedNode.FullPath;
            tbPath.Text = FilePath.Substring(0, FilePath.Length - 1); ;

            DirectoryInfo di = new DirectoryInfo(FilePath);
            FileInfo[] fiArray;
            DirectoryInfo[] diArray;

            try
            {
                fiArray = di.GetFiles();
                diArray = di.GetDirectories();
            }
            catch
            {
                return;
            }

            listView1.Items.Clear();
            loadFiles();
        }
        private void twDir_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode selectedNode = e.Node;
            FilePath = selectedNode.FullPath;
            tbPath.Text = FilePath;

            DirectoryInfo di = new DirectoryInfo(FilePath);
            FileInfo[] fiArray;
            DirectoryInfo[] diArray;

            try
            {
                fiArray = di.GetFiles();
                diArray = di.GetDirectories();
            }
            catch
            {
                return;
            }

            listView1.Items.Clear();
            loadFiles();
        }
        #endregion
        #region ListView
        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            selectedItem = e.Item.Text;
            FileAttributes attrs = File.GetAttributes(FilePath + "/" + selectedItem);
            if ((attrs & FileAttributes.Directory) == FileAttributes.Directory)
            {
                isFile = false;
                tbPath.Text = FilePath + "/" + selectedItem;
            }
            else
            {
                isFile = true;
            }
        }
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            FilePath = tbPath.Text;
            loadFiles();
            isFile = false;
        }
        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listView1.FocusedItem.Bounds.Contains(e.Location))
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }
        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListView lsw = (ListView)sender;
            if (e.Column == ListViewItemComparer.SortColumn)
            {
                if (ListViewItemComparer.Order == SortOrder.Ascending)
                {
                    ListViewItemComparer.Order = SortOrder.Descending;
                }
                else
                {
                    ListViewItemComparer.Order = SortOrder.Ascending;
                }
            }
            else
            {
                ListViewItemComparer.SortColumn = e.Column;
                ListViewItemComparer.Order = SortOrder.Ascending;
            }
            this.listView1.ListViewItemSorter = new ListViewItemComparer(e.Column);
        }
        #endregion
        #region OtherElements
        private void tbPath_Enter(object sender, EventArgs e)
        {
            FilePath = tbPath.Text;
            loadFiles();
            isFile = false;
        }
        private void btnup_Click(object sender, EventArgs e)
        {
            back();
            loadFiles();
        }
        private void btnFolder_Click(object sender, EventArgs e)
        {
            string myname = "";
            string mypath = "";

            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Add Folder";
            dialog.ShowNewFolderButton = true;
            dialog.SelectedPath = tbPath.Text;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                mypath = dialog.SelectedPath;
                myname = mypath.Substring(mypath.LastIndexOf("\\") + 1);

                AddFolderNode(myname, mypath);
            }
        }
        private void btnCut_Click(object sender, EventArgs e)
        {
            Copy();
            Delete();
            Paste();
        }
        private void btnCopy_Click(object sender, EventArgs e)
        {
            Copy();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }
        private void cbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbViewSelect();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Detaild();
            ListViewItem foundItem = listView1.FindItemWithText(textBox1.Text, false, 0, true);
            if (foundItem != null)
            {
                listView1.TopItem = foundItem;
            }
            if (textBox1.Text == "")
            {
                cbViewSelect();
                loadFiles();
            }
        }
        private void btnPath_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(FilePath + "/" + listView1.FocusedItem.Text);
        }
        private void btnPaste_Click(object sender, EventArgs e)
        {
            Paste();
        }
        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbSort.SelectedItem.ToString())
            {
                case "None":
                    listView1.Sorting = SortOrder.None;
                    break;
                case "By name (A-Z)":
                    listView1.Sorting = SortOrder.Ascending;
                    break;
                case "By name (Z-A)":
                    listView1.Sorting = SortOrder.Descending;
                    break;
                case "Extended":
                    Detaild();
                    break;
                default:
                    MessageBox.Show("Unknown", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
        void pasteMenuItem_Click(object sender, EventArgs e)
        {
            Paste();
        }
        void copyMenuItem_Click(object sender, EventArgs e)
        {
            Copy();
        }
        void cutMenuItem_Click(object sender, EventArgs e)
        {
            Copy();
            Delete();
            Paste();
        }
        void deleteMenuItem_Click(object sender, EventArgs e)
        {
            Delete();
        }
        void pathMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(FilePath + "/" + listView1.FocusedItem.Text);
        }
        void propertiesMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name" + listView1.FocusedItem.Text + "\n" + "Full path" + FilePath + "/" + listView1.FocusedItem.Text, "Properties", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.BackColor = Color.DarkSlateBlue;
                listView1.BackColor = Color.DarkSlateBlue;
                listView1.ForeColor = Color.White;
                twDir.BackColor = Color.DarkSlateBlue;
                twDir.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.White;
                listView1.BackColor = Color.White;
                listView1.ForeColor = Color.Black;
                twDir.BackColor = Color.White;
                twDir.ForeColor = Color.Black;
            }
        }
        #endregion
        #endregion
        #region Methods
        public void DriveTreeInit()
        {
            string[] drivesArray = Directory.GetLogicalDrives();

            twDir.BeginUpdate();
            twDir.Nodes.Clear();

            foreach (string s in drivesArray)
            {
                TreeNode drive = new TreeNode(s, 0, 0);
                twDir.Nodes.Add(drive);

                GetDirs(drive);
            }
            twDir.EndUpdate();
        }
        public void GetDirs(TreeNode node)
        {
            DirectoryInfo[] diArray;

            node.Nodes.Clear();

            string fullPath = node.FullPath;
            DirectoryInfo di = new DirectoryInfo(fullPath);

            try
            {
                diArray = di.GetDirectories();
            }
            catch
            {
                return;
            }

            foreach (DirectoryInfo dirinfo in diArray)
            {
                TreeNode dir = new TreeNode(dirinfo.Name, 1, 1);
                node.Nodes.Add(dir);
            }
        }
        public void loadFiles()
        {
            DirectoryInfo fileList;
            string tempPath = "";
            try
            {
                if (isFile)
                {
                    tempPath = FilePath + "/" + selectedItem;
                    Process.Start(tempPath);
                }
                else
                {
                    fileList = new DirectoryInfo(FilePath);
                    FileInfo[] files = fileList.GetFiles();
                    DirectoryInfo[] dirs = fileList.GetDirectories();
                    string extention = "";
                    listView1.Items.Clear();
                    for (int i = 0; i < files.Length; i++)
                    {
                        extention = files[i].Extension.ToUpper();
                        switch (extention)
                        {
                            case ".ACC":
                                listView1.Items.Add(files[i].Name, 3);
                                break;
                            case ".AI":
                                listView1.Items.Add(files[i].Name, 4);
                                break;
                            case ".AIFF":
                                listView1.Items.Add(files[i].Name, 5);
                                break;
                            case ".AVI":
                                listView1.Items.Add(files[i].Name, 6);
                                break;
                            case ".BMP":
                                listView1.Items.Add(files[i].Name, 7);
                                break;
                            case ".C":
                                listView1.Items.Add(files[i].Name, 8);
                                break;
                            case ".CPP":
                                listView1.Items.Add(files[i].Name, 9);
                                break;
                            case ".CSS":
                                listView1.Items.Add(files[i].Name, 10);
                                break;
                            case ".CSV":
                                listView1.Items.Add(files[i].Name, 11);
                                break;
                            case ".DAT":
                                listView1.Items.Add(files[i].Name, 12);
                                break;
                            case ".DMG":
                                listView1.Items.Add(files[i].Name, 13);
                                break;
                            case ".DOC":
                            case ".DOCX":
                                listView1.Items.Add(files[i].Name, 14);
                                break;
                            case ".DOTX":
                                listView1.Items.Add(files[i].Name, 15);
                                break;
                            case ".DWG":
                                listView1.Items.Add(files[i].Name, 16);
                                break;
                            case ".DXF":
                                listView1.Items.Add(files[i].Name, 17);
                                break;
                            case ".EPS":
                                listView1.Items.Add(files[i].Name, 18);
                                break;
                            case ".EXE":
                                listView1.Items.Add(files[i].Name, 19);
                                break;
                            case ".FLV":
                                listView1.Items.Add(files[i].Name, 20);
                                break;
                            case ".GIF":
                                listView1.Items.Add(files[i].Name, 21);
                                break;
                            case ".H":
                                listView1.Items.Add(files[i].Name, 22);
                                break;
                            case ".HPP":
                                listView1.Items.Add(files[i].Name, 23);
                                break;
                            case ".HTML":
                            case ".HTM":
                                listView1.Items.Add(files[i].Name, 24);
                                break;
                            case ".ICS":
                                listView1.Items.Add(files[i].Name, 25);
                                break;
                            case ".ISO":
                                listView1.Items.Add(files[i].Name, 26);
                                break;
                            case ".JAVA":
                                listView1.Items.Add(files[i].Name, 27);
                                break;
                            case ".JPG":
                            case ".JPEG":
                                listView1.Items.Add(files[i].Name, 28);
                                break;
                            case ".JS":
                                listView1.Items.Add(files[i].Name, 29);
                                break;
                            case ".KEY":
                                listView1.Items.Add(files[i].Name, 30);
                                break;
                            case ".LESS":
                                listView1.Items.Add(files[i].Name, 31);
                                break;
                            case ".MID":
                                listView1.Items.Add(files[i].Name, 32);
                                break;
                            case ".MP3":
                                listView1.Items.Add(files[i].Name, 33);
                                break;
                            case ".MP4":
                                listView1.Items.Add(files[i].Name, 34);
                                break;
                            case ".MPG":
                                listView1.Items.Add(files[i].Name, 35);
                                break;
                            case ".ODF":
                                listView1.Items.Add(files[i].Name, 36);
                                break;
                            case ".ODS":
                                listView1.Items.Add(files[i].Name, 37);
                                break;
                            case ".ODT":
                                listView1.Items.Add(files[i].Name, 38);
                                break;
                            case ".OTP":
                                listView1.Items.Add(files[i].Name, 39);
                                break;
                            case ".OTS":
                                listView1.Items.Add(files[i].Name, 40);
                                break;
                            case ".OTT":
                                listView1.Items.Add(files[i].Name, 41);
                                break;
                            case ".PDF":
                                listView1.Items.Add(files[i].Name, 42);
                                break;
                            case ".PHP":
                                listView1.Items.Add(files[i].Name, 43);
                                break;
                            case ".PNG":
                                listView1.Items.Add(files[i].Name, 44);
                                break;
                            case ".PPT":
                                listView1.Items.Add(files[i].Name, 45);
                                break;
                            case ".PSD":
                                listView1.Items.Add(files[i].Name, 46);
                                break;
                            case ".PY":
                                listView1.Items.Add(files[i].Name, 47);
                                break;
                            case ".QT":
                                listView1.Items.Add(files[i].Name, 48);
                                break;
                            case ".RAR":
                                listView1.Items.Add(files[i].Name, 49);
                                break;
                            case ".RB":
                                listView1.Items.Add(files[i].Name, 50);
                                break;
                            case ".RTF":
                                listView1.Items.Add(files[i].Name, 51);
                                break;
                            case ".SASS":
                                listView1.Items.Add(files[i].Name, 52);
                                break;
                            case ".SCSS":
                                listView1.Items.Add(files[i].Name, 53);
                                break;
                            case ".SQL":
                                listView1.Items.Add(files[i].Name, 54);
                                break;
                            case ".TGA":
                                listView1.Items.Add(files[i].Name, 55);
                                break;
                            case ".TGZ":
                                listView1.Items.Add(files[i].Name, 56);
                                break;
                            case ".TIFF":
                                listView1.Items.Add(files[i].Name, 57);
                                break;
                            case ".TXT":
                                listView1.Items.Add(files[i].Name, 58);
                                break;
                            case ".WAV":
                                listView1.Items.Add(files[i].Name, 59);
                                break;
                            case ".XLS":
                                listView1.Items.Add(files[i].Name, 60);
                                break;
                            case ".XLSX":
                                listView1.Items.Add(files[i].Name, 61);
                                break;
                            case ".XML":
                                listView1.Items.Add(files[i].Name, 62);
                                break;
                            case ".YML":
                                listView1.Items.Add(files[i].Name, 63);
                                break;
                            case ".ZIP":
                            case ".7Z":
                                listView1.Items.Add(files[i].Name, 64);
                                break;
                            default:
                                listView1.Items.Add(files[i].Name, 1);
                                break;
                        }

                    }
                    for (int i = 0; i < dirs.Length; i++)
                    {
                        listView1.Items.Add(dirs[i].Name, 0);
                    }
                    label1.Text = "Files:" + (files.Count() + dirs.Count()).ToString();

                }
            }
            catch (Exception e)
            {

            }
        }
        public void removeSlash()
        {
            string path = tbPath.Text;
            if (path.LastIndexOf("/") == path.Length - 1)
            {
                tbPath.Text = path.Substring(0, path.Length - 1);
            }
        }
        public void back()
        {
            try
            {
                removeSlash();
                string path = tbPath.Text;
                path = path.Substring(0, path.LastIndexOf("/"));
                isFile = false;
                tbPath.Text = path;
                removeSlash();
            }
            catch (Exception e)
            {

            }
        }
        private void AddFolderNode(string name, string path)
        {
            try
            {
                if (Directory.Exists(path))
                {
                    foreach (string dir in Directory.GetDirectories(path))
                    {
                        TreeNode node = new TreeNode();
                        node.Tag = dir;
                        node.Text = dir.Substring(dir.LastIndexOf(@"\") + 1);
                        node.ImageIndex = 1;
                        twDir.Nodes.Add(node);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while Filling the Explorer:" + ex.Message);
            }
        }
        public void Copy()
        {
            if (listView1.SelectedItems.Count == 0)
                return;

            var selectedItems = new ListViewItem[listView1.SelectedItems.Count];
            listView1.SelectedItems.CopyTo(selectedItems, 0);
            Clipboard.SetDataObject(selectedItems, false);
        }
        public void Paste()
        {
            var selectedItems = Clipboard.GetDataObject().GetData(typeof(ListViewItem[]))
                                    as ListViewItem[];
            if (System.IO.Directory.Exists(selectedItems.ToString()))
            {
                string[] files = System.IO.Directory.GetFiles(selectedItems.ToString());
                foreach (string s in files)
                {
                    string fileName = System.IO.Path.GetFileName(s);
                    string destFile = System.IO.Path.Combine(tbPath.Text, fileName);
                    System.IO.File.Copy(s, destFile, true);
                }
            }
            else
            {
                Console.WriteLine("Source path does not exist!");
            }

            listView1.Items.AddRange(selectedItems);
        }
        public void Delete()
        {
            var selectedItems = new ListViewItem[listView1.SelectedItems.Count];
            listView1.SelectedItems.CopyTo(selectedItems, 0);
            if (listView1.SelectedIndices.Count > 0)
            {
                var confirmation = MessageBox.Show("Are you shure?", "Сonfirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmation == DialogResult.Yes)
                {
                    for (int i = listView1.SelectedIndices.Count - 1; i >= 0; i--)
                    {

                        listView1.Items.RemoveAt(listView1.SelectedIndices[i]);

                    }
                }
            }
            else
                MessageBox.Show("The selected file does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
        }
        public void Detaild()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Items.Clear();
            foreach (string s in columnsForFiles)
            {
                listView1.Columns.Add(s, 100);
            }
            string[] directories = Directory.GetDirectories(FilePath);
            foreach (string directory in directories)
            {
                DirectoryInfo di = new DirectoryInfo(directory);
                fileSystemItems.Add(di);
            }

            string[] files = Directory.GetFiles(FilePath);
            foreach (string file in files)
            {
                FileInfo fi = new FileInfo(file);
                fileSystemItems.Add(fi);
            }

            ListViewItem lviFile = null;
            foreach (FileSystemInfo file in fileSystemItems)
            {
                listView1.BeginUpdate();
                lviFile = new ListViewItem();
                lviFile.Tag = file;
                lviFile.Text = file.Name;

                if (file is DirectoryInfo)
                {
                    lviFile.ImageIndex = 1;
                    lviFile.SubItems.Add("Catalog");
                    lviFile.SubItems.Add("-");
                }

                else if (file is FileInfo)
                {
                    FileInfo currentFile = file as FileInfo;
                    if (currentFile == null)
                    {
                        return;
                    }
                    string fileExtention = currentFile.Extension.ToLower();
                    lviFile.SubItems.Add(fileExtention);
                    lviFile.SubItems.Add(currentFile.Length.ToString());
                }
                lviFile.SubItems.Add(file.CreationTime.ToString());
                lviFile.SubItems.Add(file.LastWriteTime.ToString());

                listView1.Items.Add(lviFile);

                listView1.EndUpdate();
            }
        }
        public void cbViewSelect()
        {
            switch (cbView.SelectedItem.ToString())
            {
                case "Large Icon":
                    listView1.View = View.LargeIcon;
                    break;
                case "Small Icon":
                    listView1.View = View.SmallIcon;
                    break;
                case "Details":
                    Detaild();
                    break;
                case "List":
                    listView1.View = View.List;
                    break;
                case "Tile":
                    listView1.View = View.Tile;
                    break;
                default:
                    MessageBox.Show("Unknown", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
        #endregion
    }
    class ListViewItemComparer : IComparer
    {
        private int col;
        public static int SortColumn { get; set; }
        public static SortOrder Order { get; set; }
        public ListViewItemComparer()
        {
            col = 0;
        }
        public ListViewItemComparer(int column)
        {
            col = column;
        }
        public string FullCompareString(string s)
        {
            string Res = s;
            while (Res.Length < 10) Res = "0" + Res;
            return Res;
        }
        public int Compare(object x, object y)
        {

            string s1 = FullCompareString(((ListViewItem)x).SubItems[col].Text);
            string s2 = FullCompareString(((ListViewItem)y).SubItems[col].Text);
            if (Order == SortOrder.Ascending)
                return String.Compare(s1, s2);
            else
                return String.Compare(s2, s1);
        }
    }
}
