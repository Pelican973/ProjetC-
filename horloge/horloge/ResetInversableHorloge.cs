using horloge.trade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace horloge
{
    /// <summary>
    /// Interface mvvm pour nos horloges avec un reverse
    /// </summary>
    public class InversableHorloge : ViewModelBase, IHorloge
    {
        public TimeSpan Time { get { return this.horloge.Time; } }

        private bool _Reverse = false;
        public bool Reverse
        {
            get { return _Reverse; }
            set { _Reverse = value; OnPropertyChanged("Reverse"); }
        }

        

        public bool Pause { get; set; } = false;

        Horloge horloge = null;

        public InversableHorloge(Horloge horloge)
        {
            this.horloge = horloge;
            this.horloge.PropertyChanged += (e, v) =>
            {
                if (!Pause)
                    OnPropertyChanged("Time");
            };
        }
    }

    /// <summary>
    /// Interface mvvm reverse amélioré avec un reset
    /// </summary>
    public class ResetableInversableHorlorge : InversableHorloge
    {
        public ResetableInversableHorlorge(Horloge horloge) : base(horloge)
        {
        }

        #region Reset
        RelayCommand _ResetCommand;
        public ICommand ResetCommand
        {
            get
            {
                if (_ResetCommand == null)
                {
                    _ResetCommand = new RelayCommand(param => this.DoReset(),
                        param => CanReset);
                }
                return _ResetCommand;
            }
        }
        // function for Reset
        private void DoReset()
        {
            //Console.WriteLine("DoReset");
            this.Pause = !this.Pause;
        }
        private bool CanReset
        {
            get
            {
                return true;
            }
        }
        #endregion
    }
}
