using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeApparat
{
    class AmericanoDirector:CoffeBuilder
    {
        public AmericanoDirector()
        {
            setSugar(1);
            setVariety("Либерика");
        }
    }
}
