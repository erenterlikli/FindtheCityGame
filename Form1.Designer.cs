namespace ŞehirTahminOyunu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblKalan = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGirilen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnTahmin = new System.Windows.Forms.Button();
            this.txtTahmin = new System.Windows.Forms.TextBox();
            this.BtnHarfGir = new System.Windows.Forms.Button();
            this.txtHarf = new System.Windows.Forms.TextBox();
            this.BtnYeniOyun = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Wheat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(93, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Soru Paneli";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Wheat;
            this.groupBox2.Controls.Add(this.lblKalan);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblGirilen);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.BtnTahmin);
            this.groupBox2.Controls.Add(this.txtTahmin);
            this.groupBox2.Controls.Add(this.BtnHarfGir);
            this.groupBox2.Controls.Add(this.txtHarf);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(93, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 195);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cevap Paneli";
            // 
            // lblKalan
            // 
            this.lblKalan.AutoSize = true;
            this.lblKalan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalan.Location = new System.Drawing.Point(141, 147);
            this.lblKalan.Name = "lblKalan";
            this.lblKalan.Size = new System.Drawing.Size(17, 17);
            this.lblKalan.TabIndex = 8;
            this.lblKalan.Text = "4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(7, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kalan Hak:";
            // 
            // lblGirilen
            // 
            this.lblGirilen.AutoSize = true;
            this.lblGirilen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGirilen.Location = new System.Drawing.Point(141, 109);
            this.lblGirilen.Name = "lblGirilen";
            this.lblGirilen.Size = new System.Drawing.Size(14, 17);
            this.lblGirilen.TabIndex = 6;
            this.lblGirilen.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Girilen Harfler:";
            // 
            // BtnTahmin
            // 
            this.BtnTahmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTahmin.Location = new System.Drawing.Point(333, 70);
            this.BtnTahmin.Name = "BtnTahmin";
            this.BtnTahmin.Size = new System.Drawing.Size(75, 23);
            this.BtnTahmin.TabIndex = 4;
            this.BtnTahmin.Text = "Tahmin Et";
            this.BtnTahmin.UseVisualStyleBackColor = true;
            this.BtnTahmin.Click += new System.EventHandler(this.BtnTahmin_Click);
            // 
            // txtTahmin
            // 
            this.txtTahmin.Location = new System.Drawing.Point(235, 70);
            this.txtTahmin.Name = "txtTahmin";
            this.txtTahmin.Size = new System.Drawing.Size(92, 23);
            this.txtTahmin.TabIndex = 3;
            // 
            // BtnHarfGir
            // 
            this.BtnHarfGir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnHarfGir.Location = new System.Drawing.Point(104, 70);
            this.BtnHarfGir.Name = "BtnHarfGir";
            this.BtnHarfGir.Size = new System.Drawing.Size(75, 23);
            this.BtnHarfGir.TabIndex = 2;
            this.BtnHarfGir.Text = "Harf Girin";
            this.BtnHarfGir.UseVisualStyleBackColor = true;
            this.BtnHarfGir.Click += new System.EventHandler(this.BtnHarfGir_Click);
            // 
            // txtHarf
            // 
            this.txtHarf.Location = new System.Drawing.Point(6, 70);
            this.txtHarf.Name = "txtHarf";
            this.txtHarf.Size = new System.Drawing.Size(92, 23);
            this.txtHarf.TabIndex = 1;
            // 
            // BtnYeniOyun
            // 
            this.BtnYeniOyun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnYeniOyun.Location = new System.Drawing.Point(93, 12);
            this.BtnYeniOyun.Name = "BtnYeniOyun";
            this.BtnYeniOyun.Size = new System.Drawing.Size(437, 27);
            this.BtnYeniOyun.TabIndex = 2;
            this.BtnYeniOyun.Text = "Yeni Oyun Başlat";
            this.BtnYeniOyun.UseVisualStyleBackColor = true;
            this.BtnYeniOyun.Click += new System.EventHandler(this.BtnYeniOyun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(635, 498);
            this.Controls.Add(this.BtnYeniOyun);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Şehir Tahmin Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblKalan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGirilen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnTahmin;
        private System.Windows.Forms.TextBox txtTahmin;
        private System.Windows.Forms.Button BtnHarfGir;
        private System.Windows.Forms.TextBox txtHarf;
        private System.Windows.Forms.Button BtnYeniOyun;
    }
}

