namespace QLCF
{
    partial class fTableManager
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
            menuStrip1 = new MenuStrip();
            aDMINToolStripMenuItem = new ToolStripMenuItem();
            tHÔNGTINTÀIKHOẢNToolStripMenuItem = new ToolStripMenuItem();
            tHÔNGTINCÁNHÂNToolStripMenuItem = new ToolStripMenuItem();
            đĂNGXUẤTToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            label1 = new Label();
            lsvBill = new ListView();
            panel3 = new Panel();
            numericUpDown1 = new NumericUpDown();
            btnChange = new Button();
            nUDDis = new NumericUpDown();
            btnDis = new Button();
            btnCheckOut = new Button();
            panel4 = new Panel();
            button1 = new Button();
            nUD1 = new NumericUpDown();
            btnAdd = new Button();
            cb2 = new ComboBox();
            cb1 = new ComboBox();
            flpTable = new FlowLayoutPanel();
            dataGridView1 = new DataGridView();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUDDis).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUD1).BeginInit();
            flpTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aDMINToolStripMenuItem, tHÔNGTINTÀIKHOẢNToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1005, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // aDMINToolStripMenuItem
            // 
            aDMINToolStripMenuItem.Name = "aDMINToolStripMenuItem";
            aDMINToolStripMenuItem.Size = new Size(72, 24);
            aDMINToolStripMenuItem.Text = "ADMIN";
            aDMINToolStripMenuItem.Click += aDMINToolStripMenuItem_Click;
            // 
            // tHÔNGTINTÀIKHOẢNToolStripMenuItem
            // 
            tHÔNGTINTÀIKHOẢNToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tHÔNGTINCÁNHÂNToolStripMenuItem, đĂNGXUẤTToolStripMenuItem });
            tHÔNGTINTÀIKHOẢNToolStripMenuItem.Name = "tHÔNGTINTÀIKHOẢNToolStripMenuItem";
            tHÔNGTINTÀIKHOẢNToolStripMenuItem.Size = new Size(182, 24);
            tHÔNGTINTÀIKHOẢNToolStripMenuItem.Text = "THÔNG TIN TÀI KHOẢN";
            // 
            // tHÔNGTINCÁNHÂNToolStripMenuItem
            // 
            tHÔNGTINCÁNHÂNToolStripMenuItem.Name = "tHÔNGTINCÁNHÂNToolStripMenuItem";
            tHÔNGTINCÁNHÂNToolStripMenuItem.Size = new Size(244, 26);
            tHÔNGTINCÁNHÂNToolStripMenuItem.Text = "THÔNG TIN CÁ NHÂN ";
            tHÔNGTINCÁNHÂNToolStripMenuItem.Click += tHÔNGTINCÁNHÂNToolStripMenuItem_Click;
            // 
            // đĂNGXUẤTToolStripMenuItem
            // 
            đĂNGXUẤTToolStripMenuItem.Name = "đĂNGXUẤTToolStripMenuItem";
            đĂNGXUẤTToolStripMenuItem.Size = new Size(244, 26);
            đĂNGXUẤTToolStripMenuItem.Text = "ĐĂNG XUẤT";
            đĂNGXUẤTToolStripMenuItem.Click += đĂNGXUẤTToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lsvBill);
            panel2.Location = new Point(469, 120);
            panel2.Name = "panel2";
            panel2.Size = new Size(532, 295);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(162, 3);
            label1.Name = "label1";
            label1.Size = new Size(210, 38);
            label1.TabIndex = 1;
            label1.Text = "Danh sách món";
            // 
            // lsvBill
            // 
            lsvBill.BackColor = Color.DarkGray;
            lsvBill.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lsvBill.Location = new Point(-2, 3);
            lsvBill.Name = "lsvBill";
            lsvBill.Size = new Size(526, 289);
            lsvBill.TabIndex = 0;
            lsvBill.UseCompatibleStateImageBehavior = false;
            lsvBill.SelectedIndexChanged += lsvBill_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LemonChiffon;
            panel3.Controls.Add(numericUpDown1);
            panel3.Controls.Add(btnChange);
            panel3.Controls.Add(nUDDis);
            panel3.Controls.Add(btnDis);
            panel3.Controls.Add(btnCheckOut);
            panel3.Location = new Point(470, 421);
            panel3.Name = "panel3";
            panel3.Size = new Size(531, 136);
            panel3.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.FromArgb(192, 192, 255);
            numericUpDown1.BorderStyle = BorderStyle.None;
            numericUpDown1.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold);
            numericUpDown1.Location = new Point(7, 105);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(155, 22);
            numericUpDown1.TabIndex = 7;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnChange
            // 
            btnChange.BackColor = Color.Gold;
            btnChange.FlatStyle = FlatStyle.Flat;
            btnChange.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnChange.Location = new Point(8, 5);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(155, 91);
            btnChange.TabIndex = 6;
            btnChange.Text = "Chuyển Bàn";
            btnChange.UseVisualStyleBackColor = false;
            // 
            // nUDDis
            // 
            nUDDis.BackColor = Color.FromArgb(192, 192, 255);
            nUDDis.BorderStyle = BorderStyle.None;
            nUDDis.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold);
            nUDDis.Location = new Point(174, 105);
            nUDDis.Name = "nUDDis";
            nUDDis.Size = new Size(162, 22);
            nUDDis.TabIndex = 5;
            nUDDis.TextAlign = HorizontalAlignment.Center;
            nUDDis.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnDis
            // 
            btnDis.BackColor = Color.Gold;
            btnDis.FlatStyle = FlatStyle.Flat;
            btnDis.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDis.ForeColor = Color.Black;
            btnDis.Location = new Point(174, 5);
            btnDis.Name = "btnDis";
            btnDis.Size = new Size(162, 91);
            btnDis.TabIndex = 4;
            btnDis.Text = "Giảm Giá";
            btnDis.UseVisualStyleBackColor = false;
            btnDis.Click += button1_Click;
            // 
            // btnCheckOut
            // 
            btnCheckOut.BackColor = Color.Gold;
            btnCheckOut.FlatStyle = FlatStyle.Flat;
            btnCheckOut.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckOut.Location = new Point(347, 20);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(167, 93);
            btnCheckOut.TabIndex = 3;
            btnCheckOut.Text = "Thanh Toán";
            btnCheckOut.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LemonChiffon;
            panel4.Controls.Add(button1);
            panel4.Controls.Add(nUD1);
            panel4.Controls.Add(btnAdd);
            panel4.Controls.Add(cb2);
            panel4.Controls.Add(cb1);
            panel4.Location = new Point(470, 35);
            panel4.Name = "panel4";
            panel4.Size = new Size(531, 78);
            panel4.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(305, 4);
            button1.Name = "button1";
            button1.Size = new Size(107, 66);
            button1.TabIndex = 4;
            button1.Text = "Hết Món";
            button1.UseVisualStyleBackColor = false;
            // 
            // nUD1
            // 
            nUD1.BackColor = Color.FromArgb(192, 192, 255);
            nUD1.BorderStyle = BorderStyle.None;
            nUD1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            nUD1.Location = new Point(223, 28);
            nUD1.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nUD1.Name = "nUD1";
            nUD1.Size = new Size(72, 26);
            nUD1.TabIndex = 3;
            nUD1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nUD1.ValueChanged += nUD1_ValueChanged;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Gold;
            btnAdd.BackgroundImageLayout = ImageLayout.None;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(418, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(107, 66);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Thêm Món";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // cb2
            // 
            cb2.BackColor = Color.FromArgb(192, 192, 255);
            cb2.FlatStyle = FlatStyle.Flat;
            cb2.Font = new Font("Showcard Gothic", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            cb2.FormattingEnabled = true;
            cb2.Location = new Point(4, 46);
            cb2.Name = "cb2";
            cb2.Size = new Size(212, 29);
            cb2.TabIndex = 1;
            // 
            // cb1
            // 
            cb1.BackColor = Color.FromArgb(192, 192, 255);
            cb1.FlatStyle = FlatStyle.Popup;
            cb1.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            cb1.FormattingEnabled = true;
            cb1.Location = new Point(4, 9);
            cb1.Name = "cb1";
            cb1.Size = new Size(212, 31);
            cb1.TabIndex = 0;
            // 
            // flpTable
            // 
            flpTable.BackColor = Color.PaleGoldenrod;
            flpTable.Controls.Add(dataGridView1);
            flpTable.Location = new Point(4, 35);
            flpTable.Name = "flpTable";
            flpTable.Size = new Size(462, 522);
            flpTable.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(454, 512);
            dataGridView1.TabIndex = 0;
            // 
            // fTableManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(1005, 560);
            Controls.Add(flpTable);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MainMenuStrip = menuStrip1;
            Name = "fTableManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " LUMETARY";
            Load += fTableManager_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUDDis).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nUD1).EndInit();
            flpTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem aDMINToolStripMenuItem;
        private ToolStripMenuItem tHÔNGTINTÀIKHOẢNToolStripMenuItem;
        private ToolStripMenuItem tHÔNGTINCÁNHÂNToolStripMenuItem;
        private Panel panel2;
        private ListView lsvBill;
        private Panel panel3;
        private Panel panel4;
        private Button btnAdd;
        private ComboBox cb2;
        private ComboBox cb1;
        private NumericUpDown nUD1;
        private FlowLayoutPanel flpTable;
        private Button btnDis;
        private Button btnCheckOut;
        private NumericUpDown nUDDis;
        private NumericUpDown numericUpDown1;
        private Button btnChange;
        private ToolStripMenuItem đĂNGXUẤTToolStripMenuItem;
        private DataGridView dataGridView1;
        private Label label1;
        private Button button1;
    }
}