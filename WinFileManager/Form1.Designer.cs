
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbView = new System.Windows.Forms.ComboBox();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnShare = new System.Windows.Forms.Button();
            this.btnPath = new System.Windows.Forms.Button();
            this.btnPaste = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnCut = new System.Windows.Forms.Button();
            this.btnFolder = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnup = new System.Windows.Forms.Button();
            this.btnright = new System.Windows.Forms.Button();
            this.btnleft = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // twDir
            // 
            this.twDir.ImageIndex = 2;
            this.twDir.ImageList = this.imageList1;
            this.twDir.Location = new System.Drawing.Point(1, 150);
            this.twDir.Name = "twDir";
            this.twDir.SelectedImageIndex = 0;
            this.twDir.Size = new System.Drawing.Size(182, 404);
            this.twDir.TabIndex = 0;
            this.twDir.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.twDir_BeforeExpand);
            this.twDir.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.twDir_AfterSelect);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbView);
            this.groupBox1.Controls.Add(this.cbSort);
            this.groupBox1.Controls.Add(this.btnSettings);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnShare);
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
            // cbView
            // 
            this.cbView.FormattingEnabled = true;
            this.cbView.Location = new System.Drawing.Point(593, 34);
            this.cbView.Name = "cbView";
            this.cbView.Size = new System.Drawing.Size(136, 24);
            this.cbView.TabIndex = 9;
            // 
            // cbSort
            // 
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Location = new System.Drawing.Point(432, 34);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(137, 24);
            this.cbSort.TabIndex = 8;
            // 
            // btnSettings
            // 
            this.btnSettings.BackgroundImage = global::WinFileManager.Properties.Resources.setting;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSettings.Location = new System.Drawing.Point(735, 21);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(52, 48);
            this.btnSettings.TabIndex = 7;
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::WinFileManager.Properties.Resources.delete;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.Location = new System.Drawing.Point(356, 21);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(51, 48);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnShare
            // 
            this.btnShare.BackgroundImage = global::WinFileManager.Properties.Resources.share;
            this.btnShare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShare.Location = new System.Drawing.Point(298, 21);
            this.btnShare.Name = "btnShare";
            this.btnShare.Size = new System.Drawing.Size(52, 48);
            this.btnShare.TabIndex = 5;
            this.btnShare.UseVisualStyleBackColor = true;
            // 
            // btnPath
            // 
            this.btnPath.BackgroundImage = global::WinFileManager.Properties.Resources.link;
            this.btnPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPath.Location = new System.Drawing.Point(241, 21);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(51, 48);
            this.btnPath.TabIndex = 4;
            this.btnPath.UseVisualStyleBackColor = true;
            // 
            // btnPaste
            // 
            this.btnPaste.BackgroundImage = global::WinFileManager.Properties.Resources.paste;
            this.btnPaste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPaste.Location = new System.Drawing.Point(184, 21);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(51, 48);
            this.btnPaste.TabIndex = 3;
            this.btnPaste.UseVisualStyleBackColor = true;
            // 
            // btnCopy
            // 
            this.btnCopy.BackgroundImage = global::WinFileManager.Properties.Resources.copy;
            this.btnCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCopy.Location = new System.Drawing.Point(124, 21);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(54, 48);
            this.btnCopy.TabIndex = 2;
            this.btnCopy.UseVisualStyleBackColor = true;
            // 
            // btnCut
            // 
            this.btnCut.BackgroundImage = global::WinFileManager.Properties.Resources.cut;
            this.btnCut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCut.Location = new System.Drawing.Point(66, 21);
            this.btnCut.Name = "btnCut";
            this.btnCut.Size = new System.Drawing.Size(52, 48);
            this.btnCut.TabIndex = 1;
            this.btnCut.UseVisualStyleBackColor = true;
            // 
            // btnFolder
            // 
            this.btnFolder.BackColor = System.Drawing.Color.Transparent;
            this.btnFolder.BackgroundImage = global::WinFileManager.Properties.Resources.add_folder;
            this.btnFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFolder.Location = new System.Drawing.Point(11, 21);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(49, 48);
            this.btnFolder.TabIndex = 0;
            this.btnFolder.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnup);
            this.groupBox2.Controls.Add(this.btnright);
            this.groupBox2.Controls.Add(this.btnleft);
            this.groupBox2.Location = new System.Drawing.Point(1, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 63);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // btnup
            // 
            this.btnup.BackgroundImage = global::WinFileManager.Properties.Resources.free_icon_up_arrow_109583;
            this.btnup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnup.Location = new System.Drawing.Point(124, 21);
            this.btnup.Name = "btnup";
            this.btnup.Size = new System.Drawing.Size(52, 42);
            this.btnup.TabIndex = 7;
            this.btnup.UseVisualStyleBackColor = true;
            // 
            // btnright
            // 
            this.btnright.BackgroundImage = global::WinFileManager.Properties.Resources.free_icon_right_arrow_109617;
            this.btnright.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnright.Location = new System.Drawing.Point(66, 21);
            this.btnright.Name = "btnright";
            this.btnright.Size = new System.Drawing.Size(52, 42);
            this.btnright.TabIndex = 6;
            this.btnright.UseVisualStyleBackColor = true;
            // 
            // btnleft
            // 
            this.btnleft.BackgroundImage = global::WinFileManager.Properties.Resources.free_icon_left_arrow_109618;
            this.btnleft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnleft.Location = new System.Drawing.Point(11, 21);
            this.btnleft.Name = "btnleft";
            this.btnleft.Size = new System.Drawing.Size(49, 42);
            this.btnleft.TabIndex = 5;
            this.btnleft.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(617, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 22);
            this.textBox1.TabIndex = 3;
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
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Folder.png");
            this.imageList1.Images.SetKeyName(1, "Network.png");
            this.imageList1.Images.SetKeyName(2, "Hardrive.png");
            this.imageList1.Images.SetKeyName(3, "Folder Grey.png");
            this.imageList1.Images.SetKeyName(4, "Blank.png");
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.imageList2;
            this.listView1.Location = new System.Drawing.Point(189, 150);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(607, 404);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "14.png");
            this.imageList2.Images.SetKeyName(1, "15.png");
            this.imageList2.Images.SetKeyName(2, "24.png");
            this.imageList2.Images.SetKeyName(3, "26.png");
            this.imageList2.Images.SetKeyName(4, "28.png");
            this.imageList2.Images.SetKeyName(5, "29.png");
            this.imageList2.Images.SetKeyName(6, "30.png");
            this.imageList2.Images.SetKeyName(7, "31.png");
            this.imageList2.Images.SetKeyName(8, "33.png");
            this.imageList2.Images.SetKeyName(9, "34.png");
            this.imageList2.Images.SetKeyName(10, "37.png");
            this.imageList2.Images.SetKeyName(11, "38.png");
            this.imageList2.Images.SetKeyName(12, "39.png");
            this.imageList2.Images.SetKeyName(13, "40.png");
            this.imageList2.Images.SetKeyName(14, "41.png");
            this.imageList2.Images.SetKeyName(15, "42.png");
            this.imageList2.Images.SetKeyName(16, "43.png");
            this.imageList2.Images.SetKeyName(17, "44.png");
            this.imageList2.Images.SetKeyName(18, "45.png");
            this.imageList2.Images.SetKeyName(19, "48.png");
            this.imageList2.Images.SetKeyName(20, "49.png");
            this.imageList2.Images.SetKeyName(21, "50.png");
            this.imageList2.Images.SetKeyName(22, "52.png");
            this.imageList2.Images.SetKeyName(23, "53.png");
            this.imageList2.Images.SetKeyName(24, "56.png");
            this.imageList2.Images.SetKeyName(25, "58.png");
            this.imageList2.Images.SetKeyName(26, "60.png");
            this.imageList2.Images.SetKeyName(27, "61.png");
            this.imageList2.Images.SetKeyName(28, "62.png");
            this.imageList2.Images.SetKeyName(29, "63.png");
            this.imageList2.Images.SetKeyName(30, "64.png");
            this.imageList2.Images.SetKeyName(31, "65.png");
            this.imageList2.Images.SetKeyName(32, "73.png");
            this.imageList2.Images.SetKeyName(33, "75.png");
            this.imageList2.Images.SetKeyName(34, "91.png");
            this.imageList2.Images.SetKeyName(35, "92.png");
            this.imageList2.Images.SetKeyName(36, "94.png");
            this.imageList2.Images.SetKeyName(37, "96.png");
            this.imageList2.Images.SetKeyName(38, "103.png");
            this.imageList2.Images.SetKeyName(39, "104.png");
            this.imageList2.Images.SetKeyName(40, "105.png");
            this.imageList2.Images.SetKeyName(41, "106.png");
            this.imageList2.Images.SetKeyName(42, "107.png");
            this.imageList2.Images.SetKeyName(43, "116.png");
            this.imageList2.Images.SetKeyName(44, "120.png");
            this.imageList2.Images.SetKeyName(45, "124.png");
            this.imageList2.Images.SetKeyName(46, "125.png");
            this.imageList2.Images.SetKeyName(47, "130.png");
            this.imageList2.Images.SetKeyName(48, "135.png");
            this.imageList2.Images.SetKeyName(49, "136.png");
            this.imageList2.Images.SetKeyName(50, "139.png");
            this.imageList2.Images.SetKeyName(51, "140.png");
            this.imageList2.Images.SetKeyName(52, "141.png");
            this.imageList2.Images.SetKeyName(53, "142.png");
            this.imageList2.Images.SetKeyName(54, "148.png");
            this.imageList2.Images.SetKeyName(55, "149.png");
            this.imageList2.Images.SetKeyName(56, "157.png");
            this.imageList2.Images.SetKeyName(57, "163.png");
            this.imageList2.Images.SetKeyName(58, "164.png");
            this.imageList2.Images.SetKeyName(59, "169.png");
            this.imageList2.Images.SetKeyName(60, "170.png");
            this.imageList2.Images.SetKeyName(61, "172.png");
            this.imageList2.Images.SetKeyName(62, "173.png");
            this.imageList2.Images.SetKeyName(63, "176.png");
            this.imageList2.Images.SetKeyName(64, "180.png");
            this.imageList2.Images.SetKeyName(65, "1010.png");
            this.imageList2.Images.SetKeyName(66, "1021.png");
            this.imageList2.Images.SetKeyName(67, "1027.png");
            this.imageList2.Images.SetKeyName(68, "1030.png");
            this.imageList2.Images.SetKeyName(69, "1032.png");
            this.imageList2.Images.SetKeyName(70, "1033.png");
            this.imageList2.Images.SetKeyName(71, "1034.png");
            this.imageList2.Images.SetKeyName(72, "1035.png");
            this.imageList2.Images.SetKeyName(73, "1036.png");
            this.imageList2.Images.SetKeyName(74, "1041.png");
            this.imageList2.Images.SetKeyName(75, "1042.png");
            this.imageList2.Images.SetKeyName(76, "1400.png");
            this.imageList2.Images.SetKeyName(77, "1401.png");
            this.imageList2.Images.SetKeyName(78, "1402.png");
            this.imageList2.Images.SetKeyName(79, "1403.png");
            this.imageList2.Images.SetKeyName(80, "1404.png");
            this.imageList2.Images.SetKeyName(81, "1405.png");
            this.imageList2.Images.SetKeyName(82, "add-folder.png");
            this.imageList2.Images.SetKeyName(83, "Audio file.png");
            this.imageList2.Images.SetKeyName(84, "Audio.png");
            this.imageList2.Images.SetKeyName(85, "Blank.png");
            this.imageList2.Images.SetKeyName(86, "Briefcase.png");
            this.imageList2.Images.SetKeyName(87, "Camera.png");
            this.imageList2.Images.SetKeyName(88, "Computer.png");
            this.imageList2.Images.SetKeyName(89, "config.png");
            this.imageList2.Images.SetKeyName(90, "Control Panel.png");
            this.imageList2.Images.SetKeyName(91, "copy.png");
            this.imageList2.Images.SetKeyName(92, "cut.png");
            this.imageList2.Images.SetKeyName(93, "Defrag.png");
            this.imageList2.Images.SetKeyName(94, "delete.png");
            this.imageList2.Images.SetKeyName(95, "Desktop.png");
            this.imageList2.Images.SetKeyName(96, "Device 2.png");
            this.imageList2.Images.SetKeyName(97, "Device.png");
            this.imageList2.Images.SetKeyName(98, "dll.png");
            this.imageList2.Images.SetKeyName(99, "exe.png");
            this.imageList2.Images.SetKeyName(100, "Folder 3D.png");
            this.imageList2.Images.SetKeyName(101, "Folder Blue.png");
            this.imageList2.Images.SetKeyName(102, "Folder check.png");
            this.imageList2.Images.SetKeyName(103, "Folder Contacts.png");
            this.imageList2.Images.SetKeyName(104, "Folder Desktop.png");
            this.imageList2.Images.SetKeyName(105, "Folder Documents.png");
            this.imageList2.Images.SetKeyName(106, "Folder Downloads.png");
            this.imageList2.Images.SetKeyName(107, "Folder Favourites.png");
            this.imageList2.Images.SetKeyName(108, "Folder Fonts.png");
            this.imageList2.Images.SetKeyName(109, "Folder Games.png");
            this.imageList2.Images.SetKeyName(110, "Folder Green.png");
            this.imageList2.Images.SetKeyName(111, "Folder Grey.png");
            this.imageList2.Images.SetKeyName(112, "Folder Links 2.png");
            this.imageList2.Images.SetKeyName(113, "Folder Links.png");
            this.imageList2.Images.SetKeyName(114, "Folder Live - Back.png");
            this.imageList2.Images.SetKeyName(115, "Folder Live - Front.png");
            this.imageList2.Images.SetKeyName(116, "Folder Music.png");
            this.imageList2.Images.SetKeyName(117, "Folder OneDrive.png");
            this.imageList2.Images.SetKeyName(118, "Folder Open.png");
            this.imageList2.Images.SetKeyName(119, "Folder Pictures.png");
            this.imageList2.Images.SetKeyName(120, "Folder Search.png");
            this.imageList2.Images.SetKeyName(121, "Folder Searches.png");
            this.imageList2.Images.SetKeyName(122, "Folder User 2.png");
            this.imageList2.Images.SetKeyName(123, "Folder User.png");
            this.imageList2.Images.SetKeyName(124, "Folder Videos.png");
            this.imageList2.Images.SetKeyName(125, "Folder.png");
            this.imageList2.Images.SetKeyName(126, "free-icon-left-arrow-109618.png");
            this.imageList2.Images.SetKeyName(127, "free-icon-right-arrow-109617.png");
            this.imageList2.Images.SetKeyName(128, "free-icon-up-arrow-109583.png");
            this.imageList2.Images.SetKeyName(129, "Hardrive Windows.png");
            this.imageList2.Images.SetKeyName(130, "Hardrive.png");
            this.imageList2.Images.SetKeyName(131, "Hardware.png");
            this.imageList2.Images.SetKeyName(132, "Help 2.png");
            this.imageList2.Images.SetKeyName(133, "Help.png");
            this.imageList2.Images.SetKeyName(134, "History.png");
            this.imageList2.Images.SetKeyName(135, "HomeGroup.png");
            this.imageList2.Images.SetKeyName(136, "Hotspot.png");
            this.imageList2.Images.SetKeyName(137, "Info.png");
            this.imageList2.Images.SetKeyName(138, "Key.png");
            this.imageList2.Images.SetKeyName(139, "Keyboard.png");
            this.imageList2.Images.SetKeyName(140, "Library Library.png");
            this.imageList2.Images.SetKeyName(141, "Library Music.png");
            this.imageList2.Images.SetKeyName(142, "Library TV.png");
            this.imageList2.Images.SetKeyName(143, "Library Videos.png");
            this.imageList2.Images.SetKeyName(144, "Library.png");
            this.imageList2.Images.SetKeyName(145, "Libray Documents.png");
            this.imageList2.Images.SetKeyName(146, "Libray Pictures.png");
            this.imageList2.Images.SetKeyName(147, "link.png");
            this.imageList2.Images.SetKeyName(148, "Lock.png");
            this.imageList2.Images.SetKeyName(149, "Media.png");
            this.imageList2.Images.SetKeyName(150, "Multimedia file.png");
            this.imageList2.Images.SetKeyName(151, "Music file.png");
            this.imageList2.Images.SetKeyName(152, "Network.png");
            this.imageList2.Images.SetKeyName(153, "Notes.png");
            this.imageList2.Images.SetKeyName(154, "One Drive.png");
            this.imageList2.Images.SetKeyName(155, "paste.png");
            this.imageList2.Images.SetKeyName(156, "Personalization.png");
            this.imageList2.Images.SetKeyName(157, "Phone.png");
            this.imageList2.Images.SetKeyName(158, "Photos file.png");
            this.imageList2.Images.SetKeyName(159, "Photos.png");
            this.imageList2.Images.SetKeyName(160, "Pictures file.png");
            this.imageList2.Images.SetKeyName(161, "Printer 2.png");
            this.imageList2.Images.SetKeyName(162, "Printer.png");
            this.imageList2.Images.SetKeyName(163, "Programs.png");
            this.imageList2.Images.SetKeyName(164, "Quick Access.png");
            this.imageList2.Images.SetKeyName(165, "Recent.png");
            this.imageList2.Images.SetKeyName(166, "Region.png");
            this.imageList2.Images.SetKeyName(167, "Run 1.png");
            this.imageList2.Images.SetKeyName(168, "Run.png");
            this.imageList2.Images.SetKeyName(169, "Scanner.png");
            this.imageList2.Images.SetKeyName(170, "Screensaver.png");
            this.imageList2.Images.SetKeyName(171, "Search.png");
            this.imageList2.Images.SetKeyName(172, "Security.png");
            this.imageList2.Images.SetKeyName(173, "setting.png");
            this.imageList2.Images.SetKeyName(174, "Settings 2.png");
            this.imageList2.Images.SetKeyName(175, "Settings.png");
            this.imageList2.Images.SetKeyName(176, "share.png");
            this.imageList2.Images.SetKeyName(177, "SHIDI_SHIELD_INTERNAL.png");
            this.imageList2.Images.SetKeyName(178, "Shield.png");
            this.imageList2.Images.SetKeyName(179, "Stop.png");
            this.imageList2.Images.SetKeyName(180, "Tasks.png");
            this.imageList2.Images.SetKeyName(181, "Trash Empty.png");
            this.imageList2.Images.SetKeyName(182, "Trash Full.png");
            this.imageList2.Images.SetKeyName(183, "User.png");
            this.imageList2.Images.SetKeyName(184, "Users.png");
            this.imageList2.Images.SetKeyName(185, "Video device.png");
            this.imageList2.Images.SetKeyName(186, "Video file.png");
            this.imageList2.Images.SetKeyName(187, "Videos file.png");
            this.imageList2.Images.SetKeyName(188, "Warning.png");
            this.imageList2.Images.SetKeyName(189, "x.png");
            this.imageList2.Images.SetKeyName(190, "Zip.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 585);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.twDir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView twDir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnup;
        private System.Windows.Forms.Button btnright;
        private System.Windows.Forms.Button btnleft;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnShare;
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
    }
}

