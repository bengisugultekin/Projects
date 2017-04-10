namespace IZSU_FormsApp_DB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBoxAboneBilgileri = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAboneNo = new System.Windows.Forms.TextBox();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAdSoyad = new System.Windows.Forms.TextBox();
            this.comboBoxAboneTuru = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxFaturaBilgileri = new System.Windows.Forms.GroupBox();
            this.Tarih = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonGetir = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxFaturaAdSoyad = new System.Windows.Forms.TextBox();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxSonraki = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxOnceki = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxFaturaAboneNo = new System.Windows.Forms.TextBox();
            this.buttonBas = new System.Windows.Forms.Button();
            this.groupBoxAboneBilgileri.SuspendLayout();
            this.groupBoxFaturaBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAboneBilgileri
            // 
            this.groupBoxAboneBilgileri.BackColor = System.Drawing.Color.Thistle;
            this.groupBoxAboneBilgileri.Controls.Add(this.label5);
            this.groupBoxAboneBilgileri.Controls.Add(this.comboBoxAboneTuru);
            this.groupBoxAboneBilgileri.Controls.Add(this.label4);
            this.groupBoxAboneBilgileri.Controls.Add(this.textBoxAdSoyad);
            this.groupBoxAboneBilgileri.Controls.Add(this.buttonKaydet);
            this.groupBoxAboneBilgileri.Controls.Add(this.label1);
            this.groupBoxAboneBilgileri.Controls.Add(this.textBoxAboneNo);
            this.groupBoxAboneBilgileri.Location = new System.Drawing.Point(13, 70);
            this.groupBoxAboneBilgileri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxAboneBilgileri.Name = "groupBoxAboneBilgileri";
            this.groupBoxAboneBilgileri.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxAboneBilgileri.Size = new System.Drawing.Size(283, 216);
            this.groupBoxAboneBilgileri.TabIndex = 0;
            this.groupBoxAboneBilgileri.TabStop = false;
            this.groupBoxAboneBilgileri.Text = "Abone Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Abone No";
            // 
            // textBoxAboneNo
            // 
            this.textBoxAboneNo.Location = new System.Drawing.Point(108, 34);
            this.textBoxAboneNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxAboneNo.Name = "textBoxAboneNo";
            this.textBoxAboneNo.Size = new System.Drawing.Size(163, 22);
            this.textBoxAboneNo.TabIndex = 0;
            this.textBoxAboneNo.Leave += new System.EventHandler(this.textBoxAboneNo_Leave);
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.BackColor = System.Drawing.Color.DarkOrchid;
            this.buttonKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKaydet.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonKaydet.Location = new System.Drawing.Point(11, 160);
            this.buttonKaydet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(260, 36);
            this.buttonKaydet.TabIndex = 6;
            this.buttonKaydet.Text = "KAYDET";
            this.buttonKaydet.UseVisualStyleBackColor = false;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ad Soyad";
            // 
            // textBoxAdSoyad
            // 
            this.textBoxAdSoyad.Location = new System.Drawing.Point(108, 75);
            this.textBoxAdSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAdSoyad.Name = "textBoxAdSoyad";
            this.textBoxAdSoyad.Size = new System.Drawing.Size(163, 22);
            this.textBoxAdSoyad.TabIndex = 1;
            // 
            // comboBoxAboneTuru
            // 
            this.comboBoxAboneTuru.FormattingEnabled = true;
            this.comboBoxAboneTuru.Location = new System.Drawing.Point(108, 119);
            this.comboBoxAboneTuru.Name = "comboBoxAboneTuru";
            this.comboBoxAboneTuru.Size = new System.Drawing.Size(163, 24);
            this.comboBoxAboneTuru.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 124);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Abone Türü";
            // 
            // groupBoxFaturaBilgileri
            // 
            this.groupBoxFaturaBilgileri.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBoxFaturaBilgileri.Controls.Add(this.Tarih);
            this.groupBoxFaturaBilgileri.Controls.Add(this.label7);
            this.groupBoxFaturaBilgileri.Controls.Add(this.buttonGetir);
            this.groupBoxFaturaBilgileri.Controls.Add(this.label9);
            this.groupBoxFaturaBilgileri.Controls.Add(this.textBoxFaturaAdSoyad);
            this.groupBoxFaturaBilgileri.Controls.Add(this.buttonEkle);
            this.groupBoxFaturaBilgileri.Controls.Add(this.label10);
            this.groupBoxFaturaBilgileri.Controls.Add(this.textBoxSonraki);
            this.groupBoxFaturaBilgileri.Controls.Add(this.label11);
            this.groupBoxFaturaBilgileri.Controls.Add(this.textBoxOnceki);
            this.groupBoxFaturaBilgileri.Controls.Add(this.label12);
            this.groupBoxFaturaBilgileri.Controls.Add(this.textBoxFaturaAboneNo);
            this.groupBoxFaturaBilgileri.Location = new System.Drawing.Point(13, 309);
            this.groupBoxFaturaBilgileri.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxFaturaBilgileri.Name = "groupBoxFaturaBilgileri";
            this.groupBoxFaturaBilgileri.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxFaturaBilgileri.Size = new System.Drawing.Size(283, 289);
            this.groupBoxFaturaBilgileri.TabIndex = 1;
            this.groupBoxFaturaBilgileri.TabStop = false;
            this.groupBoxFaturaBilgileri.Text = "Fatura Bilgileri";
            // 
            // Tarih
            // 
            this.Tarih.Location = new System.Drawing.Point(108, 116);
            this.Tarih.Name = "Tarih";
            this.Tarih.Size = new System.Drawing.Size(163, 22);
            this.Tarih.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 116);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tarih";
            // 
            // buttonGetir
            // 
            this.buttonGetir.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonGetir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGetir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonGetir.Location = new System.Drawing.Point(145, 234);
            this.buttonGetir.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGetir.Name = "buttonGetir";
            this.buttonGetir.Size = new System.Drawing.Size(116, 36);
            this.buttonGetir.TabIndex = 7;
            this.buttonGetir.Text = "GETİR";
            this.buttonGetir.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 78);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Ad Soyad";
            // 
            // textBoxFaturaAdSoyad
            // 
            this.textBoxFaturaAdSoyad.Enabled = false;
            this.textBoxFaturaAdSoyad.Location = new System.Drawing.Point(108, 75);
            this.textBoxFaturaAdSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFaturaAdSoyad.Name = "textBoxFaturaAdSoyad";
            this.textBoxFaturaAdSoyad.Size = new System.Drawing.Size(163, 22);
            this.textBoxFaturaAdSoyad.TabIndex = 1;
            // 
            // buttonEkle
            // 
            this.buttonEkle.BackColor = System.Drawing.Color.Navy;
            this.buttonEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEkle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEkle.Location = new System.Drawing.Point(11, 234);
            this.buttonEkle.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(116, 36);
            this.buttonEkle.TabIndex = 6;
            this.buttonEkle.Text = "EKLE";
            this.buttonEkle.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 195);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "Güncel Sayaç";
            // 
            // textBoxSonraki
            // 
            this.textBoxSonraki.Location = new System.Drawing.Point(108, 192);
            this.textBoxSonraki.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSonraki.Name = "textBoxSonraki";
            this.textBoxSonraki.Size = new System.Drawing.Size(163, 22);
            this.textBoxSonraki.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 154);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "Önceki Sayaç";
            // 
            // textBoxOnceki
            // 
            this.textBoxOnceki.Location = new System.Drawing.Point(108, 151);
            this.textBoxOnceki.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxOnceki.Name = "textBoxOnceki";
            this.textBoxOnceki.Size = new System.Drawing.Size(163, 22);
            this.textBoxOnceki.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 37);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Abone No";
            // 
            // textBoxFaturaAboneNo
            // 
            this.textBoxFaturaAboneNo.Enabled = false;
            this.textBoxFaturaAboneNo.Location = new System.Drawing.Point(108, 34);
            this.textBoxFaturaAboneNo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFaturaAboneNo.Name = "textBoxFaturaAboneNo";
            this.textBoxFaturaAboneNo.Size = new System.Drawing.Size(163, 22);
            this.textBoxFaturaAboneNo.TabIndex = 0;
            // 
            // buttonBas
            // 
            this.buttonBas.BackColor = System.Drawing.Color.Transparent;
            this.buttonBas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBas.BackgroundImage")));
            this.buttonBas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonBas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonBas.Location = new System.Drawing.Point(13, 13);
            this.buttonBas.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBas.Name = "buttonBas";
            this.buttonBas.Size = new System.Drawing.Size(37, 37);
            this.buttonBas.TabIndex = 7;
            this.buttonBas.UseVisualStyleBackColor = false;
            this.buttonBas.Click += new System.EventHandler(this.buttonBas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 633);
            this.Controls.Add(this.buttonBas);
            this.Controls.Add(this.groupBoxFaturaBilgileri);
            this.Controls.Add(this.groupBoxAboneBilgileri);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxAboneBilgileri.ResumeLayout(false);
            this.groupBoxAboneBilgileri.PerformLayout();
            this.groupBoxFaturaBilgileri.ResumeLayout(false);
            this.groupBoxFaturaBilgileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAboneBilgileri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAboneNo;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAdSoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxAboneTuru;
        private System.Windows.Forms.GroupBox groupBoxFaturaBilgileri;
        private System.Windows.Forms.DateTimePicker Tarih;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonGetir;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxFaturaAdSoyad;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxSonraki;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxOnceki;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxFaturaAboneNo;
        private System.Windows.Forms.Button buttonBas;
    }
}

