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
using WPF_application.ViewModel;

namespace WPF_application
{
    /// <summary>
    /// Логика взаимодействия для EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        public static bool flag = false;

        public EditWindow(Employee emp)
        {
            InitializeComponent();
            editWindowList.DataContext = emp;
        }


        private void Window_Closed(object sender, EventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BindingExpression be = textBox_name.GetBindingExpression(TextBox.TextProperty);
            BindingExpression be1 = textBox_surname.GetBindingExpression(TextBox.TextProperty);
            BindingExpression be2 = textBox_age.GetBindingExpression(TextBox.TextProperty);

            be.UpdateSource();
            be1.UpdateSource();
            be2.UpdateSource();

        }
    }
}
