using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Web;

namespace Crud_Demo_Code.Controllers
{
    public class DbClass
    {
        SqlConnection cnn = null;
        SqlCommand command;
        string query;
        SqlDataReader dataReader;
        string connection = "Data Source=HRMPC349\\SQLEXPRESS;Initial Catalog=Crud_Demo;Integrated Security=True";

        public void connect()
        {
            cnn = new SqlConnection(connection);
            try
            {
                cnn.Open();
                Console.WriteLine("Connected");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
        }

        public void disconnect()
        {
            cnn.Close();
        }

        public List<Class1> selectAll()
        {
            List<Class1> arr = new List<Class1>();

            connect();

            //code logic query
            Class1 obj;
            query = "select * from test";
            command = new SqlCommand(query, cnn);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                /*obj = new Class1(Convert.ToInt32(dataReader.GetValue(0)), dataReader.GetValue(1).ToString().Trim(), dataReader.GetValue(2).ToString().Trim());
                arr.Add(obj);*/
                arr.Add(new Class1(Convert.ToInt32(dataReader.GetValue(0)), dataReader.GetValue(1).ToString().Trim(), dataReader.GetValue(2).ToString().Trim()));
            }
            //arr.Add(new Class1(52, "nishant", "nishant"));

            disconnect();
            return arr;
        }

        public int enterData(Class1 obj)
        {
            connect();
            int i = 0;
            query = $"insert into test values('{obj.name}','{obj.email}')";
            command = new SqlCommand(query, cnn);
            i = command.ExecuteNonQuery();
            disconnect();
            return i;
        }
    }
}