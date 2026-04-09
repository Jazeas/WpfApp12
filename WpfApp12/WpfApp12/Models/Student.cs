using System.ComponentModel;

namespace WpfApp12
{
    public class Student : INotifyPropertyChanged
    {
        private string firstName;
        private string lastName;
        private int age;
        private string group;

        public string FirstName
        {
            get => firstName;
            set
            {
                firstName = value;
                OnPropertyChanged(nameof(FirstName));
            }
        }

        public string LastName
        {
            get => lastName;
            set
            {
                lastName = value;
                OnPropertyChanged(nameof(LastName));
            }
        }

        public int Age
        {
            get => age;
            set
            {
                age = value;
                OnPropertyChanged(nameof(Age));
            }
        }

        public string Group
        {
            get => group;
            set
            {
                group = value;
                OnPropertyChanged(nameof(Group));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(propertyName));
        }
    }
}