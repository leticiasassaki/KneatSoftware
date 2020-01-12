using Kneat.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Kneat.Service
{
    public static class SwapiService
    {
        public static readonly string SwapiURL = "https://swapi.co/api/starships/";

        public static async Task<List<StarshipModel>> GetStarshipsAsync()
        {
            List<StarshipModel> starships = new List<StarshipModel>();
            string baseUrl = SwapiURL;

            try
            {
                Console.WriteLine("Requesting the Starships.");
                HttpClient httpClient = new HttpClient();

                do
                {
                    var getAsyncResponse = await httpClient.GetAsync(baseUrl);

                    if (getAsyncResponse.IsSuccessStatusCode)
                    {
                        string responseAsync = await getAsyncResponse.Content.ReadAsStringAsync();
                        var startshipHeader = JsonConvert.DeserializeObject<StarshipHeaderModel>(responseAsync);
                        if (startshipHeader != null)
                        {
                            starships.AddRange(startshipHeader.Starships.ToList());
                        }

                        baseUrl = startshipHeader.Next;
                    }

                } while (baseUrl != null);

                Console.WriteLine("Requested {0} starships.", starships.Count);
                return starships;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
