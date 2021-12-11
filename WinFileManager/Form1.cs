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
        private string FilePath = "home";
        //private string cNode= "C:";
        private bool isFile=false;
        private string selectedItem = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender,EventArgs e)
        {
            //get a list of the drives
            tbPath.Text= FilePath;
            loadFiles();
            string[] drives = Environment.GetLogicalDrives();

            foreach (string drive in drives)
            {
                TreeNode node = new TreeNode();
                node.Tag = drive;
                node.Text = drive;
                DriveInfo di = new DriveInfo(drive);
                int driveImage;

                switch (di.DriveType)    //set the drive's icon
                {
                    case DriveType.CDRom:
                        driveImage = 2;
                        break;
                    case DriveType.Network:
                        driveImage = 1;
                        break;
                    case DriveType.NoRootDirectory:
                        driveImage = 4;
                        break;
                    case DriveType.Unknown:
                        driveImage = 3;
                        break;
                    default:
                        driveImage = 0;
                        break;
                }
                twDir.Nodes.Add(node);
                node.EnsureVisible();
                twDir.Refresh();

                if (di.IsReady == true)
                    node.Nodes.Add("...");

                twDir.Nodes.Add(node);
            }
        }
        private void twDir_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes.Count > 0)
            {
                if (e.Node.Nodes[0].Text == "..." && e.Node.Nodes[0].Tag == null)
                {
                    e.Node.Nodes.Clear();

                    //get the list of sub direcotires
                    string[] dirs = Directory.GetDirectories(e.Node.Tag.ToString());

                    //add files of rootdirectory
                    /*DirectoryInfo rootDir = new DirectoryInfo(e.Node.Tag.ToString());
                    foreach (var file in rootDir.GetFiles())
                    {
                        TreeNode n = new TreeNode(file.Name, 13, 13);
                        e.Node.Nodes.Add(n);
                    }*/

                    foreach (string dir in dirs)
                    {
                        DirectoryInfo di = new DirectoryInfo(dir);
                        TreeNode node = new TreeNode(di.Name, 0, 1);

                        try
                        {
                            //keep the directory's full path in the tag for use later
                            node.Tag = dir;

                            //if the directory has sub directories add the place holder
                            if (di.GetDirectories().Count() > 0)
                                node.Nodes.Add(null, "...", 0, 0);

                            foreach (var file in di.GetFiles())
                            {
                                TreeNode n = new TreeNode(file.Name, 13, 13);
                                node.Nodes.Add(n);
                            }

                        }
                        catch (UnauthorizedAccessException)
                        {
                            //display a locked folder icon
                            node.ImageIndex = 5;
                            node.SelectedImageIndex = 5;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "DirectoryLister",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            e.Node.Nodes.Add(node);
                        }
                    }
                }
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
            TreeNode t = e.Node;
            DirectoryInfo dirInf = t.Tag as DirectoryInfo;
            //if (dirInf == null) { return; }
            FilePath = dirInf.Name;
            tbPath.Text = FilePath;
            loadFiles();
            
            //this.UpdateList(dirInf);
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
        /* private void UpdateList(DirectoryInfo dirInf)
{
this.listBox1.Items.Clear();
string[] names = dirInf.GetDirectories(e.Node.Tag.ToString());
foreach (string name in names)
{
ListViewItem lvi = new ListViewItem(name);
Directory rType = dirInf.GetType();
lvi.Tag = rType;

string value = null;
if (rType == RegistryValueKind.Binary)
{
byte[] valueObj = dirInf.GetValue(name) as byte[];
foreach (byte item in valueObj)
{
value += item.ToString("X2") + " ";
}
}
else
{
value = dirInf.GetValue(name).ToString();
}

string type = rType.ToString();
lvi.SubItems.Add(type);
lvi.SubItems.Add(value.Trim());
this.listBox1.Items.Add(lvi);
}
}*/
    }
}
