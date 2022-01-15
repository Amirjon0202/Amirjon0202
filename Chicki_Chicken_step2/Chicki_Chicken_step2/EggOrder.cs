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
        public override void Cook()
        {
            Crack();
            DiscardShell();
        }
    }
}
