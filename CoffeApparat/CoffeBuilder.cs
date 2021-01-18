using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeApparat
{
    class CoffeBuilder
    {
        Coffe _coffe;
        protected CoffeBuilder()
        {
            _coffe = new Coffe();
        }
        public void setMilk()
        {
            _coffe.Milk = true;
        }
        public  void setSyrup(string syrup)
        {
            _coffe.Syrup.Add(syrup);
        }
        public  void setSugar( uint count)
        {
            _coffe.Sugar += count;
        }
        public  void setVariety( string variety)
        {
           if (_coffe.Variety=="")
            {
                _coffe.Variety = variety;
            }
        }
        public Coffe getCoffe()
        {
            return _coffe;
        }
    }
}
