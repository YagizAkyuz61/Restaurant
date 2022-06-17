using Rezervasyon.Model;
using Rezervasyon.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Rezervasyon.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddReservationPage : ContentPage
    {
        public ObservableCollection<TableClass> TableClasses;
        public ObservableCollection<TimeClass> TimeClasses;
        public AddReservationPage()
        {
            InitializeComponent();
            TableClasses = new ObservableCollection<TableClass>();
            TimeClasses = new ObservableCollection<TimeClass>();
            LoadTable();

            datePC.MinimumDate = DateTime.Now;
            datePC.MaximumDate = DateTime.Now.AddMonths(2);
            datePC.Date = DateTime.Now;
            datePC.Format = "dd-MM-yyyy";
        }

        public async void LoadTable()
        {
            var tables = await ApiService.GetTable();
            foreach (var table in tables)
            {
                TableClasses.Add(table);
            }
            tableCB.ItemsSource = TableClasses;

            var times = await ApiService.GetTime();
            foreach(var time in times)
            {
                TimeClasses.Add(time);
            }
            timePC.ItemsSource = TimeClasses;
        }

        private async void addBTN_Clicked(object sender, EventArgs e)
        {
            var reservation = new ReservationClass();
            var table = tableCB.SelectedItem as TableClass;
            var time = timePC.SelectedItem as TimeClass;

            reservation.CName = cnameTXT.Text;
            reservation.TableName = Convert.ToString(table.TableName);
            reservation.Date = datePC.Date;
            reservation.Time = time.Time;

            var response = await ApiService.ReservationAdd(reservation);
            if(response != null)
            {
                await DisplayAlert("Hata","Hata var","OK");
            }
            else
            {
                await DisplayAlert("Sorun Yok", "İşlem tamam", "OK");
                await Navigation.PushAsync(new HomePage());
            }
        }
    }
}