using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using  ABBTask.Model;

namespace ABBTask.Data
{
    public class AlbumService : IAlbumServices
    {
        private readonly HttpClient httpClient;

        public AlbumService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<List<Album>> GetAlbums()
        {
            string res = string.Empty;
            try
            {
                string url = "https://jsonplaceholder.typicode.com/albums";
                HttpClient client = new HttpClient();
                string response = await client.GetStringAsync(url);

                var data = JsonConvert.DeserializeObject<List<Album>>(response);
                return data;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
