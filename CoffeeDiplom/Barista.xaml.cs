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

namespace CoffeeDiplom
{
    /// <summary>
    /// Логика взаимодействия для Barista.xaml
    /// </summary>
    public partial class Barista : Window
    {
        public Barista()
        {
            InitializeComponent();
            CoffeClass.MainFrame = MainFrame;
            CoffeClass.MainFrame.Navigate(new BaristaOrder());  
        }     

        private void Coffe(object sender, RoutedEventArgs e)
        {
            CoffeClass.MainFrame.Navigate(new BaristaCoffee());
        }

        private void Zakaz(object sender, RoutedEventArgs e)
        {
            CoffeClass.MainFrame.Navigate(new BaristaOrder());
        }    

        private void Nazad(object sender, RoutedEventArgs e)
        {
            MainWindow AAA = new MainWindow();
            AAA.Show();
            Close();
        }
    }
}
