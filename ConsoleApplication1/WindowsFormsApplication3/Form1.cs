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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void employeesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.View_Country' table. You can move, or remove it, as needed.
            this.view_CountryTableAdapter.Fill(this.dataSet1.View_Country);
            // TODO: This line of code loads data into the 'dataSet1.View_City' table. You can move, or remove it, as needed.
            this.view_CityTableAdapter.Fill(this.dataSet1.View_City);
            // TODO: This line of code loads data into the 'dataSet1.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.dataSet1.Employees);

        }
    }
}
