
namespace _3_GUI
{
    partial class frm_ThongKeThuChi
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_HoaDonNhap = new System.Windows.Forms.DateTimePicker();
            this.btn_QuiChi = new System.Windows.Forms.Button();
            this.btn_ThangChi = new System.Windows.Forms.Button();
            this.btn_NgayChi = new System.Windows.Forms.Button();
            this.lbl_chi = new System.Windows.Forms.Label();
            this.lbl_TongChi = new System.Windows.Forms.Label();
            this.dgrid_HoaDonNhap = new System.Windows.Forms.DataGridView();
            this.gbx_ChiTietHoaDonBan = new System.Windows.Forms.GroupBox();
            this.txt_MaHoaDonBan = new System.Windows.Forms.TextBox();
            this.txt_CongThucTinh = new System.Windows.Forms.TextBox();
            this.txt_ThoiGianDung = new System.Windows.Forms.TextBox();
            this.txt_DonGiaBan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_MaPhong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgrid_ChiTietHoaDonBan = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtp_HoaDonXuat = new System.Windows.Forms.DateTimePicker();
            this.btn_QuiThu = new System.Windows.Forms.Button();
            this.btn_ThangThu = new System.Windows.Forms.Button();
            this.btn_NgayThu = new System.Windows.Forms.Button();
            this.lbl_Thu = new System.Windows.Forms.Label();
            this.lbl_TongThu = new System.Windows.Forms.Label();
            this.dgrid_HoaDonBan = new System.Windows.Forms.DataGridView();
            this.gbx_ChiTietHoaDonNhap = new System.Windows.Forms.GroupBox();
            this.txt_MaHoaDonNhap = new System.Windows.Forms.TextBox();
            this.txt_DonGiaNhap = new System.Windows.Forms.TextBox();
            this.txt_NhaCungCap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgrid_ChiTietHoaDonNhap = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_HoaDonNhap)).BeginInit();
            this.gbx_ChiTietHoaDonBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_ChiTietHoaDonBan)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_HoaDonBan)).BeginInit();
            this.gbx_ChiTietHoaDonNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_ChiTietHoaDonNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtp_HoaDonNhap);
            this.groupBox1.Controls.Add(this.btn_QuiChi);
            this.groupBox1.Controls.Add(this.btn_ThangChi);
            this.groupBox1.Controls.Add(this.btn_NgayChi);
            this.groupBox1.Controls.Add(this.lbl_chi);
            this.groupBox1.Controls.Add(this.lbl_TongChi);
            this.groupBox1.Controls.Add(this.dgrid_HoaDonNhap);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 846);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa đơn nhập";
            // 
            // dtp_HoaDonNhap
            // 
            this.dtp_HoaDonNhap.Location = new System.Drawing.Point(23, 110);
            this.dtp_HoaDonNhap.Name = "dtp_HoaDonNhap";
            this.dtp_HoaDonNhap.Size = new System.Drawing.Size(294, 27);
            this.dtp_HoaDonNhap.TabIndex = 4;
            // 
            // btn_QuiChi
            // 
            this.btn_QuiChi.Location = new System.Drawing.Point(223, 75);
            this.btn_QuiChi.Name = "btn_QuiChi";
            this.btn_QuiChi.Size = new System.Drawing.Size(94, 29);
            this.btn_QuiChi.TabIndex = 3;
            this.btn_QuiChi.Text = "Năm";
            this.btn_QuiChi.UseVisualStyleBackColor = true;
            this.btn_QuiChi.Click += new System.EventHandler(this.btn_QuiChi_Click);
            // 
            // btn_ThangChi
            // 
            this.btn_ThangChi.Location = new System.Drawing.Point(123, 75);
            this.btn_ThangChi.Name = "btn_ThangChi";
            this.btn_ThangChi.Size = new System.Drawing.Size(94, 29);
            this.btn_ThangChi.TabIndex = 3;
            this.btn_ThangChi.Text = "Tháng";
            this.btn_ThangChi.UseVisualStyleBackColor = true;
            this.btn_ThangChi.Click += new System.EventHandler(this.btn_ThangChi_Click);
            // 
            // btn_NgayChi
            // 
            this.btn_NgayChi.Location = new System.Drawing.Point(23, 75);
            this.btn_NgayChi.Name = "btn_NgayChi";
            this.btn_NgayChi.Size = new System.Drawing.Size(94, 29);
            this.btn_NgayChi.TabIndex = 3;
            this.btn_NgayChi.Text = "Ngày";
            this.btn_NgayChi.UseVisualStyleBackColor = true;
            this.btn_NgayChi.Click += new System.EventHandler(this.btn_NgayChi_Click);
            // 
            // lbl_chi
            // 
            this.lbl_chi.AutoSize = true;
            this.lbl_chi.Location = new System.Drawing.Point(110, 37);
            this.lbl_chi.Name = "lbl_chi";
            this.lbl_chi.Size = new System.Drawing.Size(17, 20);
            this.lbl_chi.TabIndex = 2;
            this.lbl_chi.Text = "0";
            // 
            // lbl_TongChi
            // 
            this.lbl_TongChi.AutoSize = true;
            this.lbl_TongChi.Location = new System.Drawing.Point(26, 37);
            this.lbl_TongChi.Name = "lbl_TongChi";
            this.lbl_TongChi.Size = new System.Drawing.Size(66, 20);
            this.lbl_TongChi.TabIndex = 2;
            this.lbl_TongChi.Text = "Tổng chi";
            // 
            // dgrid_HoaDonNhap
            // 
            this.dgrid_HoaDonNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_HoaDonNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_HoaDonNhap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrid_HoaDonNhap.Location = new System.Drawing.Point(3, 160);
            this.dgrid_HoaDonNhap.Name = "dgrid_HoaDonNhap";
            this.dgrid_HoaDonNhap.RowHeadersWidth = 51;
            this.dgrid_HoaDonNhap.RowTemplate.Height = 29;
            this.dgrid_HoaDonNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_HoaDonNhap.Size = new System.Drawing.Size(332, 683);
            this.dgrid_HoaDonNhap.TabIndex = 1;
            this.dgrid_HoaDonNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_HoaDonNhap_CellClick);
            // 
            // gbx_ChiTietHoaDonBan
            // 
            this.gbx_ChiTietHoaDonBan.Controls.Add(this.txt_MaHoaDonBan);
            this.gbx_ChiTietHoaDonBan.Controls.Add(this.txt_CongThucTinh);
            this.gbx_ChiTietHoaDonBan.Controls.Add(this.txt_ThoiGianDung);
            this.gbx_ChiTietHoaDonBan.Controls.Add(this.txt_DonGiaBan);
            this.gbx_ChiTietHoaDonBan.Controls.Add(this.label8);
            this.gbx_ChiTietHoaDonBan.Controls.Add(this.txt_MaPhong);
            this.gbx_ChiTietHoaDonBan.Controls.Add(this.label7);
            this.gbx_ChiTietHoaDonBan.Controls.Add(this.label4);
            this.gbx_ChiTietHoaDonBan.Controls.Add(this.label5);
            this.gbx_ChiTietHoaDonBan.Controls.Add(this.label6);
            this.gbx_ChiTietHoaDonBan.Controls.Add(this.dgrid_ChiTietHoaDonBan);
            this.gbx_ChiTietHoaDonBan.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbx_ChiTietHoaDonBan.Location = new System.Drawing.Point(1011, 0);
            this.gbx_ChiTietHoaDonBan.Name = "gbx_ChiTietHoaDonBan";
            this.gbx_ChiTietHoaDonBan.Size = new System.Drawing.Size(329, 846);
            this.gbx_ChiTietHoaDonBan.TabIndex = 0;
            this.gbx_ChiTietHoaDonBan.TabStop = false;
            this.gbx_ChiTietHoaDonBan.Text = "Chi tiết hóa đơn xuất ";
            // 
            // txt_MaHoaDonBan
            // 
            this.txt_MaHoaDonBan.Location = new System.Drawing.Point(123, 37);
            this.txt_MaHoaDonBan.Name = "txt_MaHoaDonBan";
            this.txt_MaHoaDonBan.Size = new System.Drawing.Size(194, 27);
            this.txt_MaHoaDonBan.TabIndex = 3;
            // 
            // txt_CongThucTinh
            // 
            this.txt_CongThucTinh.Location = new System.Drawing.Point(123, 177);
            this.txt_CongThucTinh.Name = "txt_CongThucTinh";
            this.txt_CongThucTinh.Size = new System.Drawing.Size(194, 27);
            this.txt_CongThucTinh.TabIndex = 4;
            // 
            // txt_ThoiGianDung
            // 
            this.txt_ThoiGianDung.Location = new System.Drawing.Point(123, 142);
            this.txt_ThoiGianDung.Name = "txt_ThoiGianDung";
            this.txt_ThoiGianDung.Size = new System.Drawing.Size(194, 27);
            this.txt_ThoiGianDung.TabIndex = 4;
            // 
            // txt_DonGiaBan
            // 
            this.txt_DonGiaBan.Location = new System.Drawing.Point(123, 107);
            this.txt_DonGiaBan.Name = "txt_DonGiaBan";
            this.txt_DonGiaBan.Size = new System.Drawing.Size(194, 27);
            this.txt_DonGiaBan.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Công thức";
            // 
            // txt_MaPhong
            // 
            this.txt_MaPhong.Location = new System.Drawing.Point(123, 72);
            this.txt_MaPhong.Name = "txt_MaPhong";
            this.txt_MaPhong.Size = new System.Drawing.Size(194, 27);
            this.txt_MaPhong.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Thời gian dùng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã hóa đơn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Đơn giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Mã phòng";
            // 
            // dgrid_ChiTietHoaDonBan
            // 
            this.dgrid_ChiTietHoaDonBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_ChiTietHoaDonBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_ChiTietHoaDonBan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrid_ChiTietHoaDonBan.Location = new System.Drawing.Point(3, 226);
            this.dgrid_ChiTietHoaDonBan.Name = "dgrid_ChiTietHoaDonBan";
            this.dgrid_ChiTietHoaDonBan.RowHeadersWidth = 51;
            this.dgrid_ChiTietHoaDonBan.RowTemplate.Height = 29;
            this.dgrid_ChiTietHoaDonBan.Size = new System.Drawing.Size(323, 617);
            this.dgrid_ChiTietHoaDonBan.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtp_HoaDonXuat);
            this.groupBox3.Controls.Add(this.btn_QuiThu);
            this.groupBox3.Controls.Add(this.btn_ThangThu);
            this.groupBox3.Controls.Add(this.btn_NgayThu);
            this.groupBox3.Controls.Add(this.lbl_Thu);
            this.groupBox3.Controls.Add(this.lbl_TongThu);
            this.groupBox3.Controls.Add(this.dgrid_HoaDonBan);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(672, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(339, 846);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hóa đơn xuất";
            // 
            // dtp_HoaDonXuat
            // 
            this.dtp_HoaDonXuat.Location = new System.Drawing.Point(29, 110);
            this.dtp_HoaDonXuat.Name = "dtp_HoaDonXuat";
            this.dtp_HoaDonXuat.Size = new System.Drawing.Size(294, 27);
            this.dtp_HoaDonXuat.TabIndex = 9;
            // 
            // btn_QuiThu
            // 
            this.btn_QuiThu.Location = new System.Drawing.Point(229, 75);
            this.btn_QuiThu.Name = "btn_QuiThu";
            this.btn_QuiThu.Size = new System.Drawing.Size(94, 29);
            this.btn_QuiThu.TabIndex = 6;
            this.btn_QuiThu.Text = "Năm";
            this.btn_QuiThu.UseVisualStyleBackColor = true;
            this.btn_QuiThu.Click += new System.EventHandler(this.btn_QuiThu_Click);
            // 
            // btn_ThangThu
            // 
            this.btn_ThangThu.Location = new System.Drawing.Point(129, 75);
            this.btn_ThangThu.Name = "btn_ThangThu";
            this.btn_ThangThu.Size = new System.Drawing.Size(94, 29);
            this.btn_ThangThu.TabIndex = 7;
            this.btn_ThangThu.Text = "Tháng";
            this.btn_ThangThu.UseVisualStyleBackColor = true;
            this.btn_ThangThu.Click += new System.EventHandler(this.btn_ThangThu_Click);
            // 
            // btn_NgayThu
            // 
            this.btn_NgayThu.Location = new System.Drawing.Point(29, 75);
            this.btn_NgayThu.Name = "btn_NgayThu";
            this.btn_NgayThu.Size = new System.Drawing.Size(94, 29);
            this.btn_NgayThu.TabIndex = 8;
            this.btn_NgayThu.Text = "Ngày";
            this.btn_NgayThu.UseVisualStyleBackColor = true;
            this.btn_NgayThu.Click += new System.EventHandler(this.btn_NgayThu_Click);
            // 
            // lbl_Thu
            // 
            this.lbl_Thu.AutoSize = true;
            this.lbl_Thu.Location = new System.Drawing.Point(115, 37);
            this.lbl_Thu.Name = "lbl_Thu";
            this.lbl_Thu.Size = new System.Drawing.Size(17, 20);
            this.lbl_Thu.TabIndex = 5;
            this.lbl_Thu.Text = "0";
            // 
            // lbl_TongThu
            // 
            this.lbl_TongThu.AutoSize = true;
            this.lbl_TongThu.Location = new System.Drawing.Point(32, 37);
            this.lbl_TongThu.Name = "lbl_TongThu";
            this.lbl_TongThu.Size = new System.Drawing.Size(68, 20);
            this.lbl_TongThu.TabIndex = 5;
            this.lbl_TongThu.Text = "Tổng thu";
            // 
            // dgrid_HoaDonBan
            // 
            this.dgrid_HoaDonBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_HoaDonBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_HoaDonBan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrid_HoaDonBan.Location = new System.Drawing.Point(3, 160);
            this.dgrid_HoaDonBan.Name = "dgrid_HoaDonBan";
            this.dgrid_HoaDonBan.RowHeadersWidth = 51;
            this.dgrid_HoaDonBan.RowTemplate.Height = 29;
            this.dgrid_HoaDonBan.Size = new System.Drawing.Size(333, 683);
            this.dgrid_HoaDonBan.TabIndex = 0;
            this.dgrid_HoaDonBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_HoaDonBan_CellClick);
            // 
            // gbx_ChiTietHoaDonNhap
            // 
            this.gbx_ChiTietHoaDonNhap.Controls.Add(this.txt_MaHoaDonNhap);
            this.gbx_ChiTietHoaDonNhap.Controls.Add(this.txt_DonGiaNhap);
            this.gbx_ChiTietHoaDonNhap.Controls.Add(this.txt_NhaCungCap);
            this.gbx_ChiTietHoaDonNhap.Controls.Add(this.label2);
            this.gbx_ChiTietHoaDonNhap.Controls.Add(this.label3);
            this.gbx_ChiTietHoaDonNhap.Controls.Add(this.dgrid_ChiTietHoaDonNhap);
            this.gbx_ChiTietHoaDonNhap.Controls.Add(this.label1);
            this.gbx_ChiTietHoaDonNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbx_ChiTietHoaDonNhap.Location = new System.Drawing.Point(338, 0);
            this.gbx_ChiTietHoaDonNhap.Name = "gbx_ChiTietHoaDonNhap";
            this.gbx_ChiTietHoaDonNhap.Size = new System.Drawing.Size(334, 846);
            this.gbx_ChiTietHoaDonNhap.TabIndex = 2;
            this.gbx_ChiTietHoaDonNhap.TabStop = false;
            this.gbx_ChiTietHoaDonNhap.Text = "Chi tiết hóa đơn nhập";
            // 
            // txt_MaHoaDonNhap
            // 
            this.txt_MaHoaDonNhap.Location = new System.Drawing.Point(119, 40);
            this.txt_MaHoaDonNhap.Name = "txt_MaHoaDonNhap";
            this.txt_MaHoaDonNhap.Size = new System.Drawing.Size(194, 27);
            this.txt_MaHoaDonNhap.TabIndex = 1;
            // 
            // txt_DonGiaNhap
            // 
            this.txt_DonGiaNhap.Location = new System.Drawing.Point(119, 115);
            this.txt_DonGiaNhap.Name = "txt_DonGiaNhap";
            this.txt_DonGiaNhap.Size = new System.Drawing.Size(194, 27);
            this.txt_DonGiaNhap.TabIndex = 1;
            // 
            // txt_NhaCungCap
            // 
            this.txt_NhaCungCap.Location = new System.Drawing.Point(119, 78);
            this.txt_NhaCungCap.Name = "txt_NhaCungCap";
            this.txt_NhaCungCap.Size = new System.Drawing.Size(194, 27);
            this.txt_NhaCungCap.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã hóa đơn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đơn giá";
            // 
            // dgrid_ChiTietHoaDonNhap
            // 
            this.dgrid_ChiTietHoaDonNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_ChiTietHoaDonNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_ChiTietHoaDonNhap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrid_ChiTietHoaDonNhap.Location = new System.Drawing.Point(3, 226);
            this.dgrid_ChiTietHoaDonNhap.Name = "dgrid_ChiTietHoaDonNhap";
            this.dgrid_ChiTietHoaDonNhap.RowHeadersWidth = 51;
            this.dgrid_ChiTietHoaDonNhap.RowTemplate.Height = 29;
            this.dgrid_ChiTietHoaDonNhap.Size = new System.Drawing.Size(328, 617);
            this.dgrid_ChiTietHoaDonNhap.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhà cung cấp";
            // 
            // frm_ThongKeThuChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 846);
            this.Controls.Add(this.gbx_ChiTietHoaDonNhap);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbx_ChiTietHoaDonBan);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_ThongKeThuChi";
            this.Text = "frm_ThongKeThuChi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_HoaDonNhap)).EndInit();
            this.gbx_ChiTietHoaDonBan.ResumeLayout(false);
            this.gbx_ChiTietHoaDonBan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_ChiTietHoaDonBan)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_HoaDonBan)).EndInit();
            this.gbx_ChiTietHoaDonNhap.ResumeLayout(false);
            this.gbx_ChiTietHoaDonNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_ChiTietHoaDonNhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgrid_HoaDonNhap;
        private System.Windows.Forms.GroupBox gbx_ChiTietHoaDonBan;
        private System.Windows.Forms.DataGridView dgrid_ChiTietHoaDonBan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgrid_HoaDonBan;
        private System.Windows.Forms.GroupBox gbx_ChiTietHoaDonNhap;
        private System.Windows.Forms.DataGridView dgrid_ChiTietHoaDonNhap;
        private System.Windows.Forms.DateTimePicker dtp_HoaDonNhap;
        private System.Windows.Forms.Button btn_QuiChi;
        private System.Windows.Forms.Button btn_ThangChi;
        private System.Windows.Forms.Button btn_NgayChi;
        private System.Windows.Forms.Label lbl_TongChi;
        private System.Windows.Forms.DateTimePicker dtp_HoaDonXuat;
        private System.Windows.Forms.Button btn_QuiThu;
        private System.Windows.Forms.Button btn_ThangThu;
        private System.Windows.Forms.Button btn_NgayThu;
        private System.Windows.Forms.Label lbl_TongThu;
        private System.Windows.Forms.TextBox txt_MaHoaDonNhap;
        private System.Windows.Forms.TextBox txt_DonGiaNhap;
        private System.Windows.Forms.TextBox txt_NhaCungCap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MaHoaDonBan;
        private System.Windows.Forms.TextBox txt_DonGiaBan;
        private System.Windows.Forms.TextBox txt_MaPhong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_chi;
        private System.Windows.Forms.TextBox txt_ThoiGianDung;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_Thu;
        private System.Windows.Forms.TextBox txt_CongThucTinh;
        private System.Windows.Forms.Label label8;
    }
}