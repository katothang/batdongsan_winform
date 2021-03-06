namespace QuanLyBatDongSan.GUI.DANHMUC
{
	partial class NhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVien));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pcDelete = new System.Windows.Forms.PictureBox();
            this.gvdata = new System.Windows.Forms.DataGridView();
            this.pcSearch = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btLamMoi = new System.Windows.Forms.Button();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.pcEdit = new System.Windows.Forms.PictureBox();
            this.pcSave = new System.Windows.Forms.PictureBox();
            this.pndata = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnmenu = new System.Windows.Forms.Panel();
            this.lbdiachi = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbnhaplaimk = new System.Windows.Forms.Label();
            this.lbmatkhau = new System.Windows.Forms.Label();
            this.lbtaikhoan = new System.Windows.Forms.Label();
            this.lbtennv = new System.Windows.Forms.Label();
            this.cbbChucVu = new System.Windows.Forms.ComboBox();
            this.cbbGioiTinh = new System.Windows.Forms.ComboBox();
            this.lbcv = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMK2 = new System.Windows.Forms.TextBox();
            this.tbMK1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTenNV = new System.Windows.Forms.TextBox();
            this.tbTenTK = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcSave)).BeginInit();
            this.pndata.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcDelete
            // 
            this.pcDelete.Image = ((System.Drawing.Image)(resources.GetObject("pcDelete.Image")));
            this.pcDelete.Location = new System.Drawing.Point(781, 262);
            this.pcDelete.Name = "pcDelete";
            this.pcDelete.Size = new System.Drawing.Size(88, 57);
            this.pcDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcDelete.TabIndex = 28;
            this.pcDelete.TabStop = false;
            this.pcDelete.Click += new System.EventHandler(this.PcDelete_Click);
            // 
            // gvdata
            // 
            this.gvdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvdata.Location = new System.Drawing.Point(8, 325);
            this.gvdata.Name = "gvdata";
            this.gvdata.ReadOnly = true;
            this.gvdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvdata.Size = new System.Drawing.Size(896, 253);
            this.gvdata.TabIndex = 14;
            this.gvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gvdata_CellContentClick);
            // 
            // pcSearch
            // 
            this.pcSearch.Image = ((System.Drawing.Image)(resources.GetObject("pcSearch.Image")));
            this.pcSearch.Location = new System.Drawing.Point(228, 15);
            this.pcSearch.Name = "pcSearch";
            this.pcSearch.Size = new System.Drawing.Size(32, 26);
            this.pcSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcSearch.TabIndex = 14;
            this.pcSearch.TabStop = false;
            this.pcSearch.Click += new System.EventHandler(this.PcSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tìm kiếm";
            // 
            // btLamMoi
            // 
            this.btLamMoi.BackColor = System.Drawing.Color.DarkOrange;
            this.btLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLamMoi.ForeColor = System.Drawing.Color.White;
            this.btLamMoi.Location = new System.Drawing.Point(266, 3);
            this.btLamMoi.Name = "btLamMoi";
            this.btLamMoi.Size = new System.Drawing.Size(104, 48);
            this.btLamMoi.TabIndex = 12;
            this.btLamMoi.Text = "Làm Mới";
            this.btLamMoi.UseVisualStyleBackColor = false;
            this.btLamMoi.Click += new System.EventHandler(this.BtLamMoi_Click);
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimKiem.Location = new System.Drawing.Point(18, 15);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Size = new System.Drawing.Size(203, 26);
            this.tbTimKiem.TabIndex = 11;
            // 
            // pcEdit
            // 
            this.pcEdit.Image = ((System.Drawing.Image)(resources.GetObject("pcEdit.Image")));
            this.pcEdit.Location = new System.Drawing.Point(691, 261);
            this.pcEdit.Name = "pcEdit";
            this.pcEdit.Size = new System.Drawing.Size(73, 58);
            this.pcEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcEdit.TabIndex = 27;
            this.pcEdit.TabStop = false;
            this.pcEdit.Click += new System.EventHandler(this.PcEdit_Click);
            // 
            // pcSave
            // 
            this.pcSave.Image = ((System.Drawing.Image)(resources.GetObject("pcSave.Image")));
            this.pcSave.Location = new System.Drawing.Point(607, 261);
            this.pcSave.Name = "pcSave";
            this.pcSave.Size = new System.Drawing.Size(64, 58);
            this.pcSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcSave.TabIndex = 26;
            this.pcSave.TabStop = false;
            this.pcSave.Click += new System.EventHandler(this.PcSave_Click);
            // 
            // pndata
            // 
            this.pndata.BackColor = System.Drawing.Color.White;
            this.pndata.Controls.Add(this.pcSearch);
            this.pndata.Controls.Add(this.label2);
            this.pndata.Controls.Add(this.btLamMoi);
            this.pndata.Controls.Add(this.tbTimKiem);
            this.pndata.Location = new System.Drawing.Point(8, 261);
            this.pndata.Name = "pndata";
            this.pndata.Size = new System.Drawing.Size(387, 58);
            this.pndata.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pcDelete);
            this.panel2.Controls.Add(this.pcEdit);
            this.panel2.Controls.Add(this.pcSave);
            this.panel2.Controls.Add(this.pndata);
            this.panel2.Controls.Add(this.gvdata);
            this.panel2.Controls.Add(this.pnmenu);
            this.panel2.Location = new System.Drawing.Point(2, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(909, 594);
            this.panel2.TabIndex = 47;
            // 
            // pnmenu
            // 
            this.pnmenu.BackColor = System.Drawing.Color.White;
            this.pnmenu.Controls.Add(this.lbdiachi);
            this.pnmenu.Controls.Add(this.lbSDT);
            this.pnmenu.Controls.Add(this.lbnhaplaimk);
            this.pnmenu.Controls.Add(this.lbmatkhau);
            this.pnmenu.Controls.Add(this.lbtaikhoan);
            this.pnmenu.Controls.Add(this.lbtennv);
            this.pnmenu.Controls.Add(this.cbbChucVu);
            this.pnmenu.Controls.Add(this.cbbGioiTinh);
            this.pnmenu.Controls.Add(this.lbcv);
            this.pnmenu.Controls.Add(this.label8);
            this.pnmenu.Controls.Add(this.dtNgaySinh);
            this.pnmenu.Controls.Add(this.label9);
            this.pnmenu.Controls.Add(this.label1);
            this.pnmenu.Controls.Add(this.tbSDT);
            this.pnmenu.Controls.Add(this.label3);
            this.pnmenu.Controls.Add(this.tbDiaChi);
            this.pnmenu.Controls.Add(this.label4);
            this.pnmenu.Controls.Add(this.tbMK2);
            this.pnmenu.Controls.Add(this.tbMK1);
            this.pnmenu.Controls.Add(this.label5);
            this.pnmenu.Controls.Add(this.tbTenNV);
            this.pnmenu.Controls.Add(this.tbTenTK);
            this.pnmenu.Controls.Add(this.label6);
            this.pnmenu.Controls.Add(this.label7);
            this.pnmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnmenu.ForeColor = System.Drawing.Color.Black;
            this.pnmenu.Location = new System.Drawing.Point(8, 12);
            this.pnmenu.Name = "pnmenu";
            this.pnmenu.Size = new System.Drawing.Size(891, 243);
            this.pnmenu.TabIndex = 9;
            this.pnmenu.TabStop = true;
            // 
            // lbdiachi
            // 
            this.lbdiachi.AutoSize = true;
            this.lbdiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdiachi.ForeColor = System.Drawing.Color.Red;
            this.lbdiachi.Location = new System.Drawing.Point(610, 47);
            this.lbdiachi.Name = "lbdiachi";
            this.lbdiachi.Size = new System.Drawing.Size(0, 13);
            this.lbdiachi.TabIndex = 53;
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSDT.ForeColor = System.Drawing.Color.Red;
            this.lbSDT.Location = new System.Drawing.Point(588, 139);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(0, 13);
            this.lbSDT.TabIndex = 52;
            // 
            // lbnhaplaimk
            // 
            this.lbnhaplaimk.AutoSize = true;
            this.lbnhaplaimk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnhaplaimk.ForeColor = System.Drawing.Color.Red;
            this.lbnhaplaimk.Location = new System.Drawing.Point(138, 185);
            this.lbnhaplaimk.Name = "lbnhaplaimk";
            this.lbnhaplaimk.Size = new System.Drawing.Size(0, 13);
            this.lbnhaplaimk.TabIndex = 51;
            // 
            // lbmatkhau
            // 
            this.lbmatkhau.AutoSize = true;
            this.lbmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmatkhau.ForeColor = System.Drawing.Color.Red;
            this.lbmatkhau.Location = new System.Drawing.Point(138, 140);
            this.lbmatkhau.Name = "lbmatkhau";
            this.lbmatkhau.Size = new System.Drawing.Size(0, 13);
            this.lbmatkhau.TabIndex = 50;
            // 
            // lbtaikhoan
            // 
            this.lbtaikhoan.AutoSize = true;
            this.lbtaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtaikhoan.ForeColor = System.Drawing.Color.Red;
            this.lbtaikhoan.Location = new System.Drawing.Point(138, 95);
            this.lbtaikhoan.Name = "lbtaikhoan";
            this.lbtaikhoan.Size = new System.Drawing.Size(0, 13);
            this.lbtaikhoan.TabIndex = 49;
            // 
            // lbtennv
            // 
            this.lbtennv.AutoSize = true;
            this.lbtennv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtennv.ForeColor = System.Drawing.Color.Red;
            this.lbtennv.Location = new System.Drawing.Point(141, 50);
            this.lbtennv.Name = "lbtennv";
            this.lbtennv.Size = new System.Drawing.Size(0, 13);
            this.lbtennv.TabIndex = 48;
            // 
            // cbbChucVu
            // 
            this.cbbChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbChucVu.FormattingEnabled = true;
            this.cbbChucVu.Items.AddRange(new object[] {
            "admin",
            "Nhân Viên"});
            this.cbbChucVu.Location = new System.Drawing.Point(591, 197);
            this.cbbChucVu.Name = "cbbChucVu";
            this.cbbChucVu.Size = new System.Drawing.Size(288, 28);
            this.cbbChucVu.TabIndex = 34;
            // 
            // cbbGioiTinh
            // 
            this.cbbGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbGioiTinh.FormattingEnabled = true;
            this.cbbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbGioiTinh.Location = new System.Drawing.Point(591, 63);
            this.cbbGioiTinh.Name = "cbbGioiTinh";
            this.cbbGioiTinh.Size = new System.Drawing.Size(64, 28);
            this.cbbGioiTinh.TabIndex = 35;
            // 
            // lbcv
            // 
            this.lbcv.AutoSize = true;
            this.lbcv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcv.Location = new System.Drawing.Point(490, 200);
            this.lbcv.Name = "lbcv";
            this.lbcv.Size = new System.Drawing.Size(78, 20);
            this.lbcv.TabIndex = 37;
            this.lbcv.Text = "Chức vụ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 20);
            this.label8.TabIndex = 47;
            this.label8.Text = "Tên tài khoản:";
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgaySinh.Location = new System.Drawing.Point(591, 155);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(288, 26);
            this.dtNgaySinh.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 20);
            this.label9.TabIndex = 44;
            this.label9.Text = "Nhập lại MK:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "Mật khẩu:";
            // 
            // tbSDT
            // 
            this.tbSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSDT.Location = new System.Drawing.Point(591, 110);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(288, 26);
            this.tbSDT.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Tên NV:";
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiaChi.Location = new System.Drawing.Point(591, 18);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(288, 26);
            this.tbDiaChi.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(490, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 43;
            this.label4.Text = "Ngày Sinh:";
            // 
            // tbMK2
            // 
            this.tbMK2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMK2.Location = new System.Drawing.Point(141, 156);
            this.tbMK2.Name = "tbMK2";
            this.tbMK2.Size = new System.Drawing.Size(270, 26);
            this.tbMK2.TabIndex = 33;
            this.tbMK2.UseSystemPasswordChar = true;
            // 
            // tbMK1
            // 
            this.tbMK1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMK1.Location = new System.Drawing.Point(141, 111);
            this.tbMK1.Name = "tbMK1";
            this.tbMK1.Size = new System.Drawing.Size(270, 26);
            this.tbMK1.TabIndex = 32;
            this.tbMK1.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(490, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "Địa Chỉ:";
            // 
            // tbTenNV
            // 
            this.tbTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenNV.Location = new System.Drawing.Point(141, 21);
            this.tbTenNV.Name = "tbTenNV";
            this.tbTenNV.Size = new System.Drawing.Size(270, 26);
            this.tbTenNV.TabIndex = 30;
            // 
            // tbTenTK
            // 
            this.tbTenTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenTK.Location = new System.Drawing.Point(141, 66);
            this.tbTenTK.Name = "tbTenTK";
            this.tbTenTK.Size = new System.Drawing.Size(270, 26);
            this.tbTenTK.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(490, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 40;
            this.label6.Text = "Giới Tính:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(490, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "SĐT:";
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(913, 606);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.pcDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcSave)).EndInit();
            this.pndata.ResumeLayout(false);
            this.pndata.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnmenu.ResumeLayout(false);
            this.pnmenu.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.PictureBox pcDelete;
		private System.Windows.Forms.DataGridView gvdata;
		private System.Windows.Forms.PictureBox pcSearch;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btLamMoi;
		private System.Windows.Forms.TextBox tbTimKiem;
		private System.Windows.Forms.PictureBox pcEdit;
		private System.Windows.Forms.PictureBox pcSave;
		private System.Windows.Forms.Panel pndata;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel pnmenu;
		private System.Windows.Forms.Label lbdiachi;
		private System.Windows.Forms.Label lbSDT;
		private System.Windows.Forms.Label lbnhaplaimk;
		private System.Windows.Forms.Label lbmatkhau;
		private System.Windows.Forms.Label lbtaikhoan;
		private System.Windows.Forms.Label lbtennv;
		private System.Windows.Forms.ComboBox cbbChucVu;
		private System.Windows.Forms.ComboBox cbbGioiTinh;
		private System.Windows.Forms.Label lbcv;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DateTimePicker dtNgaySinh;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbSDT;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbDiaChi;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbMK2;
		private System.Windows.Forms.TextBox tbMK1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbTenNV;
		private System.Windows.Forms.TextBox tbTenTK;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
	}
}