using BengiSuDagitim.DBConnection.MyModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BengiSuDagitim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (BengiSuDagitimModel con = new BengiSuDagitimModel())
            {
                dataGridView1.DataSource = con.Product.ToList();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (BengiSuDagitimModel connection = new BengiSuDagitimModel())
            {
                Product p = new Product();
                p.ProductName = textBoxName.Text;
                p.ProductPrice = Convert.ToDouble(numericUpDownPrice.Value);
                p.ProductSize = Convert.ToDouble(numericUpDownSize.Value);

                connection.Product.Add(p);                

                connection.SaveChanges();

                dataGridView1.DataSource = connection.Product.ToList();


                //con.Product.Add(new Product { ProductName = "Saka 19lt", ProductPrice = 8.45 });
                //var result = con.Product.ToList();
            }
        }
    }
}
