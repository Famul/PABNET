using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start App3");
            SqlConnection remoteConnection =
                new SqlConnection(ConfigurationManager.AppSettings["sqlconnectionstring"]);

            try
            {
                remoteConnection.StateChange += new StateChangeEventHandler(StateChange);
                remoteConnection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_dodaj";
                cmd.Parameters.Add(new SqlParameter("arg1", 3));
                cmd.Parameters.Add(new SqlParameter("arg2", 4));
                cmd.Connection = remoteConnection;
                Console.WriteLine(string.Format("{0}", cmd.ExecuteScalar()));

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                remoteConnection.Close();
            }
            Console.ReadKey();
        }
        private static void StateChange(object sender, StateChangeEventArgs e)
        {
            Console.WriteLine("{0}: {1}", "Connection State", e.CurrentState.ToString());
        }
    }
}
