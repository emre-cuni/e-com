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
            SqlDataReader reader = null;
            try
            {
                //sql bağlantısının olup olmadığını kontrol et
                cmd = new SqlCommand(command, conn);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                    customer.Append(reader.GetString(3) + "-" + reader.GetString(4));

                cmd.Dispose();
                cmd = null;
                reader.Close();
                reader = null;
            }
            catch (Exception ex)
            {
                cmd.Dispose();
                cmd = null;
                reader.Close();
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace + " Olay Zamanı: " + DateTime.Now, "SQL Okuma Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool SqlControl(string command)
        {
            SqlDataReader controlDataReader = null;
            try
            {
                cmd = new SqlCommand(command, conn);
                controlDataReader = cmd.ExecuteReader();
                if (controlDataReader.Read())
                {
                    controlDataReader.Close();
                    controlDataReader = null;
                    cmd.Dispose();
                    cmd = null;
                    return true;
                }
                else
                {
                    controlDataReader.Close();
                    controlDataReader = null;
                    cmd.Dispose();
                    cmd = null;
                    return false;
                }
            }
            catch (Exception ex)
            {
                controlDataReader.Close();
                cmd.Dispose();
                cmd = null;
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace + " Olay Zamanı: " + DateTime.Now, "SQL Ödeme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool SqlWriter(string command)
        {
            try
            {
                cmd = new SqlCommand(command, conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cmd = null;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace + " Olay Zamanı: " + DateTime.Now, "SQL Yazma Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmd.Dispose();
                cmd = null;
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
                sqlDataAdapter = null;
            }
            catch (Exception ex)
            {
                sqlDataAdapter.Dispose();
                sqlDataAdapter = null;
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace + " Olay Zamanı: " + DateTime.Now, "SQL Ürün Çekme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
