using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace e_com
{
    public class SqlProcess
    {
        public string connString = "Server=.;Database=e-com;User Id=Cuni;Password=123456;";
        SqlConnection conn = null;
        SqlCommand cmd;
        public DataSet dataSet = new DataSet();
        SqlDataAdapter sqlDataAdapter;
        public StringBuilder customer = new StringBuilder();
        public List<string> customerList = new List<string>();
        public List<string> products = new List<string>();
        public List<byte> productsPhotos = new List<byte>();
        
                
        public bool SqlConn(string connString)
        {
            try
            {
                conn = new SqlConnection(connectionString: connString);
                conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace + " Olay Zamanı: " + DateTime.Now, "SQL Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void SqlReader(string command)
        {
            try
            {
                //sql bağlantısının olup olmadığını kontrol et
                cmd = new SqlCommand(command, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    customer.Append(reader.GetString(3) + "-" + reader.GetString(4)); // customer olmadan da list'e eklenebilir!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                    customerList.Add(customer.ToString());
                    customer.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace + " Olay Zamanı: " + DateTime.Now, "SQL Okuma Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool SqlWriter(string command)
        {
            try
            {
                cmd = new SqlCommand(command, conn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace + " Olay Zamanı: " + DateTime.Now, "SQL Yazma Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void SqlGetProduct(string command) 
        {
            try
            {
                sqlDataAdapter = new SqlDataAdapter(new SqlCommand(command, conn));
                dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                sqlDataAdapter.Dispose();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace + " Olay Zamanı: " + DateTime.Now, "SQL Ürün Çekme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
