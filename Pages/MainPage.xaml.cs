using Store.Models;
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

namespace Store.Pages
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public void db()
        {
            using var dbContext = new SqliteDBContext();
            dbContext.Database.EnsureCreated();
        }

        // Navigates to different pages in the WPF app
        //goes to the shop, adds items to cart
        private void GoToMenu(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Menu());
        }

        // show items in cart
        private void ViewCart(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Cart());
        }

        // message box showing total amount of items in cart
        private void Checkout(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Checkout());
        }

        // add items to the database, delete items from the database.
        private void ModifyShop(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ModifyShop());
        }
    }
}
