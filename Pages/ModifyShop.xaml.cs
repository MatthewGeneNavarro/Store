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
    /// Interaction logic for ModifyShop.xaml
    /// </summary>
    public partial class ModifyShop : Page
    {
        public ModifyShop()
        {
            InitializeComponent();
        }

        private void BackToMain(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }
        //C in CRUD
        // Create items in Database
        private void AddToDatabase(object sender, RoutedEventArgs e)
        {

            if (NameOfItem.Text is not null && AmountOfItem.Text is not null && PriceOfItem.Text is not null)
            {

                var newEntry = new Product
                {
                    ProductName = NameOfItem.Text,
                    ProductPrice = Convert.ToDouble(PriceOfItem.Text),
                    ProductAmount = Convert.ToInt32(AmountOfItem.Text)
                };

                using var dbContext = new SqliteDBContext();
                dbContext.Add(newEntry);
                dbContext.SaveChanges();
                NameOfItem.Text = "";
                PriceOfItem.Text = "";
                AmountOfItem.Text = "";
                NavigationService.Navigate(new MainPage());

            }

            else
            {
                MessageBox.Show("Please enter all three values.");
            }
        }
        
        // D in CRUD
        //Deletes items in Database
        private void DeleteItem(object sender, RoutedEventArgs e)
        {

            if (RemoveItem.Text is not null)
            {
                using var dbContext = new SqliteDBContext();
                var rmItemFromInventory = dbContext.Items.First(c => c.ProductName == RemoveItem.Text); 
                dbContext.SaveChanges();
                RemoveItem.Text = "";
                NavigationService.Navigate(new MainPage());
            }
        }
    }
}
