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

namespace wyscigi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Greyhound[] grayHounds = new Greyhound[4];
        Guy[] guys = new Guy[3];
        public MainWindow()
        {
            //guys[0] = new Guy() { Name = "Adolf", }

            InitializeComponent();
        }
    }
}
