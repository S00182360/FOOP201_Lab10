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

namespace FOOP201_Lab10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Bike> BikeList = new ObservableCollection<Bike>();
        ObservableCollection<Bike> ProductList = new ObservableCollection<Bike>();
        ObservableCollection<Bike> CartList = new ObservableCollection<Bike>();
        static decimal total = 0m;
        string totalMsg = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow1_Loaded(object sender, RoutedEventArgs e)
        {
            Bike bike1 = new Bike(1234, "Road Bike", 335.00m, "Male");
            Bike bike2 = new Bike(1235, "Road Bike", 325.00m, "Female");
            Bike bike3 = new Bike(1325, "Mountain Bike", 435.00m, "Male");
            Bike bike4 = new Bike(1326, "Mountain Bike", 433.00m, "Female");
            Bike bike5 = new Bike(2176, "Hybrid Bike", 735.00m, "Male");
            Bike bike6 = new Bike(2178, "Hybrid Bike", 730.00m, "Female");

            BikeList.Add(bike1);
            BikeList.Add(bike2);
            BikeList.Add(bike3);
            BikeList.Add(bike4);
            BikeList.Add(bike5);
            BikeList.Add(bike6);

            lbxProducts.ItemsSource = BikeList;
            lbxCart.ItemsSource = CartList;

            tbkCart.Text = totalMsg + total.ToString();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Bike BikeSelected = lbxProducts.SelectedItem as Bike;
            if (BikeSelected != null)
            {
                CartList.Add(BikeSelected);
                total += BikeSelected.Price;
            }
        }

        private void BtnRemove_Click(object sender, RoutedEventArgs e)
        {
            Bike BikeRemove = lbxCart.SelectedItem as Bike;
            if (BikeRemove != null)
            {
                CartList.Remove(BikeRemove);
                total -= BikeRemove.Price;
            }
        }
    }
}
