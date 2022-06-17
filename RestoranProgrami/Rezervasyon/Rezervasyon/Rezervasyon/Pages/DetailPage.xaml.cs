using Rezervasyon.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Rezervasyon.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        public DetailPage(int id)
        {
            InitializeComponent();
            GetReservationId(id);
        }

        private async void GetReservationId(int id)
        {
            var reservation = await ApiService.GetReservation(id);
            cnameLBL.Text = reservation.CName;
            tableLBL.Text = reservation.TableName;
            dateLBL.Text = reservation.Date.ToShortDateString();
            timeLBL.Text = reservation.Time;
        }
    }
}