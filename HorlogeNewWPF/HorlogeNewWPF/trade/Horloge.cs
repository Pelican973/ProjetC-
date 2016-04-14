#define DISPATCHER
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace HorlogeNewWPF.trade
{
    /// <summary>
    /// Base class for all clocks
    /// </summary>
    public abstract class Horloge : ViewModelBase, IHorloge
    {
        public TimeSpan Time { get; protected set; } = new TimeSpan();

        public Horloge()
        {
#if DISPATCHER
            DispatcherTimer dt = new DispatcherTimer();
            dt.Interval = new TimeSpan(0, 0, 0, 1); // Tick every milliseconds
            dt.Tick += (e, v) =>
            {
                OnTicked();
                OnPropertyChanged("Time");
            };
            dt.Start();
#else
            Timer t = new Timer();
            t.Interval = 1000;
            t.Elapsed += (e, v) =>
            {
                OnTicked();
                //OnPropertyChanged("Time");
            };
            t.Start();
#endif
        }

        protected abstract void OnTicked();
    }
}
