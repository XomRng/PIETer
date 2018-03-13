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

namespace PIETer
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IView
    {
        private Controller controller;
    

        public MainWindow()
        {
            controller = new Controller(this);
       
            InitializeComponent();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            if (tb_scanBox.IsEnabled)
            {
                tb_scanBox.Focus();

            }
        }

        private void tb_scanBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter || e.Key == Key.Return)
            {
                try
                {
                    var barCode = tb_scanBox.Text;
                    controller.AnalyseBarcode(barCode);
                    ClearTextField();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    controller.LogOut();
                }
            }
        }

        public void DisplayBottomInfo(string text, Color color)
        {
            var brush = new SolidColorBrush(color);
            lb_bottom.Foreground = brush;
            lb_bottom.Content = text;
        }

        public void DisplayTopInfo(string text, Color color)
        {
            var brush = new SolidColorBrush(color);
            lb_top.Foreground = brush;
            lb_top.Content = text;
            
        }

        public void Lock()
        {
            tb_scanBox.IsEnabled = false;
        }

        public void Unlock()
        {
            tb_scanBox.IsEnabled = true;
        }

        public void ClearTextField()
        {
            tb_scanBox.Text = "";
        }

        public void DisplayCurrentUser(string user)
        {
            lb_currentUser.Content = "Użytkownik: " + user;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            controller.LogOut();
        }
    }
}
