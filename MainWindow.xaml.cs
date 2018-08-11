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
using System.Collections.ObjectModel;


namespace WPF_application
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Program mainClass = new Program();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListEmploye_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Employee emp = ListEmploye.SelectedItem as Employee;
            Department dep = ListEmploye.SelectedItem as Department;
            textBox_name.Text = emp.Name;
            textBox_surname.Text = emp.SurName;
            textBox_age.Text = Convert.ToString(emp.Age);
            textBox_depart.Text = dep.Name;
        }

        private void ListEmploye_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
    }


}
