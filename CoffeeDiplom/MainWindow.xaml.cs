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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void inSign_Click(object sender, RoutedEventArgs e)
        {
            using(var db = new coffee_houseEntities())
            {
                var pass = db.Users.AsNoTracking().FirstOrDefault(u => u.login == inputLogin.Text && u.password == inputPassword.Password);
                var log = db.Users.AsNoTracking().FirstOrDefault(u => u.login == inputLogin.Text);

                if (inputLogin.Text.Length == 0)
                    MessageBox.Show("Введите логин!");

                else if (inputPassword.Password.Length == 0)
                    MessageBox.Show("Введите пароль!");

                else
                {
                    if (log == null)
                        MessageBox.Show("Пользователь не найден!");
                    else
                    {
                        if (pass == null)
                            MessageBox.Show("Неверный пароль!");
                        else
                        {
                            if (pass.isAdmin == true)
                            {
                                Menedjer admin = new Menedjer();
                                admin.Show();
                                Close();
                            }
                            if (pass.isAdmin == false)
                            {
                                Barista managers = new Barista();
                                managers.Show();
                                Close();
                            }

                        }
                    }
                }
            }
        }

        private void cancl_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
