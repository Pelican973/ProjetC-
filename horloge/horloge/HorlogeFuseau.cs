using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace horloge
{
    public class HorlogeFuseau : HorlogeReel
    {
        private int fuseau = 0;
        public int Fuseau { get { return fuseau; } }

        public HorlogeFuseau(int fuseau = 0)
        {
            this.fuseau = fuseau;
        }

        protected override void OnTicked()
        {
            base.OnTicked();
            this.Time = this.Time.Add(new TimeSpan(fuseau, 0, 0));
        }
    }
}