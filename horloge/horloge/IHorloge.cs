using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace horloge
{
    public interface IHorloge
    {
        //int Heure { get; }
        //int Minute { get; }
        //int Seconde { get; }
        //int TotalMilliseconde { get; }

        TimeSpan Time { get; }
    }
}