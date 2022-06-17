using Garson.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Garson.Service
{
    public class ApiService
    {
        public static async Task<bool> Login(string nickname, string password)
        {
            var login = new WaiterClass()
            {
                Nickname = nickname,
                Password = password
            };
            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(login);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("https://api-ox5.conveyor.cloud/api/Account/Login", content);
            if (!response.IsSuccessStatusCode) return false;

            var jsonResult = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<TokenClass>(jsonResult);
            Preferences.Set("accessToken", result.access_token);
            Preferences.Set("waiterId", Convert.ToString(result.waiter_Id));
            Preferences.Set("waiterNames", Convert.ToString(result.waiter_Name));
            return true;
        }

        public static async Task<List<FoodClass>> GetFoods()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("https://api-ox5.conveyor.cloud/api/food");
            return JsonConvert.DeserializeObject<List<FoodClass>>(response);
        }

        public static async Task<List<TableClass>> GetTable()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("https://api-ox5.conveyor.cloud/api/table");
            return JsonConvert.DeserializeObject<List<TableClass>>(response);
        }

        public static async Task<OrderClass> OrderAdd(OrderClass order)
        {
            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(order);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("https://api-ox5.conveyor.cloud/api/order", content);
            var jsonResult = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<OrderClass>(jsonResult);
        }

        public static async Task<bool> OrderDelete(int id)
        {
            var httpClient = new HttpClient();
            var order = new OrderClass()
            {
                Id = id
            };
            var json = JsonConvert.SerializeObject(order);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await httpClient.DeleteAsync("https://api-ox5.conveyor.cloud/api/order/" + id);
            return response.IsSuccessStatusCode;
        }

        public static async Task<List<OrderClass>> GetOrderSe(int id)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("https://api-ox5.conveyor.cloud/api/orderse/" + id);
            return JsonConvert.DeserializeObject<List<OrderClass>>(response);
        }

        public static async Task<List<OrderClass>> GetOrder()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("https://api-ox5.conveyor.cloud/api/order");
            return JsonConvert.DeserializeObject<List<OrderClass>>(response);
        }
    }
}
