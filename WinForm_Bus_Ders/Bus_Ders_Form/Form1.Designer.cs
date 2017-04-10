namespace Bus_Ders_Form
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CBoxOtobusTuru = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTravego = new System.Windows.Forms.Panel();
            this.panelSetra = new System.Windows.Forms.Panel();
            this.GBoxMusteriBilgileri = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelOtobusTuru = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelKoltukNo = new System.Windows.Forms.Label();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.GBoxCinsiyet = new System.Windows.Forms.GroupBox();
            this.RBKadin = new System.Windows.Forms.RadioButton();
            this.RBErkek = new System.Windows.Forms.RadioButton();
            this.TxtYolcuIsim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GBoxMusteriBilgileri.SuspendLayout();
            this.GBoxCinsiyet.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(615, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CBoxOtobusTuru
            // 
            this.CBoxOtobusTuru.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CBoxOtobusTuru.FormattingEnabled = true;
            this.CBoxOtobusTuru.Items.AddRange(new object[] {
            "Travego",
            "Setra"});
            this.CBoxOtobusTuru.Location = new System.Drawing.Point(12, 167);
            this.CBoxOtobusTuru.Name = "CBoxOtobusTuru";
            this.CBoxOtobusTuru.Size = new System.Drawing.Size(121, 24);
            this.CBoxOtobusTuru.TabIndex = 1;
            this.CBoxOtobusTuru.SelectedIndexChanged += new System.EventHandler(this.CBoxOtobusTuru_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Otobüs Türü";
            // 
            // panelTravego
            // 
            this.panelTravego.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelTravego.Location = new System.Drawing.Point(183, 167);
            this.panelTravego.Name = "panelTravego";
            this.panelTravego.Size = new System.Drawing.Size(177, 426);
            this.panelTravego.TabIndex = 3;
            // 
            // panelSetra
            // 
            this.panelSetra.Location = new System.Drawing.Point(181, 167);
            this.panelSetra.Name = "panelSetra";
            this.panelSetra.Size = new System.Drawing.Size(179, 423);
            this.panelSetra.TabIndex = 4;
            // 
            // GBoxMusteriBilgileri
            // 
            this.GBoxMusteriBilgileri.Controls.Add(this.label4);
            this.GBoxMusteriBilgileri.Controls.Add(this.labelOtobusTuru);
            this.GBoxMusteriBilgileri.Controls.Add(this.label3);
            this.GBoxMusteriBilgileri.Controls.Add(this.labelKoltukNo);
            this.GBoxMusteriBilgileri.Controls.Add(this.BtnKaydet);
            this.GBoxMusteriBilgileri.Controls.Add(this.GBoxCinsiyet);
            this.GBoxMusteriBilgileri.Controls.Add(this.TxtYolcuIsim);
            this.GBoxMusteriBilgileri.Controls.Add(this.label2);
            this.GBoxMusteriBilgileri.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GBoxMusteriBilgileri.Location = new System.Drawing.Point(394, 167);
            this.GBoxMusteriBilgileri.Name = "GBoxMusteriBilgileri";
            this.GBoxMusteriBilgileri.Size = new System.Drawing.Size(200, 210);
            this.GBoxMusteriBilgileri.TabIndex = 5;
            this.GBoxMusteriBilgileri.TabStop = false;
            this.GBoxMusteriBilgileri.Text = "Müşteri Bilgileri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(11, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Otobüs Türü :";
            // 
            // labelOtobusTuru
            // 
            this.labelOtobusTuru.AutoSize = true;
            this.labelOtobusTuru.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOtobusTuru.Location = new System.Drawing.Point(105, 152);
            this.labelOtobusTuru.Name = "labelOtobusTuru";
            this.labelOtobusTuru.Size = new System.Drawing.Size(12, 16);
            this.labelOtobusTuru.TabIndex = 4;
            this.labelOtobusTuru.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(11, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Koltuk No :";
            // 
            // labelKoltukNo
            // 
            this.labelKoltukNo.AutoSize = true;
            this.labelKoltukNo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKoltukNo.Location = new System.Drawing.Point(89, 126);
            this.labelKoltukNo.Name = "labelKoltukNo";
            this.labelKoltukNo.Size = new System.Drawing.Size(15, 16);
            this.labelKoltukNo.TabIndex = 3;
            this.labelKoltukNo.Text = "0";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(14, 175);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(173, 23);
            this.BtnKaydet.TabIndex = 5;
            this.BtnKaydet.Text = "KAYDET";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // GBoxCinsiyet
            // 
            this.GBoxCinsiyet.Controls.Add(this.RBKadin);
            this.GBoxCinsiyet.Controls.Add(this.RBErkek);
            this.GBoxCinsiyet.Location = new System.Drawing.Point(6, 68);
            this.GBoxCinsiyet.Name = "GBoxCinsiyet";
            this.GBoxCinsiyet.Size = new System.Drawing.Size(188, 49);
            this.GBoxCinsiyet.TabIndex = 2;
            this.GBoxCinsiyet.TabStop = false;
            this.GBoxCinsiyet.Text = "Cinsiyet";
            // 
            // RBKadın
            // 
            this.RBKadin.AutoSize = true;
            this.RBKadin.Location = new System.Drawing.Point(119, 21);
            this.RBKadin.Name = "RBKadın";
            this.RBKadin.Size = new System.Drawing.Size(63, 20);
            this.RBKadin.TabIndex = 1;
            this.RBKadin.TabStop = true;
            this.RBKadin.Text = "Kadın";
            this.RBKadin.UseVisualStyleBackColor = true;
            // 
            // RBErkek
            // 
            this.RBErkek.AutoSize = true;
            this.RBErkek.Location = new System.Drawing.Point(9, 21);
            this.RBErkek.Name = "RBErkek";
            this.RBErkek.Size = new System.Drawing.Size(61, 20);
            this.RBErkek.TabIndex = 0;
            this.RBErkek.TabStop = true;
            this.RBErkek.Text = "Erkek";
            this.RBErkek.UseVisualStyleBackColor = true;
            // 
            // TxtYolcuİsim
            // 
            this.TxtYolcuIsim.Location = new System.Drawing.Point(6, 39);
            this.TxtYolcuIsim.Name = "TxtYolcuİsim";
            this.TxtYolcuIsim.Size = new System.Drawing.Size(188, 22);
            this.TxtYolcuIsim.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad Soyad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 602);
            this.Controls.Add(this.GBoxMusteriBilgileri);
            this.Controls.Add(this.panelSetra);
            this.Controls.Add(this.panelTravego);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBoxOtobusTuru);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GBoxMusteriBilgileri.ResumeLayout(false);
            this.GBoxMusteriBilgileri.PerformLayout();
            this.GBoxCinsiyet.ResumeLayout(false);
            this.GBoxCinsiyet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox CBoxOtobusTuru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTravego;
        private System.Windows.Forms.Panel panelSetra;
        private System.Windows.Forms.GroupBox GBoxMusteriBilgileri;
        private System.Windows.Forms.TextBox TxtYolcuIsim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelKoltukNo;
        private System.Windows.Forms.GroupBox GBoxCinsiyet;
        private System.Windows.Forms.RadioButton RBKadin;
        private System.Windows.Forms.RadioButton RBErkek;
        private System.Windows.Forms.Label labelOtobusTuru;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

