using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chicki_Chicken_step2
{
    class Cook
    {
        Order ORDER;
        public Cook()
        { }
        public void QabulAzOfitsiant(Menu bludo, int Miqdor)
        {

            if (bludo == Menu.Chicken)
                ORDER = new ChickenOrder(Miqdor);
            if (bludo == Menu.Egg)
                ORDER = new EggOrder(Miqdor);
        }
        public void PrepareFood()
        {
            for (int i = 0; i < ORDER.GetQuantity(); ++i)
                ORDER.Cook();

        }
    }
}
