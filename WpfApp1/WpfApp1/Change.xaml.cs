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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Change.xaml
    /// </summary>
    public partial class Change1 : Window
    {
        MainWindow1 window1 = new MainWindow1();
        public int index;
        public string dept = null;
        public Change1()
        {
            InitializeComponent();
            foreach (string item in window1.Employee)
            {
                EmployeeComboBox.Items.Add(item);
            }
            foreach (string item in window1.Department)
            {
                DepartmentComboBox.Items.Add(item);
            }

        }

        private void Okey_Click(object sender, RoutedEventArgs e)
        {
            index = EmployeeComboBox.SelectedIndex;
            dept = DepartmentComboBox.SelectedItem.ToString();
            window1.Department.Insert(index, dept);
            Hide();
        }
    }
}
