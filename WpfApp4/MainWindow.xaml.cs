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

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public static int flag = 0;
        public void Button1_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            TB1.Visibility = Visibility.Visible;
            TB2.Visibility = Visibility.Visible;
            TB3.Visibility = Visibility.Visible;
            r1.Visibility = Visibility.Visible;
            Button14.Visibility = Visibility.Visible;
            slider1.Visibility = Visibility.Visible;
            slider2.Visibility = Visibility.Visible;
            slider3.Visibility = Visibility.Visible;
            flag = 1;
        }
        public void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Brush color = Button1.Background;
            Canv.DefaultDrawingAttributes.Color = (Color)ColorConverter.ConvertFromString(Convert.ToString(color));
        }

        //2 кнопка
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Brush color = Button2.Background;
            Canv.DefaultDrawingAttributes.Color = (Color)ColorConverter.ConvertFromString(Convert.ToString(color));
        }

        private void Button2_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            TB1.Visibility = Visibility.Visible;
            TB2.Visibility = Visibility.Visible;
            TB3.Visibility = Visibility.Visible;
            r1.Visibility = Visibility.Visible;
            Button14.Visibility = Visibility.Visible;
            slider1.Visibility = Visibility.Visible;
            slider2.Visibility = Visibility.Visible;
            slider3.Visibility = Visibility.Visible;
            flag = 2;
        }

        //3 кнопка
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Brush color = Button3.Background;
            Canv.DefaultDrawingAttributes.Color = (Color)ColorConverter.ConvertFromString(Convert.ToString(color));
        }

        private void Button3_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            TB1.Visibility = Visibility.Visible;
            TB2.Visibility = Visibility.Visible;
            TB3.Visibility = Visibility.Visible;
            r1.Visibility = Visibility.Visible;
            Button14.Visibility = Visibility.Visible;
            slider1.Visibility = Visibility.Visible;
            slider2.Visibility = Visibility.Visible;
            slider3.Visibility = Visibility.Visible;
            flag = 3;
        }

        //4 кнопка
        private void Button4_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            TB1.Visibility = Visibility.Visible;
            TB2.Visibility = Visibility.Visible;
            TB3.Visibility = Visibility.Visible;
            r1.Visibility = Visibility.Visible;
            Button14.Visibility = Visibility.Visible;
            slider1.Visibility = Visibility.Visible;
            slider2.Visibility = Visibility.Visible;
            slider3.Visibility = Visibility.Visible;
            flag = 4;
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Brush color = Button4.Background;
            Canv.DefaultDrawingAttributes.Color = (Color)ColorConverter.ConvertFromString(Convert.ToString(color));
        }

        //5 кнопка
        private void Button5_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            TB1.Visibility = Visibility.Visible;
            TB2.Visibility = Visibility.Visible;
            TB3.Visibility = Visibility.Visible;
            r1.Visibility = Visibility.Visible;
            Button14.Visibility = Visibility.Visible;
            slider1.Visibility = Visibility.Visible;
            slider2.Visibility = Visibility.Visible;
            slider3.Visibility = Visibility.Visible;
            flag = 5;
        }
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Brush color = Button5.Background;
            Canv.DefaultDrawingAttributes.Color = (Color)ColorConverter.ConvertFromString(Convert.ToString(color));
        }

        //6 кнопка
        private void Button6_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            TB1.Visibility = Visibility.Visible;
            TB2.Visibility = Visibility.Visible;
            TB3.Visibility = Visibility.Visible;
            r1.Visibility = Visibility.Visible;
            Button14.Visibility = Visibility.Visible;
            slider1.Visibility = Visibility.Visible;
            slider2.Visibility = Visibility.Visible;
            slider3.Visibility = Visibility.Visible;
            flag = 6;
        }
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Brush color = Button6.Background;
            Canv.DefaultDrawingAttributes.Color = (Color)ColorConverter.ConvertFromString(Convert.ToString(color));
        }

        //7 кнопка

        private void Button7_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            TB1.Visibility = Visibility.Visible;
            TB2.Visibility = Visibility.Visible;
            TB3.Visibility = Visibility.Visible;
            r1.Visibility = Visibility.Visible;
            Button14.Visibility = Visibility.Visible;
            slider1.Visibility = Visibility.Visible;
            slider2.Visibility = Visibility.Visible;
            slider3.Visibility = Visibility.Visible;
            flag = 7;
        }
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Brush color = Button7.Background;
            Canv.DefaultDrawingAttributes.Color = (Color)ColorConverter.ConvertFromString(Convert.ToString(color));
        }
        //8 кнопка
        private void Button8_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {

            TB1.Visibility = Visibility.Visible;
            TB2.Visibility = Visibility.Visible;
            TB3.Visibility = Visibility.Visible;
            r1.Visibility = Visibility.Visible;
            Button14.Visibility = Visibility.Visible;
            slider1.Visibility = Visibility.Visible;
            slider2.Visibility = Visibility.Visible;
            slider3.Visibility = Visibility.Visible;
            flag = 8;
        }
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Brush color = Button8.Background;
            Canv.DefaultDrawingAttributes.Color = (Color)ColorConverter.ConvertFromString(Convert.ToString(color));
        }

        //9 кнопка

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            Brush color = Button9.Background;
            Canv.DefaultDrawingAttributes.Color = (Color)ColorConverter.ConvertFromString(Convert.ToString(color));
        }
        private void Button12_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            TB1.Visibility = Visibility.Visible;
            TB2.Visibility = Visibility.Visible;
            TB3.Visibility = Visibility.Visible;
            r1.Visibility = Visibility.Visible;
            Button14.Visibility = Visibility.Visible;
            slider1.Visibility = Visibility.Visible;
            slider2.Visibility = Visibility.Visible;
            slider3.Visibility = Visibility.Visible;
            flag = 9;
        }

        //10 кнопка
        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            Brush color = Button10.Background;
            Canv.DefaultDrawingAttributes.Color = (Color)ColorConverter.ConvertFromString(Convert.ToString(color));
        }
        private void Button11_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            TB1.Visibility = Visibility.Visible;
            TB2.Visibility = Visibility.Visible;
            TB3.Visibility = Visibility.Visible;
            r1.Visibility = Visibility.Visible;
            Button14.Visibility = Visibility.Visible;
            slider1.Visibility = Visibility.Visible;
            slider2.Visibility = Visibility.Visible;
            slider3.Visibility = Visibility.Visible;
            flag = 10;
        }

        //11 кнопка
        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            Brush color = Button11.Background;
            Canv.DefaultDrawingAttributes.Color = (Color)ColorConverter.ConvertFromString(Convert.ToString(color));
        }
        private void Button10_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            TB1.Visibility = Visibility.Visible;
            TB2.Visibility = Visibility.Visible;
            TB3.Visibility = Visibility.Visible;
            r1.Visibility = Visibility.Visible;
            Button14.Visibility = Visibility.Visible;
            slider1.Visibility = Visibility.Visible;
            slider2.Visibility = Visibility.Visible;
            slider3.Visibility = Visibility.Visible;
            flag = 11;
        }

        //12 кнопка
        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            Brush color = Button12.Background;
            Canv.DefaultDrawingAttributes.Color = (Color)ColorConverter.ConvertFromString(Convert.ToString(color));
        }
        private void Button9_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            TB1.Visibility = Visibility.Visible;
            TB2.Visibility = Visibility.Visible;
            TB3.Visibility = Visibility.Visible;
            r1.Visibility = Visibility.Visible;
            Button14.Visibility = Visibility.Visible;
            slider1.Visibility = Visibility.Visible;
            slider2.Visibility = Visibility.Visible;
            slider3.Visibility = Visibility.Visible;
            flag = 12 ;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem item = (ComboBoxItem)comboBox.SelectedItem;
            Canv.DefaultDrawingAttributes.Width = Convert.ToInt32(item.Content.ToString().Split()[0]);
        }

        private void Button_Click_20(object sender, RoutedEventArgs e)
        {
            Gallery gallery = new Gallery();
            gallery.Show();
            this.Hide();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Button9.Visibility == Visibility.Hidden)
            {
                Brush color = r1.Fill;
                Canv.DefaultDrawingAttributes.Color = (Color)ColorConverter.ConvertFromString(Convert.ToString(color));
                Button9.Background = color;
                Button9.Visibility = Visibility.Visible;
                TB1.Visibility = Visibility.Hidden;
                TB2.Visibility = Visibility.Hidden;
                TB3.Visibility = Visibility.Hidden;
                r1.Visibility = Visibility.Hidden;
                Button.Visibility = Visibility.Hidden;
                slider1.Visibility = Visibility.Hidden;
                slider2.Visibility = Visibility.Hidden;
                slider3.Visibility = Visibility.Hidden;
            }
            else if (Button10.Visibility == Visibility.Hidden)
            {
                Brush color = r1.Fill;
                Canv.DefaultDrawingAttributes.Color = (Color)ColorConverter.ConvertFromString(Convert.ToString(color));
                Button10.Background = color;
                Button10.Visibility = Visibility.Visible;
                TB1.Visibility = Visibility.Hidden;
                TB2.Visibility = Visibility.Hidden;
                TB3.Visibility = Visibility.Hidden;
                r1.Visibility = Visibility.Hidden;
                Button.Visibility = Visibility.Hidden;
                slider1.Visibility = Visibility.Hidden;
                slider2.Visibility = Visibility.Hidden;
                slider3.Visibility = Visibility.Hidden;
            }
            else if (Button11.Visibility == Visibility.Hidden)
            {
                Brush color = r1.Fill;
                Canv.DefaultDrawingAttributes.Color = (Color)ColorConverter.ConvertFromString(Convert.ToString(color));
                Button11.Background = color;
                Button11.Visibility = Visibility.Visible;
                TB1.Visibility = Visibility.Hidden;
                TB2.Visibility = Visibility.Hidden;
                TB3.Visibility = Visibility.Hidden;
                r1.Visibility = Visibility.Hidden;
                Button.Visibility = Visibility.Hidden;
                slider1.Visibility = Visibility.Hidden;
                slider2.Visibility = Visibility.Hidden;
                slider3.Visibility = Visibility.Hidden;
            }
            else if (Button12.Visibility == Visibility.Hidden)
            {
                Brush color = r1.Fill;
                Canv.DefaultDrawingAttributes.Color = (Color)ColorConverter.ConvertFromString(Convert.ToString(color));
                Button12.Background = color;
                Button12.Visibility = Visibility.Visible;
                TB1.Visibility = Visibility.Hidden;
                TB2.Visibility = Visibility.Hidden;
                TB3.Visibility = Visibility.Hidden;
                r1.Visibility = Visibility.Hidden;
                Button.Visibility = Visibility.Hidden;
                slider1.Visibility = Visibility.Hidden;
                slider2.Visibility = Visibility.Hidden;
                slider3.Visibility = Visibility.Hidden;
            }
        }
        public void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double red = slider1.Value;
            double grn = slider2.Value;
            double blu = slider3.Value;
            r1.Fill = new SolidColorBrush(Color.FromRgb((byte)red, (byte)grn, (byte)blu));
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            if (Button9.Visibility == Visibility.Hidden)
            {
                TB1.Visibility = Visibility.Visible;
                TB2.Visibility = Visibility.Visible;
                TB3.Visibility = Visibility.Visible;
                r1.Visibility = Visibility.Visible;
                Button.Visibility = Visibility.Visible;
                slider1.Visibility = Visibility.Visible;
                slider2.Visibility = Visibility.Visible;
                slider3.Visibility = Visibility.Visible;
            }
            else if (Button10.Visibility == Visibility.Hidden)
            {
                TB1.Visibility = Visibility.Visible;
                TB2.Visibility = Visibility.Visible;
                TB3.Visibility = Visibility.Visible;
                r1.Visibility = Visibility.Visible;
                Button.Visibility = Visibility.Visible;
                slider1.Visibility = Visibility.Visible;
                slider2.Visibility = Visibility.Visible;
                slider3.Visibility = Visibility.Visible;
            }
            else if (Button11.Visibility == Visibility.Hidden)
            {
                TB1.Visibility = Visibility.Visible;
                TB2.Visibility = Visibility.Visible;
                TB3.Visibility = Visibility.Visible;
                r1.Visibility = Visibility.Visible;
                Button.Visibility = Visibility.Visible;
                slider1.Visibility = Visibility.Visible;
                slider2.Visibility = Visibility.Visible;
                slider3.Visibility = Visibility.Visible;
            }
            else if (Button12.Visibility == Visibility.Hidden)
            {
                TB1.Visibility = Visibility.Visible;
                TB2.Visibility = Visibility.Visible;
                TB3.Visibility = Visibility.Visible;
                r1.Visibility = Visibility.Visible;
                Button.Visibility = Visibility.Visible;
                slider1.Visibility = Visibility.Visible;
                slider2.Visibility = Visibility.Visible;
                slider3.Visibility = Visibility.Visible;
            }
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            if (flag == 1)
            {
                Brush color = r1.Fill;
                Canv.DefaultDrawingAttributes.Color = (Color)ColorConverter.ConvertFromString(Convert.ToString(color));
                Button1.Background = color;
            }
            else if (flag == 2)
            {
                Brush color = r1.Fill;
                Canv.DefaultDrawingAttributes.Color = (Color)ColorConverter.ConvertFromString(Convert.ToString(color));
                Button2.Background = color;
            }
            else if (flag == 3)
            {
                Brush color = r1.Fill;
                Canv.DefaultDrawingAttributes.Color = (Color)ColorConverter.ConvertFromString(Convert.ToString(color));
                Button3.Background = color;
            }
            else if (flag == 4)
            {
                Brush color = r1.Fill;
                Canv.DefaultDrawingAttributes.Color = (Color)ColorConverter.ConvertFromString(Convert.ToString(color));
                Button4.Background = color;
            }
            else if (flag == 5)
            {
                Brush color = r1.Fill;
                Canv.DefaultDrawingAttributes.Color = (Color)ColorConverter.ConvertFromString(Convert.ToString(color));
                Button5.Background = color;
            }
            else if (flag == 6)
            {
                Brush color = r1.Fill;
                Canv.DefaultDrawingAttributes.Color = (Color)ColorConverter.ConvertFromString(Convert.ToString(color));
                Button6.Background = color;
            }
            else if (flag == 7)
            {
                Brush color = r1.Fill;
                Canv.DefaultDrawingAttributes.Color = (Color)ColorConverter.ConvertFromString(Convert.ToString(color));
                Button7.Background = color;
            }
            else if (flag == 8)
            {
                Brush color = r1.Fill;
                Canv.DefaultDrawingAttributes.Color = (Color)ColorConverter.ConvertFromString(Convert.ToString(color));
                Button8.Background = color;
            }
            else if (flag == 9)
            {
                Brush color = r1.Fill;
                Canv.DefaultDrawingAttributes.Color = (Color)ColorConverter.ConvertFromString(Convert.ToString(color));
                Button9.Background = color;
            }
            else if (flag == 10)
            {
                Brush color = r1.Fill;
                Canv.DefaultDrawingAttributes.Color = (Color)ColorConverter.ConvertFromString(Convert.ToString(color));
                Button10.Background = color;
            }
            else if (flag == 11)
            {
                Brush color = r1.Fill;
                Canv.DefaultDrawingAttributes.Color = (Color)ColorConverter.ConvertFromString(Convert.ToString(color));
                Button11.Background = color;
            }
            else if (flag == 12)
            {
                Brush color = r1.Fill;
                Canv.DefaultDrawingAttributes.Color = (Color)ColorConverter.ConvertFromString(Convert.ToString(color));
                Button12.Background = color;
            }
            TB1.Visibility = Visibility.Hidden;
            TB2.Visibility = Visibility.Hidden;
            TB3.Visibility = Visibility.Hidden;
            r1.Visibility = Visibility.Hidden;
            Button14.Visibility = Visibility.Hidden;
            slider1.Visibility = Visibility.Hidden;
            slider2.Visibility = Visibility.Hidden;
            slider3.Visibility = Visibility.Hidden;
        }
    }
}