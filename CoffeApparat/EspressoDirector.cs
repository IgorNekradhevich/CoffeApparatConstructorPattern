﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeApparat
{
    class EspressoDirector:CoffeBuilder
    {
        public EspressoDirector()
        {
            setVariety("Робуста");
        }
    }
}
