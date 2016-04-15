﻿#define DISPATCHER

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Threading;

namespace horloge
{
    public abstract class Horloge : trade.ViewModelBase, IHorloge
    {
        public TimeSpan Time { get; protected set; } = new TimeSpan();
        public int ToMillisecondes { get { return ((int)TimeSpan.FromSeconds(Time.Seconds).TotalMilliseconds + Time.Milliseconds); }  protected set { } }

        public Horloge()
        {
#if DISPATCHER
            DispatcherTimer dt = new DispatcherTimer();
            dt.Interval = new TimeSpan(0, 0, 0, 0, 500);
            dt.Tick += (e, v) =>
            {
                OnTicked();
                OnPropertyChanged("Time");
            };
            dt.Start();
#else
            Timer t = new Timer();
            t.Interval = 1;
            t.Elapsed += (e, v) =>
            {
                OnTicked();
                OnPropertyChanged("Time");
            };
            t.Start();
#endif
        }

        protected abstract void OnTicked();
    }
}