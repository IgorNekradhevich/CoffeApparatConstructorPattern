using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeApparat
{
    class LatteDirector:CoffeBuilder
    {
        public LatteDirector( string syrup)
        {
            setMilk();
            setSugar(2);
            setSyrup(syrup);
            setVariety("Арабика");
        }
    }
}
