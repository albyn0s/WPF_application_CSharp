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
            mainClass.Main();
            ListEmploye.ItemsSource = mainClass.emp_s;
            ListDepartment.ItemsSource = mainClass.dep_s;


        }
    }


}
