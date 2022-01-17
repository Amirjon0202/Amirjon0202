using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chicki_Chicken_step2
{
    class EggOrder : Order
    {
        public EggOrder(int Quantity)
            : base(Quantity)
        {

        }
        public void Crack()
        {

        }
        public void DiscardShell()
        {

        }
        public override void Cook() // тут нужно было добавить метод, который несколько раз вызывал бы нижние два метода и один раз - Cook()
        {
            Crack();
            DiscardShell();
        }
    }
}
