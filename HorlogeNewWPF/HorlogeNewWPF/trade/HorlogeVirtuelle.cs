using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorlogeNewWPF.trade
{
    /// <summary>
    /// Virtual clock with a speed paramter _milliAdd
    /// </summary>
    public class HorlogeVirtuelle : Horloge
    {
        private int _milliAdd;
        public int MilliAdd { get { return _milliAdd; } set { _milliAdd = value; } }

        protected override void OnTicked()
        {
            this.Time = this.Time.Add(new TimeSpan(0, 0, 0, 0, _milliAdd));
        }
    }
}
