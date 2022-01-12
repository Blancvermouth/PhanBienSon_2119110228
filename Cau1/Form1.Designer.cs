namespace Cau1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chbgioitinh = new System.Windows.Forms.CheckBox();
            this.tbma = new System.Windows.Forms.TextBox();
            this.tbhoten = new System.Windows.Forms.TextBox();
            this.tbnoisinh = new System.Windows.Forms.TextBox();
            this.cbdonvi = new System.Windows.Forms.ComboBox();
            this.dtpngaysinh = new System.Windows.Forms.DateTimePicker();
            this.dgvnhanvien = new System.Windows.Forms.DataGridView();
            this.ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noisinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donvi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btthem = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đơn vị";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nơi sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(556, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày sinh";
            // 
            // chbgioitinh
            // 
            this.chbgioitinh.AutoSize = true;
            this.chbgioitinh.Location = new System.Drawing.Point(859, 12);
            this.chbgioitinh.Name = "chbgioitinh";
            this.chbgioitinh.Size = new System.Drawing.Size(130, 24);
            this.chbgioitinh.TabIndex = 5;
            this.chbgioitinh.Text = "Giới tính Nam";
            this.chbgioitinh.UseVisualStyleBackColor = true;
            // 
            // tbma
            // 
            this.tbma.Location = new System.Drawing.Point(72, 12);
            this.tbma.Name = "tbma";
            this.tbma.Size = new System.Drawing.Size(188, 26);
            this.tbma.TabIndex = 6;
            // 
            // tbhoten
            // 
            this.tbhoten.Location = new System.Drawing.Point(341, 12);
            this.tbhoten.Name = "tbhoten";
            this.tbhoten.Size = new System.Drawing.Size(209, 26);
            this.tbhoten.TabIndex = 7;
            // 
            // tbnoisinh
            // 
            this.tbnoisinh.Location = new System.Drawing.Point(341, 57);
            this.tbnoisinh.Name = "tbnoisinh";
            this.tbnoisinh.Size = new System.Drawing.Size(648, 26);
            this.tbnoisinh.TabIndex = 8;
            // 
            // cbdonvi
            // 
            this.cbdonvi.FormattingEnabled = true;
            this.cbdonvi.Location = new System.Drawing.Point(72, 57);
            this.cbdonvi.Name = "cbdonvi";
            this.cbdonvi.Size = new System.Drawing.Size(188, 28);
            this.cbdonvi.TabIndex = 9;
            // 
            // dtpngaysinh
            // 
            this.dtpngaysinh.Location = new System.Drawing.Point(640, 10);
            this.dtpngaysinh.Name = "dtpngaysinh";
            this.dtpngaysinh.Size = new System.Drawing.Size(197, 26);
            this.dtpngaysinh.TabIndex = 10;
            // 
            // dgvnhanvien
            // 
            this.dgvnhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma,
            this.hoten,
            this.ngaysinh,
            this.gioitinh,
            this.noisinh,
            this.donvi});
            this.dgvnhanvien.Location = new System.Drawing.Point(17, 108);
            this.dgvnhanvien.Name = "dgvnhanvien";
            this.dgvnhanvien.RowHeadersWidth = 62;
            this.dgvnhanvien.RowTemplate.Height = 28;
            this.dgvnhanvien.Size = new System.Drawing.Size(972, 249);
            this.dgvnhanvien.TabIndex = 11;
            // 
            // ma
            // 
            this.ma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ma.DataPropertyName = "id";
            this.ma.HeaderText = "Mã";
            this.ma.MinimumWidth = 8;
            this.ma.Name = "ma";
            // 
            // hoten
            // 
            this.hoten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hoten.DataPropertyName = "name";
            this.hoten.HeaderText = "Họ tên";
            this.hoten.MinimumWidth = 8;
            this.hoten.Name = "hoten";
            // 
            // ngaysinh
            // 
            this.ngaysinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngaysinh.DataPropertyName = "datebirth";
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.MinimumWidth = 8;
            this.ngaysinh.Name = "ngaysinh";
            // 
            // gioitinh
            // 
            this.gioitinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gioitinh.DataPropertyName = "gender";
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.MinimumWidth = 8;
            this.gioitinh.Name = "gioitinh";
            // 
            // noisinh
            // 
            this.noisinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.noisinh.DataPropertyName = "placebirth";
            this.noisinh.HeaderText = "Nơi sinh";
            this.noisinh.MinimumWidth = 8;
            this.noisinh.Name = "noisinh";
            // 
            // donvi
            // 
            this.donvi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.donvi.DataPropertyName = "department";
            this.donvi.HeaderText = "Đơn vị";
            this.donvi.MinimumWidth = 8;
            this.donvi.Name = "donvi";
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(365, 378);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(106, 32);
            this.btthem.TabIndex = 12;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(544, 378);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(106, 32);
            this.btxoa.TabIndex = 13;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(711, 378);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(106, 32);
            this.btsua.TabIndex = 14;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            // 
            // btthoat
            // 
            this.btthoat.Location = new System.Drawing.Point(883, 378);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(106, 32);
            this.btthoat.TabIndex = 15;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 450);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.dgvnhanvien);
            this.Controls.Add(this.dtpngaysinh);
            this.Controls.Add(this.cbdonvi);
            this.Controls.Add(this.tbnoisinh);
            this.Controls.Add(this.tbhoten);
            this.Controls.Add(this.tbma);
            this.Controls.Add(this.chbgioitinh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chbgioitinh;
        private System.Windows.Forms.TextBox tbma;
        private System.Windows.Forms.TextBox tbhoten;
        private System.Windows.Forms.TextBox tbnoisinh;
        private System.Windows.Forms.ComboBox cbdonvi;
        private System.Windows.Forms.DateTimePicker dtpngaysinh;
        private System.Windows.Forms.DataGridView dgvnhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn noisinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn donvi;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btthoat;
    }
}

