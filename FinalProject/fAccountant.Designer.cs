
namespace FinalProject
{
    partial class fAccountant
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accountantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cNPMDataSet = new FinalProject.CNPMDataSet();
            this.cNPMDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aCCOUNTANTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aCCOUNTANTTableAdapter = new FinalProject.CNPMDataSetTableAdapters.ACCOUNTANTTableAdapter();
            this.tExport = new System.Windows.Forms.TabPage();
            this.tImport = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IsvImport = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbGoods = new System.Windows.Forms.ComboBox();
            this.btnAddToImport = new System.Windows.Forms.Button();
            this.numGoodsCount = new System.Windows.Forms.NumericUpDown();
            this.flpAdd = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvImport = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dtpkFormDate = new System.Windows.Forms.DateTimePicker();
            this.dtpkToDate = new System.Windows.Forms.DateTimePicker();
            this.btnView = new System.Windows.Forms.Button();
            this.tabReport = new System.Windows.Forms.TabControl();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cNPMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPMDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCCOUNTANTBindingSource)).BeginInit();
            this.tExport.SuspendLayout();
            this.tImport.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGoodsCount)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvImport)).BeginInit();
            this.panel6.SuspendLayout();
            this.tabReport.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountantToolStripMenuItem,
            this.thôngTinCáNhânToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1117, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // accountantToolStripMenuItem
            // 
            this.accountantToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem});
            this.accountantToolStripMenuItem.Name = "accountantToolStripMenuItem";
            this.accountantToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.accountantToolStripMenuItem.Text = "Accountant";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // cNPMDataSet
            // 
            this.cNPMDataSet.DataSetName = "CNPMDataSet";
            this.cNPMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cNPMDataSetBindingSource
            // 
            this.cNPMDataSetBindingSource.DataSource = this.cNPMDataSet;
            this.cNPMDataSetBindingSource.Position = 0;
            // 
            // aCCOUNTANTBindingSource
            // 
            this.aCCOUNTANTBindingSource.DataMember = "ACCOUNTANT";
            this.aCCOUNTANTBindingSource.DataSource = this.cNPMDataSet;
            // 
            // aCCOUNTANTTableAdapter
            // 
            this.aCCOUNTANTTableAdapter.ClearBeforeFill = true;
            // 
            // tExport
            // 
            this.tExport.Controls.Add(this.button8);
            this.tExport.Controls.Add(this.button4);
            this.tExport.Controls.Add(this.button5);
            this.tExport.Controls.Add(this.button6);
            this.tExport.Controls.Add(this.button7);
            this.tExport.Controls.Add(this.dataGridView1);
            this.tExport.Controls.Add(this.panel5);
            this.tExport.Controls.Add(this.panel4);
            this.tExport.Controls.Add(this.listView1);
            this.tExport.Location = new System.Drawing.Point(4, 25);
            this.tExport.Name = "tExport";
            this.tExport.Padding = new System.Windows.Forms.Padding(3);
            this.tExport.Size = new System.Drawing.Size(1298, 655);
            this.tExport.TabIndex = 1;
            this.tExport.Text = "Xuất kho";
            this.tExport.UseVisualStyleBackColor = true;
            // 
            // tImport
            // 
            this.tImport.Controls.Add(this.panel6);
            this.tImport.Controls.Add(this.panel3);
            this.tImport.Controls.Add(this.btnSave);
            this.tImport.Controls.Add(this.button1);
            this.tImport.Controls.Add(this.flpAdd);
            this.tImport.Controls.Add(this.panel2);
            this.tImport.Controls.Add(this.panel1);
            this.tImport.Controls.Add(this.btnEdit);
            this.tImport.Controls.Add(this.btnDelete);
            this.tImport.Location = new System.Drawing.Point(4, 25);
            this.tImport.Name = "tImport";
            this.tImport.Padding = new System.Windows.Forms.Padding(3);
            this.tImport.Size = new System.Drawing.Size(1298, 655);
            this.tImport.TabIndex = 0;
            this.tImport.Text = "Nhập kho";
            this.tImport.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(778, 395);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 53);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(584, 480);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(121, 53);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.IsvImport);
            this.panel1.Location = new System.Drawing.Point(6, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 486);
            this.panel1.TabIndex = 6;
            // 
            // IsvImport
            // 
            this.IsvImport.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader3});
            this.IsvImport.GridLines = true;
            this.IsvImport.HideSelection = false;
            this.IsvImport.Location = new System.Drawing.Point(0, 3);
            this.IsvImport.Name = "IsvImport";
            this.IsvImport.Size = new System.Drawing.Size(544, 445);
            this.IsvImport.TabIndex = 7;
            this.IsvImport.UseCompatibleStateImageBehavior = false;
            this.IsvImport.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Count";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Price";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Total Price";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.numGoodsCount);
            this.panel2.Controls.Add(this.btnAddToImport);
            this.panel2.Controls.Add(this.cbGoods);
            this.panel2.Controls.Add(this.cbCategory);
            this.panel2.Location = new System.Drawing.Point(6, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(547, 61);
            this.panel2.TabIndex = 7;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(3, 6);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(367, 24);
            this.cbCategory.TabIndex = 0;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // cbGoods
            // 
            this.cbGoods.FormattingEnabled = true;
            this.cbGoods.Location = new System.Drawing.Point(3, 36);
            this.cbGoods.Name = "cbGoods";
            this.cbGoods.Size = new System.Drawing.Size(367, 24);
            this.cbGoods.TabIndex = 1;
            // 
            // btnAddToImport
            // 
            this.btnAddToImport.Location = new System.Drawing.Point(376, 7);
            this.btnAddToImport.Name = "btnAddToImport";
            this.btnAddToImport.Size = new System.Drawing.Size(75, 51);
            this.btnAddToImport.TabIndex = 2;
            this.btnAddToImport.Text = "ADD";
            this.btnAddToImport.UseVisualStyleBackColor = true;
            this.btnAddToImport.Click += new System.EventHandler(this.btnAddToImport_Click);
            // 
            // numGoodsCount
            // 
            this.numGoodsCount.Location = new System.Drawing.Point(473, 22);
            this.numGoodsCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numGoodsCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numGoodsCount.Name = "numGoodsCount";
            this.numGoodsCount.Size = new System.Drawing.Size(71, 22);
            this.numGoodsCount.TabIndex = 3;
            this.numGoodsCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // flpAdd
            // 
            this.flpAdd.Location = new System.Drawing.Point(584, 395);
            this.flpAdd.Name = "flpAdd";
            this.flpAdd.Size = new System.Drawing.Size(121, 53);
            this.flpAdd.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(778, 481);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 51);
            this.button1.TabIndex = 9;
            this.button1.Text = "Print warehouse receipt";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(956, 395);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 52);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvImport);
            this.panel3.Location = new System.Drawing.Point(559, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(532, 317);
            this.panel3.TabIndex = 11;
            // 
            // dtgvImport
            // 
            this.dtgvImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvImport.Location = new System.Drawing.Point(4, 3);
            this.dtgvImport.Name = "dtgvImport";
            this.dtgvImport.RowHeadersWidth = 51;
            this.dtgvImport.RowTemplate.Height = 24;
            this.dtgvImport.Size = new System.Drawing.Size(525, 325);
            this.dtgvImport.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnView);
            this.panel6.Controls.Add(this.dtpkToDate);
            this.panel6.Controls.Add(this.dtpkFormDate);
            this.panel6.Location = new System.Drawing.Point(560, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(528, 38);
            this.panel6.TabIndex = 12;
            // 
            // dtpkFormDate
            // 
            this.dtpkFormDate.Location = new System.Drawing.Point(4, 4);
            this.dtpkFormDate.Name = "dtpkFormDate";
            this.dtpkFormDate.Size = new System.Drawing.Size(221, 22);
            this.dtpkFormDate.TabIndex = 0;
            // 
            // dtpkToDate
            // 
            this.dtpkToDate.Location = new System.Drawing.Point(299, 4);
            this.dtpkToDate.Name = "dtpkToDate";
            this.dtpkToDate.Size = new System.Drawing.Size(226, 22);
            this.dtpkToDate.TabIndex = 1;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(232, 2);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(61, 33);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            // 
            // tabReport
            // 
            this.tabReport.Controls.Add(this.tImport);
            this.tabReport.Controls.Add(this.tExport);
            this.tabReport.Location = new System.Drawing.Point(12, 31);
            this.tabReport.Name = "tabReport";
            this.tabReport.SelectedIndex = 0;
            this.tabReport.Size = new System.Drawing.Size(1306, 684);
            this.tabReport.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(9, 73);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(544, 445);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Name";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Count";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Price";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Total Price";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.numericUpDown1);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Controls.Add(this.comboBox2);
            this.panel4.Location = new System.Drawing.Point(6, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(547, 61);
            this.panel4.TabIndex = 9;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(473, 22);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(71, 22);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(376, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 51);
            this.button2.TabIndex = 2;
            this.button2.Text = "ADD";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(367, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(3, 6);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(367, 24);
            this.comboBox2.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.dateTimePicker1);
            this.panel5.Controls.Add(this.dateTimePicker2);
            this.panel5.Location = new System.Drawing.Point(561, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(528, 38);
            this.panel5.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(232, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 33);
            this.button3.TabIndex = 2;
            this.button3.Text = "View";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(299, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(226, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(4, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(221, 22);
            this.dateTimePicker2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(564, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(525, 325);
            this.dataGridView1.TabIndex = 14;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(961, 401);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 52);
            this.button4.TabIndex = 19;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(783, 487);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 51);
            this.button5.TabIndex = 18;
            this.button5.Text = "Print warehouse receipt";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(589, 486);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(121, 53);
            this.button6.TabIndex = 16;
            this.button6.Text = "Edit";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(783, 401);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(121, 53);
            this.button7.TabIndex = 15;
            this.button7.Text = "Delete";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(589, 400);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(121, 53);
            this.button8.TabIndex = 20;
            this.button8.Text = "Add";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // fAccountant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 626);
            this.Controls.Add(this.tabReport);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fAccountant";
            this.Text = "Acountant Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cNPMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cNPMDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aCCOUNTANTBindingSource)).EndInit();
            this.tExport.ResumeLayout(false);
            this.tImport.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numGoodsCount)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvImport)).EndInit();
            this.panel6.ResumeLayout(false);
            this.tabReport.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accountantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.BindingSource cNPMDataSetBindingSource;
        private CNPMDataSet cNPMDataSet;
        private System.Windows.Forms.BindingSource aCCOUNTANTBindingSource;
        private CNPMDataSetTableAdapters.ACCOUNTANTTableAdapter aCCOUNTANTTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.TabPage tExport;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.TabPage tImport;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DateTimePicker dtpkToDate;
        private System.Windows.Forms.DateTimePicker dtpkFormDate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvImport;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flpAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numGoodsCount;
        private System.Windows.Forms.Button btnAddToImport;
        private System.Windows.Forms.ComboBox cbGoods;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView IsvImport;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TabControl tabReport;
    }
}

