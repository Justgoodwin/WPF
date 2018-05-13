using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Add.xaml
    /// </summary>
    /// 

    

    public partial class Add1 : Window
    {
        public string name = null;
        public string department = null;

        public bool state = false; // костыль для того чтобы обносить форму после добавления людей
        public Add1()
        {
            InitializeComponent();
        }
        private void addWorkersToPlaces()
        { 
            name = TextBoxName.Text.ToString();
            department = TextBoxName.Text.ToString();
            TextBoxName.Clear();
            TextBoxDepartment.Clear();
            state = true;
        }

        private void OkeyButton_Click(object sender, RoutedEventArgs e)
        {
            addWorkersToPlaces();
            Hide();
        }
    }
}
