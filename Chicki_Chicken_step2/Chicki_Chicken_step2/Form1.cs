using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chicki_Chicken_step2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Korgar Korgar = new Korgar();
        static int a = 0;

        private void button1_Click(object sender, EventArgs e)
        {
          

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ToCook)
            {
                ToCook = false;
                serverd = true;
                Vyvod.Items.Clear();
                Vyvod.Items.AddRange(Korgar.GetOneCustomer());

            }
            else
                Vyvod.Items.Add("Сначала отправьте повару!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {

                int EggQuantity;
                int ChickenQuantity;
                EggQuantity = int.Parse(textBox2.Text);
                ChickenQuantity = int.Parse(textBox1.Text);
                Vyvod.Items.Add(" ");
                var drink = Enum.Parse(typeof(DrinkType), comboBox1.SelectedItem.ToString());
                Korgar.Zakaz(ChickenQuantity, EggQuantity, (DrinkType)drink);
                ++a;
                if (serverd)
                {
                    Vyvod.Items.Clear();
                    serverd = false;
                    Vyvod.Items.Add("Дархости " + a.ToString() + "-ум мизоч кабул шуд  " + ChickenQuantity + "то мург " + EggQuantity + "то тухм ва " + drink.ToString());
                }
                else
                    Vyvod.Items.Add("Дархости " + a.ToString() + "-ум мизоч кабул шуд  " + ChickenQuantity + "то мург" + EggQuantity + "то тухм ва " + drink.ToString());


            }
            
            catch (ArgumentOutOfRangeException)
            {
                Vyvod.Items.Add("Извините, можно обслуживать 1 стол до 8 человек(");
            }
            catch (Exception)
            {
                Vyvod.Items.Add("Пожалуйста выберите что нибудь из меню!");
            }
        }
        bool ToCook = false;
        bool serverd = false;
       
        private void button2_Click(object sender, EventArgs e)
        {
            ToCook = true;
            a = 0;
            Korgar.Send();
        }
    }
}
