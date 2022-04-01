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
    /// Логика взаимодействия для Gallery.xaml
    /// </summary>
    public partial class Gallery : Window
    {
        public Gallery()
        {
            InitializeComponent();
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Img.Source = new BitmapImage(new Uri(@"C:\Users\Kira\source\repos\WpfApp4\WpfApp4\Images\img1.jpg"));
            mainWindow.Show();
        }

        private void RadioButton_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Img.Source = new BitmapImage(new Uri(@"C:\Users\Kira\source\repos\WpfApp4\WpfApp4\Images\img2.jpg"));
            mainWindow.Show();
        }

        private void RadioButton_Click_2(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Img.Source = new BitmapImage(new Uri(@"C:\Users\Kira\source\repos\WpfApp4\WpfApp4\Images\img3.png"));
            mainWindow.Show();
        }

        private void RadioButton_Click_3(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Img.Source = new BitmapImage(new Uri(@"C:\Users\Kira\source\repos\WpfApp4\WpfApp4\Images\img5.jpg"));
            mainWindow.Show();
        }

        private void RadioButton_Click_4(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Img.Source = new BitmapImage(new Uri(@"C:\Users\Kira\source\repos\WpfApp4\WpfApp4\Images\img6.jpg"));
            mainWindow.Show();
        }

        private void RadioButton_Click_5(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Img.Source = new BitmapImage(new Uri(@"C:\Users\Kira\source\repos\WpfApp4\WpfApp4\Images\img7.jpg"));
            mainWindow.Show();
        }

        private void RadioButton_Click_6(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Img.Source = new BitmapImage(new Uri(@"C:\Users\Kira\source\repos\WpfApp4\WpfApp4\Images\img8.jpg"));
            mainWindow.Show();
        }
    }
}
