using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow1 : Window
    {
        public ObservableCollection<string> Employee;
        public ObservableCollection<string> Department;

        Random rnd = new Random();

        Add1 add = new Add1();

        public MainWindow1()
        {

            InitializeComponent();

            Employee = new ObservableCollection<string>() { "Ivanov", "Petrov", "Sidorov", "Smirnov", "Kuplinov", "Kurpatov" };//filling list Employee

            Department = new ObservableCollection<string>() { "COMMUNICATIONS", "COMMERCIAL DEPARTMENT", "LEGAL DEPARTMENT", "SECURITY DEPARTMENT", "GROUND HANDLING DEPARTMENT", "HUMAN RESOURCES DEPARTMENT" }; //filling list Department

            AddToEmployee();
            AddToDepartment();

        }

        public void AddToEmployee()
        {
            foreach (string item in Employee)
            {
                EmployeeList.Items.Add(item);
            }
        }
        public void AddToDepartment()
        {
            foreach (string item in Department)
            {
                DepartmentList.Items.Add(item);
            }
        }

        public void Update()
        {
            if (add.name != null && add.department != null)
            {
                Employee.Add(add.name);
                Department.Add(add.department);
                EmployeeList.Items.Clear();
                DepartmentList.Items.Clear();
                AddToEmployee();
                AddToDepartment();
                add.name = null;
                add.department = null;
                MessageBox.Show("Обновлено");
            }
            else
                MessageBox.Show("Обновлять нечего");
        }

        private void Delete()
        {
            string name = null;
            string department = null;
            try
            {
                name = EmployeeList.SelectedItem.ToString();
                department = DepartmentList.SelectedItem.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбран департамент или сотрудник");
            }
            
            if (name != null && department != null)
            {
                Employee.Remove(name);
                Department.Remove(department);
                EmployeeList.Items.Clear();
                DepartmentList.Items.Clear();
                AddToEmployee();
                AddToDepartment();
            }

        }

        public void Chanege(int index,string dept)  //что бы не захламлять, тут обновление полсе внесения изменения
        {
            EmployeeList.Items.Clear();
            DepartmentList.Items.Clear();
            Department.Insert(index, dept);
            AddToEmployee();
            AddToDepartment();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            add.Show();
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            Delete();
        }

        private void btnUpdater_Click(object sender, RoutedEventArgs e)
        {
            Update();
        }

        private void btnChng_Click(object sender, RoutedEventArgs e)
        {
            Change1 change = new Change1();
            change.Show();
        }
    }
}
