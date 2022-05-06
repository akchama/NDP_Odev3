namespace NDP_Proje
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
            this.satilanUrunlerButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Gun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Urun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KimeSatildi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // satilanUrunlerButton
            // 
            this.satilanUrunlerButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (192)))), ((int) (((byte) (255)))));
            this.satilanUrunlerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.satilanUrunlerButton.Location = new System.Drawing.Point(12, 308);
            this.satilanUrunlerButton.Name = "satilanUrunlerButton";
            this.satilanUrunlerButton.Size = new System.Drawing.Size(257, 34);
            this.satilanUrunlerButton.TabIndex = 0;
            this.satilanUrunlerButton.Text = "Satilan Urunleri Listele";
            this.satilanUrunlerButton.UseVisualStyleBackColor = true;
            this.satilanUrunlerButton.Click += new System.EventHandler(this.satilanUrunlerButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.Gun, this.Urun, this.KimeSatildi});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(257, 290);
            this.dataGridView1.TabIndex = 1;
            // 
            // Gun
            // 
            this.Gun.HeaderText = "Gün";
            this.Gun.Name = "Gun";
            // 
            // Urun
            // 
            this.Urun.HeaderText = "Ürün";
            this.Urun.Name = "Urun";
            // 
            // KimeSatildi
            // 
            this.KimeSatildi.HeaderText = "Kime Satıldığı";
            this.KimeSatildi.Name = "KimeSatildi";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.dataGridViewTextBoxColumn1, this.dataGridViewTextBoxColumn2, this.dataGridViewTextBoxColumn3});
            this.dataGridView2.Location = new System.Drawing.Point(275, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(257, 290);
            this.dataGridView2.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Gün";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Ürün";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Sipariş Edilen Kişi";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.button1.Location = new System.Drawing.Point(275, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Siparis Edilen Urunler";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonSiparisEdilen_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.dataGridViewTextBoxColumn4, this.dataGridViewTextBoxColumn5, this.dataGridViewTextBoxColumn6});
            this.dataGridView3.Location = new System.Drawing.Point(538, 12);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(257, 290);
            this.dataGridView3.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Gün";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Gelir";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Gider";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.button2.Location = new System.Drawing.Point(538, 308);
            this.button2.MinimumSize = new System.Drawing.Size(257, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(257, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "Gelir Gider Raporu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonGelirGider_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.dataGridViewTextBoxColumn8, this.Adet});
            this.dataGridView4.Location = new System.Drawing.Point(12, 348);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(257, 207);
            this.dataGridView4.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Ürün";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // Adet
            // 
            this.Adet.HeaderText = "Adet";
            this.Adet.Name = "Adet";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.button3.Location = new System.Drawing.Point(12, 561);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(257, 34);
            this.button3.TabIndex = 7;
            this.button3.Text = "Depodaki Urunleri Listele";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonDepodakiUrunleriListele_Click);
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.dataGridViewTextBoxColumn11, this.Column1});
            this.dataGridView5.Location = new System.Drawing.Point(275, 348);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(257, 207);
            this.dataGridView5.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Ürün";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Adet";
            this.Column1.Name = "Column1";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.button4.Location = new System.Drawing.Point(275, 561);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(257, 34);
            this.button4.TabIndex = 9;
            this.button4.Text = "Raftaki Urunleri Listele";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonRaftakiUrunleriListele_Click);
            // 
            // about
            // 
            this.about.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.about.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (162)));
            this.about.Location = new System.Drawing.Point(556, 354);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(239, 215);
            this.about.TabIndex = 10;
            this.about.Text = "Açıklama";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 615);
            this.Controls.Add(this.about);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.satilanUrunlerButton);
            this.MaximumSize = new System.Drawing.Size(828, 654);
            this.MinimumSize = new System.Drawing.Size(828, 654);
            this.Name = "Form1";
            this.Text = "Magaza";
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView5)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;

        private System.Windows.Forms.DataGridViewTextBoxColumn Adet;

        private System.Windows.Forms.Label about;

        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Button button4;

        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.DataGridViewTextBoxColumn Gun;

        private System.Windows.Forms.DataGridViewTextBoxColumn Urun;
        private System.Windows.Forms.DataGridViewTextBoxColumn KimeSatildi;

        private System.Windows.Forms.Button satilanUrunlerButton;

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
    }
}