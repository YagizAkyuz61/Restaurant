using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Rezervasyon.Model;

namespace Rezervasyon.Service
{
    public class ApiService
    {
        public static async Task<List<ReservationClass>> GetReservations()
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("https://api-ox5.conveyor.cloud/api/reservation");
            return JsonConvert.DeserializeObject<List<ReservationClass>>(response);
        }

        public static async Task<ReservationClass> GetReservation(int id)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("https://api-ox5.conveyor.cloud/api/reser/" + id);
            return JsonConvert.DeserializeObject<ReservationClass>(response);
        }

        public static async Task<ReservationClass> ReservationAdd(ReservationClass reservation)
        {
            HttpClient httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(reservation);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("https://api-ox5.conveyor.cloud/api/reservation", content);
            var jsonResult = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ReservationClass>(jsonResult);
        }

        public static async Task<List<TableClass>> GetTable()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("https://api-ox5.conveyor.cloud/api/table");
            return JsonConvert.DeserializeObject<List<TableClass>>(response);
        }

        public static async Task<List<TimeClass>> GetTime()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("https://api-ox5.conveyor.cloud/api/time");
            return JsonConvert.DeserializeObject<List<TimeClass>>(response);
        }
    }
}
