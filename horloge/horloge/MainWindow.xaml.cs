using horloge.trade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace horloge
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //this.DataContext = new Horloge();                     // version metier
            //this.DataContext = new HorlogeWPF();                  // metié adapter wpf
            //this.DataContext = new HorlogeMVVM(new Horloge());      // version mvvm

            //while (i.Time.Hours == 0)
            //{
            //    App.DoEvents();
            //}
            //this.grid.DataContext = i;

            //this.grid.DataContext = new HorlogeReel();
            HorlogeReel Hr = new HorlogeReel();
            this.Stack.DataContext = Hr;
            this.GridHr.DataContext = Hr;


         }
    }
}
