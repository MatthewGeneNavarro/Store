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
using Store;
using Store.Models;


namespace Store.Pages
{
    /// <summary>
    /// Interaction logic for Inventory.xaml
    /// </summary>
    public partial class Menu : Page
    {
        public Menu()
        {
            InitializeComponent();
            syncDB();
        }

        private void syncDB()
        {
            using var dbContext = new SqliteDBContext();
            var items = dbContext.Items.ToList<Product>();
            if(items is not null)
            {
                ItemChoices.ItemsSource = items.Select(c => c.ProductName);
            }

        }

        // Navigates to differet pages in the WPF app
        private void BackToMain(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }


        private void AddItem(object sender, RoutedEventArgs e)
        {
            if(ItemChoices.SelectedIndex is not -1)
            {
                using var dbContext = new SqliteDBContext();
                ProductQuantity cart = new ProductQuantity();
                cart.product.Add(dbContext.Items.Where(c => c.ProductName == ItemChoices.Text).First());

                


                dbContext.SaveChanges();
                ItemChoices.SelectedIndex = -1;
                NavigationService.Navigate(new MainPage());
            }
        }
    }
}
