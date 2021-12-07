using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                DriveInfo di = new DriveInfo(drive);
                int driveImage;

                switch (di.DriveType)    //set the drive's icon
                {
                    case DriveType.CDRom:
                        driveImage = imageList1.Images.IndexOfKey("Hardrive.png");
                        break;
                    case DriveType.Network:
                        driveImage = 6;
                        break;
                    case DriveType.NoRootDirectory:
                        driveImage = 8;
                        break;
                    case DriveType.Unknown:
                        driveImage = 8;
                        break;
                    default:
                        driveImage = 2;
                        break;
                }
                TreeNode node = new TreeNode(drive.Substring(0, 1), driveImage, driveImage);
                node.Tag = drive;

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
                    DirectoryInfo rootDir = new DirectoryInfo(e.Node.Tag.ToString());
                    foreach (var file in rootDir.GetFiles())
                    {
                        TreeNode n = new TreeNode(file.Name, 13, 13);
                        e.Node.Nodes.Add(n);
                    }

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
                            node.ImageIndex = 12;
                            node.SelectedImageIndex = 12;
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
                }
                else
                {
                    fileList = new DirectoryInfo(FilePath);
                    FileInfo[] files = fileList.GetFiles();
                    DirectoryInfo[] dirs = fileList.GetDirectories();
                    listView1.Items.Clear();
                    for (int i = 0; i < files.Length; i++)
                    {
                        listView1.Items.Add(files[i].Name);
                    }
                    for (int i = 0; i < dirs.Length; i++)
                    {
                        listView1.Items.Add(dirs[i].Name);
                    }
                }
            }
            catch (Exception e)
            {

            }
        }
        private void twDir_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode t = e.Node;
            DirectoryInfo dirInf = t.Tag as DirectoryInfo;
            if (dirInf == null) { return; }
            FilePath = dirInf.FullName;
            loadFiles();
            tbPath.Text = FilePath;
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

        private void tbPath_TextChanged(object sender, EventArgs e)
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
