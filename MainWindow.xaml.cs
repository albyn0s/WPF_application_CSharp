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
        Program vm = new Program();

        public MainWindow()
        {
            InitializeComponent();
            ListEmploye.ItemsSource = vm.emp_s;
        }

        private void ListEmploye_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void ListEmploye_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
    }


}
