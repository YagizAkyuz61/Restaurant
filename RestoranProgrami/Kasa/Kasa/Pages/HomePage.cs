using Kasa.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kasa.Service;

namespace Kasa.Pages
{
    public partial class HomePage : Form
    {
        ObservableCollection<TableClass> TableClasses;
        ObservableCollection<TimeClass> TimeClasses;
        ObservableCollection<OrderClass> OrderClasses;
        public HomePage()
        {
            InitializeComponent();
            TableClasses = new ObservableCollection<TableClass>();
            TimeClasses = new ObservableCollection<TimeClass>();
            OrderClasses = new ObservableCollection<OrderClass>();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            List();
            Loading();
        }

        private async void finishBTN_Click(object sender, EventArgs e)
        {
            var tcb = tableCB.SelectedItem as TableClass;
            var finish = await ApiService.OrderFinish(Convert.ToInt32(tcb.Id), 0);
            MessageBox.Show("Hesap kapandı.");
        }

        public async void List()
        {
            var reservation = await ApiService.GetReservation();
            rDGV.DataSource = reservation;
        }

        public async void Loading()
        {
            var tables = await ApiService.GetTable();
            foreach(var table in tables)
            {
                TableClasses.Add(table);
            }
            tableCB.DataSource = TableClasses;
            rtableCB.DataSource = TableClasses;

            var times = await ApiService.GetTime();
            foreach (var time in times)
            {
                TimeClasses.Add(time);
            }
            timeCB.DataSource = TimeClasses;

            tableCB.DisplayMember = "TableName";
            rtableCB.DisplayMember = "TableName";
            timeCB.DisplayMember = "Time";
        }

        private async void insertBTN_Click(object sender, EventArgs e)
        {
            var reservation = new ReservationClass();
            var table = tableCB.SelectedItem as TableClass;
            var time = timeCB.SelectedItem as TimeClass;

            reservation.CName = cNameTXT.Text;
            reservation.TableName = table.TableName;
            reservation.Date = Convert.ToDateTime(dateTXT.Text);
            reservation.Time = time.Time;

            var response = await ApiService.ReservationAdd(reservation);
            if (response != null)
            {
                MessageBox.Show("Hata");
            }
            else
            {
                MessageBox.Show("Kayıt başarılı.");
                cNameTXT.Clear();
                dateTXT.Clear();
            }
            List();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToShortTimeString();
        }

        private void ykmBTN_Click(object sender, EventArgs e)
        {
            FoodPage page = new FoodPage();
            page.Show();
            this.Hide();
        }

        private async void showBTN_Click(object sender, EventArgs e)
        {
            var table = tableCB.SelectedItem as TableClass;
            var orders = await ApiService.GetOrderSe(Convert.ToInt32(table.Id));
            oDGV.DataSource = orders;

            int toplam = 0;
            for (int i = 0; i < oDGV.Rows.Count; ++i)
            {
                toplam += Convert.ToInt32(oDGV.Rows[i].Cells[3].Value);
            }
            priceLBL.Text = "Ücret: " + toplam.ToString();
        }

        private void toBTN_Click(object sender, EventArgs e)
        {
            TodayPage todayPage = new TodayPage();
            todayPage.Show();
        }

        private void waiterBTN_Click(object sender, EventArgs e)
        {
            WaiterPage waiterPage = new WaiterPage();
            waiterPage.Show();
        }
    }
}
