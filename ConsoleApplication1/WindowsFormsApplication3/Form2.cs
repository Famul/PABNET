using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.View_OrderDetails' table. You can move, or remove it, as needed.
            this.view_OrderDetailsTableAdapter.Fill(this.dataSet1.View_OrderDetails);
            // TODO: This line of code loads data into the 'dataSet1.Order_Details' table. You can move, or remove it, as needed.
            this.order_DetailsTableAdapter.Fill(this.dataSet1.Order_Details);
            // TODO: This line of code loads data into the 'dataSet1.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.dataSet1.Orders);
            // TODO: This line of code loads data into the 'dataSet1.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.dataSet1.Customers);

        }
    }
}
