using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        NorthwindEntities db = new NorthwindEntities();
        public Form1()
        {
            InitializeComponent();
            //db.Customers.Load();
            customersBindingSource.DataSource = db.Customers.ToList();
            
        }

        private void customersBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var orders_customers = db.Orders.Where(s => s.CustomerID == ((Customers)customersBindingSource.Current).CustomerID);
            ordersBindingSource.DataSource = orders_customers.ToList();
        }

        private void customersBindingNavigator_RefreshItems(object sender, EventArgs e)
        {
            customersBindingSource.EndEdit();
            ordersBindingSource.EndEdit();
            db.SaveChanges();
        }
    }
}
