namespace QLPhongTro.GUI
{
    partial class frmQLPC
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
            this.lvds = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpngaychi = new System.Windows.Forms.DateTimePicker();
            this.cbphong = new System.Windows.Forms.ComboBox();
            this.txttien = new System.Windows.Forms.TextBox();
            this.txtmapchi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.btnlammoi = new System.Windows.Forms.Button();
            this.lvtt = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvds
            // 
            this.lvds.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5});
            this.lvds.FullRowSelect = true;
            this.lvds.GridLines = true;
            this.lvds.Location = new System.Drawing.Point(12, 247);
            this.lvds.Name = "lvds";
            this.lvds.Size = new System.Drawing.Size(443, 242);
            this.lvds.TabIndex = 0;
            this.lvds.UseCompatibleStateImageBehavior = false;
            this.lvds.View = System.Windows.Forms.View.Details;
            this.lvds.Click += new System.EventHandler(this.lvds_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã phiếu chi";
            this.columnHeader1.Width = 103;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tổng tiền";
            this.columnHeader2.Width = 102;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ngày chi";
            this.columnHeader3.Width = 105;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mã phòng";
            this.columnHeader5.Width = 82;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpngaychi);
            this.groupBox1.Controls.Add(this.cbphong);
            this.groupBox1.Controls.Add(this.txttien);
            this.groupBox1.Controls.Add(this.txtmapchi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(34, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 133);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu chi";
            // 
            // dtpngaychi
            // 
            this.dtpngaychi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaychi.Location = new System.Drawing.Point(112, 93);
            this.dtpngaychi.Name = "dtpngaychi";
            this.dtpngaychi.Size = new System.Drawing.Size(158, 20);
            this.dtpngaychi.TabIndex = 9;
            // 
            // cbphong
            // 
            this.cbphong.FormattingEnabled = true;
            this.cbphong.Location = new System.Drawing.Point(407, 26);
            this.cbphong.Name = "cbphong";
            this.cbphong.Size = new System.Drawing.Size(158, 21);
            this.cbphong.TabIndex = 8;
            // 
            // txttien
            // 
            this.txttien.Location = new System.Drawing.Point(112, 61);
            this.txttien.Name = "txttien";
            this.txttien.Size = new System.Drawing.Size(158, 20);
            this.txttien.TabIndex = 6;
            // 
            // txtmapchi
            // 
            this.txtmapchi.Enabled = false;
            this.txtmapchi.Location = new System.Drawing.Point(112, 26);
            this.txtmapchi.Name = "txtmapchi";
            this.txtmapchi.Size = new System.Drawing.Size(158, 20);
            this.txtmapchi.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(363, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày chi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số tiền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu chi";
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(49, 171);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 30);
            this.btnthem.TabIndex = 2;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(145, 171);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 30);
            this.btnxoa.TabIndex = 3;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btncapnhat
            // 
            this.btncapnhat.Location = new System.Drawing.Point(241, 171);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(75, 30);
            this.btncapnhat.TabIndex = 4;
            this.btncapnhat.Text = "Cập nhật";
            this.btncapnhat.UseVisualStyleBackColor = true;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // btnlammoi
            // 
            this.btnlammoi.Location = new System.Drawing.Point(564, 171);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(75, 30);
            this.btnlammoi.TabIndex = 5;
            this.btnlammoi.Text = "Làm mới";
            this.btnlammoi.UseVisualStyleBackColor = true;
            // 
            // lvtt
            // 
            this.lvtt.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader6});
            this.lvtt.FullRowSelect = true;
            this.lvtt.GridLines = true;
            this.lvtt.Location = new System.Drawing.Point(461, 247);
            this.lvtt.Name = "lvtt";
            this.lvtt.Size = new System.Drawing.Size(209, 242);
            this.lvtt.TabIndex = 6;
            this.lvtt.UseCompatibleStateImageBehavior = false;
            this.lvtt.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Lý do";
            this.columnHeader4.Width = 108;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Số tiền";
            this.columnHeader6.Width = 93;
            // 
            // frmQLPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 501);
            this.Controls.Add(this.lvtt);
            this.Controls.Add(this.btnlammoi);
            this.Controls.Add(this.btncapnhat);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvds);
            this.Name = "frmQLPC";
            this.Text = "frmQLPC";
            this.Load += new System.EventHandler(this.frmQLPC_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvds;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpngaychi;
        private System.Windows.Forms.ComboBox cbphong;
        private System.Windows.Forms.TextBox txttien;
        private System.Windows.Forms.TextBox txtmapchi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.Button btnlammoi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListView lvtt;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}