namespace QLPhongTro.GUI
{
    partial class NhapPC
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
            this.cbphong = new System.Windows.Forms.ComboBox();
            this.txtlydo = new System.Windows.Forms.TextBox();
            this.dtpngaychi = new System.Windows.Forms.DateTimePicker();
            this.txttien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvds = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnlammoi = new System.Windows.Forms.Button();
            this.btnghi = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbltongtien = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbphong);
            this.groupBox1.Controls.Add(this.txtlydo);
            this.groupBox1.Controls.Add(this.dtpngaychi);
            this.groupBox1.Controls.Add(this.txttien);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu chi";
            // 
            // cbphong
            // 
            this.cbphong.FormattingEnabled = true;
            this.cbphong.Location = new System.Drawing.Point(378, 70);
            this.cbphong.Name = "cbphong";
            this.cbphong.Size = new System.Drawing.Size(158, 21);
            this.cbphong.TabIndex = 8;
            // 
            // txtlydo
            // 
            this.txtlydo.Location = new System.Drawing.Point(378, 30);
            this.txtlydo.Name = "txtlydo";
            this.txtlydo.Size = new System.Drawing.Size(158, 20);
            this.txtlydo.TabIndex = 7;
            // 
            // dtpngaychi
            // 
            this.dtpngaychi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaychi.Location = new System.Drawing.Point(104, 67);
            this.dtpngaychi.Name = "dtpngaychi";
            this.dtpngaychi.Size = new System.Drawing.Size(158, 20);
            this.dtpngaychi.TabIndex = 6;
            // 
            // txttien
            // 
            this.txttien.Location = new System.Drawing.Point(104, 30);
            this.txttien.Name = "txttien";
            this.txttien.Size = new System.Drawing.Size(158, 20);
            this.txttien.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lý do";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày chi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số tiền";
            // 
            // lvds
            // 
            this.lvds.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvds.FullRowSelect = true;
            this.lvds.GridLines = true;
            this.lvds.Location = new System.Drawing.Point(12, 211);
            this.lvds.Name = "lvds";
            this.lvds.Size = new System.Drawing.Size(604, 240);
            this.lvds.TabIndex = 1;
            this.lvds.UseCompatibleStateImageBehavior = false;
            this.lvds.View = System.Windows.Forms.View.Details;
            this.lvds.Click += new System.EventHandler(this.lvds_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 58;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số tiền";
            this.columnHeader2.Width = 108;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày chi";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Lý do";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mã phòng";
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(35, 149);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 30);
            this.btnthem.TabIndex = 2;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(132, 149);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 30);
            this.btnxoa.TabIndex = 3;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(229, 149);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 30);
            this.btnupdate.TabIndex = 4;
            this.btnupdate.Text = "Cập nhật";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnlammoi
            // 
            this.btnlammoi.Location = new System.Drawing.Point(530, 131);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(75, 30);
            this.btnlammoi.TabIndex = 5;
            this.btnlammoi.Text = "Làm mới";
            this.btnlammoi.UseVisualStyleBackColor = true;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // btnghi
            // 
            this.btnghi.Location = new System.Drawing.Point(326, 149);
            this.btnghi.Name = "btnghi";
            this.btnghi.Size = new System.Drawing.Size(75, 30);
            this.btnghi.TabIndex = 6;
            this.btnghi.Text = "Ghi";
            this.btnghi.UseVisualStyleBackColor = true;
            this.btnghi.Click += new System.EventHandler(this.btnghi_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(441, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tổng tiền:";
            // 
            // lbltongtien
            // 
            this.lbltongtien.AutoSize = true;
            this.lbltongtien.Location = new System.Drawing.Point(502, 195);
            this.lbltongtien.Name = "lbltongtien";
            this.lbltongtien.Size = new System.Drawing.Size(39, 13);
            this.lbltongtien.TabIndex = 8;
            this.lbltongtien.Text = "0 VND";
            // 
            // NhapPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 463);
            this.Controls.Add(this.lbltongtien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnghi);
            this.Controls.Add(this.btnlammoi);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.lvds);
            this.Controls.Add(this.groupBox1);
            this.Name = "NhapPC";
            this.Text = "NhapPC";
            this.Load += new System.EventHandler(this.NhapPC_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvds;
        private System.Windows.Forms.ComboBox cbphong;
        private System.Windows.Forms.TextBox txtlydo;
        private System.Windows.Forms.DateTimePicker dtpngaychi;
        private System.Windows.Forms.TextBox txttien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnlammoi;
        private System.Windows.Forms.Button btnghi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbltongtien;
    }
}