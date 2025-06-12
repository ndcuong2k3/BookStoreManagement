namespace BookStoreManagement
{
    partial class DangNhap
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtTaikhoan = new TextBox();
            txtMatkhau = new TextBox();
            btnDangNhap = new Button();
            label4 = new Label();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Poster;
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(308, 428);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(431, 105);
            label1.Name = "label1";
            label1.Size = new Size(115, 28);
            label1.TabIndex = 1;
            label1.Text = "Đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(325, 158);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 2;
            label2.Text = "Tài khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(325, 192);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 3;
            label3.Text = "Mật khẩu";
            // 
            // txtTaikhoan
            // 
            txtTaikhoan.Location = new Point(402, 151);
            txtTaikhoan.Name = "txtTaikhoan";
            txtTaikhoan.Size = new Size(202, 27);
            txtTaikhoan.TabIndex = 4;
            // 
            // txtMatkhau
            // 
            txtMatkhau.Location = new Point(403, 189);
            txtMatkhau.Name = "txtMatkhau";
            txtMatkhau.Size = new Size(202, 27);
            txtMatkhau.TabIndex = 5;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(366, 240);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(250, 35);
            btnDangNhap.TabIndex = 6;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(366, 341);
            label4.Name = "label4";
            label4.Size = new Size(139, 20);
            label4.TabIndex = 7;
            label4.Text = "Chưa có tài khoản ?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(511, 341);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 8;
            label5.Text = "Đăng ký";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = Properties.Resources.icons8_hide_password_30;
            pictureBox2.Location = new Point(615, 186);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 423);
            Controls.Add(pictureBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnDangNhap);
            Controls.Add(txtMatkhau);
            Controls.Add(txtTaikhoan);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            ForeColor = Color.Black;
            Name = "DangNhap";
            Text = "DangNhap";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTaikhoan;
        private TextBox txtMatkhau;
        private Button btnDangNhap;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox2;
    }
}