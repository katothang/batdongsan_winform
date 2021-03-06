namespace QuanLyBatDongSan.GUI.DANHMUC
{
	partial class NhomKH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhomKH));
            this.pcDelete = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pcEdit = new System.Windows.Forms.PictureBox();
            this.pcSave = new System.Windows.Forms.PictureBox();
            this.pndata = new System.Windows.Forms.Panel();
            this.pcSearch = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btLamMoi = new System.Windows.Forms.Button();
            this.tbTimKiem = new System.Windows.Forms.TextBox();
            this.gvdata = new System.Windows.Forms.DataGridView();
            this.pnmenu = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMaNhom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTenNhom = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcDelete)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcSave)).BeginInit();
            this.pndata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvdata)).BeginInit();
            this.pnmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcDelete
            // 
            this.pcDelete.Image = ((System.Drawing.Image)(resources.GetObject("pcDelete.Image")));
            this.pcDelete.Location = new System.Drawing.Point(781, 164);
            this.pcDelete.Name = "pcDelete";
            this.pcDelete.Size = new System.Drawing.Size(88, 57);
            this.pcDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcDelete.TabIndex = 28;
            this.pcDelete.TabStop = false;
            this.pcDelete.Click += new System.EventHandler(this.PcDelete_Click);
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
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(909, 594);
            this.panel2.TabIndex = 46;
            // 
            // pcEdit
            // 
            this.pcEdit.Image = ((System.Drawing.Image)(resources.GetObject("pcEdit.Image")));
            this.pcEdit.Location = new System.Drawing.Point(691, 163);
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
            this.pcSave.Location = new System.Drawing.Point(607, 163);
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
            this.pndata.Location = new System.Drawing.Point(8, 163);
            this.pndata.Name = "pndata";
            this.pndata.Size = new System.Drawing.Size(387, 58);
            this.pndata.TabIndex = 25;
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
            // gvdata
            // 
            this.gvdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvdata.Location = new System.Drawing.Point(8, 227);
            this.gvdata.Name = "gvdata";
            this.gvdata.ReadOnly = true;
            this.gvdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvdata.Size = new System.Drawing.Size(896, 196);
            this.gvdata.TabIndex = 14;
            this.gvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gvdata_CellContentClick);
            // 
            // pnmenu
            // 
            this.pnmenu.BackColor = System.Drawing.Color.White;
            this.pnmenu.Controls.Add(this.label3);
            this.pnmenu.Controls.Add(this.tbMaNhom);
            this.pnmenu.Controls.Add(this.label1);
            this.pnmenu.Controls.Add(this.tbTenNhom);
            this.pnmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnmenu.ForeColor = System.Drawing.Color.Black;
            this.pnmenu.Location = new System.Drawing.Point(8, 12);
            this.pnmenu.Name = "pnmenu";
            this.pnmenu.Size = new System.Drawing.Size(891, 135);
            this.pnmenu.TabIndex = 9;
            this.pnmenu.TabStop = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Mã Nhóm:";
            // 
            // tbMaNhom
            // 
            this.tbMaNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaNhom.Location = new System.Drawing.Point(294, 9);
            this.tbMaNhom.Name = "tbMaNhom";
            this.tbMaNhom.Size = new System.Drawing.Size(231, 26);
            this.tbMaNhom.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Tên Nhóm:";
            // 
            // tbTenNhom
            // 
            this.tbTenNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenNhom.Location = new System.Drawing.Point(294, 55);
            this.tbTenNhom.Name = "tbTenNhom";
            this.tbTenNhom.Size = new System.Drawing.Size(231, 26);
            this.tbTenNhom.TabIndex = 23;
            // 
            // NhomKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(922, 611);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NhomKH";
            this.Text = "NhaCungCap";
            ((System.ComponentModel.ISupportInitialize)(this.pcDelete)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcSave)).EndInit();
            this.pndata.ResumeLayout(false);
            this.pndata.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvdata)).EndInit();
            this.pnmenu.ResumeLayout(false);
            this.pnmenu.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.PictureBox pcDelete;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pcEdit;
		private System.Windows.Forms.PictureBox pcSave;
		private System.Windows.Forms.Panel pndata;
		private System.Windows.Forms.PictureBox pcSearch;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btLamMoi;
		private System.Windows.Forms.TextBox tbTimKiem;
		private System.Windows.Forms.DataGridView gvdata;
		private System.Windows.Forms.Panel pnmenu;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbTenNhom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMaNhom;
    }
}