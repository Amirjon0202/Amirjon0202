using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chicki_Chicken_step2
{
    class ChickenOrder : Order
    {
        public ChickenOrder(int Quantity)
            : base(Quantity)
        {

        }
        public void CutUp()
        {

        }
        public override void Cook() // тут нужно было добавить метод, который несколько раз вызывал бы метод ниже и один раз - Cook()
        {
            CutUp();
        }
    }
}
