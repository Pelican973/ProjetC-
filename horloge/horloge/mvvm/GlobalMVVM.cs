using horloge.trade;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace horloge.mvvm
{
    public class GlobalMVVM : ViewModelBase
    {
        public object Hv { get; } = new ResetableInversableHorlorge(new HorlogeVirtuelle());
        public object Hr { get; } = new ResetableInversableHorlorge(new HorlogeReel());
        public object Ha { get; } = new ResetableInversableHorlorge(new HorlogeAleatoire());
        public object Hf { get; } = new ResetableInversableHorlorge(new HorlogeFuseau());


        public ObservableCollection<IHorloge> Horloges { get; } = new ObservableCollection<IHorloge>();

        public GlobalMVVM()
        {
            Horloges.Add(new ResetableInversableHorlorge(new HorlogeReel()));
            Horloges.Add(new ResetableInversableHorlorge(new HorlogeVirtuelle()));
            Horloges.Add(new ResetableInversableHorlorge(new HorlogeFuseau()));
            Horloges.Add(new ResetableInversableHorlorge(new HorlogeAleatoire()));
        }
    }
}
