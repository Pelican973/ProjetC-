using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Threading;

//namespace horloge.trade
//{
//    // classe de base
//    public class Horloge
//    {
//        public event HorlogeChangedEventHandler Changed;

//        public int Heure { get { return DateTime.Now.Hour; } }
//        public int Minute { get { return DateTime.Now.Minute; } }
//        public int Seconde { get { return DateTime.Now.Second; } }
//        //public int Milliseconde { get { return DateTime.Now.Millisecond; } }

//        public Horloge()
//        {
//            DispatcherTimer dt = new DispatcherTimer();
//            dt.Interval = new TimeSpan(0,0,0,0,1);
//            dt.Tick += (e,v) =>
//            {
//                if (Changed != null)
//                    Changed();
//            };
//            dt.Start();
//        }
//    }

//    public delegate void HorlogeChangedEventHandler();

   
//}

