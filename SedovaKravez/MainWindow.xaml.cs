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
using static SedovaKravez.AppData;


namespace SedovaKravez
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var Employes = context.Employee.Where(i => i.Phone == loginBox.Text && i.Password == passwordBox.Text).FirstOrDefault();
            if (Employes != null)
            {
                if (Employes == null)
                {
                    MessageBox.Show("Пользователь не найден, повторите попытку", "Пользователь не найден", MessageBoxButton.OK);
                }
                else if (Employes.Role == 1)
                {
                    DoctorWin DocW = new DoctorWin();
                    DocW.Show();
                    Application.Current.MainWindow.Close();
                }
                else
                {
                    MessageBox.Show("Пароль не совпадает повторите попытку", "Ошибка ввода пароля", MessageBoxButton.OK);
                }
            }
        }
    }
}
