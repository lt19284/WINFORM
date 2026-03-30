namespace QLCF
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
            tcAdmin = new TabControl();
            tpBill = new TabPage();
            tpFood = new TabPage();
            tpCategory = new TabPage();
            tpTable = new TabPage();
            tpAcc = new TabPage();
            panel1 = new Panel();
            panel2 = new Panel();
            dtgvBill = new DataGridView();
            dtpkFromDate = new DateTimePicker();
            dtpkToDate = new DateTimePicker();
            btnView = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            dtgvFood = new DataGridView();
            btnAddFood = new Button();
            btnDeleteFood = new Button();
            btnFix = new Button();
            btnShowFood = new Button();
            btnSearch = new Button();
            txtSearchFood = new TextBox();
            txbID = new TextBox();
            panel8 = new Panel();
            label1 = new Label();
            label2 = new Label();
            txbNameFood = new TextBox();
            panel9 = new Panel();
            label3 = new Label();
            panel10 = new Panel();
            comboBox1 = new ComboBox();
            label4 = new Label();
            panel11 = new Panel();
            numericUpDown1 = new NumericUpDown();
            tcAdmin.SuspendLayout();
            tpBill.SuspendLayout();
            tpFood.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvBill).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvFood).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // tcAdmin
            // 
            tcAdmin.Controls.Add(tpBill);
            tcAdmin.Controls.Add(tpFood);
            tcAdmin.Controls.Add(tpCategory);
            tcAdmin.Controls.Add(tpTable);
            tcAdmin.Controls.Add(tpAcc);
            tcAdmin.Location = new Point(4, 6);
            tcAdmin.Name = "tcAdmin";
            tcAdmin.SelectedIndex = 0;
            tcAdmin.Size = new Size(1168, 578);
            tcAdmin.TabIndex = 0;
            // 
            // tpBill
            // 
            tpBill.Controls.Add(panel2);
            tpBill.Controls.Add(panel1);
            tpBill.Location = new Point(4, 29);
            tpBill.Name = "tpBill";
            tpBill.Padding = new Padding(3);
            tpBill.Size = new Size(1160, 545);
            tpBill.TabIndex = 0;
            tpBill.Text = "Doanh Thu";
            tpBill.UseVisualStyleBackColor = true;
            // 
            // tpFood
            // 
            tpFood.Controls.Add(panel3);
            tpFood.Location = new Point(4, 29);
            tpFood.Name = "tpFood";
            tpFood.Padding = new Padding(3);
            tpFood.Size = new Size(1160, 545);
            tpFood.TabIndex = 1;
            tpFood.Text = "Thức Ăn";
            tpFood.UseVisualStyleBackColor = true;
            // 
            // tpCategory
            // 
            tpCategory.Location = new Point(4, 29);
            tpCategory.Name = "tpCategory";
            tpCategory.Padding = new Padding(3);
            tpCategory.Size = new Size(1160, 545);
            tpCategory.TabIndex = 2;
            tpCategory.Text = "Danh Mục";
            tpCategory.UseVisualStyleBackColor = true;
            // 
            // tpTable
            // 
            tpTable.Location = new Point(4, 29);
            tpTable.Name = "tpTable";
            tpTable.Padding = new Padding(3);
            tpTable.Size = new Size(1160, 545);
            tpTable.TabIndex = 3;
            tpTable.Text = "Bàn Ăn";
            tpTable.UseVisualStyleBackColor = true;
            // 
            // tpAcc
            // 
            tpAcc.Location = new Point(4, 29);
            tpAcc.Name = "tpAcc";
            tpAcc.Padding = new Padding(3);
            tpAcc.Size = new Size(1160, 545);
            tpAcc.TabIndex = 4;
            tpAcc.Text = "Tài Khoản";
            tpAcc.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(dtgvBill);
            panel1.Location = new Point(6, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(1148, 500);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnView);
            panel2.Controls.Add(dtpkToDate);
            panel2.Controls.Add(dtpkFromDate);
            panel2.Location = new Point(7, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1146, 34);
            panel2.TabIndex = 1;
            // 
            // dtgvBill
            // 
            dtgvBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvBill.Location = new Point(3, 3);
            dtgvBill.Name = "dtgvBill";
            dtgvBill.RowHeadersWidth = 51;
            dtgvBill.Size = new Size(1142, 494);
            dtgvBill.TabIndex = 0;
            // 
            // dtpkFromDate
            // 
            dtpkFromDate.Location = new Point(3, 3);
            dtpkFromDate.Name = "dtpkFromDate";
            dtpkFromDate.Size = new Size(274, 27);
            dtpkFromDate.TabIndex = 0;
            // 
            // dtpkToDate
            // 
            dtpkToDate.Location = new Point(283, 3);
            dtpkToDate.Name = "dtpkToDate";
            dtpkToDate.Size = new Size(271, 27);
            dtpkToDate.TabIndex = 1;
            // 
            // btnView
            // 
            btnView.Location = new Point(560, 2);
            btnView.Name = "btnView";
            btnView.Size = new Size(94, 29);
            btnView.TabIndex = 2;
            btnView.Text = "Kiểm Tra";
            btnView.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1154, 537);
            panel3.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(dtgvFood);
            panel4.Location = new Point(3, 61);
            panel4.Name = "panel4";
            panel4.Size = new Size(584, 470);
            panel4.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnShowFood);
            panel5.Controls.Add(btnFix);
            panel5.Controls.Add(btnDeleteFood);
            panel5.Controls.Add(btnAddFood);
            panel5.Location = new Point(3, 6);
            panel5.Name = "panel5";
            panel5.Size = new Size(584, 49);
            panel5.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Controls.Add(numericUpDown1);
            panel6.Controls.Add(label4);
            panel6.Controls.Add(panel11);
            panel6.Controls.Add(comboBox1);
            panel6.Controls.Add(label3);
            panel6.Controls.Add(panel10);
            panel6.Controls.Add(label2);
            panel6.Controls.Add(txbNameFood);
            panel6.Controls.Add(panel9);
            panel6.Controls.Add(label1);
            panel6.Controls.Add(txbID);
            panel6.Controls.Add(panel8);
            panel6.Location = new Point(593, 61);
            panel6.Name = "panel6";
            panel6.Size = new Size(556, 470);
            panel6.TabIndex = 2;
            // 
            // panel7
            // 
            panel7.Controls.Add(txtSearchFood);
            panel7.Controls.Add(btnSearch);
            panel7.Location = new Point(593, 6);
            panel7.Name = "panel7";
            panel7.Size = new Size(556, 49);
            panel7.TabIndex = 3;
            // 
            // dtgvFood
            // 
            dtgvFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvFood.Location = new Point(3, 3);
            dtgvFood.Name = "dtgvFood";
            dtgvFood.RowHeadersWidth = 51;
            dtgvFood.Size = new Size(581, 464);
            dtgvFood.TabIndex = 0;
            // 
            // btnAddFood
            // 
            btnAddFood.Location = new Point(3, 3);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(94, 41);
            btnAddFood.TabIndex = 0;
            btnAddFood.Text = "Thêm";
            btnAddFood.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFood
            // 
            btnDeleteFood.Location = new Point(103, 3);
            btnDeleteFood.Name = "btnDeleteFood";
            btnDeleteFood.Size = new Size(94, 41);
            btnDeleteFood.TabIndex = 1;
            btnDeleteFood.Text = "Xóa";
            btnDeleteFood.UseVisualStyleBackColor = true;
            // 
            // btnFix
            // 
            btnFix.Location = new Point(203, 3);
            btnFix.Name = "btnFix";
            btnFix.Size = new Size(94, 41);
            btnFix.TabIndex = 2;
            btnFix.Text = "Sửa";
            btnFix.UseVisualStyleBackColor = true;
            // 
            // btnShowFood
            // 
            btnShowFood.Location = new Point(303, 3);
            btnShowFood.Name = "btnShowFood";
            btnShowFood.Size = new Size(94, 41);
            btnShowFood.TabIndex = 3;
            btnShowFood.Text = "Xem";
            btnShowFood.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(331, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 41);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Tìm";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearchFood
            // 
            txtSearchFood.Location = new Point(3, 10);
            txtSearchFood.Name = "txtSearchFood";
            txtSearchFood.Size = new Size(322, 27);
            txtSearchFood.TabIndex = 5;
            txtSearchFood.TextChanged += textBox1_TextChanged;
            // 
            // txbID
            // 
            txbID.BackColor = Color.White;
            txbID.BorderStyle = BorderStyle.None;
            txbID.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txbID.ForeColor = Color.Black;
            txbID.Location = new Point(103, 8);
            txbID.Name = "txbID";
            txbID.Size = new Size(450, 38);
            txbID.TabIndex = 5;
            txbID.TextAlign = HorizontalAlignment.Center;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Black;
            panel8.BackgroundImageLayout = ImageLayout.None;
            panel8.Location = new Point(3, 39);
            panel8.Name = "panel8";
            panel8.Size = new Size(550, 10);
            panel8.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 11);
            label1.Name = "label1";
            label1.Size = new Size(60, 35);
            label1.TabIndex = 7;
            label1.Text = "ID:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 66);
            label2.Name = "label2";
            label2.Size = new Size(153, 35);
            label2.TabIndex = 10;
            label2.Text = "Tên Món:";
            label2.Click += label2_Click;
            // 
            // txbNameFood
            // 
            txbNameFood.BackColor = Color.White;
            txbNameFood.BorderStyle = BorderStyle.None;
            txbNameFood.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txbNameFood.ForeColor = Color.Black;
            txbNameFood.Location = new Point(169, 63);
            txbNameFood.Name = "txbNameFood";
            txbNameFood.ReadOnly = true;
            txbNameFood.Size = new Size(384, 38);
            txbNameFood.TabIndex = 8;
            txbNameFood.TextAlign = HorizontalAlignment.Center;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Black;
            panel9.BackgroundImageLayout = ImageLayout.None;
            panel9.Location = new Point(3, 94);
            panel9.Name = "panel9";
            panel9.Size = new Size(550, 10);
            panel9.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 125);
            label3.Name = "label3";
            label3.Size = new Size(176, 35);
            label3.TabIndex = 13;
            label3.Text = "Danh Mục:";
            // 
            // panel10
            // 
            panel10.BackColor = Color.Black;
            panel10.BackgroundImageLayout = ImageLayout.None;
            panel10.Location = new Point(3, 153);
            panel10.Name = "panel10";
            panel10.Size = new Size(550, 10);
            panel10.TabIndex = 12;
            // 
            // comboBox1
            // 
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(188, 115);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(365, 45);
            comboBox1.TabIndex = 14;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 179);
            label4.Name = "label4";
            label4.Size = new Size(76, 35);
            label4.TabIndex = 16;
            label4.Text = "Giá:";
            // 
            // panel11
            // 
            panel11.BackColor = Color.Black;
            panel11.BackgroundImageLayout = ImageLayout.None;
            panel11.Location = new Point(3, 207);
            panel11.Name = "panel11";
            panel11.Size = new Size(550, 10);
            panel11.TabIndex = 15;
            // 
            // numericUpDown1
            // 
            numericUpDown1.BorderStyle = BorderStyle.None;
            numericUpDown1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            numericUpDown1.Location = new Point(91, 177);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(465, 37);
            numericUpDown1.TabIndex = 17;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // fAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 584);
            Controls.Add(tcAdmin);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "fAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LUMETA_MIN";
            Load += fAdmin_Load;
            tcAdmin.ResumeLayout(false);
            tpBill.ResumeLayout(false);
            tpFood.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvBill).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvFood).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcAdmin;
        private TabPage tpBill;
        private TabPage tpFood;
        private TabPage tpCategory;
        private TabPage tpTable;
        private TabPage tpAcc;
        private Panel panel2;
        private Button btnView;
        private DateTimePicker dtpkToDate;
        private DateTimePicker dtpkFromDate;
        private Panel panel1;
        private DataGridView dtgvBill;
        private Panel panel3;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Button btnAddFood;
        private Panel panel4;
        private DataGridView dtgvFood;
        private TextBox txtSearchFood;
        private Button btnSearch;
        private Button btnShowFood;
        private Button btnFix;
        private Button btnDeleteFood;
        private Label label1;
        private TextBox txbID;
        private Panel panel8;
        private Label label2;
        private TextBox txbNameFood;
        private Panel panel9;
        private Label label3;
        private Panel panel10;
        private ComboBox comboBox1;
        private Label label4;
        private Panel panel11;
        private NumericUpDown numericUpDown1;
    }
}