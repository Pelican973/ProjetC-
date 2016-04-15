using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Data;
using System.Windows.Input;

namespace horloge.trade
{
    /// <summary>
    /// Classe qui nous sert de MVVM
    /// </summary>
    public class ViewModelBase : INotifyPropertyChanged
    {
        protected double _speed;
        protected bool Reverse { get; set; } = false;

        #region OnPropertyChanger        
        protected void OnPropertyChanged<T>(Expression<Func<T>> expression)
        {
            var property = (MemberExpression)expression.Body;
            this.OnPropertyChanged(property.Member.Name);
        }

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
        
        #region Reverse
        RelayCommand _ReverseCommand;
        public ICommand ReverseCommand
        {
            get
            {
                if (_ReverseCommand == null)
                {
                    _ReverseCommand = new RelayCommand(param => this.DoReverse(),
                        param => true);
                }
                return _ReverseCommand;
            }
        }
        // function for Reverse
        private void DoReverse()
        {
            if (Reverse) Reverse = false;
            else Reverse = true;
        }
        private bool CanReverse
        {
            get
            {
                return false;
            }
        }
        #endregion

        #region slider
        public void Speed_changed(double Speed)
        {
            _speed = Speed;
        }
        #endregion
    }
}
