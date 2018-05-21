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

    public partial class Form2 : Form
    {
        DataClasses1DataContext db;
        public Form2()
        {
            InitializeComponent();
            db = new DataClasses1DataContext();
        }

        private void loadDataButton_Click(object sender, EventArgs e)
        {
            IEnumerable<Ten_Most_Expensive_ProductsResult> zapytanie = db.Ten_Most_Expensive_Products();
            IEnumerable<CustOrdersOrdersResult> zapytanie2 = db.CustOrdersOrders("ALFKI");
            dataView.DataSource = zapytanie;
            dataView2.DataSource = zapytanie2;
            categoriesComboBox.DataSource = db.Categories;
            categoriesComboBox.DisplayMember = "CategoryName";
            categoriesComboBox.ValueMember = "categoryid";
        }

        private void changeForm_Click(object sender, EventArgs e)
        {
            Form form = new Form1();
            form.Location = this.Location;
            form.Show();
            this.Close();
        }
    }
}
