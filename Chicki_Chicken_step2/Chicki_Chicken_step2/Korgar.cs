using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chicki_Chicken_step2
{
   public class Korgar
    {
         int CustomerNumber = 0;
        Menu[][] Orders;
        readonly Cook cook;
        public Korgar()
        {
            Orders = new Menu[8][];
            cook = new Cook();
        } 
        int miqChicken = 0;
        int miqEgg = 0;
        public void Zakaz(int countChicken, int countEgg, DrinkType drink)
        {
            if (CustomerNumber < 8)
            {
                Menu[] CustomerOrder = new Menu[countChicken + countEgg + 1];
                int i = 0; 
                for (i = 0; i < countChicken; ++i)
                {
                    CustomerOrder[i] = Menu.Chicken; miqChicken++;
                }
                for (int j = 0; j < countEgg; ++j)
                {
                    CustomerOrder[j + i] = Menu.Egg; miqEgg++;
                }
                CustomerOrder[CustomerOrder.Length - 1] = (Menu)Enum.Parse(typeof(DrinkType), drink.ToString());

                Orders[CustomerNumber] = CustomerOrder;
                CustomerNumber++;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Maximum 8 zakaz giriftan mumkin!");
            }
        }

        public void Send()
        {

            if (miqChicken > 0)
            {
                cook.QabulAzOfitsiant(Menu.Chicken, miqChicken);
                cook.PrepareFood();
            }
            if (miqEgg > 0)
            {
                cook.QabulAzOfitsiant(Menu.Egg, miqEgg);
                cook.PrepareFood();
            }
            
        }

         
        public string[] GetOneCustomer()
        {
            
            string[] s1 = new string[CustomerNumber + 1];
            int egg, chicken;
            for (int i = 0; i < CustomerNumber; ++i)
            {
                egg = 0; chicken = 0;
                for (int j = 0; j < Orders[i].Length; ++j)
                {
                    if (Orders[i][j] == Menu.Chicken)
                    {
                        ++chicken;
                    }
                    else if (Orders[i][j] == Menu.Egg)
                    {
                        ++egg;
                    }
                }
                
                s1[i] = "Customer " + (i+1) + " is served " + chicken + " chicken " + egg + " egg " + Orders[i][Orders[i].Length - 1];
            }
            s1[CustomerNumber] = "Please, enjoy your food!";
            Orders = new Menu[8][];
            CustomerNumber = 0;
            return s1;
        }
    }
}
