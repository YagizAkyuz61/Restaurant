using Kasa.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Kasa.Service
{
    class ApiService
    {
        public static async Task<List<FoodClass>> GetFood()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("https://localhost:44316/api/food");
            return JsonConvert.DeserializeObject<List<FoodClass>>(response);
        }

        public static async Task<FoodClass> FoodAdd(FoodClass food)
        {
            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(food);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("https://localhost:44316/api/food", content);
            var jsonResult = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<FoodClass>(jsonResult);
        }

        public static async Task<bool> FoodUpdate(int Id, string FoodName, int Category, int Price)
        {
            var httpClient = new HttpClient();
            var food = new FoodClass()
            {
                Id = Id,
                FoodName = FoodName,
                CategoryId = Category,
                Price = Price
            };
            var json = JsonConvert.SerializeObject(food);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await httpClient.PutAsync("https://localhost:44316/api/food/"+Id, content);
            return response.IsSuccessStatusCode;
        }

        public static async Task<bool> FoodDelete(int id)
        {
            var httpClient = new HttpClient();
            var food = new FoodClass()
            {
                Id = id
            };
            var json = JsonConvert.SerializeObject(food);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await httpClient.DeleteAsync("https://localhost:44316/api/food/"+id);
            return response.IsSuccessStatusCode;
        }

        public static async Task<List<CategoryClass>> GetCategory()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("https://localhost:44316/api/category");
            return JsonConvert.DeserializeObject<List<CategoryClass>>(response);
        }

        public static async Task<CategoryClass> CategoryAdd(CategoryClass category)
        {
            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(category);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("https://localhost:44316/api/category", content);
            var jsonResult = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<CategoryClass>(jsonResult);
        }

        public static async Task<bool> CategoryUpdate(int id, string categoryName)
        {
            var categoryModel = new CategoryClass()
            {
                Id = id,
                CategoryName = categoryName
            };
            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(categoryModel);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await httpClient.PutAsync("https://localhost:44316/api/category/" + id, content);
            return response.IsSuccessStatusCode;
        }

        public static async Task<bool> CategoryDelete(int id)
        {
            var httpClient = new HttpClient();
            var category = new CategoryClass()
            {
                Id = id
            };
            var json = JsonConvert.SerializeObject(category);
            var response = await httpClient.DeleteAsync("https://localhost:44316/api/category/" + id);
            return response.IsSuccessStatusCode;
        }

        public static async Task<List<ReservationClass>> GetReservation()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("https://localhost:44316/api/reservation");
            return JsonConvert.DeserializeObject<List<ReservationClass>>(response);
        }

        public static async Task<ReservationClass> ReservationAdd(ReservationClass reservation)
        {
            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(reservation);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("https://localhost:44316/api/reservation", content);
            var jsonResult = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ReservationClass>(jsonResult);
        }

        public static async Task<List<TimeClass>> GetTime()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("https://localhost:44316/api/time");
            return JsonConvert.DeserializeObject<List<TimeClass>>(response);
        }

        public static async Task<List<TableClass>> GetTable()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("https://localhost:44316/api/table");
            return JsonConvert.DeserializeObject<List<TableClass>>(response);
        }

        public static async Task<TableClass> TableAdd(TableClass table)
        {
            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(table);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("https://localhost:44316/api/table", content);
            var jsonResult = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<TableClass>(jsonResult);
        }

        public static async Task<bool> TableUpdate(int id, string tableName)
        {
            var tableModel = new TableClass()
            {
                Id = id,
                TableName = tableName
            };
            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(tableModel);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await httpClient.PutAsync("https://localhost:44316/api/table/" + id, content);
            return response.IsSuccessStatusCode;
        }

        public static async Task<bool> TableDelete(int id)
        {
            var httpClient = new HttpClient();
            var table = new TableClass()
            {
                Id = id
            };
            var json = JsonConvert.SerializeObject(table);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await httpClient.DeleteAsync("https://localhost:44316/api/table/" + id);
            return response.IsSuccessStatusCode;
        }

        public static async Task<List<ListOrderClass>> GetOrder()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("https://localhost:44316/api/order");
            return JsonConvert.DeserializeObject<List<ListOrderClass>>(response);
        }

        public static async Task<bool> OrderFinish(int id, int open)
        {
            var orderModel = new OrderClass()
            {
                Id = id,
                Opens = open
            };
            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(orderModel);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await httpClient.PutAsync("https://localhost:44316/api/order/" + id, content);
            return response.IsSuccessStatusCode;
        }

        public static async Task<List<ListOrderClass>> GetOrderSe(int id)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("https://localhost:44316/api/orderse/" + id);
            return JsonConvert.DeserializeObject<List<ListOrderClass>>(response);
        }

        public static async Task<List<WaiterClass>> GetWaiter()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("https://localhost:44316/api/waiter");
            return JsonConvert.DeserializeObject<List<WaiterClass>>(response);
        }

        public static async Task<bool> RegisterWaiter(string name, string sur, string nick, string pass, string gender)
        {
            var waiterModel = new WaiterClass()
            {
                Name = name,
                Surname = sur,
                Nickname = nick,
                Password = pass,
                Gender = gender
            };
            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(waiterModel);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("https://localhost:44316/api/Account/Register", content);
            if (!response.IsSuccessStatusCode) return false;
            return true;
        }

        public static async Task<bool> WaiterUpdate(int id, string name, string sur, string nick, string gender)
        {
            var httpClient = new HttpClient();
            var waiterModel = new WaiterClass()
            {
                Id = id,
                Name = name,
                Surname = sur,
                Nickname = nick,
                Gender = gender
            };
            var json = JsonConvert.SerializeObject(waiterModel);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await httpClient.PutAsync("https://localhost:44316/api/waiter/" + id, content);
            return response.IsSuccessStatusCode;
        }

        public static async Task<bool> WaiterDelete(int id)
        {
            var httpClient = new HttpClient();
            var waiterModel = new WaiterClass()
            {
                Id = id
            };
            var json = JsonConvert.SerializeObject(waiterModel);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await httpClient.DeleteAsync("https://localhost:44316/api/waiter/" + id);
            return response.IsSuccessStatusCode;
        }
    }
}
