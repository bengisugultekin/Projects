using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace KafeSiparis_SINAV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string[] yemekler = { "Kuru Fasülye", "Tavuklu Pilav", "Kaşarlı Tost", "Lazanya" };
        private string[] icecekler = { "Su", "Kola", "Limonata", "Çay", "Kahve" };

        
        
        

        private void Button_Click(object sender, EventArgs e)
        {

            listBoxSiparisler.Items.Clear();
            panelYemekSec.Visible = true;
            labelEkDown.Visible = true;
            labelEkUp.Visible = true;

            Button secilenMasa = sender as Button;
            labelMasaNoDown.Text = secilenMasa.Text;
            labelMasaNoUp.Text = secilenMasa.Text;

            if (masalar[int.Parse(secilenMasa.Text)] != null)
            {
                foreach (var item in masalar[int.Parse(secilenMasa.Text)].siparisler)
                {
                    listBoxSiparisler.Items.Add(item);
                }
            }

        }

        XmlDocument xmlDoc;
        double dolar, euro, pound;

        

        private void Form1_Load(object sender, EventArgs e)
        {


            #region buttonOlusturma          

            int counter = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Button btn = new Button();
                    btn.Click += Button_Click;
                    btn.Width = 30;
                    btn.Height = 30;
                    btn.Text = counter + "";
                    btn.Left = (btn.Width * j * 2);
                    btn.Top = (btn.Height * i * 2);
                    btn.BackColor = Color.FromArgb(240, 255, 240);
                    btn.FlatStyle = FlatStyle.Popup;

                    panelMasalar.Controls.Add(btn);
                    counter++;
                }
            }

            #endregion

            #region ParaBirimi_XML

            xmlDoc = new XmlDocument();
            xmlDoc.Load("http://www.tcmb.gov.tr/kurlar/today.xml");

            dolar = double.Parse(xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml, CultureInfo.InvariantCulture);
            euro = double.Parse(xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml, CultureInfo.InvariantCulture);
            pound = double.Parse(xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteSelling").InnerXml, CultureInfo.InvariantCulture);

            labelUSD.Text = "$ " + dolar.ToString("F");
            labelEUR.Text = "€ " + euro.ToString("F");
            labelGBP.Text = "£ " + pound.ToString("F");

            #endregion

            #region Gizlemeler

            comboBoxYemek.Items.AddRange(yemekler);
            comboBoxIcecek.Items.AddRange(icecekler);
            panelYemekSec.Visible = false;
            labelEkDown.Visible = false;
            labelEkUp.Visible = false;
            groupBoxParaBirimi.Visible = false;
            buttonOde.Visible = false;

            #endregion

        }

        Masa[] masalar = new Masa[16];
        Masa m = new Masa();

        private void buttonSiparisVer_Click(object sender, EventArgs e)
        {
            Siparis s = new Siparis();
            m = new Masa();
            
            
            #region SiparişlerinAlınması

            if (comboBoxYemek.SelectedItem != null && numericUpDownYemek.Value != 0)
            {
                s.siparisAdi = comboBoxYemek.SelectedItem.ToString();
                s.adet = int.Parse(numericUpDownYemek.Value.ToString());
                s.adetCarpıUcret = s.adet * s.ucret;
                m.toplamTutar += s.adetCarpıUcret;
                m.siparisler.Add(s);
            }


            if (comboBoxIcecek.SelectedItem != null && numericUpDownIcecek.Value != 0)
            {
                s = new Siparis();
                s.siparisAdi = comboBoxIcecek.SelectedItem.ToString();
                s.adet = int.Parse(numericUpDownIcecek.Value.ToString());
                s.adetCarpıUcret = s.adet * s.ucret;
                m.toplamTutar += s.adetCarpıUcret;
                m.siparisler.Add(s);

            }

            #endregion

            #region SiparişlerinEklenmesi

            foreach (var item in m.siparisler)
            {
                listBoxSiparisler.Items.Add(item);
            }

            Masa _masa = new Masa();

            if (masalar[int.Parse(labelMasaNoDown.Text)] != null)
            {
                _masa = masalar[int.Parse(labelMasaNoDown.Text)];
                foreach (var item in m.siparisler)
                {
                    _masa.toplamTutar += item.adetCarpıUcret;
                    _masa.siparisler.Add(item);
                }
            }
            else
            {
                _masa = m;
                masalar[int.Parse(labelMasaNoDown.Text)] = _masa;
            }

            #endregion

            #region Temizlik

            comboBoxYemek.SelectedIndex = -1;
            comboBoxIcecek.SelectedIndex = -1;
            numericUpDownYemek.Value = 0;
            numericUpDownIcecek.Value = 0;

            #endregion

            groupBoxParaBirimi.Visible = true;
            buttonOde.Visible = true;

        }
                   
        private void buttonOde_Click(object sender, EventArgs e)
        {
            double total = Hesapla(masalar[int.Parse(labelMasaNoDown.Text)].toplamTutar);

            if (paraBirimi != null)
            {

                DialogResult result = MessageBox.Show("Tutar: " + paraBirimi + " " + total.ToString("F") + "\nÖdeme yapmak ister misiniz?", "Ödeme Ekranı", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    masalar[int.Parse(labelMasaNoDown.Text)] = null;
                    listBoxSiparisler.Items.Clear();
                }
            }
            else
            {
                MessageBox.Show("Lütfen para birimi seçiniz.");
            }
            
        }

        private void listBoxSiparisler_DoubleClick(object sender, EventArgs e)
        {
            Siparis s = (Siparis)listBoxSiparisler.SelectedItem;
            double total = Hesapla(s.adetCarpıUcret);

            if (paraBirimi != null)
            {
                DialogResult result = MessageBox.Show("Tutar: " + paraBirimi + " " + total.ToString("F") + "\nÖdeme yapmak istiyor musunuz?", "Ödeme Ekranı", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    masalar[int.Parse(labelMasaNoDown.Text)].toplamTutar -= s.adetCarpıUcret;
                    s.adetCarpıUcret = 0;
                    listBoxSiparisler.Items.Remove(s);                    
                    masalar[int.Parse(labelMasaNoDown.Text)].siparisler.Remove(s);
                }
            }
            else
            {
                MessageBox.Show("Lütfen para birimi seçiniz.");
            }
        }

        string paraBirimi;

        private double Hesapla(double value)
        {
            double total = 0;

            if (radioButtonTL.Checked == true)
            {
                total = value;
                paraBirimi = "TL";
            }
            else if (radioButtonUSD.Checked == true)
            {
                total = value / dolar;
                paraBirimi = "$";
            }
            else if (radioButtonEUR.Checked == true)
            {
                total = value / euro;
                paraBirimi = "€";
            }
            else if (radioButtonGBP.Checked == true)
            {
                total = value / pound;
                paraBirimi = "£";
            }            

            return total;            
        }
    }
}
