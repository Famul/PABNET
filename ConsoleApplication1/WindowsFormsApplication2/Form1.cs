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
        public void loadData()
        {
            var zapytanie = (from x in db.Products
                             select x).ToList();
            dataView.DataSource = zapytanie;
        }

        private void loadDataButton_Click(object sender, EventArgs e)
        {
            var zapytanie = from x in db.Products
                            select new { x.ProductName, x.UnitPrice, x.UnitsInStock, Magazyn = x.UnitPrice * x.UnitsInStock };
            var zapytanie2 = from x in db.Products
                             let Magazyn = x.UnitPrice * x.UnitsInStock
                             select new { x.ProductName, x.UnitPrice, x.UnitsInStock, Magazyn };
            var zapytanie3 = (from x in db.Products
                             select x).ToList(); //tylko w ten sposob bedzie dzialac aktualizacja

            dataView.DataSource = zapytanie3;
            
        }

        private void patchButton_Click(object sender, EventArgs e)
        {
            db.ExecuteCommand("set nocount off");
            db.SubmitChanges();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Product dane = new Product {ProductName = newProductText.Text, UnitPrice = 101, UnitsInStock = 11 };
            db.Products.InsertOnSubmit(dane);
            db.SubmitChanges();
            loadData();
        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            IEnumerable<Product> dane = from x in db.Products
                                        where x.ProductName == deleteProductText.Text
                                        select x;
            db.Products.DeleteAllOnSubmit(dane);
            db.SubmitChanges();
            loadData();
        }

        private void changeForm_Click(object sender, EventArgs e)
        {
            Form form = new Form2();
            form.Location = this.Location;
            form.Show();
            this.Close();
        }
    }
}
