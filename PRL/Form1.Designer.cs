namespace PRL
{
    partial class Form1
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
            dtg_View = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btn_xoa = new Button();
            txt_manv = new TextBox();
            txt_timkiem = new TextBox();
            txt_ngaysinh = new TextBox();
            txt_hoten = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            rbtn_nam = new RadioButton();
            rbtn_nu = new RadioButton();
            cmbx_diachi = new ComboBox();
            btn_them = new Button();
            btn_sua = new Button();
            btn_clear = new Button();
            ((System.ComponentModel.ISupportInitialize)dtg_View).BeginInit();
            SuspendLayout();
            // 
            // dtg_View
            // 
            dtg_View.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_View.Location = new Point(53, 597);
            dtg_View.Name = "dtg_View";
            dtg_View.RowHeadersWidth = 62;
            dtg_View.Size = new Size(1324, 391);
            dtg_View.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 26);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 1;
            label1.Text = "MaNV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 97);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 2;
            label2.Text = "Ho ten";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 177);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 3;
            label3.Text = "Ngay sinh";
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(911, 254);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(112, 34);
            btn_xoa.TabIndex = 4;
            btn_xoa.Text = "Xoa";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // txt_manv
            // 
            txt_manv.Location = new Point(244, 25);
            txt_manv.Name = "txt_manv";
            txt_manv.Size = new Size(422, 31);
            txt_manv.TabIndex = 5;
            // 
            // txt_timkiem
            // 
            txt_timkiem.Location = new Point(244, 429);
            txt_timkiem.Name = "txt_timkiem";
            txt_timkiem.Size = new Size(422, 31);
            txt_timkiem.TabIndex = 7;
            // 
            // txt_ngaysinh
            // 
            txt_ngaysinh.Location = new Point(244, 174);
            txt_ngaysinh.Name = "txt_ngaysinh";
            txt_ngaysinh.Size = new Size(422, 31);
            txt_ngaysinh.TabIndex = 8;
            // 
            // txt_hoten
            // 
            txt_hoten.Location = new Point(244, 97);
            txt_hoten.Name = "txt_hoten";
            txt_hoten.Size = new Size(422, 31);
            txt_hoten.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 259);
            label4.Name = "label4";
            label4.Size = new Size(78, 25);
            label4.TabIndex = 10;
            label4.Text = "Gioi tinh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(62, 333);
            label5.Name = "label5";
            label5.Size = new Size(65, 25);
            label5.TabIndex = 11;
            label5.Text = "Dia chi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(62, 429);
            label6.Name = "label6";
            label6.Size = new Size(84, 25);
            label6.TabIndex = 12;
            label6.Text = "Tim kiem";
            // 
            // rbtn_nam
            // 
            rbtn_nam.AutoSize = true;
            rbtn_nam.Location = new Point(251, 262);
            rbtn_nam.Name = "rbtn_nam";
            rbtn_nam.Size = new Size(75, 29);
            rbtn_nam.TabIndex = 13;
            rbtn_nam.TabStop = true;
            rbtn_nam.Text = "Nam";
            rbtn_nam.UseVisualStyleBackColor = true;
            // 
            // rbtn_nu
            // 
            rbtn_nu.AutoSize = true;
            rbtn_nu.Location = new Point(525, 262);
            rbtn_nu.Name = "rbtn_nu";
            rbtn_nu.Size = new Size(60, 29);
            rbtn_nu.TabIndex = 14;
            rbtn_nu.TabStop = true;
            rbtn_nu.Text = "Nu";
            rbtn_nu.UseVisualStyleBackColor = true;
            // 
            // cmbx_diachi
            // 
            cmbx_diachi.FormattingEnabled = true;
            cmbx_diachi.Location = new Point(244, 333);
            cmbx_diachi.Name = "cmbx_diachi";
            cmbx_diachi.Size = new Size(422, 33);
            cmbx_diachi.TabIndex = 15;
            // 
            // btn_them
            // 
            btn_them.Location = new Point(911, 12);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(112, 34);
            btn_them.TabIndex = 16;
            btn_them.Text = "Them";
            btn_them.UseVisualStyleBackColor = true;
            btn_them.Click += btn_them_Click;
            // 
            // btn_sua
            // 
            btn_sua.Location = new Point(911, 127);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(112, 34);
            btn_sua.TabIndex = 17;
            btn_sua.Text = "Sua";
            btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(911, 377);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(112, 34);
            btn_clear.TabIndex = 18;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1430, 1096);
            Controls.Add(btn_clear);
            Controls.Add(btn_sua);
            Controls.Add(btn_them);
            Controls.Add(cmbx_diachi);
            Controls.Add(rbtn_nu);
            Controls.Add(rbtn_nam);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txt_hoten);
            Controls.Add(txt_ngaysinh);
            Controls.Add(txt_timkiem);
            Controls.Add(txt_manv);
            Controls.Add(btn_xoa);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtg_View);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dtg_View).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtg_View;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_xoa;
        private TextBox txt_manv;
        private TextBox txt_timkiem;
        private TextBox txt_ngaysinh;
        private TextBox txt_hoten;
        private Label label4;
        private Label label5;
        private Label label6;
        private RadioButton rbtn_nam;
        private RadioButton rbtn_nu;
        private ComboBox cmbx_diachi;
        private Button btn_them;
        private Button btn_sua;
        private Button btn_clear;
    }
}
