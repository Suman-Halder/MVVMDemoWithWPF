using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> cart = new List<int>() { 0,1, 0, 3, 1, 3 };
            List<int> ucart = new List<int>();
            for (int i = 0; i < cart.Count(); i++)
            {
                if (cart.Count() >= 1 && ucart.Count() < 1)
                {
                    ucart.Add(cart[0]);
                    //updatedCartItems[0].Quantity = 0;
                }
                for (int j = 0; j < i; j++)
                {
                    if(ucart[j] == cart[i])
                    {

                    }
                    else if(!IsContain(ucart, cart[i]))
                    {
                        ucart.Add(cart[i]);
                    }
                }

            }
             
        }

        private static bool IsContain(List<int> Items, int Item)
        {
            bool isPresent = false;
            foreach(int item in Items)
            {
                if(item == Item)
                {
                    isPresent = true;
                    break;
                }
            }
            return isPresent;
        }
    }
}
