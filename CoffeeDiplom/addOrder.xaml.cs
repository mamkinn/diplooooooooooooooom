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

namespace CoffeeDiplom
{
    /// <summary>
    /// Логика взаимодействия для addOrder.xaml
    /// </summary>
    public partial class addOrder : Page
    {
        private Order _cur = new Order();
        public addOrder()
        {
            InitializeComponent();
            DataContext = _cur;
            typeCoffee.ItemsSource = coffee_houseEntities.Getcontext().Coffee.ToList();
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            CoffeClass.MainFrame.Navigate(new BaristaOrder());
        }


        private void save_Click(object sender, RoutedEventArgs e)
        {
            coffee_houseEntities.Getcontext().Order.Add(_cur);
            //обработка исключений
            try
            {
                coffee_houseEntities.Getcontext().SaveChanges();
                MessageBox.Show("Информация сохранена!");
                CoffeClass.MainFrame.Navigate(new BaristaOrder());
                coffee_houseEntities.Getcontext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                coffee_houseEntities.Getcontext().Order.ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
        }
    }
}
