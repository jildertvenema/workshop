using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ThuisbezorgdModels;

namespace Backend.Services
{
    public class DishesExternalApiService : IDishService
    {
        private const string EXTERNAL_DISHES_URL = "https://raw.githubusercontent.com/jildertvenema/workshop/master/EternalData/dishes.json";
        private IHttpClientFactory _httpClientFactory;

        public DishesExternalApiService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<Dish[]> GetAllDishesAsync()
        {
            HttpClient httpClient = _httpClientFactory.CreateClient();

            HttpResponseMessage result = await httpClient.GetAsync(EXTERNAL_DISHES_URL);
            string jsonResult = await result.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<Dish[]>(jsonResult);
        }

        public Task PostOrderAsync(Dish[] dishes)
        {
            throw new NotImplementedException();
        }
    }
}
