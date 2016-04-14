using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorlogeNewWPF.trade
{
    public interface IHorloge
    {
        TimeSpan Time { get; }
    }
}
