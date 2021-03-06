namespace QuanLyBatDongSan.GUI.DANHMUC
{
    partial class XetDuyet
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
            this.lbTieuDe = new System.Windows.Forms.Label();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.tbLyDo = new System.Windows.Forms.RichTextBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbLyDo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.AutoSize = true;
            this.lbTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTieuDe.Location = new System.Drawing.Point(48, 30);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(228, 18);
            this.lbTieuDe.TabIndex = 0;
            this.lbTieuDe.Text = "Xét Duyệt Cho Bài Đăng Mã: ";
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Items.AddRange(new object[] {
            "Trả Về",
            "Duyệt"});
            this.cbTrangThai.Location = new System.Drawing.Point(112, 95);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(158, 21);
            this.cbTrangThai.TabIndex = 1;
            this.cbTrangThai.SelectedIndexChanged += new System.EventHandler(this.cbTrangThai_SelectedIndexChanged);
            // 
            // tbLyDo
            // 
            this.tbLyDo.Location = new System.Drawing.Point(112, 123);
            this.tbLyDo.Name = "tbLyDo";
            this.tbLyDo.Size = new System.Drawing.Size(158, 96);
            this.tbLyDo.TabIndex = 2;
            this.tbLyDo.Text = "";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.DarkOrange;
            this.btnXacNhan.Location = new System.Drawing.Point(288, 237);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(113, 32);
            this.btnXacNhan.TabIndex = 3;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Trạng Thái";
            // 
            // lbLyDo
            // 
            this.lbLyDo.AutoSize = true;
            this.lbLyDo.Location = new System.Drawing.Point(48, 135);
            this.lbLyDo.Name = "lbLyDo";
            this.lbLyDo.Size = new System.Drawing.Size(35, 13);
            this.lbLyDo.TabIndex = 5;
            this.lbLyDo.Text = "Lý Do";
            // 
            // XetDuyet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 277);
            this.Controls.Add(this.lbLyDo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.tbLyDo);
            this.Controls.Add(this.cbTrangThai);
            this.Controls.Add(this.lbTieuDe);
            this.Name = "XetDuyet";
            this.Text = "Duyệt Bài Đăng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTieuDe;
        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.RichTextBox tbLyDo;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbLyDo;
    }
}