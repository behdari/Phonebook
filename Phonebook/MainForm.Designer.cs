using PresentationControls;
using System.Windows.Forms;
namespace Phonebook
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PresentationControls.CheckBoxProperties checkBoxProperties1 = new PresentationControls.CheckBoxProperties();
            this.categoryCheckboxComboBox = new PresentationControls.CheckBoxComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonClearSearchTextBox = new System.Windows.Forms.Button();
            this.labelSearch = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderDescription = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderTelegramNumber = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderFaxNumber = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderMobileNumber = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderLandlineNumber = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderOrganization = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderLastName = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderFirstName = new System.Windows.Forms.ColumnHeader();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgrammerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightToLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftToRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.christianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.persianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFontSize8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFontSize10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFontSize12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFontSize14 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFontSize16 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFontSize18 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoryCheckboxComboBox
            // 
            checkBoxProperties1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.categoryCheckboxComboBox.CheckBoxProperties = checkBoxProperties1;
            this.categoryCheckboxComboBox.DisplayMemberSingleItem = "";
            this.categoryCheckboxComboBox.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.categoryCheckboxComboBox.FormattingEnabled = true;
            this.categoryCheckboxComboBox.Location = new System.Drawing.Point(656, 3);
            this.categoryCheckboxComboBox.Name = "categoryCheckboxComboBox";
            this.categoryCheckboxComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.categoryCheckboxComboBox.Size = new System.Drawing.Size(138, 28);
            this.categoryCheckboxComboBox.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.listView1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.851852F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.03704F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.9462F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(907, 540);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.269526F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.73048F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel2.Controls.Add(this.textBoxSearch, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonClearSearchTextBox, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelSearch, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.categoryCheckboxComboBox, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(901, 31);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSearch.Enabled = false;
            this.textBoxSearch.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSearch.Location = new System.Drawing.Point(57, 3);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(593, 27);
            this.textBoxSearch.TabIndex = 0;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // buttonClearSearchTextBox
            // 
            this.buttonClearSearchTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonClearSearchTextBox.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClearSearchTextBox.Location = new System.Drawing.Point(800, 3);
            this.buttonClearSearchTextBox.Name = "buttonClearSearchTextBox";
            this.buttonClearSearchTextBox.Size = new System.Drawing.Size(98, 25);
            this.buttonClearSearchTextBox.TabIndex = 6;
            this.buttonClearSearchTextBox.Text = "پاک کردن";
            this.buttonClearSearchTextBox.UseVisualStyleBackColor = true;
            this.buttonClearSearchTextBox.Click += new System.EventHandler(this.buttonClearSearchTextBox_Click);
            // 
            // labelSearch
            // 
            this.labelSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSearch.Location = new System.Drawing.Point(3, 0);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(47, 31);
            this.labelSearch.TabIndex = 5;
            this.labelSearch.Text = "جستجو : ";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.buttonDelete, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonNew, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonEdit, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 483);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(901, 54);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.Location = new System.Drawing.Point(700, 7);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 40);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "حذف";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNew.Enabled = false;
            this.buttonNew.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNew.Location = new System.Drawing.Point(100, 7);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(100, 40);
            this.buttonNew.TabIndex = 0;
            this.buttonNew.Text = "جدید";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.buttonEdit.Enabled = false;
            this.buttonEdit.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEdit.Location = new System.Drawing.Point(400, 7);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(100, 40);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "ویرایش";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderDescription,
            this.columnHeaderTelegramNumber,
            this.columnHeaderFaxNumber,
            this.columnHeaderMobileNumber,
            this.columnHeaderLandlineNumber,
            this.columnHeaderOrganization,
            this.columnHeaderLastName,
            this.columnHeaderFirstName});
            this.listView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Enabled = false;
            this.listView1.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(3, 40);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(901, 437);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeaderDescription
            // 
            this.columnHeaderDescription.Text = "توضیحات";
            this.columnHeaderDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderDescription.Width = 260;
            // 
            // columnHeaderTelegramNumber
            // 
            this.columnHeaderTelegramNumber.Text = "شماره تلگرام";
            this.columnHeaderTelegramNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderTelegramNumber.Width = 220;
            // 
            // columnHeaderFaxNumber
            // 
            this.columnHeaderFaxNumber.Text = "فکس";
            this.columnHeaderFaxNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderFaxNumber.Width = 220;
            // 
            // columnHeaderMobileNumber
            // 
            this.columnHeaderMobileNumber.Text = "موبایل";
            this.columnHeaderMobileNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderMobileNumber.Width = 220;
            // 
            // columnHeaderLandlineNumber
            // 
            this.columnHeaderLandlineNumber.Text = "تلفن";
            this.columnHeaderLandlineNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderLandlineNumber.Width = 220;
            // 
            // columnHeaderOrganization
            // 
            this.columnHeaderOrganization.Text = "سازمان";
            this.columnHeaderOrganization.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderOrganization.Width = 250;
            // 
            // columnHeaderLastName
            // 
            this.columnHeaderLastName.Text = "نام خانوادگی";
            this.columnHeaderLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderLastName.Width = 250;
            // 
            // columnHeaderFirstName
            // 
            this.columnHeaderFirstName.Text = "نام";
            this.columnHeaderFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderFirstName.Width = 250;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(907, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutProgrammerToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutProgrammerToolStripMenuItem
            // 
            this.aboutProgrammerToolStripMenuItem.Name = "aboutProgrammerToolStripMenuItem";
            this.aboutProgrammerToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.aboutProgrammerToolStripMenuItem.Text = "About Programmer";
            this.aboutProgrammerToolStripMenuItem.Click += new System.EventHandler(this.aboutProgrammerToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newUserToolStripMenuItem,
            this.changeUserToolStripMenuItem,
            this.changeInfoToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // newUserToolStripMenuItem
            // 
            this.newUserToolStripMenuItem.Name = "newUserToolStripMenuItem";
            this.newUserToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.newUserToolStripMenuItem.Text = "Create New User";
            this.newUserToolStripMenuItem.Click += new System.EventHandler(this.newUserToolStripMenuItem_Click);
            // 
            // changeUserToolStripMenuItem
            // 
            this.changeUserToolStripMenuItem.Name = "changeUserToolStripMenuItem";
            this.changeUserToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.changeUserToolStripMenuItem.Text = "Change User";
            this.changeUserToolStripMenuItem.Click += new System.EventHandler(this.changeUserToolStripMenuItem_Click);
            // 
            // changeInfoToolStripMenuItem
            // 
            this.changeInfoToolStripMenuItem.Enabled = false;
            this.changeInfoToolStripMenuItem.Name = "changeInfoToolStripMenuItem";
            this.changeInfoToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.changeInfoToolStripMenuItem.Text = "Change Info";
            this.changeInfoToolStripMenuItem.Click += new System.EventHandler(this.changeInfoToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rightToLeftToolStripMenuItem,
            this.leftToRightToolStripMenuItem,
            this.datesToolStripMenuItem,
            this.fontSizeToolStripMenuItem});
            this.settingsToolStripMenuItem.Enabled = false;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // rightToLeftToolStripMenuItem
            // 
            this.rightToLeftToolStripMenuItem.CheckOnClick = true;
            this.rightToLeftToolStripMenuItem.Name = "rightToLeftToolStripMenuItem";
            this.rightToLeftToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.rightToLeftToolStripMenuItem.Text = "Right To Left";
            this.rightToLeftToolStripMenuItem.Click += new System.EventHandler(this.rightToLeftToolStripMenuItem_Click);
            // 
            // leftToRightToolStripMenuItem
            // 
            this.leftToRightToolStripMenuItem.Checked = true;
            this.leftToRightToolStripMenuItem.CheckOnClick = true;
            this.leftToRightToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.leftToRightToolStripMenuItem.Name = "leftToRightToolStripMenuItem";
            this.leftToRightToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.leftToRightToolStripMenuItem.Text = "Left To Right";
            this.leftToRightToolStripMenuItem.Click += new System.EventHandler(this.leftToRightToolStripMenuItem_Click);
            // 
            // datesToolStripMenuItem
            // 
            this.datesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.christianToolStripMenuItem,
            this.persianToolStripMenuItem});
            this.datesToolStripMenuItem.Name = "datesToolStripMenuItem";
            this.datesToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.datesToolStripMenuItem.Text = "Dates";
            // 
            // christianToolStripMenuItem
            // 
            this.christianToolStripMenuItem.CheckOnClick = true;
            this.christianToolStripMenuItem.Name = "christianToolStripMenuItem";
            this.christianToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.christianToolStripMenuItem.Text = "Christian";
            this.christianToolStripMenuItem.Click += new System.EventHandler(this.christianToolStripMenuItem_Click);
            // 
            // persianToolStripMenuItem
            // 
            this.persianToolStripMenuItem.Checked = true;
            this.persianToolStripMenuItem.CheckOnClick = true;
            this.persianToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.persianToolStripMenuItem.Name = "persianToolStripMenuItem";
            this.persianToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.persianToolStripMenuItem.Text = "Persian";
            this.persianToolStripMenuItem.Click += new System.EventHandler(this.persianToolStripMenuItem_Click);
            // 
            // fontSizeToolStripMenuItem
            // 
            this.fontSizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFontSize8,
            this.toolStripMenuItemFontSize10,
            this.toolStripMenuItemFontSize12,
            this.toolStripMenuItemFontSize14,
            this.toolStripMenuItemFontSize16,
            this.toolStripMenuItemFontSize18});
            this.fontSizeToolStripMenuItem.Name = "fontSizeToolStripMenuItem";
            this.fontSizeToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.fontSizeToolStripMenuItem.Text = "Font Size ";
            // 
            // toolStripMenuItemFontSize8
            // 
            this.toolStripMenuItemFontSize8.CheckOnClick = true;
            this.toolStripMenuItemFontSize8.Name = "toolStripMenuItemFontSize8";
            this.toolStripMenuItemFontSize8.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItemFontSize8.Text = "8";
            this.toolStripMenuItemFontSize8.Click += new System.EventHandler(this.toolStripMenuItemFontSize_Click);
            // 
            // toolStripMenuItemFontSize10
            // 
            this.toolStripMenuItemFontSize10.Checked = true;
            this.toolStripMenuItemFontSize10.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemFontSize10.Name = "toolStripMenuItemFontSize10";
            this.toolStripMenuItemFontSize10.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItemFontSize10.Text = "10";
            this.toolStripMenuItemFontSize10.Click += new System.EventHandler(this.toolStripMenuItemFontSize_Click);
            // 
            // toolStripMenuItemFontSize12
            // 
            this.toolStripMenuItemFontSize12.CheckOnClick = true;
            this.toolStripMenuItemFontSize12.Name = "toolStripMenuItemFontSize12";
            this.toolStripMenuItemFontSize12.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItemFontSize12.Text = "12";
            this.toolStripMenuItemFontSize12.Click += new System.EventHandler(this.toolStripMenuItemFontSize_Click);
            // 
            // toolStripMenuItemFontSize14
            // 
            this.toolStripMenuItemFontSize14.CheckOnClick = true;
            this.toolStripMenuItemFontSize14.Name = "toolStripMenuItemFontSize14";
            this.toolStripMenuItemFontSize14.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItemFontSize14.Text = "14";
            this.toolStripMenuItemFontSize14.Click += new System.EventHandler(this.toolStripMenuItemFontSize_Click);
            // 
            // toolStripMenuItemFontSize16
            // 
            this.toolStripMenuItemFontSize16.CheckOnClick = true;
            this.toolStripMenuItemFontSize16.Name = "toolStripMenuItemFontSize16";
            this.toolStripMenuItemFontSize16.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItemFontSize16.Text = "16";
            this.toolStripMenuItemFontSize16.Click += new System.EventHandler(this.toolStripMenuItemFontSize_Click);
            // 
            // toolStripMenuItemFontSize18
            // 
            this.toolStripMenuItemFontSize18.CheckOnClick = true;
            this.toolStripMenuItemFontSize18.Name = "toolStripMenuItemFontSize18";
            this.toolStripMenuItemFontSize18.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItemFontSize18.Text = "18";
            this.toolStripMenuItemFontSize18.Click += new System.EventHandler(this.toolStripMenuItemFontSize_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(907, 564);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhoneBook";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rightToLeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leftToRightToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newUserToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderFirstName;
        private System.Windows.Forms.ColumnHeader columnHeaderOrganization;
        private System.Windows.Forms.ColumnHeader columnHeaderMobileNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderLastName;
        private System.Windows.Forms.ToolStripMenuItem aboutProgrammerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFontSize8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFontSize12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFontSize14;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFontSize16;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFontSize18;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFontSize10;
        private System.Windows.Forms.ToolStripMenuItem changeInfoToolStripMenuItem;
        private System.Windows.Forms.Button buttonClearSearchTextBox;
        private System.Windows.Forms.ColumnHeader columnHeaderFaxNumber;
        private System.Windows.Forms.ToolStripMenuItem datesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem christianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem persianToolStripMenuItem;
        private ColumnHeader columnHeaderTelegramNumber;
        private ColumnHeader columnHeaderLandlineNumber;
        private ColumnHeader columnHeaderDescription;
        //private CheckBoxComboBox categoryCheckboxComboBox;
        private ToolStripMenuItem toolStripMenuItem1;
        private CheckBoxComboBox categoryCheckboxComboBox;
    }
}

