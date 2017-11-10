namespace kho17
{
    partial class fKhoHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Tenhang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clNhomHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clDonVi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clDonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 67);
            this.panel1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(257, 38);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Đóng";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(175, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "In";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Xuất";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Xem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(11, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(214, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "(Tất cả)";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(1, 72);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(874, 393);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Tenhang,
            this.clNhomHang,
            this.clDonVi,
            this.clSoLuong,
            this.clDonGia,
            this.clThanhTien});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Tenhang
            // 
            this.Tenhang.Caption = "Tên Hàng";
            this.Tenhang.Name = "Tenhang";
            this.Tenhang.Visible = true;
            this.Tenhang.VisibleIndex = 0;
            // 
            // clNhomHang
            // 
            this.clNhomHang.Caption = "Nhóm Hàng";
            this.clNhomHang.Name = "clNhomHang";
            this.clNhomHang.Visible = true;
            this.clNhomHang.VisibleIndex = 1;
            // 
            // clDonVi
            // 
            this.clDonVi.Caption = "Đơn vị";
            this.clDonVi.Name = "clDonVi";
            this.clDonVi.Visible = true;
            this.clDonVi.VisibleIndex = 2;
            // 
            // clSoLuong
            // 
            this.clSoLuong.Caption = "Số Lượng";
            this.clSoLuong.Name = "clSoLuong";
            this.clSoLuong.Visible = true;
            this.clSoLuong.VisibleIndex = 3;
            // 
            // clDonGia
            // 
            this.clDonGia.Caption = "Đơn giá";
            this.clDonGia.Name = "clDonGia";
            this.clDonGia.Visible = true;
            this.clDonGia.VisibleIndex = 4;
            // 
            // clThanhTien
            // 
            this.clThanhTien.Caption = "Thành Tiền";
            this.clThanhTien.Name = "clThanhTien";
            this.clThanhTien.Visible = true;
            this.clThanhTien.VisibleIndex = 5;
            // 
            // fKhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 457);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Name = "fKhoHang";
            this.Text = "fKhoHang";
            this.Load += new System.EventHandler(this.fKhoHang_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraGrid.Columns.GridColumn Tenhang;
        private DevExpress.XtraGrid.Columns.GridColumn clNhomHang;
        private DevExpress.XtraGrid.Columns.GridColumn clDonVi;
        private DevExpress.XtraGrid.Columns.GridColumn clSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn clDonGia;
        private DevExpress.XtraGrid.Columns.GridColumn clThanhTien;
    }
}