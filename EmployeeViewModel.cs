using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace WPF_application
{        
    /// <summary>     
    /// Неудачная реализация фильтра. мб доделаю.
    /// </summary>
    class EmployeeViewModel : DependencyObject
    {


        public string FilterText
        {
            get { return (string)GetValue(FilterTextProperty); }
            set { SetValue(FilterTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FilterText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FilterTextProperty =
            DependencyProperty.Register("FilterText", typeof(string), typeof(EmployeeViewModel), new PropertyMetadata("", FilterText_Changed));

        private static void FilterText_Changed(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var current = d as EmployeeViewModel;
            if(current != null)
            {
                current.Items.Filter = null;
                current.Items.Filter = current.FilterEmployee;
            }
        }

        public ICollectionView Items
        {
            get { return (ICollectionView)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Items.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemsProperty =
            DependencyProperty.Register("Items", typeof(ICollectionView), typeof(EmployeeViewModel), new PropertyMetadata(null));

        public EmployeeViewModel()
        {
            Items = CollectionViewSource.GetDefaultView(Employee.GetEmployees());
            Items.Filter += FilterEmployee;
        }

        private bool FilterEmployee(object obj)
        {
            bool result = true;
            Employee current = obj as Employee;
            if (!string.IsNullOrWhiteSpace(FilterText) && current != null && !current.Name.Contains(FilterText) && !current.SurName.Contains(FilterText))
            {
                result = false;
            }
            return result;
        }
    }
}
