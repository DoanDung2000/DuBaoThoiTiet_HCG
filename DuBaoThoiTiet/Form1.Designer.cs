
namespace DuBaoThoiTiet
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtGio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.cbbMay = new System.Windows.Forms.ComboBox();
            this.txtDoAm = new System.Windows.Forms.TextBox();
            this.txtNhietDo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGiaiThich = new System.Windows.Forms.Button();
            this.btnDuBao = new System.Windows.Forms.Button();
            this.lb_chuy = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_tt = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "dam.png");
            this.imageList1.Images.SetKeyName(1, "lanh.png");
            this.imageList1.Images.SetKeyName(2, "mua.png");
            this.imageList1.Images.SetKeyName(3, "nang.png");
            // 
            // txtGio
            // 
            this.txtGio.Location = new System.Drawing.Point(150, 156);
            this.txtGio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGio.Name = "txtGio";
            this.txtGio.Size = new System.Drawing.Size(157, 28);
            this.txtGio.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gió (Km/h)";
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Location = new System.Drawing.Point(152, 210);
            this.btnNhapLai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(100, 35);
            this.btnNhapLai.TabIndex = 5;
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.UseVisualStyleBackColor = true;
            // 
            // cbbMay
            // 
            this.cbbMay.FormattingEnabled = true;
            this.cbbMay.Items.AddRange(new object[] {
            "Nhiều mây",
            "Ít mây"});
            this.cbbMay.Location = new System.Drawing.Point(150, 113);
            this.cbbMay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbMay.Name = "cbbMay";
            this.cbbMay.Size = new System.Drawing.Size(157, 30);
            this.cbbMay.TabIndex = 4;
            // 
            // txtDoAm
            // 
            this.txtDoAm.Location = new System.Drawing.Point(150, 72);
            this.txtDoAm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDoAm.Name = "txtDoAm";
            this.txtDoAm.Size = new System.Drawing.Size(157, 28);
            this.txtDoAm.TabIndex = 3;
            // 
            // txtNhietDo
            // 
            this.txtNhietDo.Location = new System.Drawing.Point(150, 31);
            this.txtNhietDo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNhietDo.Name = "txtNhietDo";
            this.txtNhietDo.Size = new System.Drawing.Size(157, 28);
            this.txtNhietDo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mây";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Độ ẩm(%)";
            // 
            // btnGiaiThich
            // 
            this.btnGiaiThich.Location = new System.Drawing.Point(445, 184);
            this.btnGiaiThich.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGiaiThich.Name = "btnGiaiThich";
            this.btnGiaiThich.Size = new System.Drawing.Size(94, 40);
            this.btnGiaiThich.TabIndex = 9;
            this.btnGiaiThich.Text = "Giải thích";
            this.btnGiaiThich.UseVisualStyleBackColor = true;
            // 
            // btnDuBao
            // 
            this.btnDuBao.Location = new System.Drawing.Point(445, 116);
            this.btnDuBao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDuBao.Name = "btnDuBao";
            this.btnDuBao.Size = new System.Drawing.Size(94, 36);
            this.btnDuBao.TabIndex = 8;
            this.btnDuBao.Text = "Dự báo";
            this.btnDuBao.UseVisualStyleBackColor = true;
            // 
            // lb_chuy
            // 
            this.lb_chuy.AutoSize = true;
            this.lb_chuy.Location = new System.Drawing.Point(47, 33);
            this.lb_chuy.Name = "lb_chuy";
            this.lb_chuy.Size = new System.Drawing.Size(0, 22);
            this.lb_chuy.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lb_chuy);
            this.groupBox3.Location = new System.Drawing.Point(56, 382);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(814, 129);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lời khuyên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhiệt độ(°C)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(34, 33);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(445, 248);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 40);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.lb_tt);
            this.groupBox2.Location = new System.Drawing.Point(560, 82);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(310, 279);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thời tiết";
            // 
            // lb_tt
            // 
            this.lb_tt.AutoSize = true;
            this.lb_tt.Location = new System.Drawing.Point(46, 219);
            this.lb_tt.Name = "lb_tt";
            this.lb_tt.Size = new System.Drawing.Size(0, 22);
            this.lb_tt.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGio);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnNhapLai);
            this.groupBox1.Controls.Add(this.cbbMay);
            this.groupBox1.Controls.Add(this.txtDoAm);
            this.groupBox1.Controls.Add(this.txtNhietDo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(56, 82);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(372, 279);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thời tiết";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(361, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 36);
            this.label5.TabIndex = 11;
            this.label5.Text = "Dự Báo Thời Tiết";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 548);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGiaiThich);
            this.Controls.Add(this.btnDuBao);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dự Báo Thời Tiết";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox txtGio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.ComboBox cbbMay;
        private System.Windows.Forms.TextBox txtDoAm;
        private System.Windows.Forms.TextBox txtNhietDo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGiaiThich;
        private System.Windows.Forms.Button btnDuBao;
        private System.Windows.Forms.Label lb_chuy;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lb_tt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
    }
}

