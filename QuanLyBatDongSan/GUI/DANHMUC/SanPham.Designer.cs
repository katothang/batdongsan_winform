namespace QuanLyBatDongSan.GUI.DANHMUC
{
	partial class SanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SanPham));
            this.pcEdit = new System.Windows.Forms.PictureBox();
            this.pndata = new System.Windows.Forms.Panel();
            this.cbTimLoaiDat = new System.Windows.Forms.ComboBox();
            this.pcSearch = new System.Windows.Forms.PictureBox();
            this.btLamMoi = new System.Windows.Forms.Button();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pcSave = new System.Windows.Forms.PictureBox();
            this.gvdata = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.btnDuyetBai = new System.Windows.Forms.Button();
            this.pcDelete = new System.Windows.Forms.PictureBox();
            this.pnmenu = new System.Windows.Forms.Panel();
            this.tbGiaBDS = new System.Windows.Forms.NumericUpDown();
            this.cbXa = new System.Windows.Forms.ComboBox();
            this.cbHuyen = new System.Windows.Forms.ComboBox();
            this.cbTinh = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tbDienTichTrenSo = new System.Windows.Forms.TextBox();
            this.tbTinhTrang = new System.Windows.Forms.ComboBox();
            this.tbPhapLy = new System.Windows.Forms.ComboBox();
            this.tbLoaiBDS = new System.Windows.Forms.ComboBox();
            this.tbTrangThai = new System.Windows.Forms.ComboBox();
            this.tbThongTin = new System.Windows.Forms.RichTextBox();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.tbHuong = new System.Windows.Forms.ComboBox();
            this.dtThoiGianXD = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tbSoTang = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbDuongRong = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbMatTien = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbDienTichSuDung = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbmalk = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMaBDS = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcEdit)).BeginInit();
            this.pndata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvdata)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcDelete)).BeginInit();
            this.pnmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbGiaBDS)).BeginInit();
            this.SuspendLayout();
            // 
            // pcEdit
            // 
            this.pcEdit.Image = ((System.Drawing.Image)(resources.GetObject("pcEdit.Image")));
            this.pcEdit.Location = new System.Drawing.Point(744, 367);
            this.pcEdit.Name = "pcEdit";
            this.pcEdit.Size = new System.Drawing.Size(56, 37);
            this.pcEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcEdit.TabIndex = 27;
            this.pcEdit.TabStop = false;
            this.pcEdit.Click += new System.EventHandler(this.PcEdit_Click);
            // 
            // pndata
            // 
            this.pndata.BackColor = System.Drawing.Color.White;
            this.pndata.Controls.Add(this.cbTimLoaiDat);
            this.pndata.Controls.Add(this.pcSearch);
            this.pndata.Controls.Add(this.btLamMoi);
            this.pndata.Controls.Add(this.tbTimKiem);
            this.pndata.Location = new System.Drawing.Point(10, 361);
            this.pndata.Name = "pndata";
            this.pndata.Size = new System.Drawing.Size(438, 43);
            this.pndata.TabIndex = 25;
            // 
            // cbTimLoaiDat
            // 
            this.cbTimLoaiDat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimLoaiDat.FormattingEnabled = true;
            this.cbTimLoaiDat.Items.AddRange(new object[] {
            "Đất dự án, phân lô",
            "Đất nền, thổ cư",
            "Nhà biệt thự",
            "Nhà mặt phố",
            "Nhà ngõ, hẻm"});
            this.cbTimLoaiDat.Location = new System.Drawing.Point(3, 15);
            this.cbTimLoaiDat.Name = "cbTimLoaiDat";
            this.cbTimLoaiDat.Size = new System.Drawing.Size(91, 21);
            this.cbTimLoaiDat.Sorted = true;
            this.cbTimLoaiDat.TabIndex = 84;
            this.cbTimLoaiDat.Tag = "1";
            // 
            // pcSearch
            // 
            this.pcSearch.Image = ((System.Drawing.Image)(resources.GetObject("pcSearch.Image")));
            this.pcSearch.Location = new System.Drawing.Point(306, 14);
            this.pcSearch.Name = "pcSearch";
            this.pcSearch.Size = new System.Drawing.Size(32, 26);
            this.pcSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcSearch.TabIndex = 14;
            this.pcSearch.TabStop = false;
            this.pcSearch.Click += new System.EventHandler(this.PcSearch_Click);
            // 
            // btLamMoi
            // 
            this.btLamMoi.BackColor = System.Drawing.Color.DarkOrange;
            this.btLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLamMoi.ForeColor = System.Drawing.Color.White;
            this.btLamMoi.Location = new System.Drawing.Point(344, 6);
            this.btLamMoi.Name = "btLamMoi";
            this.btLamMoi.Size = new System.Drawing.Size(91, 34);
            this.btLamMoi.TabIndex = 12;
            this.btLamMoi.Text = "Làm Mới";
            this.btLamMoi.UseVisualStyleBackColor = false;
            this.btLamMoi.Click += new System.EventHandler(this.BtLamMoi_Click);
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimKiem.Location = new System.Drawing.Point(97, 14);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(203, 26);
            this.tbTimKiem.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Loại Đất";
            // 
            // pcSave
            // 
            this.pcSave.Image = ((System.Drawing.Image)(resources.GetObject("pcSave.Image")));
            this.pcSave.Location = new System.Drawing.Point(673, 367);
            this.pcSave.Name = "pcSave";
            this.pcSave.Size = new System.Drawing.Size(51, 37);
            this.pcSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcSave.TabIndex = 26;
            this.pcSave.TabStop = false;
            this.pcSave.Click += new System.EventHandler(this.PcSave_Click);
            // 
            // gvdata
            // 
            this.gvdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvdata.Location = new System.Drawing.Point(8, 410);
            this.gvdata.Name = "gvdata";
            this.gvdata.ReadOnly = true;
            this.gvdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvdata.Size = new System.Drawing.Size(891, 173);
            this.gvdata.TabIndex = 14;
            this.gvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gvdata_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnChiTiet);
            this.panel2.Controls.Add(this.btnDuyetBai);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pcDelete);
            this.panel2.Controls.Add(this.pcEdit);
            this.panel2.Controls.Add(this.pcSave);
            this.panel2.Controls.Add(this.pndata);
            this.panel2.Controls.Add(this.gvdata);
            this.panel2.Controls.Add(this.pnmenu);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(909, 594);
            this.panel2.TabIndex = 45;
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Location = new System.Drawing.Point(559, 367);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(99, 36);
            this.btnChiTiet.TabIndex = 32;
            this.btnChiTiet.Text = "Chi Tiết Bài";
            this.btnChiTiet.UseVisualStyleBackColor = true;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // btnDuyetBai
            // 
            this.btnDuyetBai.Location = new System.Drawing.Point(454, 367);
            this.btnDuyetBai.Name = "btnDuyetBai";
            this.btnDuyetBai.Size = new System.Drawing.Size(99, 36);
            this.btnDuyetBai.TabIndex = 31;
            this.btnDuyetBai.Text = "Duyệt Bài";
            this.btnDuyetBai.UseVisualStyleBackColor = true;
            this.btnDuyetBai.Click += new System.EventHandler(this.btnDuyetBai_Click);
            // 
            // pcDelete
            // 
            this.pcDelete.Image = ((System.Drawing.Image)(resources.GetObject("pcDelete.Image")));
            this.pcDelete.Location = new System.Drawing.Point(815, 367);
            this.pcDelete.Name = "pcDelete";
            this.pcDelete.Size = new System.Drawing.Size(61, 37);
            this.pcDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcDelete.TabIndex = 28;
            this.pcDelete.TabStop = false;
            this.pcDelete.Click += new System.EventHandler(this.PcDelete_Click);
            // 
            // pnmenu
            // 
            this.pnmenu.BackColor = System.Drawing.Color.White;
            this.pnmenu.Controls.Add(this.tbGiaBDS);
            this.pnmenu.Controls.Add(this.cbXa);
            this.pnmenu.Controls.Add(this.cbHuyen);
            this.pnmenu.Controls.Add(this.cbTinh);
            this.pnmenu.Controls.Add(this.label20);
            this.pnmenu.Controls.Add(this.tbDienTichTrenSo);
            this.pnmenu.Controls.Add(this.tbTinhTrang);
            this.pnmenu.Controls.Add(this.tbPhapLy);
            this.pnmenu.Controls.Add(this.tbLoaiBDS);
            this.pnmenu.Controls.Add(this.tbTrangThai);
            this.pnmenu.Controls.Add(this.tbThongTin);
            this.pnmenu.Controls.Add(this.tbDiaChi);
            this.pnmenu.Controls.Add(this.tbHuong);
            this.pnmenu.Controls.Add(this.dtThoiGianXD);
            this.pnmenu.Controls.Add(this.label19);
            this.pnmenu.Controls.Add(this.label18);
            this.pnmenu.Controls.Add(this.label17);
            this.pnmenu.Controls.Add(this.tbSoTang);
            this.pnmenu.Controls.Add(this.label16);
            this.pnmenu.Controls.Add(this.label15);
            this.pnmenu.Controls.Add(this.label14);
            this.pnmenu.Controls.Add(this.tbDuongRong);
            this.pnmenu.Controls.Add(this.label9);
            this.pnmenu.Controls.Add(this.tbMatTien);
            this.pnmenu.Controls.Add(this.label13);
            this.pnmenu.Controls.Add(this.tbDienTichSuDung);
            this.pnmenu.Controls.Add(this.label12);
            this.pnmenu.Controls.Add(this.label11);
            this.pnmenu.Controls.Add(this.lbmalk);
            this.pnmenu.Controls.Add(this.label8);
            this.pnmenu.Controls.Add(this.label1);
            this.pnmenu.Controls.Add(this.label6);
            this.pnmenu.Controls.Add(this.label3);
            this.pnmenu.Controls.Add(this.label5);
            this.pnmenu.Controls.Add(this.label7);
            this.pnmenu.Controls.Add(this.tbMaBDS);
            this.pnmenu.Controls.Add(this.label10);
            this.pnmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnmenu.ForeColor = System.Drawing.Color.Black;
            this.pnmenu.Location = new System.Drawing.Point(8, 3);
            this.pnmenu.Name = "pnmenu";
            this.pnmenu.Size = new System.Drawing.Size(891, 352);
            this.pnmenu.TabIndex = 9;
            this.pnmenu.TabStop = true;
            // 
            // tbGiaBDS
            // 
            this.tbGiaBDS.Location = new System.Drawing.Point(601, 201);
            this.tbGiaBDS.Maximum = new decimal(new int[] {
            1241513983,
            370409800,
            542101,
            0});
            this.tbGiaBDS.Name = "tbGiaBDS";
            this.tbGiaBDS.Size = new System.Drawing.Size(267, 26);
            this.tbGiaBDS.TabIndex = 92;
            // 
            // cbXa
            // 
            this.cbXa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbXa.FormattingEnabled = true;
            this.cbXa.Items.AddRange(new object[] {
            "Đông",
            "Tây",
            "Nam",
            "Bắc",
            "Đông Nam",
            "Tây Bắc",
            "Tây Nam",
            "Đông Bắc"});
            this.cbXa.Location = new System.Drawing.Point(191, 170);
            this.cbXa.Name = "cbXa";
            this.cbXa.Size = new System.Drawing.Size(227, 28);
            this.cbXa.TabIndex = 91;
            // 
            // cbHuyen
            // 
            this.cbHuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHuyen.FormattingEnabled = true;
            this.cbHuyen.Items.AddRange(new object[] {
            "Đông",
            "Tây",
            "Nam",
            "Bắc",
            "Đông Nam",
            "Tây Bắc",
            "Tây Nam",
            "Đông Bắc"});
            this.cbHuyen.Location = new System.Drawing.Point(191, 135);
            this.cbHuyen.Name = "cbHuyen";
            this.cbHuyen.Size = new System.Drawing.Size(228, 28);
            this.cbHuyen.TabIndex = 90;
            this.cbHuyen.SelectedIndexChanged += new System.EventHandler(this.cbHuyen_SelectedIndexChanged);
            // 
            // cbTinh
            // 
            this.cbTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTinh.FormattingEnabled = true;
            this.cbTinh.Items.AddRange(new object[] {
            "Đông",
            "Tây",
            "Nam",
            "Bắc",
            "Đông Nam",
            "Tây Bắc",
            "Tây Nam",
            "Đông Bắc"});
            this.cbTinh.Location = new System.Drawing.Point(190, 101);
            this.cbTinh.Name = "cbTinh";
            this.cbTinh.Size = new System.Drawing.Size(229, 28);
            this.cbTinh.TabIndex = 89;
            this.cbTinh.SelectedIndexChanged += new System.EventHandler(this.cbTinh_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(24, 109);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(48, 20);
            this.label20.TabIndex = 88;
            this.label20.Text = "Tỉnh:";
            // 
            // tbDienTichTrenSo
            // 
            this.tbDienTichTrenSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDienTichTrenSo.Location = new System.Drawing.Point(601, 5);
            this.tbDienTichTrenSo.Name = "tbDienTichTrenSo";
            this.tbDienTichTrenSo.Size = new System.Drawing.Size(267, 26);
            this.tbDienTichTrenSo.TabIndex = 86;
            // 
            // tbTinhTrang
            // 
            this.tbTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbTinhTrang.FormattingEnabled = true;
            this.tbTinhTrang.Items.AddRange(new object[] {
            "Cá nhân",
            "Chung chủ",
            "Kê biên",
            "Thế chấp",
            "Thừa kế, tặng cho"});
            this.tbTinhTrang.Location = new System.Drawing.Point(190, 267);
            this.tbTinhTrang.Name = "tbTinhTrang";
            this.tbTinhTrang.Size = new System.Drawing.Size(228, 28);
            this.tbTinhTrang.Sorted = true;
            this.tbTinhTrang.TabIndex = 85;
            this.tbTinhTrang.Tag = "1";
            // 
            // tbPhapLy
            // 
            this.tbPhapLy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbPhapLy.FormattingEnabled = true;
            this.tbPhapLy.Items.AddRange(new object[] {
            "Chưa có sổ đỏ",
            "Đã có sổ đỏ"});
            this.tbPhapLy.Location = new System.Drawing.Point(191, 307);
            this.tbPhapLy.Name = "tbPhapLy";
            this.tbPhapLy.Size = new System.Drawing.Size(227, 28);
            this.tbPhapLy.Sorted = true;
            this.tbPhapLy.TabIndex = 84;
            this.tbPhapLy.Tag = "1";
            // 
            // tbLoaiBDS
            // 
            this.tbLoaiBDS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbLoaiBDS.FormattingEnabled = true;
            this.tbLoaiBDS.Items.AddRange(new object[] {
            "Đất dự án, phân lô",
            "Đất nền, thổ cư",
            "Nhà biệt thự",
            "Nhà mặt phố",
            "Nhà ngõ, hẻm"});
            this.tbLoaiBDS.Location = new System.Drawing.Point(191, 204);
            this.tbLoaiBDS.Name = "tbLoaiBDS";
            this.tbLoaiBDS.Size = new System.Drawing.Size(228, 28);
            this.tbLoaiBDS.Sorted = true;
            this.tbLoaiBDS.TabIndex = 83;
            this.tbLoaiBDS.Tag = "1";
            // 
            // tbTrangThai
            // 
            this.tbTrangThai.DisplayMember = "Xây dựng mới";
            this.tbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbTrangThai.FormattingEnabled = true;
            this.tbTrangThai.Items.AddRange(new object[] {
            "Mới sủa chữa cải tạo",
            "Xây dựng cũ",
            "Xây dựng mới"});
            this.tbTrangThai.Location = new System.Drawing.Point(190, 39);
            this.tbTrangThai.Name = "tbTrangThai";
            this.tbTrangThai.Size = new System.Drawing.Size(228, 28);
            this.tbTrangThai.Sorted = true;
            this.tbTrangThai.TabIndex = 82;
            this.tbTrangThai.Tag = "1";
            this.tbTrangThai.ValueMember = "Xây dựng mới";
            // 
            // tbThongTin
            // 
            this.tbThongTin.Location = new System.Drawing.Point(601, 233);
            this.tbThongTin.Name = "tbThongTin";
            this.tbThongTin.Size = new System.Drawing.Size(267, 71);
            this.tbThongTin.TabIndex = 81;
            this.tbThongTin.Text = "";
            this.tbThongTin.TextChanged += new System.EventHandler(this.tbThongTin_TextChanged);
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiaChi.Location = new System.Drawing.Point(190, 71);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(228, 26);
            this.tbDiaChi.TabIndex = 80;
            // 
            // tbHuong
            // 
            this.tbHuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbHuong.FormattingEnabled = true;
            this.tbHuong.Items.AddRange(new object[] {
            "Đông",
            "Tây",
            "Nam",
            "Bắc",
            "Đông Nam",
            "Tây Bắc",
            "Tây Nam",
            "Đông Bắc"});
            this.tbHuong.Location = new System.Drawing.Point(601, 136);
            this.tbHuong.Name = "tbHuong";
            this.tbHuong.Size = new System.Drawing.Size(267, 28);
            this.tbHuong.TabIndex = 79;
            // 
            // dtThoiGianXD
            // 
            this.dtThoiGianXD.CustomFormat = "yyyy";
            this.dtThoiGianXD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtThoiGianXD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtThoiGianXD.Location = new System.Drawing.Point(191, 237);
            this.dtThoiGianXD.Name = "dtThoiGianXD";
            this.dtThoiGianXD.Size = new System.Drawing.Size(227, 26);
            this.dtThoiGianXD.TabIndex = 78;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(458, 207);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(138, 20);
            this.label19.TabIndex = 74;
            this.label19.Text = "Giá BĐS (VNĐ):";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(498, 233);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(93, 20);
            this.label18.TabIndex = 72;
            this.label18.Text = "Thông Tin:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(498, 173);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 20);
            this.label17.TabIndex = 70;
            this.label17.Text = "Số Tầng:";
            // 
            // tbSoTang
            // 
            this.tbSoTang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoTang.Location = new System.Drawing.Point(601, 170);
            this.tbSoTang.Name = "tbSoTang";
            this.tbSoTang.Size = new System.Drawing.Size(267, 26);
            this.tbSoTang.TabIndex = 69;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(498, 141);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 20);
            this.label16.TabIndex = 68;
            this.label16.Text = "Hướng:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(21, 275);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(154, 20);
            this.label15.TabIndex = 66;
            this.label15.Text = "Tình Trạng Sổ Đỏ:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(482, 109);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 20);
            this.label14.TabIndex = 65;
            this.label14.Text = "Đường(m):";
            // 
            // tbDuongRong
            // 
            this.tbDuongRong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDuongRong.Location = new System.Drawing.Point(601, 106);
            this.tbDuongRong.Name = "tbDuongRong";
            this.tbDuongRong.Size = new System.Drawing.Size(267, 26);
            this.tbDuongRong.TabIndex = 64;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(470, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 20);
            this.label9.TabIndex = 63;
            this.label9.Text = "Mặt Tiền(m):";
            // 
            // tbMatTien
            // 
            this.tbMatTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMatTien.Location = new System.Drawing.Point(601, 74);
            this.tbMatTien.Name = "tbMatTien";
            this.tbMatTien.Size = new System.Drawing.Size(267, 26);
            this.tbMatTien.TabIndex = 62;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(423, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(182, 17);
            this.label13.TabIndex = 61;
            this.label13.Text = "Diện Tích Sử Dụng(m2):";
            // 
            // tbDienTichSuDung
            // 
            this.tbDienTichSuDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDienTichSuDung.Location = new System.Drawing.Point(601, 40);
            this.tbDienTichSuDung.Name = "tbDienTichSuDung";
            this.tbDienTichSuDung.Size = new System.Drawing.Size(267, 26);
            this.tbDienTichSuDung.TabIndex = 60;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(424, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(178, 17);
            this.label12.TabIndex = 59;
            this.label12.Text = "Diện Tích Trên Sổ(m2):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(21, 310);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 20);
            this.label11.TabIndex = 57;
            this.label11.Text = "Pháp Lý:";
            // 
            // lbmalk
            // 
            this.lbmalk.AutoSize = true;
            this.lbmalk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmalk.ForeColor = System.Drawing.Color.Red;
            this.lbmalk.Location = new System.Drawing.Point(188, 39);
            this.lbmalk.Name = "lbmalk";
            this.lbmalk.Size = new System.Drawing.Size(0, 13);
            this.lbmalk.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 20);
            this.label8.TabIndex = 42;
            this.label8.Text = "Loại BDS:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Mã BDS:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 20);
            this.label6.TabIndex = 41;
            this.label6.Text = "Thời Gian XD:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Trạng Thái:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Địa Chỉ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "Quận/Huyện:";
            // 
            // tbMaBDS
            // 
            this.tbMaBDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaBDS.Location = new System.Drawing.Point(191, 10);
            this.tbMaBDS.Name = "tbMaBDS";
            this.tbMaBDS.Size = new System.Drawing.Size(227, 26);
            this.tbMaBDS.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 20);
            this.label10.TabIndex = 36;
            this.label10.Text = "Phường/Xã:";
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 595);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SanPham";
            this.Text = "NhapHang";
            ((System.ComponentModel.ISupportInitialize)(this.pcEdit)).EndInit();
            this.pndata.ResumeLayout(false);
            this.pndata.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvdata)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcDelete)).EndInit();
            this.pnmenu.ResumeLayout(false);
            this.pnmenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbGiaBDS)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pcEdit;
		private System.Windows.Forms.Panel pndata;
		private System.Windows.Forms.PictureBox pcSearch;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btLamMoi;
		private System.Windows.Forms.TextBox tbTimKiem;
		private System.Windows.Forms.PictureBox pcSave;
		private System.Windows.Forms.DataGridView gvdata;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pcDelete;
		private System.Windows.Forms.Panel pnmenu;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label lbmalk;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbMaBDS;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox tbHuong;
        private System.Windows.Forms.RichTextBox tbThongTin;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.DateTimePicker dtThoiGianXD;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox tbTrangThai;
        private System.Windows.Forms.ComboBox tbTinhTrang;
        private System.Windows.Forms.ComboBox tbPhapLy;
        private System.Windows.Forms.ComboBox tbLoaiBDS;
        private System.Windows.Forms.TextBox tbSoTang;
        private System.Windows.Forms.TextBox tbDuongRong;
        private System.Windows.Forms.TextBox tbMatTien;
        private System.Windows.Forms.TextBox tbDienTichSuDung;
        private System.Windows.Forms.TextBox tbDienTichTrenSo;
        private System.Windows.Forms.Button btnDuyetBai;
        private System.Windows.Forms.ComboBox cbXa;
        private System.Windows.Forms.ComboBox cbHuyen;
        private System.Windows.Forms.ComboBox cbTinh;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnChiTiet;
        private System.Windows.Forms.NumericUpDown tbGiaBDS;
        private System.Windows.Forms.ComboBox cbTimLoaiDat;
    }
}