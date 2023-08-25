using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataset
{
  public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconnection"].ToString());
                SqlDataAdapter sdr = new SqlDataAdapter("select * from customer",conn);
            DataSet dataSet = new DataSet();
                sdr.Fill(dataSet);

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    Console.WriteLine("{0} {1} {2}", row[0], row[1], row[2]);
                }


            }
            catch (Exception e){
                Console.WriteLine(e);
            }
        }

    }
}
