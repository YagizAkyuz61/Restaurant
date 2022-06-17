using Garson.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Garson.Service;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;
using Xamarin.Essentials;

namespace Garson.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderPage : ContentPage
    {
        public ObservableCollection<FoodClass> FoodClasses;
        public ObservableCollection<TableClass> TableClasses;
        private bool First = true;
        public OrderPage()
        {
            InitializeComponent();
            FoodClasses = new ObservableCollection<FoodClass>();
            TableClasses = new ObservableCollection<TableClass>();
            LoadTable();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            if (First)
            {
                var foods = await ApiService.GetFoods();
                foreach (var food in foods)
                {
                    FoodClasses.Add(food);
                }
                list1.ItemsSource = FoodClasses;
            }
            First = false;
        }

        public async void LoadTable()
        {
            var tables = await ApiService.GetTable();
            foreach(var table in tables)
            {
                TableClasses.Add(table);
            }
            tableCB.ItemsSource = TableClasses;
        }

        private void acceptBTN_Clicked(object sender, EventArgs e)
        {
            resultLBL.Text = "Sipariş açın...";
            resultLBL.TextColor = Color.Black;
        }

        private async void list1_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var wai = Preferences.Get("waiterId", string.Empty);
            var order = new OrderClass();
            var food = e.SelectedItem as FoodClass;
            var table = tableCB.SelectedItem as TableClass;
            order.FoodId = Convert.ToInt32(food.Id);
            order.TableId = Convert.ToInt32(table.Id);
            order.Opens = 1;
            order.Date = DateTime.Today;
            order.WaiterId = Convert.ToInt32(wai);


            var response = await ApiService.OrderAdd(order);
            if (response != null)
            {
                resultLBL.Text = "Sipariş onaylanamadı";
                resultLBL.TextColor = Color.Red;
            }
            else
            {
                resultLBL.Text = "Sipariş onaylandı:" + " " + food.FoodName;
                resultLBL.TextColor = Color.Green;
            }
        }

        private void orderBTN_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new OrdersPage());
        }
    }
}