namespace QLPhongTro.GUI
{
    partial class frmQLPT
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
            this.lvlist = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstds = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.txtmaphong = new System.Windows.Forms.TextBox();
            this.txttenphong = new System.Windows.Forms.TextBox();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.cbkv = new System.Windows.Forms.ComboBox();
            this.numsl = new System.Windows.Forms.NumericUpDown();
            this.cbnhomtb = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnghi = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.cbtrangthai = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numsl)).BeginInit();
            this.SuspendLayout();
            // 
            // lvlist
            // 
            this.lvlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvlist.FullRowSelect = true;
            this.lvlist.GridLines = true;
            this.lvlist.Location = new System.Drawing.Point(12, 321);
            this.lvlist.Name = "lvlist";
            this.lvlist.Size = new System.Drawing.Size(645, 182);
            this.lvlist.TabIndex = 3;
            this.lvlist.UseCompatibleStateImageBehavior = false;
            this.lvlist.View = System.Windows.Forms.View.Details;
            this.lvlist.Click += new System.EventHandler(this.listView1_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã phòng";
            this.columnHeader1.Width = 78;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên phòng";
            this.columnHeader2.Width = 81;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giá";
            this.columnHeader3.Width = 72;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Khu vực";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Số khách trọ";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Trạng thái";
            this.columnHeader6.Width = 95;
            // 
            // lstds
            // 
            this.lstds.FormattingEnabled = true;
            this.lstds.Location = new System.Drawing.Point(12, 12);
            this.lstds.Name = "lstds";
            this.lstds.Size = new System.Drawing.Size(182, 290);
            this.lstds.TabIndex = 4;
            this.lstds.SelectedIndexChanged += new System.EventHandler(this.lstds_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbtrangthai);
            this.groupBox1.Controls.Add(this.cbnhomtb);
            this.groupBox1.Controls.Add(this.numsl);
            this.groupBox1.Controls.Add(this.cbkv);
            this.groupBox1.Controls.Add(this.txtgia);
            this.groupBox1.Controls.Add(this.txttenphong);
            this.groupBox1.Controls.Add(this.txtmaphong);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(221, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 239);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phòng trọ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Khu vực";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "SLKT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Trạng thái";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Mã thiết bị";
            this.columnHeader7.Width = 78;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nhóm thiết bị";
            // 
            // txtmaphong
            // 
            this.txtmaphong.Enabled = false;
            this.txtmaphong.Location = new System.Drawing.Point(100, 26);
            this.txtmaphong.Name = "txtmaphong";
            this.txtmaphong.Size = new System.Drawing.Size(157, 20);
            this.txtmaphong.TabIndex = 7;
            // 
            // txttenphong
            // 
            this.txttenphong.Location = new System.Drawing.Point(100, 56);
            this.txttenphong.Name = "txttenphong";
            this.txttenphong.Size = new System.Drawing.Size(157, 20);
            this.txttenphong.TabIndex = 8;
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(100, 86);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(157, 20);
            this.txtgia.TabIndex = 9;
            // 
            // cbkv
            // 
            this.cbkv.FormattingEnabled = true;
            this.cbkv.Location = new System.Drawing.Point(100, 116);
            this.cbkv.Name = "cbkv";
            this.cbkv.Size = new System.Drawing.Size(157, 21);
            this.cbkv.TabIndex = 10;
            // 
            // numsl
            // 
            this.numsl.Location = new System.Drawing.Point(100, 147);
            this.numsl.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numsl.Name = "numsl";
            this.numsl.Size = new System.Drawing.Size(70, 20);
            this.numsl.TabIndex = 11;
            // 
            // cbnhomtb
            // 
            this.cbnhomtb.FormattingEnabled = true;
            this.cbnhomtb.Location = new System.Drawing.Point(100, 206);
            this.cbnhomtb.Name = "cbnhomtb";
            this.cbnhomtb.Size = new System.Drawing.Size(157, 21);
            this.cbnhomtb.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnghi
            // 
            this.btnghi.Location = new System.Drawing.Point(336, 272);
            this.btnghi.Name = "btnghi";
            this.btnghi.Size = new System.Drawing.Size(75, 30);
            this.btnghi.TabIndex = 7;
            this.btnghi.Text = "Ghi";
            this.btnghi.UseVisualStyleBackColor = true;
            this.btnghi.Click += new System.EventHandler(this.btnghi_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(432, 272);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 30);
            this.btnxoa.TabIndex = 8;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(528, 272);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 30);
            this.btnupdate.TabIndex = 9;
            this.btnupdate.Text = "Cập nhật";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // cbtrangthai
            // 
            this.cbtrangthai.FormattingEnabled = true;
            this.cbtrangthai.Location = new System.Drawing.Point(100, 176);
            this.cbtrangthai.Name = "cbtrangthai";
            this.cbtrangthai.Size = new System.Drawing.Size(157, 21);
            this.cbtrangthai.TabIndex = 14;
            // 
            // frmQLPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 515);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnghi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstds);
            this.Controls.Add(this.lvlist);
            this.Name = "frmQLPT";
            this.Text = "frmQLPT";
            this.Load += new System.EventHandler(this.frmQLPT_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numsl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lvlist;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListBox lstds;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbtrangthai;
        private System.Windows.Forms.ComboBox cbnhomtb;
        private System.Windows.Forms.NumericUpDown numsl;
        private System.Windows.Forms.ComboBox cbkv;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.TextBox txttenphong;
        private System.Windows.Forms.TextBox txtmaphong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnghi;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnupdate;
    }
}