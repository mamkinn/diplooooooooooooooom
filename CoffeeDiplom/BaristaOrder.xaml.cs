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
    /// Логика взаимодействия для BaristaOrder.xaml
    /// </summary>
    public partial class BaristaOrder : Page
    {
        public BaristaOrder()
        {
            InitializeComponent();
            OrderCoffee.ItemsSource = coffee_houseEntities.Getcontext().Order.ToList();
        }

        private void New_Click(object sender, RoutedEventArgs e)
        {
            CoffeClass.MainFrame.Navigate(new addOrder());
        }

        private void Delite_Click(object sender, RoutedEventArgs e)
        {
            var hotelsForRemoving = OrderCoffee.SelectedItems.Cast<Order>().ToList();

            //уточняем у пользователя точно ли хотим удалить
            if (MessageBox.Show($"Вы точно хотите удалить следующие {hotelsForRemoving.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                //обработка исключений
                try
                {
                    coffee_houseEntities.Getcontext().Order.RemoveRange(hotelsForRemoving);
                    coffee_houseEntities.Getcontext().SaveChanges();
                    MessageBox.Show("Данные удалены!");
                    coffee_houseEntities.Getcontext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                    OrderCoffee.ItemsSource = coffee_houseEntities.Getcontext().Order.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }     
    }
 }

