using System;
using System.Windows.Forms;


namespace ConsoleApp1
{
    class Program
    {        
        static float[] DiscountForSunglasses = new float[4] { 1f, 0.75f, 0.5f, 0.25f };                
        public static float TotalPrice(float[] price)
        {
            float totalprice = 0;
            Array.Sort(price);
            Array.Reverse(price);
            int count = price.Length;
            for (int i = 0; i<count; i++)
            {
                totalprice += price[i]*DiscountForSunglasses[i];
            }
            return totalprice;
        }           
        static void Main(string[] args)
        {
            float[] itemprice = new float[4] {400f,300f,500f,700f};
            if (itemprice.Length <= 4)
            {
                
                MessageBox.Show(TotalPrice(itemprice).ToString());
            }
            else
            {
                MessageBox.Show("You have exceeded maximum allowed amount of purchase");
            }
        }          
        
    }
    
}
