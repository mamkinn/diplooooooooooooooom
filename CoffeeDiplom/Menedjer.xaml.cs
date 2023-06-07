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
    /// Логика взаимодействия для Menedjer.xaml
    /// </summary>
    public partial class Menedjer : Window
    {
        public Menedjer()
        {
            InitializeComponent();
            CoffeClass.MainFrame = MFrame;
            CoffeClass.MainFrame.Navigate(new MenedjerCoffee());            
        }

        private void New_Click(object sender, RoutedEventArgs e)
        {
            CoffeClass.MainFrame.Navigate(new addCoffeeM());
        }

        private void Nazad(object sender, RoutedEventArgs e)
        {
            MainWindow AAA = new MainWindow();
            AAA.Show();
            Close();
        }

        private void Coffee(object sender, RoutedEventArgs e)
        {
            CoffeClass.MainFrame.Navigate(new MenedjerCoffee());
        }

        private void Zakaz(object sender, RoutedEventArgs e)
        {
            CoffeClass.MainFrame.Navigate(new MenedjerOrder());
        }
    }
}
