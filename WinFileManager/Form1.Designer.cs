
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
            this.twDir = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.cbView = new System.Windows.Forms.ComboBox();
            this.btnup = new System.Windows.Forms.Button();
            this.btnright = new System.Windows.Forms.Button();
            this.btnleft = new System.Windows.Forms.Button();
            this.btnShare = new System.Windows.Forms.Button();
            this.btnPath = new System.Windows.Forms.Button();
            this.btnPaste = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnCut = new System.Windows.Forms.Button();
            this.btnFolder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // twDir
            // 
            this.twDir.Location = new System.Drawing.Point(1, 150);
            this.twDir.Name = "twDir";
            this.twDir.Size = new System.Drawing.Size(182, 404);
            this.twDir.TabIndex = 0;
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(189, 150);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(607, 404);
            this.listBox1.TabIndex = 2;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(617, 102);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 36);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(189, 102);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(422, 36);
            this.textBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 560);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
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
            // cbSort
            // 
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Location = new System.Drawing.Point(432, 34);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(137, 24);
            this.cbSort.TabIndex = 8;
            // 
            // cbView
            // 
            this.cbView.FormattingEnabled = true;
            this.cbView.Location = new System.Drawing.Point(593, 34);
            this.cbView.Name = "cbView";
            this.cbView.Size = new System.Drawing.Size(136, 24);
            this.cbView.TabIndex = 9;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Path:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(617, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Search:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 585);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.twDir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView twDir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnup;
        private System.Windows.Forms.Button btnright;
        private System.Windows.Forms.Button btnleft;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
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
    }
}

