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
    /// Логика взаимодействия для Add_Color.xaml
    /// </summary>
    public partial class Add_Color : Window
    {
        public Add_Color()
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
            if (mainWindow.Button12.Visibility == Visibility.Hidden)
            {
                _ = mainWindow.Button12.Visibility - Visibility.Visible;
                mainWindow.Button12.Background = new SolidColorBrush(Color.FromRgb((byte)red, (byte)grn, (byte)blu));
            }
            else if (mainWindow.Button11.Visibility == Visibility.Hidden)
            {
                mainWindow.Button11.Background = new SolidColorBrush(Color.FromRgb((byte)red, (byte)grn, (byte)blu));
            }
            else if (mainWindow.Button10.Visibility == Visibility.Hidden)
            {
                mainWindow.Button10.Background = new SolidColorBrush(Color.FromRgb((byte)red, (byte)grn, (byte)blu));
            }
            else if (mainWindow.Button9.Visibility == Visibility.Hidden)
            {
                mainWindow.Button9.Background = new SolidColorBrush(Color.FromRgb((byte)red, (byte)grn, (byte)blu));
            }
            mainWindow.Brush.Color = Color.FromRgb((byte)red, (byte)grn, (byte)blu);
            mainWindow.Show();
        }
    }
}