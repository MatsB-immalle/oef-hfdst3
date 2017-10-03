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

namespace oef_hfdst_3
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

        private void Mijnknop_Click(object sender, RoutedEventArgs e)
        {
            Ellipse ellipse1 = new Ellipse();
            ellipse1.Width = 50;
            ellipse1.Height = 10;
            ellipse1.Margin = new Thickness(10, 10, 0, 0);
            ellipse1.Stroke = new SolidColorBrush(Colors.Red);
            ellipse1.Fill = new SolidColorBrush(Colors.Green);
            Canvas.Children.Add(ellipse1);
        }

        private void speelveld_Click(object sender, RoutedEventArgs e)
        {
            Line lijn = new Line();
            lijn.X1 = 30;
            lijn.Y1 = 100;
            lijn.X2 = 300;
            lijn.Y2 = 100;
            lijn.Stroke = new SolidColorBrush(Colors.Black);

            Canvas.Children.Add(lijn);


            Line lijn2 = new Line();
            lijn2.X1 = 30;
            lijn2.Y1 = 220;
            lijn2.X2 = 300;
            lijn2.Y2 = 220;
            lijn2.Stroke = new SolidColorBrush(Colors.Black);

            Canvas.Children.Add(lijn2);

            Line lijn3 = new Line();
            lijn3.X1 = 100;
            lijn3.Y1 = 30;
            lijn3.X2 = 100;
            lijn3.Y2 = 300;
            lijn3.Stroke = new SolidColorBrush(Colors.Black);

            Canvas.Children.Add(lijn3);

            Line lijn4 = new Line();
            lijn4.X1 = 220;
            lijn4.Y1 = 30;
            lijn4.X2 = 220;
            lijn4.Y2 = 300;
            lijn4.Stroke = new SolidColorBrush(Colors.Black);

            Canvas.Children.Add(lijn4);

           
        }
    }
}
