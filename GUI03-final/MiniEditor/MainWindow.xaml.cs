using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace MiniEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Person> people;
        public MainWindow()
        {
            InitializeComponent();
            people = new ObservableCollection<Person>()
            {
                new Person(){Name = "Kati", Age = 20, HaveGlasses = "Yes"},
                new Person(){Name = "Bella", Age = 30, HaveGlasses = "No"},
                new Person(){Name = "Sanyi", Age = 10, HaveGlasses = "Yes"}
            };
            lbox.ItemsSource = people;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (lbox.SelectedItem != null && lbox.SelectedItem is Person p)
            {
                if (p.HaveGlasses == "Yes")
                {
                    p.HaveGlasses = "No";
                }
                else
                {
                    p.HaveGlasses = "Yes";
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            people.Add(new Person()
            {
                Name = ""
            });
        }
    }
}
