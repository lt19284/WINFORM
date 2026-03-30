namespace QLCF
{
    partial class fLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            panel1 = new Panel();
            label1 = new Label();
            TextboxLogin = new Panel();
            btnExt = new Button();
            btnLog = new Button();
            panel5 = new Panel();
            panel4 = new Panel();
            txtPassWord = new TextBox();
            panel3 = new Panel();
            txbUserName = new TextBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            TextboxLogin.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gold;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(TextboxLogin);
            panel1.Location = new Point(-3, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(770, 421);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tempus Sans ITC", 37.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(208, 42);
            label1.Name = "label1";
            label1.Size = new Size(365, 82);
            label1.TabIndex = 1;
            label1.Text = "LUMETARY";
            label1.Click += label1_Click_1;
            // 
            // TextboxLogin
            // 
            TextboxLogin.BackColor = Color.Gold;
            TextboxLogin.Controls.Add(btnExt);
            TextboxLogin.Controls.Add(btnLog);
            TextboxLogin.Controls.Add(panel5);
            TextboxLogin.Controls.Add(panel4);
            TextboxLogin.Controls.Add(txtPassWord);
            TextboxLogin.Controls.Add(panel3);
            TextboxLogin.Controls.Add(txbUserName);
            TextboxLogin.Controls.Add(panel2);
            TextboxLogin.ImeMode = ImeMode.On;
            TextboxLogin.Location = new Point(15, 157);
            TextboxLogin.Name = "TextboxLogin";
            TextboxLogin.Size = new Size(740, 226);
            TextboxLogin.TabIndex = 0;
            // 
            // btnExt
            // 
            btnExt.BackColor = SystemColors.ActiveCaptionText;
            btnExt.FlatStyle = FlatStyle.Popup;
            btnExt.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExt.ForeColor = Color.Gold;
            btnExt.Location = new Point(404, 166);
            btnExt.Name = "btnExt";
            btnExt.Size = new Size(143, 36);
            btnExt.TabIndex = 4;
            btnExt.Text = "Thoát";
            btnExt.UseVisualStyleBackColor = false;
            btnExt.Click += btnExt_Click;
            // 
            // btnLog
            // 
            btnLog.BackColor = SystemColors.ActiveCaptionText;
            btnLog.FlatStyle = FlatStyle.Popup;
            btnLog.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLog.ForeColor = Color.Gold;
            btnLog.Location = new Point(204, 166);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(143, 36);
            btnLog.TabIndex = 3;
            btnLog.Text = "Đăng Nhập";
            btnLog.UseVisualStyleBackColor = false;
            btnLog.Click += button1_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Gold;
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Location = new Point(204, 98);
            panel5.Name = "panel5";
            panel5.Size = new Size(28, 27);
            panel5.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gold;
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Location = new Point(204, 50);
            panel4.Name = "panel4";
            panel4.Size = new Size(28, 27);
            panel4.TabIndex = 7;
            // 
            // txtPassWord
            // 
            txtPassWord.BackColor = Color.Gold;
            txtPassWord.BorderStyle = BorderStyle.None;
            txtPassWord.Cursor = Cursors.IBeam;
            txtPassWord.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassWord.ForeColor = Color.Black;
            txtPassWord.Location = new Point(248, 107);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.PlaceholderText = "Mật Khẩu";
            txtPassWord.Size = new Size(300, 27);
            txtPassWord.TabIndex = 2;
            txtPassWord.TextAlign = HorizontalAlignment.Center;
            txtPassWord.UseSystemPasswordChar = true;
            txtPassWord.TextChanged += txtPassWord_TextChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.BackgroundImageLayout = ImageLayout.None;
            panel3.Location = new Point(193, 127);
            panel3.Name = "panel3";
            panel3.Size = new Size(355, 10);
            panel3.TabIndex = 6;
            // 
            // txbUserName
            // 
            txbUserName.BackColor = Color.Gold;
            txbUserName.BorderStyle = BorderStyle.None;
            txbUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txbUserName.ForeColor = Color.Black;
            txbUserName.Location = new Point(248, 57);
            txbUserName.Name = "txbUserName";
            txbUserName.PlaceholderText = "Tên Đăng Nhập";
            txbUserName.Size = new Size(299, 27);
            txbUserName.TabIndex = 1;
            txbUserName.TextAlign = HorizontalAlignment.Center;
            txbUserName.TextChanged += textBox1_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.Location = new Point(192, 77);
            panel2.Name = "panel2";
            panel2.Size = new Size(355, 10);
            panel2.TabIndex = 4;
            panel2.Paint += panel2_Paint;
            // 
            // fLogin
            // 
            AcceptButton = btnLog;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExt;
            ClientSize = new Size(764, 413);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "fLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Nhập";
            FormClosing += fLogin_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            TextboxLogin.ResumeLayout(false);
            TextboxLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel TextboxLogin;
        private TextBox txbUserName;
        private Panel panel2;
        private TextBox txtPassWord;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Button btnLog;
        private Label label1;
        private Button btnExt;
    }
}
