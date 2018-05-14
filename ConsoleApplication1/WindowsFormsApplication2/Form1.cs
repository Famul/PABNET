using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        DataClasses1DataContext db;
        public Form1()
        {
            InitializeComponent();
            db = new DataClasses1DataContext();
        }

        private void loadDataButton_Click(object sender, EventArgs e)
        {
            var zapytanie = from x in db.Products
                            select new { x.ProductName, x.UnitPrice, x.UnitsInStock, Magazyn = x.UnitPrice * x.UnitsInStock };
            var zapytanie2 = from x in db.Products
                             let Magazyn = x.UnitPrice * x.UnitsInStock
                             select new { x.ProductName, x.UnitPrice, x.UnitsInStock, Magazyn };
            dataView.DataSource = zapytanie;
        }
    }
}
