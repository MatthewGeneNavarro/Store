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
        // this pushes all items in Dbset ITEMS to show all present products in table to combobox
        private void syncDB()
        {
            using var dbContext = new SqliteDBContext();
            var items = dbContext.Items.ToList<Product>();
            if (items is not null)
            {
                ItemChoices.ItemsSource = items.Select(c => c.ProductName);
            }            
        }

        // Navigates to different pages in the WPF app
        private void BackToMain(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }

        // Add Items to cart
        private void AddItem(object sender, RoutedEventArgs e)
        {
            if(ItemChoices.SelectedIndex is not -1)
            {
                using var dbContext = new SqliteDBContext();

                //This acts as a cart
                ProductQuantity cart = new ProductQuantity();
                var checkAmount = dbContext.Items.First(a => a.ProductName == ItemChoices.Text);
                //if(Convert.ToInt32(DesiredAmount) >= checkAmount)
                //{

                //}



                //cart.Products.Add(dbContext.Items.Where(c => c.ProductName == ItemChoices.Text).First());


                //var temp = cart.Products[0];
                //temp.ProductAmount = Convert.ToInt32(DesiredAmount.Text);




                // Assign the current amount of items available to variable


                //dbContext.SaveChanges();
                //ItemChoices.SelectedIndex = -1;
                //NavigationService.Navigate(new MainPage());
            }
        }


        private void SyncDG(object sender, SelectionChangedEventArgs e)
        {
            using var dbContext = new SqliteDBContext();
            //Implement user cart tracking if time
            //ProductQuantity cart = dbContext.ItemsInCart.


            //List<ProductQuantity> cart = dbContext.ItemsInCart.Where(p => p.ProductQuantityId == items.ProductId).ToList<Product>();
            //MainDG.ItemsSource = cart;
        }
    }
}




