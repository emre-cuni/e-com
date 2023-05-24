using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_com
{
    public class ShopCart
    {

        public Dictionary<string, Tuple<int, double>> shopCart = new Dictionary<string, Tuple<int, double>>();


        public bool AddToCart(string name, int count, double totalPrice)
        {
            try
            {
                shopCart.Add(name, Tuple.Create(count, totalPrice));
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace + " Olay Zamanı: " + DateTime.Now, "Sepete Ekleme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


    }
}
