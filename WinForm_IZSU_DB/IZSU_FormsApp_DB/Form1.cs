using IZSU_FormsApp_DB.DataLayer.DBConnection;
using IZSU_FormsApp_DB.DataLayer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IZSU_FormsApp_DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tarih.Format = DateTimePickerFormat.Custom;
            Tarih.CustomFormat = "MM-yyyy";
            Tarih.ShowUpDown = true;

            buttonKaydet.Enabled = false;
            groupBoxFaturaBilgileri.Enabled = false;

            using (IzsuDBContext context = new IzsuDBContext())
            {
                var result = context.AboneTuru.ToList();

                foreach (var item in result)
                {
                    comboBoxAboneTuru.Items.Add(item);
                }

                int yeniAboneNo = context.Abone.OrderByDescending(a => a.AboneNo).FirstOrDefault().AboneNo++;
                //burada devemı vaarr !!!

            }
        }

        private void textBoxAboneNo_Leave(object sender, EventArgs e)
        {
            using (IzsuDBContext context = new IzsuDBContext())
            {
                int _aboneNo = int.Parse(textBoxAboneNo.Text);

                var result = context.Abone.FirstOrDefault(a => a.AboneNo == _aboneNo);

                if (result != null)
                {
                    textBoxAboneNo.Enabled = false;
                    textBoxAdSoyad.Enabled = false;
                    comboBoxAboneTuru.Enabled = false;

                    textBoxAdSoyad.Text = result.AboneAdSoyad;
                    groupBoxFaturaBilgileri.Enabled = true;

                    comboBoxAboneTuru.SelectedIndex = result.AboneTuruID - 1;

                    textBoxFaturaAboneNo.Text = result.AboneNo.ToString();
                    textBoxFaturaAdSoyad.Text = result.AboneAdSoyad.ToString();

                }
                else
                {
                    MessageBox.Show("Kullanıcı bulunamadı !");
                    buttonKaydet.Enabled = true;
                    textBoxAdSoyad.Enabled = true;
                    comboBoxAboneTuru.Enabled = true;
                }

            }
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            Abone a = new Abone();
            a.AboneNo = int.Parse(textBoxAboneNo.Text);
            a.AboneAdSoyad = textBoxAdSoyad.Text;

            AboneTuru at = (AboneTuru)comboBoxAboneTuru.SelectedItem;
            a.AboneTuruID = at.AboneTuruID;

            using (IzsuDBContext context = new IzsuDBContext())
            {
                context.Abone.Add(a);
                context.SaveChanges();

            }

        }

        private void buttonBas_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in groupBoxAboneBilgileri.Controls)
            {
                if (ctr is TextBox)
                {
                    ctr.Text = "";
                }

                if (ctr is ComboBox)
                {
                    ctr.Text = "";
                }
            }

            textBoxAboneNo.Enabled = true;

        }
    }
}
