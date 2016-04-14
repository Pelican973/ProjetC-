using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace horloge.trade
{
    //// classe HorlogeWPF
    public class HorlogeWPF : ViewModelBase
    {
        //Propriétés
        public int Heure { get { return DateTime.Now.Hour; } }
        public int Minute { get { return DateTime.Now.Minute; } }
        public int Seconde { get { return DateTime.Now.Second; } }
        public double ToMilliseconde { get { return (TimeSpan.FromSeconds(Seconde).TotalMilliseconds + DateTime.Now.Millisecond); } }

        public HorlogeWPF()
        {
            DispatcherTimer dt = new DispatcherTimer();
            dt.Interval = new TimeSpan(0, 0, 0, 0, 1);
            dt.Tick += (e, v) =>
            {
                OnPropertyChanged("Heure");
                OnPropertyChanged("Minute");
                OnPropertyChanged("Seconde");
                OnPropertyChanged("ToMilliseconde");
            };
            dt.Start();
        }
    }

    /// <summary>
    /// Class VirtualHorloge
    /// Clock with virtual time (accelerated/slowed)
    /// </summary>
    public class VirtualHorloge : ViewModelBase
    {
        private int _heure = DateTime.Now.Hour;
        private int _minute = DateTime.Now.Minute;
        private int _seconde = DateTime.Now.Second;
        private int _milliseconde = DateTime.Now.Millisecond;

        public int Heure { get { return _heure; } set { } }
        public int Minute { get { return _minute; } set { } }
        public int Seconde { get { return _seconde; } set { _seconde = value; } }
        public double ToMilliseconde { get { return (TimeSpan.FromSeconds(Seconde).TotalMilliseconds + _milliseconde); } }

        public VirtualHorloge()
        {
            DispatcherTimer dt = new DispatcherTimer();
            dt.Interval = new TimeSpan(0, 0, 0, 1);
            dt.Tick += Dt_Tick;
            dt.Tick += (e, v) =>
            {
                OnPropertyChanged("Heure");
                OnPropertyChanged("Minute");
                OnPropertyChanged("Seconde");
                OnPropertyChanged("ToMilliseconde");
            };
            dt.Start();
        }

        private void Dt_Tick(object sender, EventArgs e)
        {
            if (_seconde > 59) Seconde = _seconde + 5;
            else Seconde = 0;
        }
    }
}
