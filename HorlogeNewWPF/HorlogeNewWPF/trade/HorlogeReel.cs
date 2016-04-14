using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorlogeNewWPF.trade
{
    /// <summary>
    /// Create a normal Clock with real time
    /// </summary>
    public class HorlogeReel : Horloge
    {
        protected override void OnTicked()
        {
            DateTime dt = DateTime.Now;
            this.Time = new TimeSpan(0, dt.Hour, dt.Minute, dt.Second, dt.Millisecond);
        }
    }

    /// <summary>
    /// Create a clock with random time
    /// </summary>
    public class HorlogeAleatoire : Horloge
    {
        Random rnd = new Random();

        protected override void OnTicked()
        {
            int h = rnd.Next(0, 23);
            int m = rnd.Next(0, 59);
            int s = rnd.Next(0, 59);

            this.Time = new TimeSpan(h, m, s);
        }
    }
}
