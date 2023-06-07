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
    /// Логика взаимодействия для addCoffeeM.xaml
    /// </summary>
    public partial class addCoffeeM : Page
    {
        private Coffee _cur = new Coffee();
        public addCoffeeM()
        {

            InitializeComponent();
            DataContext = _cur;
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            coffee_houseEntities.Getcontext().Coffee.Add(_cur);
            //обработка исключений
            try
            {
                coffee_houseEntities.Getcontext().SaveChanges();
                MessageBox.Show("Информация сохранена!");
                CoffeClass.MainFrame.Navigate(new MenedjerCoffee());
                coffee_houseEntities.Getcontext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                coffee_houseEntities.Getcontext().Coffee.ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            CoffeClass.MainFrame.Navigate(new MenedjerCoffee());
        }
    }

      
    }

