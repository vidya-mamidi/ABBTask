using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static ABBTask.Model.Common;

namespace ABBTask.Data
{
    public class UserService:IUserService
    {

        private readonly HttpClient httpClient;

        public UserService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<List<Users>> GetUsers()
        {
            string res = string.Empty;
            try
            {
                string url = "https://jsonplaceholder.typicode.com/users";
                HttpClient client = new HttpClient();
                string response = await client.GetStringAsync(url);
                var data = JsonConvert.DeserializeObject<List<Users>>(response);              
                return data;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
