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

namespace _2324_2Y_Integ_2A_WindowEventsAndManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Window1 w1 = new Window1();
        //Window1 w2 = new Window1("Hello world");
        public MainWindow()
        {
            InitializeComponent();
            if(!WindowManager._mainWin)
            {
                WindowManager._mainWindow = this;
                WindowManager._mainWin = true;
            }
        }

        private void btnButton_Click(object sender, RoutedEventArgs e)
        {
            //w1.Show();
            //w2.Show();

            if(!WindowManager._win1)
            {
                WindowManager._window1 = new Window1();
                WindowManager._win1 = true;
                WindowManager._window1.Show();
                //this.Hide();
            }
            else
            {
                WindowManager._window1.Focus();
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        { 

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //Window1 w1 = new Window1();
            //w1.Show();

            WindowManager._mainWin = false;
        }
    }
}
