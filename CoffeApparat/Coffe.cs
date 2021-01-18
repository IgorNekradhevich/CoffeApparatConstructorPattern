using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeApparat
{
    class Coffe
    {
        public uint Sugar { get; set; }
        public List<string> Syrup { get; set; }
        public bool Milk { get; set; }
        public string Variety { get; set; }

        public Coffe()
        {
            Sugar = 0;
            Milk = false;
            Variety = "";
            Syrup = new List<string>();
        }
         
        public string Check()
        {
            string check =$"Сорт {Variety}\n\r Добавки:\n\r\t";
            foreach(string syrup in Syrup)
            {
                check += syrup + "\n\r\t";
            }
            check += $"Сахар х{Sugar}\n\r\t";
            check += Milk == true ? "Молоко" : "";
            return check;
        }
    }
}
