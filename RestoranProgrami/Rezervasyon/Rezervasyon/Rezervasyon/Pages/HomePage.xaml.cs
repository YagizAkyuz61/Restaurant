using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rezervasyon.Model;
using Rezervasyon.Pages;
using Rezervasyon.Service;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Rezervasyon.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public ObservableCollection<ReservationClass> ReservationClasses;
        private bool First = true;
        public HomePage()
        {
            InitializeComponent();
            ReservationClasses = new ObservableCollection<ReservationClass>();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            if (First)
            {
                var reservations = await ApiService.GetReservations();
                foreach (var reservation in reservations)
                {
                    ReservationClasses.Add(reservation);
                }
                list1.ItemsSource = ReservationClasses;
            }
            First = false;
        }

        private async void rezerBTN_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddReservationPage());
        }

        private async void list1_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedReservation = e.SelectedItem as ReservationClass;
            if(selectedReservation != null)
            {
                await Navigation.PushAsync(new DetailPage(selectedReservation.Id));
            }
            ((ListView)sender).SelectedItem = null;
        }

        private double width = 0;
        private double height = 0;
        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            if (width != this.width || height != this.height)
            {
                this.width = width;
                this.height = height;
                if (width > height)
                {
                    outerStack.Orientation = StackOrientation.Horizontal;
                }
                else
                {
                    outerStack.Orientation = StackOrientation.Vertical;
                }
            }
        }
    }
}