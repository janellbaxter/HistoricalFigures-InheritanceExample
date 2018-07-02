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

namespace InheritanceExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        List<Person> people = new List<Person>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void InheritanceExample_Loaded(object sender, RoutedEventArgs e)
        {
            Information.Text = "";
            AddAnother.Visibility = Visibility.Collapsed;
            Information.Visibility = Visibility.Collapsed;
            InformationScroller.Visibility = Visibility.Collapsed;
        }

        private void Update(Person person)
        {
            InformationScroller.Visibility = Visibility.Visible;
            AddAnother.Visibility = Visibility.Visible;
            Information.Visibility = Visibility.Visible;
            string temp = "";
            Information.Text = "";

            foreach (Person p in people)
            {
                temp += p.About() + "\n\n";
            }

            Information.Text = temp;
            AddPerson.Visibility = Visibility.Collapsed;
            LblFirstName.Visibility = Visibility.Collapsed;
            LblLastName.Visibility = Visibility.Collapsed;
            LblDescription.Visibility = Visibility.Collapsed;
            
        }

      

        private void AddProgrammer_Click(object sender, RoutedEventArgs e)
        {
            Person person;
            person = new Programmer(PersonFirstName.Text, PersonLastName.Text, PersonDescription.Text);
            people.Add(person);
            Update(person);
        }

        private void AddMathematician_Click(object sender, RoutedEventArgs e)
        {
            Person person;
            person = new Mathematician(PersonFirstName.Text, PersonLastName.Text, PersonDescription.Text);
            people.Add(person);
            Update(person);
        }

        private void AddAnother_Click(object sender, RoutedEventArgs e)
        {
            AddPerson.Visibility = Visibility.Visible;
            LblFirstName.Visibility = Visibility.Visible;
            LblLastName.Visibility = Visibility.Visible;
            LblDescription.Visibility = Visibility.Visible;
            Information.Visibility = Visibility.Collapsed;
        }
    }
}
