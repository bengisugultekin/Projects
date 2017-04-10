using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BengiSuDagitim.DBConnection.MyModel
{
    public class Product
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public double? ProductPrice { get; set; } //ya da Nullable<double> null olabilir demek

        public double ProductSize { get; set; }
    }
}
