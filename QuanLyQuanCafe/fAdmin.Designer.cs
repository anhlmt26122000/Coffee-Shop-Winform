namespace QuanLyQuanCafe
{
    partial class fAdmin
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
            tcMain = new TabControl();
            tpBill = new TabPage();
            panel2 = new Panel();
            btnViewbill = new Button();
            dtpkTodate = new DateTimePicker();
            dtpkFromDate = new DateTimePicker();
            panel1 = new Panel();
            dtgvBill = new DataGridView();
            tpFood = new TabPage();
            panel6 = new Panel();
            txbSearchFoodName = new TextBox();
            btnSearchFood = new Button();
            panel5 = new Panel();
            panel10 = new Panel();
            nmFoodPrice = new NumericUpDown();
            label4 = new Label();
            panel9 = new Panel();
            cbCategory = new ComboBox();
            label3 = new Label();
            panel8 = new Panel();
            txbFoodName = new TextBox();
            label1 = new Label();
            panel7 = new Panel();
            txbFoodID = new TextBox();
            label2 = new Label();
            panel4 = new Panel();
            btnShowFood = new Button();
            btnUpdateFood = new Button();
            btnDeleteFood = new Button();
            btnAddFood = new Button();
            panel3 = new Panel();
            dtgvFood = new DataGridView();
            tpCategory = new TabPage();
            panel13 = new Panel();
            panel16 = new Panel();
            txbCategoryName = new TextBox();
            label7 = new Label();
            panel17 = new Panel();
            txbCategoryID = new TextBox();
            label8 = new Label();
            panel18 = new Panel();
            dtgvCategory = new DataGridView();
            panel12 = new Panel();
            btnShowCategory = new Button();
            btnUpdateCategory = new Button();
            btnDeleteCategory = new Button();
            btnAddCategory = new Button();
            tpTable = new TabPage();
            panel11 = new Panel();
            panel21 = new Panel();
            cbTableStatus = new ComboBox();
            label9 = new Label();
            panel14 = new Panel();
            txbTableName = new TextBox();
            label5 = new Label();
            panel15 = new Panel();
            textBox2 = new TextBox();
            label6 = new Label();
            panel19 = new Panel();
            dtgvTable = new DataGridView();
            panel20 = new Panel();
            btnShowTable = new Button();
            btnUpdateTable = new Button();
            btnDeleteTable = new Button();
            btnAddTable = new Button();
            tpAccount = new TabPage();
            panel23 = new Panel();
            btnResetPassword = new Button();
            panel25 = new Panel();
            cbAccountType = new ComboBox();
            label11 = new Label();
            panel26 = new Panel();
            txbDisplayName = new TextBox();
            label12 = new Label();
            panel27 = new Panel();
            txbUsername = new TextBox();
            label13 = new Label();
            panel28 = new Panel();
            btnShowAccount = new Button();
            btnUpdateAccount = new Button();
            btnDeleteAccount = new Button();
            btnAddAccount = new Button();
            panel29 = new Panel();
            dtgvAccount = new DataGridView();
            tcMain.SuspendLayout();
            tpBill.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvBill).BeginInit();
            tpFood.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodPrice).BeginInit();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvFood).BeginInit();
            tpCategory.SuspendLayout();
            panel13.SuspendLayout();
            panel16.SuspendLayout();
            panel17.SuspendLayout();
            panel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvCategory).BeginInit();
            panel12.SuspendLayout();
            tpTable.SuspendLayout();
            panel11.SuspendLayout();
            panel21.SuspendLayout();
            panel14.SuspendLayout();
            panel15.SuspendLayout();
            panel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvTable).BeginInit();
            panel20.SuspendLayout();
            tpAccount.SuspendLayout();
            panel23.SuspendLayout();
            panel25.SuspendLayout();
            panel26.SuspendLayout();
            panel27.SuspendLayout();
            panel28.SuspendLayout();
            panel29.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).BeginInit();
            SuspendLayout();
            // 
            // tcMain
            // 
            tcMain.Controls.Add(tpBill);
            tcMain.Controls.Add(tpFood);
            tcMain.Controls.Add(tpCategory);
            tcMain.Controls.Add(tpTable);
            tcMain.Controls.Add(tpAccount);
            tcMain.Location = new Point(2, 3);
            tcMain.Name = "tcMain";
            tcMain.SelectedIndex = 0;
            tcMain.Size = new Size(798, 442);
            tcMain.TabIndex = 0;
            // 
            // tpBill
            // 
            tpBill.Controls.Add(panel2);
            tpBill.Controls.Add(panel1);
            tpBill.Location = new Point(4, 24);
            tpBill.Name = "tpBill";
            tpBill.Padding = new Padding(3);
            tpBill.Size = new Size(790, 414);
            tpBill.TabIndex = 0;
            tpBill.Text = "Doanh thu";
            tpBill.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnViewbill);
            panel2.Controls.Add(dtpkTodate);
            panel2.Controls.Add(dtpkFromDate);
            panel2.Location = new Point(7, 7);
            panel2.Name = "panel2";
            panel2.Size = new Size(775, 26);
            panel2.TabIndex = 1;
            // 
            // btnViewbill
            // 
            btnViewbill.Location = new Point(351, 3);
            btnViewbill.Name = "btnViewbill";
            btnViewbill.Size = new Size(75, 23);
            btnViewbill.TabIndex = 2;
            btnViewbill.Text = "Thống kê";
            btnViewbill.UseVisualStyleBackColor = true;
            // 
            // dtpkTodate
            // 
            dtpkTodate.Location = new Point(572, 3);
            dtpkTodate.Name = "dtpkTodate";
            dtpkTodate.Size = new Size(200, 23);
            dtpkTodate.TabIndex = 1;
            // 
            // dtpkFromDate
            // 
            dtpkFromDate.Location = new Point(3, 3);
            dtpkFromDate.Name = "dtpkFromDate";
            dtpkFromDate.Size = new Size(200, 23);
            dtpkFromDate.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(dtgvBill);
            panel1.Location = new Point(6, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 369);
            panel1.TabIndex = 0;
            // 
            // dtgvBill
            // 
            dtgvBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvBill.Location = new Point(3, 3);
            dtgvBill.Name = "dtgvBill";
            dtgvBill.Size = new Size(770, 363);
            dtgvBill.TabIndex = 0;
            // 
            // tpFood
            // 
            tpFood.Controls.Add(panel6);
            tpFood.Controls.Add(panel5);
            tpFood.Controls.Add(panel4);
            tpFood.Controls.Add(panel3);
            tpFood.Location = new Point(4, 24);
            tpFood.Name = "tpFood";
            tpFood.Padding = new Padding(3);
            tpFood.Size = new Size(790, 414);
            tpFood.TabIndex = 1;
            tpFood.Text = "Thức ăn";
            tpFood.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(txbSearchFoodName);
            panel6.Controls.Add(btnSearchFood);
            panel6.Location = new Point(456, 6);
            panel6.Name = "panel6";
            panel6.Size = new Size(326, 55);
            panel6.TabIndex = 3;
            // 
            // txbSearchFoodName
            // 
            txbSearchFoodName.Location = new Point(8, 17);
            txbSearchFoodName.Name = "txbSearchFoodName";
            txbSearchFoodName.Size = new Size(234, 23);
            txbSearchFoodName.TabIndex = 5;
            // 
            // btnSearchFood
            // 
            btnSearchFood.Location = new Point(248, 3);
            btnSearchFood.Name = "btnSearchFood";
            btnSearchFood.Size = new Size(75, 48);
            btnSearchFood.TabIndex = 4;
            btnSearchFood.Text = "Tìm kiếm";
            btnSearchFood.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel10);
            panel5.Controls.Add(panel9);
            panel5.Controls.Add(panel8);
            panel5.Controls.Add(panel7);
            panel5.Location = new Point(456, 71);
            panel5.Name = "panel5";
            panel5.Size = new Size(326, 337);
            panel5.TabIndex = 2;
            // 
            // panel10
            // 
            panel10.Controls.Add(nmFoodPrice);
            panel10.Controls.Add(label4);
            panel10.Location = new Point(6, 149);
            panel10.Name = "panel10";
            panel10.Size = new Size(315, 39);
            panel10.TabIndex = 4;
            // 
            // nmFoodPrice
            // 
            nmFoodPrice.Location = new Point(96, 7);
            nmFoodPrice.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nmFoodPrice.Name = "nmFoodPrice";
            nmFoodPrice.Size = new Size(218, 23);
            nmFoodPrice.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 11);
            label4.Name = "label4";
            label4.Size = new Size(40, 19);
            label4.TabIndex = 0;
            label4.Text = "Giá:";
            // 
            // panel9
            // 
            panel9.Controls.Add(cbCategory);
            panel9.Controls.Add(label3);
            panel9.Location = new Point(8, 102);
            panel9.Name = "panel9";
            panel9.Size = new Size(315, 39);
            panel9.TabIndex = 3;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(94, 7);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(218, 23);
            cbCategory.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 11);
            label3.Name = "label3";
            label3.Size = new Size(93, 19);
            label3.TabIndex = 0;
            label3.Text = "Danh mục:";
            // 
            // panel8
            // 
            panel8.Controls.Add(txbFoodName);
            panel8.Controls.Add(label1);
            panel8.Location = new Point(8, 57);
            panel8.Name = "panel8";
            panel8.Size = new Size(315, 39);
            panel8.TabIndex = 2;
            // 
            // txbFoodName
            // 
            txbFoodName.Location = new Point(94, 7);
            txbFoodName.Name = "txbFoodName";
            txbFoodName.Size = new Size(218, 23);
            txbFoodName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 11);
            label1.Name = "label1";
            label1.Size = new Size(82, 19);
            label1.TabIndex = 0;
            label1.Text = "Tên món:";
            // 
            // panel7
            // 
            panel7.Controls.Add(txbFoodID);
            panel7.Controls.Add(label2);
            panel7.Location = new Point(8, 12);
            panel7.Name = "panel7";
            panel7.Size = new Size(315, 39);
            panel7.TabIndex = 1;
            // 
            // txbFoodID
            // 
            txbFoodID.Location = new Point(94, 7);
            txbFoodID.Name = "txbFoodID";
            txbFoodID.ReadOnly = true;
            txbFoodID.Size = new Size(218, 23);
            txbFoodID.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 11);
            label2.Name = "label2";
            label2.Size = new Size(31, 19);
            label2.TabIndex = 0;
            label2.Text = "ID:";
            // 
            // panel4
            // 
            panel4.Controls.Add(btnShowFood);
            panel4.Controls.Add(btnUpdateFood);
            panel4.Controls.Add(btnDeleteFood);
            panel4.Controls.Add(btnAddFood);
            panel4.Location = new Point(11, 6);
            panel4.Name = "panel4";
            panel4.Size = new Size(432, 55);
            panel4.TabIndex = 1;
            // 
            // btnShowFood
            // 
            btnShowFood.Location = new Point(251, 3);
            btnShowFood.Name = "btnShowFood";
            btnShowFood.Size = new Size(75, 48);
            btnShowFood.TabIndex = 3;
            btnShowFood.Text = "Xem";
            btnShowFood.UseVisualStyleBackColor = true;
            // 
            // btnUpdateFood
            // 
            btnUpdateFood.Location = new Point(170, 3);
            btnUpdateFood.Name = "btnUpdateFood";
            btnUpdateFood.Size = new Size(75, 48);
            btnUpdateFood.TabIndex = 2;
            btnUpdateFood.Text = "Sửa";
            btnUpdateFood.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFood
            // 
            btnDeleteFood.Location = new Point(89, 4);
            btnDeleteFood.Name = "btnDeleteFood";
            btnDeleteFood.Size = new Size(75, 48);
            btnDeleteFood.TabIndex = 1;
            btnDeleteFood.Text = "Xóa";
            btnDeleteFood.UseVisualStyleBackColor = true;
            // 
            // btnAddFood
            // 
            btnAddFood.Location = new Point(8, 4);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(75, 48);
            btnAddFood.TabIndex = 0;
            btnAddFood.Text = "Thêm";
            btnAddFood.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(dtgvFood);
            panel3.Location = new Point(11, 67);
            panel3.Name = "panel3";
            panel3.Size = new Size(432, 341);
            panel3.TabIndex = 0;
            // 
            // dtgvFood
            // 
            dtgvFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvFood.Location = new Point(3, 4);
            dtgvFood.Name = "dtgvFood";
            dtgvFood.Size = new Size(426, 334);
            dtgvFood.TabIndex = 0;
            // 
            // tpCategory
            // 
            tpCategory.Controls.Add(panel13);
            tpCategory.Controls.Add(panel18);
            tpCategory.Controls.Add(panel12);
            tpCategory.Location = new Point(4, 24);
            tpCategory.Name = "tpCategory";
            tpCategory.Padding = new Padding(3);
            tpCategory.Size = new Size(790, 414);
            tpCategory.TabIndex = 2;
            tpCategory.Text = "Danh mục";
            tpCategory.UseVisualStyleBackColor = true;
            // 
            // panel13
            // 
            panel13.Controls.Add(panel16);
            panel13.Controls.Add(panel17);
            panel13.Location = new Point(456, 67);
            panel13.Name = "panel13";
            panel13.Size = new Size(326, 337);
            panel13.TabIndex = 7;
            // 
            // panel16
            // 
            panel16.Controls.Add(txbCategoryName);
            panel16.Controls.Add(label7);
            panel16.Location = new Point(8, 57);
            panel16.Name = "panel16";
            panel16.Size = new Size(315, 39);
            panel16.TabIndex = 2;
            // 
            // txbCategoryName
            // 
            txbCategoryName.Location = new Point(125, 7);
            txbCategoryName.Name = "txbCategoryName";
            txbCategoryName.Size = new Size(187, 23);
            txbCategoryName.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(6, 11);
            label7.Name = "label7";
            label7.Size = new Size(124, 19);
            label7.TabIndex = 0;
            label7.Text = "Tên danh mục:";
            // 
            // panel17
            // 
            panel17.Controls.Add(txbCategoryID);
            panel17.Controls.Add(label8);
            panel17.Location = new Point(8, 12);
            panel17.Name = "panel17";
            panel17.Size = new Size(315, 39);
            panel17.TabIndex = 1;
            // 
            // txbCategoryID
            // 
            txbCategoryID.Location = new Point(125, 7);
            txbCategoryID.Name = "txbCategoryID";
            txbCategoryID.ReadOnly = true;
            txbCategoryID.Size = new Size(187, 23);
            txbCategoryID.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(6, 11);
            label8.Name = "label8";
            label8.Size = new Size(31, 19);
            label8.TabIndex = 0;
            label8.Text = "ID:";
            // 
            // panel18
            // 
            panel18.Controls.Add(dtgvCategory);
            panel18.Location = new Point(3, 70);
            panel18.Name = "panel18";
            panel18.Size = new Size(432, 341);
            panel18.TabIndex = 6;
            // 
            // dtgvCategory
            // 
            dtgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCategory.Location = new Point(3, 4);
            dtgvCategory.Name = "dtgvCategory";
            dtgvCategory.Size = new Size(424, 325);
            dtgvCategory.TabIndex = 0;
            // 
            // panel12
            // 
            panel12.Controls.Add(btnShowCategory);
            panel12.Controls.Add(btnUpdateCategory);
            panel12.Controls.Add(btnDeleteCategory);
            panel12.Controls.Add(btnAddCategory);
            panel12.Location = new Point(3, 6);
            panel12.Name = "panel12";
            panel12.Size = new Size(432, 55);
            panel12.TabIndex = 4;
            // 
            // btnShowCategory
            // 
            btnShowCategory.Location = new Point(251, 3);
            btnShowCategory.Name = "btnShowCategory";
            btnShowCategory.Size = new Size(75, 48);
            btnShowCategory.TabIndex = 3;
            btnShowCategory.Text = "Xem";
            btnShowCategory.UseVisualStyleBackColor = true;
            // 
            // btnUpdateCategory
            // 
            btnUpdateCategory.Location = new Point(170, 3);
            btnUpdateCategory.Name = "btnUpdateCategory";
            btnUpdateCategory.Size = new Size(75, 48);
            btnUpdateCategory.TabIndex = 2;
            btnUpdateCategory.Text = "Sửa";
            btnUpdateCategory.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.Location = new Point(89, 4);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(75, 48);
            btnDeleteCategory.TabIndex = 1;
            btnDeleteCategory.Text = "Xóa";
            btnDeleteCategory.UseVisualStyleBackColor = true;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(8, 4);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(75, 48);
            btnAddCategory.TabIndex = 0;
            btnAddCategory.Text = "Thêm";
            btnAddCategory.UseVisualStyleBackColor = true;
            // 
            // tpTable
            // 
            tpTable.Controls.Add(panel11);
            tpTable.Controls.Add(panel19);
            tpTable.Controls.Add(panel20);
            tpTable.Location = new Point(4, 24);
            tpTable.Name = "tpTable";
            tpTable.Padding = new Padding(3);
            tpTable.Size = new Size(790, 414);
            tpTable.TabIndex = 3;
            tpTable.Text = "Bàn ăn";
            tpTable.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            panel11.Controls.Add(panel21);
            panel11.Controls.Add(panel14);
            panel11.Controls.Add(panel15);
            panel11.Location = new Point(459, 66);
            panel11.Name = "panel11";
            panel11.Size = new Size(326, 337);
            panel11.TabIndex = 10;
            // 
            // panel21
            // 
            panel21.Controls.Add(cbTableStatus);
            panel21.Controls.Add(label9);
            panel21.Location = new Point(8, 102);
            panel21.Name = "panel21";
            panel21.Size = new Size(315, 39);
            panel21.TabIndex = 3;
            // 
            // cbTableStatus
            // 
            cbTableStatus.FormattingEnabled = true;
            cbTableStatus.Location = new Point(125, 7);
            cbTableStatus.Name = "cbTableStatus";
            cbTableStatus.Size = new Size(187, 23);
            cbTableStatus.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(6, 11);
            label9.Name = "label9";
            label9.Size = new Size(91, 19);
            label9.TabIndex = 0;
            label9.Text = "Trạng thái:";
            // 
            // panel14
            // 
            panel14.Controls.Add(txbTableName);
            panel14.Controls.Add(label5);
            panel14.Location = new Point(8, 57);
            panel14.Name = "panel14";
            panel14.Size = new Size(315, 39);
            panel14.TabIndex = 2;
            // 
            // txbTableName
            // 
            txbTableName.Location = new Point(125, 7);
            txbTableName.Name = "txbTableName";
            txbTableName.Size = new Size(187, 23);
            txbTableName.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 11);
            label5.Name = "label5";
            label5.Size = new Size(77, 19);
            label5.TabIndex = 0;
            label5.Text = "Tên bàn:";
            // 
            // panel15
            // 
            panel15.Controls.Add(textBox2);
            panel15.Controls.Add(label6);
            panel15.Location = new Point(8, 12);
            panel15.Name = "panel15";
            panel15.Size = new Size(315, 39);
            panel15.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(125, 7);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(187, 23);
            textBox2.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(6, 11);
            label6.Name = "label6";
            label6.Size = new Size(31, 19);
            label6.TabIndex = 0;
            label6.Text = "ID:";
            // 
            // panel19
            // 
            panel19.Controls.Add(dtgvTable);
            panel19.Location = new Point(6, 69);
            panel19.Name = "panel19";
            panel19.Size = new Size(432, 341);
            panel19.TabIndex = 9;
            // 
            // dtgvTable
            // 
            dtgvTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvTable.Location = new Point(3, 4);
            dtgvTable.Name = "dtgvTable";
            dtgvTable.Size = new Size(424, 325);
            dtgvTable.TabIndex = 0;
            // 
            // panel20
            // 
            panel20.Controls.Add(btnShowTable);
            panel20.Controls.Add(btnUpdateTable);
            panel20.Controls.Add(btnDeleteTable);
            panel20.Controls.Add(btnAddTable);
            panel20.Location = new Point(6, 5);
            panel20.Name = "panel20";
            panel20.Size = new Size(432, 55);
            panel20.TabIndex = 8;
            // 
            // btnShowTable
            // 
            btnShowTable.Location = new Point(251, 3);
            btnShowTable.Name = "btnShowTable";
            btnShowTable.Size = new Size(75, 48);
            btnShowTable.TabIndex = 3;
            btnShowTable.Text = "Xem";
            btnShowTable.UseVisualStyleBackColor = true;
            // 
            // btnUpdateTable
            // 
            btnUpdateTable.Location = new Point(170, 3);
            btnUpdateTable.Name = "btnUpdateTable";
            btnUpdateTable.Size = new Size(75, 48);
            btnUpdateTable.TabIndex = 2;
            btnUpdateTable.Text = "Sửa";
            btnUpdateTable.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTable
            // 
            btnDeleteTable.Location = new Point(89, 4);
            btnDeleteTable.Name = "btnDeleteTable";
            btnDeleteTable.Size = new Size(75, 48);
            btnDeleteTable.TabIndex = 1;
            btnDeleteTable.Text = "Xóa";
            btnDeleteTable.UseVisualStyleBackColor = true;
            // 
            // btnAddTable
            // 
            btnAddTable.Location = new Point(8, 4);
            btnAddTable.Name = "btnAddTable";
            btnAddTable.Size = new Size(75, 48);
            btnAddTable.TabIndex = 0;
            btnAddTable.Text = "Thêm";
            btnAddTable.UseVisualStyleBackColor = true;
            // 
            // tpAccount
            // 
            tpAccount.Controls.Add(panel23);
            tpAccount.Controls.Add(panel28);
            tpAccount.Controls.Add(panel29);
            tpAccount.Location = new Point(4, 24);
            tpAccount.Name = "tpAccount";
            tpAccount.Padding = new Padding(3);
            tpAccount.Size = new Size(790, 414);
            tpAccount.TabIndex = 4;
            tpAccount.Text = "Tài khoản";
            tpAccount.UseVisualStyleBackColor = true;
            // 
            // panel23
            // 
            panel23.Controls.Add(btnResetPassword);
            panel23.Controls.Add(panel25);
            panel23.Controls.Add(panel26);
            panel23.Controls.Add(panel27);
            panel23.Location = new Point(455, 71);
            panel23.Name = "panel23";
            panel23.Size = new Size(326, 337);
            panel23.TabIndex = 6;
            // 
            // btnResetPassword
            // 
            btnResetPassword.Location = new Point(212, 147);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(111, 48);
            btnResetPassword.TabIndex = 4;
            btnResetPassword.Text = "Đặt lại mật khẩu";
            btnResetPassword.UseVisualStyleBackColor = true;
            // 
            // panel25
            // 
            panel25.Controls.Add(cbAccountType);
            panel25.Controls.Add(label11);
            panel25.Location = new Point(8, 102);
            panel25.Name = "panel25";
            panel25.Size = new Size(315, 39);
            panel25.TabIndex = 3;
            // 
            // cbAccountType
            // 
            cbAccountType.FormattingEnabled = true;
            cbAccountType.Location = new Point(130, 7);
            cbAccountType.Name = "cbAccountType";
            cbAccountType.Size = new Size(182, 23);
            cbAccountType.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(6, 11);
            label11.Name = "label11";
            label11.Size = new Size(122, 19);
            label11.TabIndex = 0;
            label11.Text = "Loại tài khoản:";
            // 
            // panel26
            // 
            panel26.Controls.Add(txbDisplayName);
            panel26.Controls.Add(label12);
            panel26.Location = new Point(8, 57);
            panel26.Name = "panel26";
            panel26.Size = new Size(315, 39);
            panel26.TabIndex = 2;
            // 
            // txbDisplayName
            // 
            txbDisplayName.Location = new Point(130, 7);
            txbDisplayName.Name = "txbDisplayName";
            txbDisplayName.Size = new Size(182, 23);
            txbDisplayName.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(6, 11);
            label12.Name = "label12";
            label12.Size = new Size(104, 19);
            label12.TabIndex = 0;
            label12.Text = "Tên hiển thị:";
            // 
            // panel27
            // 
            panel27.Controls.Add(txbUsername);
            panel27.Controls.Add(label13);
            panel27.Location = new Point(8, 12);
            panel27.Name = "panel27";
            panel27.Size = new Size(315, 39);
            panel27.TabIndex = 1;
            // 
            // txbUsername
            // 
            txbUsername.Location = new Point(130, 7);
            txbUsername.Name = "txbUsername";
            txbUsername.ReadOnly = true;
            txbUsername.Size = new Size(182, 23);
            txbUsername.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(6, 11);
            label13.Name = "label13";
            label13.Size = new Size(118, 19);
            label13.TabIndex = 0;
            label13.Text = "Tên tài khoản:";
            // 
            // panel28
            // 
            panel28.Controls.Add(btnShowAccount);
            panel28.Controls.Add(btnUpdateAccount);
            panel28.Controls.Add(btnDeleteAccount);
            panel28.Controls.Add(btnAddAccount);
            panel28.Location = new Point(10, 6);
            panel28.Name = "panel28";
            panel28.Size = new Size(432, 55);
            panel28.TabIndex = 5;
            // 
            // btnShowAccount
            // 
            btnShowAccount.Location = new Point(251, 3);
            btnShowAccount.Name = "btnShowAccount";
            btnShowAccount.Size = new Size(75, 48);
            btnShowAccount.TabIndex = 3;
            btnShowAccount.Text = "Xem";
            btnShowAccount.UseVisualStyleBackColor = true;
            // 
            // btnUpdateAccount
            // 
            btnUpdateAccount.Location = new Point(170, 3);
            btnUpdateAccount.Name = "btnUpdateAccount";
            btnUpdateAccount.Size = new Size(75, 48);
            btnUpdateAccount.TabIndex = 2;
            btnUpdateAccount.Text = "Sửa";
            btnUpdateAccount.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.Location = new Point(89, 4);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(75, 48);
            btnDeleteAccount.TabIndex = 1;
            btnDeleteAccount.Text = "Xóa";
            btnDeleteAccount.UseVisualStyleBackColor = true;
            // 
            // btnAddAccount
            // 
            btnAddAccount.Location = new Point(8, 4);
            btnAddAccount.Name = "btnAddAccount";
            btnAddAccount.Size = new Size(75, 48);
            btnAddAccount.TabIndex = 0;
            btnAddAccount.Text = "Thêm";
            btnAddAccount.UseVisualStyleBackColor = true;
            // 
            // panel29
            // 
            panel29.Controls.Add(dtgvAccount);
            panel29.Location = new Point(10, 67);
            panel29.Name = "panel29";
            panel29.Size = new Size(432, 341);
            panel29.TabIndex = 4;
            // 
            // dtgvAccount
            // 
            dtgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAccount.Location = new Point(3, 4);
            dtgvAccount.Name = "dtgvAccount";
            dtgvAccount.Size = new Size(426, 334);
            dtgvAccount.TabIndex = 0;
            // 
            // fAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tcMain);
            Name = "fAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            tcMain.ResumeLayout(false);
            tpBill.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvBill).EndInit();
            tpFood.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodPrice).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvFood).EndInit();
            tpCategory.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            panel17.ResumeLayout(false);
            panel17.PerformLayout();
            panel18.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvCategory).EndInit();
            panel12.ResumeLayout(false);
            tpTable.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel21.ResumeLayout(false);
            panel21.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            panel19.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvTable).EndInit();
            panel20.ResumeLayout(false);
            tpAccount.ResumeLayout(false);
            panel23.ResumeLayout(false);
            panel25.ResumeLayout(false);
            panel25.PerformLayout();
            panel26.ResumeLayout(false);
            panel26.PerformLayout();
            panel27.ResumeLayout(false);
            panel27.PerformLayout();
            panel28.ResumeLayout(false);
            panel29.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcMain;
        private TabPage tpBill;
        private TabPage tpFood;
        private TabPage tpCategory;
        private TabPage tpTable;
        private TabPage tpAccount;
        private Panel panel2;
        private DateTimePicker dtpkFromDate;
        private Panel panel1;
        private DataGridView dtgvBill;
        private Button btnViewbill;
        private DateTimePicker dtpkTodate;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private TextBox txbSearchFoodName;
        private Button btnSearchFood;
        private Button btnShowFood;
        private Button btnUpdateFood;
        private Button btnDeleteFood;
        private Button btnAddFood;
        private DataGridView dtgvFood;
        private Panel panel7;
        private TextBox txbFoodID;
        private Label label2;
        private Panel panel8;
        private TextBox txbFoodName;
        private Label label1;
        private Panel panel9;
        private Label label3;
        private ComboBox cbCategory;
        private Panel panel10;
        private NumericUpDown nmFoodPrice;
        private Label label4;
        private Panel panel13;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private Panel panel16;
        private TextBox txbCategoryName;
        private Label label7;
        private Panel panel17;
        private TextBox txbCategoryID;
        private Label label8;
        private Panel panel18;
        private DataGridView dtgvCategory;
        private TextBox textBox1;
        private Panel panel12;
        private Button btnShowCategory;
        private Button btnUpdateCategory;
        private Button btnDeleteCategory;
        private Button btnAddCategory;
        private Panel panel11;
        private Panel panel21;
        private Label label9;
        private Panel panel14;
        private TextBox txbTableName;
        private Label label5;
        private Panel panel15;
        private TextBox textBox2;
        private Label label6;
        private Panel panel19;
        private DataGridView dtgvTable;
        private Panel panel20;
        private Button btnShowTable;
        private Button btnUpdateTable;
        private Button btnDeleteTable;
        private Button btnAddTable;
        private ComboBox cbTableStatus;
        private Panel panel23;
        private Panel panel24;
        private Label label10;
        private Panel panel25;
        private ComboBox cbAccountType;
        private Label label11;
        private Panel panel26;
        private TextBox txbDisplayName;
        private TextBox textBox3;
        private Label label12;
        private Panel panel27;
        private TextBox textBox4;
        private Label label13;
        private Panel panel28;
        private Button btnShowAccount;
        private Button btnUpdateAccount;
        private Button btnDeleteAccount;
        private Button btnAddAccount;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Panel panel29;
        private DataGridView dtgvAccount;
        private Button btnResetPassword;
        private TextBox txbUsername;
    }
}