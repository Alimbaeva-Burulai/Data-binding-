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

namespace ObservableCollection
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<string> animals;
       // List<string> animals;

        public MainWindow()
        {
            InitializeComponent();

            animals = new ObservableCollection<string>()
            {
                "Goat",
                "Cat",
                "Dog"
            };

            //animals = new List<string>()
            //{
            //    "Goat",
            //    "Cat",
            //    "Dog"
            //};

            lbox.ItemsSource = animals;
        }

        private void AddTigerButton_Click(object sender, RoutedEventArgs e)
        {
            animals.Add("Tiger");
        }
    }
}
