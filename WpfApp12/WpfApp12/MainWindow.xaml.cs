using System.Collections.ObjectModel;
using System.Windows;

namespace WpfApp12
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Student> Students { get; set; }
            = new ObservableCollection<Student>();

        public MainWindow()
        {
            InitializeComponent();

            Students.Add(new Student
            {
                FirstName = "Кирилл",
                LastName = "Баранов",
                Age = 20,
                Group = "ВПФ-42"
            });

            Students.Add(new Student
            {
                FirstName = "Анна",
                LastName = "Петрова",
                Age = 19,
                Group = "ВПФ-44"
            });

            DataContext = this;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Students.Add(new Student
            {
                FirstName = newFirstName.Text,
                LastName = newLastName.Text,
                Age = int.TryParse(newAge.Text, out int age) ? age : 0,
                Group = newGroup.Text
            });
            newFirstName.Clear();
            newLastName.Clear();
            newAge.Clear();
            newGroup.Clear();
                

        }
        

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (studentList.SelectedItem is Student selected)
            {
                Students.Remove(selected);
            }
        }
    }
}