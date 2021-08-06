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

        private void AddToDatabase(object sender, RoutedEventArgs e)
        {

            if (NameOfItem.Text is not null && AmountOfItem.Text is not null && PriceOfItem.Text is not null)
            {
                using var dbContext = new SqliteDBContext();
                dbContext.Items.Add(new() {ProductName = NameOfItem.Text, ProductPrice = Convert.ToDouble(PriceOfItem.Text), ProductAmount = Convert.ToInt32(AmountOfItem.Text) });
                dbContext.SaveChanges();
                NameOfItem.Text = "";
                PriceOfItem.Text = "";
                AmountOfItem.Text = "";
                NavigationService.Navigate(new MainPage());
                //dbContext.
            }
            else
            {
                MessageBox.Show("Please enter all three values.");
            }
        }
    }
}
