using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace horloge
{
    public class HorlogeReel : Horloge
    {
        protected override void OnTicked()
        {
            DateTime dt = DateTime.Now;
            this.Time = new TimeSpan(0, dt.Hour, dt.Minute, dt.Second, dt.Millisecond);
         }
    }

    public class HorlogeVirtuelle : Horloge
    {
        private const int ADD_MILLI = 500;

        protected override void OnTicked()
        {
            this.Time = this.Time.Add(new TimeSpan(0, 0, 0, ADD_MILLI));
        }
    }

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