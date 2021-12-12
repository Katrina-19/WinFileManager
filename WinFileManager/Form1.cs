using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFileManager
{
    public partial class Form1 : Form
    {
        private string FilePath = "D:";
        //private string cNode= "C:";
        private bool isFile=false;
        private string selectedItem = "";
        private const int BYTE_IN_KILOBYTE = 1000;
        private const int COLUMN_WIDTH = 120;
        //private string topLevelName = "Этот компьютер";
        private string[] viewModes = { "Крупные значки", "Мелкие значки", "Список", "Таблица", "Плитка" };
        private Dictionary<string, int> columnsFiles = new Dictionary<string, int>();
        private Dictionary<string, int> columnsDrives = new Dictionary<string, int>();
        private string[] columnsForFiles = { "Имя", "Размер", "Дата создания", "Дата изменения" };
        private string[] columnsForDrives = { "Имя", "Тип", "Файловая система", "Общий размер", "Свободно" };
        private List<string> prevStack;
        private List<string> nextStack;
        public Form1()
        {
            InitializeComponent();
            DriveTreeInit();
            cbView.SelectedIndex = 0;
            cbView.SelectedIndexChanged += cbView_SelectedIndexChanged;
            prevStack = new List<string>();
            nextStack = new List<string>();
        }

        private void Form1_Load(object sender,EventArgs e)
        {
            tbPath.Text= FilePath;
            loadFiles();
        }
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
        private void twDir_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            twDir.BeginUpdate();

            foreach (TreeNode node in e.Node.Nodes)
            {
                GetDirs(node);
            }

            twDir.EndUpdate();
        }
        public void loadFiles()
        {
            DirectoryInfo fileList;
            string tempPath = "";
            try
            {
                if (isFile)
                {
                    tempPath= FilePath + "/" + selectedItem;
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
                        listView1.Items.Add(dirs[i].Name,0);
                    }
                    label1.Text ="Files:" + (files.Count() + dirs.Count()).ToString();
                }
            }
            catch (Exception e)
            {

            }
        }
        public void removeSlash()
        {
            string path=tbPath.Text;
            if(path.LastIndexOf("/") == path.Length - 1)
            {
                tbPath.Text = path.Substring(0, path.Length-1);
            }
        }
        public void back()
        {
            try
            {
                removeSlash();
                string path=tbPath.Text;
                path=path.Substring(0,path.LastIndexOf("/"));
                isFile = false;
                tbPath.Text = path;
                removeSlash();
            }
            catch(Exception e)
            {

            }
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

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            selectedItem = e.Item.Text;
            FileAttributes attrs = File.GetAttributes(FilePath + "/" + selectedItem);
            if((attrs & FileAttributes.Directory)==FileAttributes.Directory)
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

        private void btnleft_Click(object sender, EventArgs e)
        {
            
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

        private void btnCut_Click(object sender, EventArgs e)
        {
           /* FileSystemInfo fsObject;
            string mypath = "";

            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Ыelect the location to move the file";
            dialog.ShowNewFolderButton = false;
            dialog.SelectedPath = tbPath.Text;
            mypath = dialog.SelectedPath;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string message = "";
                try
                {
                    if (fsObject is DirectoryInfo)
                    {
                        message = "Не возможно переместить каталог";
                        ((DirectoryInfo)fsObject).MoveTo(mypath);
                    }
                    else
                    {
                        message = "Не возможно переместить файл";
                        ((FileInfo)fsObject).MoveTo(mypath);
                    }
                    
                }
                catch
                {
                    MessageBox.Show(message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }
            //listView1.SelectedItems.Clear();FileSystemInfo fsObject*/
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
           /* string mypath = "";

            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Ыelect the location to move the file";
            dialog.ShowNewFolderButton = false;
            dialog.SelectedPath = tbPath.Text;
            mypath = dialog.SelectedPath;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string message = "";
                try
                {
                    message = "Не возможно переместить файл";
                    ((FileInfo)fsObject).CopyTo(mypath);
                }
                catch
                {
                    MessageBox.Show(message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }*/
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           /* string message = "";
            try
            {
                if (fsObject is DirectoryInfo)
                {
                    message = "Не возможно переместить каталог";
                    ((DirectoryInfo)fsObject).Delete(true);
                }
                else
                {
                    message = "Не возможно переместить файл";
                    ((FileInfo)fsObject).Delete();
                }
                //DirectoryInfo dirInfo = new DirectoryInfo(tbPath.Text);
                
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
            }
            ((FileInfo)fsObject).Delete();*/
        }
        void cbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbView.SelectedItem.ToString())
            {
                case "Крупные значки":
                    listView1.View = View.LargeIcon;
                    break;
                case "Мелкие значки":
                    listView1.View = View.SmallIcon;
                    break;
                case "Таблица":
                    listView1.View = View.Details;
                    listView1.FullRowSelect = true;
                    break;
                case "Список":
                    listView1.View = View.List;
                    break;
                case "Плитка":
                    listView1.View = View.Tile;
                    break;
                default:
                    MessageBox.Show("Неизвестный режим отображения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           // if(textBox1.Text==)
        }

        /*private void twDir_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            string currentPath = e.Node.FullPath;
            string newDirectoryName = e.Label;

            if (newDirectoryName == null || newDirectoryName.Trim().Length == 0)
            {
                e.CancelEdit = true;
                return;
            }

            string newFullName = Path.Combine(e.Node.Parent.FullPath, newDirectoryName);

            DirectoryInfo currentDirectory = new DirectoryInfo(currentPath);

            try
            {
                currentDirectory.MoveTo(newFullName);

                if (GetDirs(newFullName))
                {
                    DriveTreeInit();
                    tbPath.Text = newFullName;
                }
            }
            catch
            {
                MessageBox.Show("Невозможно переименовать каталог", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.CancelEdit = true;
            }
        }*/
    }
}
