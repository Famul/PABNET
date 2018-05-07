using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        SqlConnection remoteConnection;
        public Form1()
        {
            InitializeComponent();
            remoteConnection =
                new SqlConnection(ConfigurationManager.AppSettings["sqlconnectionstring"]);
        }

        private void runQueryButton_Click(object sender, EventArgs e)
        {
            try
            {
                //remoteConnection.StateChange += new StateChangeEventHandler(StateChange);
                remoteConnection.Open();
                SqlCommand cmd = remoteConnection.CreateCommand();
                cmd.CommandText = commandTextBox.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                String result = null;
                while (reader.HasRows)
                {
                    int columns = reader.FieldCount;
                    
                    for (int i = 0; i < columns; i++)
                    {
                        result = result + String.Format("{0, -40}",reader.GetName(i)) + "\t";
                    }
                    result = result + "\r\n";
                    while (reader.Read())
                    {
                        for (int i = 0; i < columns; i++)
                        {
                            result = result + reader[i] + "\t";
                        }
                            result = result + "\r\n";
                    }
                    resultTextBox.Text = result;
                    Console.WriteLine("\n");
                    reader.NextResult();

                }

            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.Message);
            }
            finally
            {
                remoteConnection.Close();
            }
        }

        private void clearResultsButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = "";
        }
    }
}
