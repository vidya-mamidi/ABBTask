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
    public class PhotoServices:IPhotoService
    {
        private readonly HttpClient httpClient;

        public PhotoServices(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<List<Photos>> GetPhotos()
        {
            string res = string.Empty;
            try
            {
                string url = "https://jsonplaceholder.typicode.com/photos";
                HttpClient client = new HttpClient();
                string response = await client.GetStringAsync(url);

                var data = JsonConvert.DeserializeObject<List<Photos>>(response);
                return data;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
