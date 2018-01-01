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
using DiceRollerLogicLayer;

namespace DiceRoller
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnRoll_Click(object sender, RoutedEventArgs e)
        {
            var dm = new DiceManager()
            {
                d2 = (int)d2.Value,
                d3 = (int)d3.Value,
                d4 = (int)d4.Value,
                d6 = (int)d6.Value,
                d8 = (int)d8.Value,
                d10 = (int)d10.Value,
                d12 = (int)d12.Value,
                d20 = (int)d20.Value,
                d100 = (int)d100.Value,
                dx = (int)dx.Value,
                x = (int)x.Value,
                add = (int)add.Value
            };
            btnRoll.Content = dm.Roll();
            dm = null;
        }
    }
}
