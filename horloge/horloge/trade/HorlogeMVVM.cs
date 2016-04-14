using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace horloge.trade
//{
//    public class HorlogeMVVM : ViewModelBase
//    {
//        public int Heure { get { return horloge.Heure; } }
//        public int Minute { get { return horloge.Minute; } }
//        public int Seconde { get { return horloge.Seconde; } }
//       // public int Milliseconde { get { return horloge.Milliseconde; } }

//        private Horloge horloge = null;

//        public HorlogeMVVM(Horloge horloge)
//        {
//            this.horloge = horloge;
//            this.horloge.Changed += () =>
//            {
//                OnPropertyChanged("Heure");
//                OnPropertyChanged("Minute");
//                OnPropertyChanged("Seconde");
//                OnPropertyChanged("Milliseconde");
//                //Console.WriteLine(Milliseconde);
//            };
//        }
//    }
//}
