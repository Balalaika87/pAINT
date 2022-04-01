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
using System.Windows.Shapes;

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для New_Color.xaml
    /// </summary>
    public partial class New_Color : Window
    {
        public New_Color()
        {
            InitializeComponent();
        }
        double red = 0;
        double grn = 0;
        double blu = 0;
        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            red = slider1.Value;
            grn = slider2.Value;
            blu = slider3.Value;
            r1.Fill = new SolidColorBrush(Color.FromRgb((byte)red, (byte)grn, (byte)blu));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            if (mainWindow.Button1.IsEnabled == true)
            {
                mainWindow.Button1.Background = new SolidColorBrush(Color.FromRgb((byte)red, (byte)grn, (byte)blu));
            }
            else if (mainWindow.Button2.IsEnabled == true)
            {
                mainWindow.Button2.Background = new SolidColorBrush(Color.FromRgb((byte)red, (byte)grn, (byte)blu));
            }
            else if (mainWindow.Button3.IsEnabled == false)
            {
                mainWindow.Button3.Background = new SolidColorBrush(Color.FromRgb((byte)red, (byte)grn, (byte)blu));
            }
            else if (mainWindow.Button4.IsEnabled == false)
            {
                mainWindow.Button4.Background = new SolidColorBrush(Color.FromRgb((byte)red, (byte)grn, (byte)blu));
            }
            else if (mainWindow.Button5.IsEnabled == false)
            {
                mainWindow.Button5.Background = new SolidColorBrush(Color.FromRgb((byte)red, (byte)grn, (byte)blu));
            }
            else if (mainWindow.Button6.IsEnabled == false)
            {
                mainWindow.Button6.Background = new SolidColorBrush(Color.FromRgb((byte)red, (byte)grn, (byte)blu));
            }
            else if (mainWindow.Button7.IsEnabled == false)
            {
                mainWindow.Button7.Background = new SolidColorBrush(Color.FromRgb((byte)red, (byte)grn, (byte)blu));
            }
            else if (mainWindow.Button8.IsEnabled == false)
            {
                mainWindow.Button8.Background = new SolidColorBrush(Color.FromRgb((byte)red, (byte)grn, (byte)blu));
            }

            mainWindow.Brush.Color = Color.FromRgb((byte)red, (byte)grn, (byte)blu);
            mainWindow.Show();
        }
    }
}
