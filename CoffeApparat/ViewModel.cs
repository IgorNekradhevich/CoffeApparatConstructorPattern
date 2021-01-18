using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeApparat
{
    class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

       CoffeBuilder coffeBuilder;
       Coffe coffe;
       public List<string> VarietyList { get; private set; }
       public List<string> SyrupList { get; private set; }
       string selectedSyrup;
        string selectedVariety;

       public List<string> AddedSyrupsList { get; set; }
       bool milk;
       uint sugar;
       bool rb1, rb2, rb3, rb4;
        string check;

        public string Check
        {
            get { return check; }
            set { 
                
               check = value;
                OnPropertyChanged("Check");
            }
        }

        public uint Sugar
        {
            get { return sugar; }
            set
            {
                sugar = value;
                OnPropertyChanged("Sugar");
            }
        }

        void refresh()
        {
            coffe = coffeBuilder.getCoffe();
            Milk = coffe.Milk;
            Sugar = coffe.Sugar;
            AddedSyrupsList = coffe.Syrup;
            AddedSyrupsList = new List<string>(AddedSyrupsList);
            OnPropertyChanged("AddedSyrupsList");
            SelectedVariety = coffe.Variety;

        }
        public bool Rb1
        {
            get { return rb1; }
            set
            {
               rb1 = value;
               coffeBuilder = new LatteDirector(selectedSyrup);
                refresh();
                OnPropertyChanged("Rb1");
            }
        }
      
        public bool Rb2
        {
            get { return rb2; }
            set
            {
                rb2 = value;
                coffeBuilder = new EspressoDirector();
                refresh();
                OnPropertyChanged("Rb2");
            }
        }
        public bool Rb3
        {
            get { return rb3; }
            set
            {
                rb3 = value;
                coffeBuilder = new AmericanoDirector();
                refresh();
                OnPropertyChanged("Rb3");
            }
        }
        public bool Rb4
        {
            get { return rb4; }
            set
            {
                rb4 = value;
                coffeBuilder = new MyCoffeDirector();
                refresh();
                OnPropertyChanged("Rb4");
            }
        }

        public bool Milk
        {
            get { return milk; }
            set
            {
                milk = value;
                OnPropertyChanged("Milk");
            }
        }

        public string SelectedSyrup
        {
            get { return selectedSyrup; }
            set
            {
                selectedSyrup = value;
                OnPropertyChanged("SelectedSyrup");
            }
        }
        public string SelectedVariety
        {
            get { return selectedVariety; }
            set
            {
                selectedVariety = value;
                OnPropertyChanged("SelectedVariety");
            }
        }
        public ViewModel()
        {
            VarietyList = new List<string>() { "Робуста", "Либерика", "Арабика", "Эксцельза","МакКофе 3в1" };
            SyrupList = new List<string>() { "Карамель", "Мята", "Корица", "Яблоко", "Апельсин" };
            AddedSyrupsList = new List<string>();

            SelectedSyrup = SyrupList[0];
            rb1 = true;
            Sugar = 0;
            Rb1 = true;
            OnPropertyChanged("Rb1");
        }

        public MyCommand AddSyrup
        {
            get { return new MyCommand((o)=> 
            { 
                AddedSyrupsList.Add(SelectedSyrup);
                AddedSyrupsList = new List<string>(AddedSyrupsList);
                OnPropertyChanged("AddedSyrupsList");
            });}
        }

        public MyCommand CheckPlease
        {
            get
            {
                return new MyCommand((o) =>
                {
                    coffe = coffeBuilder.getCoffe();
                    coffe.Milk = milk;
                    coffe.Sugar = sugar;
                    coffe.Syrup = AddedSyrupsList;
                    coffe.Variety = SelectedVariety;
                    Check= coffe.Check();
                });
            }
        }
    }
}
