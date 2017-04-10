namespace KafeSiparis_SINAV
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
            this.panelMasalar = new System.Windows.Forms.Panel();
            this.listBoxSiparisler = new System.Windows.Forms.ListBox();
            this.buttonOde = new System.Windows.Forms.Button();
            this.radioButtonUSD = new System.Windows.Forms.RadioButton();
            this.radioButtonEUR = new System.Windows.Forms.RadioButton();
            this.radioButtonGBP = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSiparisVer = new System.Windows.Forms.Button();
            this.panelYemekSec = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownIcecek = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownYemek = new System.Windows.Forms.NumericUpDown();
            this.comboBoxIcecek = new System.Windows.Forms.ComboBox();
            this.comboBoxYemek = new System.Windows.Forms.ComboBox();
            this.labelEkUp = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelMasaNoDown = new System.Windows.Forms.Label();
            this.radioButtonTL = new System.Windows.Forms.RadioButton();
            this.groupBoxParaBirimi = new System.Windows.Forms.GroupBox();
            this.labelGBP = new System.Windows.Forms.Label();
            this.labelEUR = new System.Windows.Forms.Label();
            this.labelUSD = new System.Windows.Forms.Label();
            this.labelEkDown = new System.Windows.Forms.Label();
            this.labelMasaNoUp = new System.Windows.Forms.Label();
            this.panelYemekSec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIcecek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYemek)).BeginInit();
            this.groupBoxParaBirimi.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMasalar
            // 
            this.panelMasalar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelMasalar.Location = new System.Drawing.Point(20, 63);
            this.panelMasalar.Name = "panelMasalar";
            this.panelMasalar.Size = new System.Drawing.Size(280, 163);
            this.panelMasalar.TabIndex = 0;
            // 
            // listBoxSiparisler
            // 
            this.listBoxSiparisler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxSiparisler.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBoxSiparisler.FormattingEnabled = true;
            this.listBoxSiparisler.ItemHeight = 16;
            this.listBoxSiparisler.Location = new System.Drawing.Point(319, 34);
            this.listBoxSiparisler.Name = "listBoxSiparisler";
            this.listBoxSiparisler.Size = new System.Drawing.Size(273, 192);
            this.listBoxSiparisler.TabIndex = 0;
            this.listBoxSiparisler.DoubleClick += new System.EventHandler(this.listBoxSiparisler_DoubleClick);
            // 
            // buttonOde
            // 
            this.buttonOde.BackColor = System.Drawing.SystemColors.Info;
            this.buttonOde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOde.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonOde.Location = new System.Drawing.Point(368, 395);
            this.buttonOde.Name = "buttonOde";
            this.buttonOde.Size = new System.Drawing.Size(176, 34);
            this.buttonOde.TabIndex = 2;
            this.buttonOde.Text = "ÖDE";
            this.buttonOde.UseVisualStyleBackColor = false;
            this.buttonOde.Click += new System.EventHandler(this.buttonOde_Click);
            // 
            // radioButtonUSD
            // 
            this.radioButtonUSD.AutoSize = true;
            this.radioButtonUSD.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonUSD.Location = new System.Drawing.Point(101, 29);
            this.radioButtonUSD.Name = "radioButtonUSD";
            this.radioButtonUSD.Size = new System.Drawing.Size(53, 20);
            this.radioButtonUSD.TabIndex = 3;
            this.radioButtonUSD.TabStop = true;
            this.radioButtonUSD.Text = "USD";
            this.radioButtonUSD.UseVisualStyleBackColor = true;
            // 
            // radioButtonEUR
            // 
            this.radioButtonEUR.AutoSize = true;
            this.radioButtonEUR.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonEUR.Location = new System.Drawing.Point(16, 68);
            this.radioButtonEUR.Name = "radioButtonEUR";
            this.radioButtonEUR.Size = new System.Drawing.Size(53, 20);
            this.radioButtonEUR.TabIndex = 4;
            this.radioButtonEUR.TabStop = true;
            this.radioButtonEUR.Text = "EUR";
            this.radioButtonEUR.UseVisualStyleBackColor = true;
            // 
            // radioButtonGBP
            // 
            this.radioButtonGBP.AutoSize = true;
            this.radioButtonGBP.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonGBP.Location = new System.Drawing.Point(102, 68);
            this.radioButtonGBP.Name = "radioButtonGBP";
            this.radioButtonGBP.Size = new System.Drawing.Size(54, 20);
            this.radioButtonGBP.TabIndex = 5;
            this.radioButtonGBP.TabStop = true;
            this.radioButtonGBP.Text = "GBP";
            this.radioButtonGBP.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(189, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "USD: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(189, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "EUR:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(190, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "GBP:";
            // 
            // buttonSiparisVer
            // 
            this.buttonSiparisVer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonSiparisVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSiparisVer.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSiparisVer.Location = new System.Drawing.Point(53, 106);
            this.buttonSiparisVer.Name = "buttonSiparisVer";
            this.buttonSiparisVer.Size = new System.Drawing.Size(160, 34);
            this.buttonSiparisVer.TabIndex = 9;
            this.buttonSiparisVer.Text = "Sipariş Ver";
            this.buttonSiparisVer.UseVisualStyleBackColor = false;
            this.buttonSiparisVer.Click += new System.EventHandler(this.buttonSiparisVer_Click);
            // 
            // panelYemekSec
            // 
            this.panelYemekSec.Controls.Add(this.label5);
            this.panelYemekSec.Controls.Add(this.label4);
            this.panelYemekSec.Controls.Add(this.numericUpDownIcecek);
            this.panelYemekSec.Controls.Add(this.buttonSiparisVer);
            this.panelYemekSec.Controls.Add(this.numericUpDownYemek);
            this.panelYemekSec.Controls.Add(this.comboBoxIcecek);
            this.panelYemekSec.Controls.Add(this.comboBoxYemek);
            this.panelYemekSec.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelYemekSec.Location = new System.Drawing.Point(12, 270);
            this.panelYemekSec.Name = "panelYemekSec";
            this.panelYemekSec.Size = new System.Drawing.Size(274, 159);
            this.panelYemekSec.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(13, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "İçecek";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(11, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Yemek";
            // 
            // numericUpDownIcecek
            // 
            this.numericUpDownIcecek.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDownIcecek.Location = new System.Drawing.Point(218, 62);
            this.numericUpDownIcecek.Name = "numericUpDownIcecek";
            this.numericUpDownIcecek.Size = new System.Drawing.Size(44, 22);
            this.numericUpDownIcecek.TabIndex = 13;
            // 
            // numericUpDownYemek
            // 
            this.numericUpDownYemek.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericUpDownYemek.Location = new System.Drawing.Point(218, 16);
            this.numericUpDownYemek.Name = "numericUpDownYemek";
            this.numericUpDownYemek.Size = new System.Drawing.Size(44, 22);
            this.numericUpDownYemek.TabIndex = 11;
            // 
            // comboBoxIcecek
            // 
            this.comboBoxIcecek.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxIcecek.FormattingEnabled = true;
            this.comboBoxIcecek.Location = new System.Drawing.Point(62, 62);
            this.comboBoxIcecek.Name = "comboBoxIcecek";
            this.comboBoxIcecek.Size = new System.Drawing.Size(139, 24);
            this.comboBoxIcecek.TabIndex = 12;
            this.comboBoxIcecek.Text = "Seçiniz...";
            // 
            // comboBoxYemek
            // 
            this.comboBoxYemek.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxYemek.FormattingEnabled = true;
            this.comboBoxYemek.Location = new System.Drawing.Point(62, 16);
            this.comboBoxYemek.Name = "comboBoxYemek";
            this.comboBoxYemek.Size = new System.Drawing.Size(139, 24);
            this.comboBoxYemek.TabIndex = 11;
            this.comboBoxYemek.Text = "Seçiniz...";
            // 
            // labelEkUp
            // 
            this.labelEkUp.AutoSize = true;
            this.labelEkUp.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelEkUp.Location = new System.Drawing.Point(337, 8);
            this.labelEkUp.Name = "labelEkUp";
            this.labelEkUp.Size = new System.Drawing.Size(160, 16);
            this.labelEkUp.TabIndex = 11;
            this.labelEkUp.Text = "nolu masanın siparişleri";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(131, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Masalar";
            // 
            // labelMasaNoDown
            // 
            this.labelMasaNoDown.AutoSize = true;
            this.labelMasaNoDown.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMasaNoDown.Location = new System.Drawing.Point(21, 251);
            this.labelMasaNoDown.Name = "labelMasaNoDown";
            this.labelMasaNoDown.Size = new System.Drawing.Size(0, 16);
            this.labelMasaNoDown.TabIndex = 16;
            // 
            // radioButtonTL
            // 
            this.radioButtonTL.AutoSize = true;
            this.radioButtonTL.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonTL.Location = new System.Drawing.Point(16, 29);
            this.radioButtonTL.Name = "radioButtonTL";
            this.radioButtonTL.Size = new System.Drawing.Size(40, 20);
            this.radioButtonTL.TabIndex = 17;
            this.radioButtonTL.TabStop = true;
            this.radioButtonTL.Text = "TL";
            this.radioButtonTL.UseVisualStyleBackColor = true;
            // 
            // groupBoxParaBirimi
            // 
            this.groupBoxParaBirimi.Controls.Add(this.labelGBP);
            this.groupBoxParaBirimi.Controls.Add(this.radioButtonTL);
            this.groupBoxParaBirimi.Controls.Add(this.radioButtonUSD);
            this.groupBoxParaBirimi.Controls.Add(this.radioButtonEUR);
            this.groupBoxParaBirimi.Controls.Add(this.labelEUR);
            this.groupBoxParaBirimi.Controls.Add(this.radioButtonGBP);
            this.groupBoxParaBirimi.Controls.Add(this.label3);
            this.groupBoxParaBirimi.Controls.Add(this.label2);
            this.groupBoxParaBirimi.Controls.Add(this.labelUSD);
            this.groupBoxParaBirimi.Controls.Add(this.label1);
            this.groupBoxParaBirimi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxParaBirimi.Location = new System.Drawing.Point(320, 270);
            this.groupBoxParaBirimi.Name = "groupBoxParaBirimi";
            this.groupBoxParaBirimi.Size = new System.Drawing.Size(273, 101);
            this.groupBoxParaBirimi.TabIndex = 18;
            this.groupBoxParaBirimi.TabStop = false;
            this.groupBoxParaBirimi.Text = "Para Birimi";
            // 
            // labelGBP
            // 
            this.labelGBP.AutoSize = true;
            this.labelGBP.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGBP.Location = new System.Drawing.Point(223, 71);
            this.labelGBP.Name = "labelGBP";
            this.labelGBP.Size = new System.Drawing.Size(0, 12);
            this.labelGBP.TabIndex = 21;
            // 
            // labelEUR
            // 
            this.labelEUR.AutoSize = true;
            this.labelEUR.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelEUR.Location = new System.Drawing.Point(223, 53);
            this.labelEUR.Name = "labelEUR";
            this.labelEUR.Size = new System.Drawing.Size(0, 12);
            this.labelEUR.TabIndex = 20;
            // 
            // labelUSD
            // 
            this.labelUSD.AutoSize = true;
            this.labelUSD.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelUSD.Location = new System.Drawing.Point(223, 36);
            this.labelUSD.Name = "labelUSD";
            this.labelUSD.Size = new System.Drawing.Size(0, 12);
            this.labelUSD.TabIndex = 19;
            // 
            // labelEkDown
            // 
            this.labelEkDown.AutoSize = true;
            this.labelEkDown.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelEkDown.Location = new System.Drawing.Point(39, 251);
            this.labelEkDown.Name = "labelEkDown";
            this.labelEkDown.Size = new System.Drawing.Size(216, 16);
            this.labelEkDown.TabIndex = 19;
            this.labelEkDown.Text = "nolu masanın sipariş seçenekleri";
            // 
            // labelMasaNoUp
            // 
            this.labelMasaNoUp.AutoSize = true;
            this.labelMasaNoUp.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMasaNoUp.Location = new System.Drawing.Point(319, 8);
            this.labelMasaNoUp.Name = "labelMasaNoUp";
            this.labelMasaNoUp.Size = new System.Drawing.Size(0, 16);
            this.labelMasaNoUp.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(618, 467);
            this.Controls.Add(this.labelMasaNoUp);
            this.Controls.Add(this.labelEkDown);
            this.Controls.Add(this.groupBoxParaBirimi);
            this.Controls.Add(this.labelMasaNoDown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelEkUp);
            this.Controls.Add(this.panelYemekSec);
            this.Controls.Add(this.buttonOde);
            this.Controls.Add(this.listBoxSiparisler);
            this.Controls.Add(this.panelMasalar);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Kafe Sipariş";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelYemekSec.ResumeLayout(false);
            this.panelYemekSec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIcecek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYemek)).EndInit();
            this.groupBoxParaBirimi.ResumeLayout(false);
            this.groupBoxParaBirimi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxSiparisler;
        private System.Windows.Forms.Button buttonOde;
        private System.Windows.Forms.RadioButton radioButtonUSD;
        private System.Windows.Forms.RadioButton radioButtonEUR;
        private System.Windows.Forms.RadioButton radioButtonGBP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSiparisVer;
        private System.Windows.Forms.Panel panelYemekSec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownIcecek;
        private System.Windows.Forms.NumericUpDown numericUpDownYemek;
        private System.Windows.Forms.ComboBox comboBoxIcecek;
        private System.Windows.Forms.ComboBox comboBoxYemek;
        private System.Windows.Forms.Label labelEkUp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelMasaNoDown;
        private System.Windows.Forms.RadioButton radioButtonTL;
        private System.Windows.Forms.GroupBox groupBoxParaBirimi;
        private System.Windows.Forms.Label labelUSD;
        private System.Windows.Forms.Label labelEUR;
        private System.Windows.Forms.Label labelGBP;
        private System.Windows.Forms.Label labelEkDown;
        private System.Windows.Forms.Label labelMasaNoUp;
        public System.Windows.Forms.Panel panelMasalar;
    }
}

