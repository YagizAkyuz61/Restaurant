using Garson.Model;
using Garson.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Garson.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrdersPage : ContentPage
    {
        ObservableCollection<OrderClass> OrderClasses;
        ObservableCollection<TableClass> TableClasses;
        public OrdersPage()
        {
            InitializeComponent();
            OrderClasses = new ObservableCollection<OrderClass>();
            TableClasses = new ObservableCollection<TableClass>();
            Load();
        }

        public async void Load()
        {
            var tables = await ApiService.GetTable();
            foreach(var table in tables)
                TableClasses.Add(table);
            tableCB.ItemsSource = TableClasses;

            var orders = await ApiService.GetOrder();
            foreach (var order in orders)
                OrderClasses.Add(order);
        }

        private async void tableCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var table = tableCB.SelectedItem as TableClass;
            var orders = await ApiService.GetOrderSe(Convert.ToInt32(table.Id));
            foreach (var order in orders)
            {
                if (order.TableId == table.Id)
                {
                    OrderClasses.Add(order);
                }
            }
            list1.ItemsSource = OrderClasses;
        }

        private async void deleteBTN_Clicked(object sender, EventArgs e)
        {
            var response = await ApiService.OrderDelete(Convert.ToInt32(orderId.Text));
            orderId.TextColor = Color.Green;
            orderId.Text = "Silme başarılı.";
        }

        private void list1_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var s = e.SelectedItem as OrderClass;
            orderId.Text = Convert.ToString(s.Id);
        }
    }
}