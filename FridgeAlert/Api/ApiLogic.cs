using System.Net.Http;
using System.Text.Json;
using FridgeAlert.Models;

namespace FridgeAlert.Api
{
    public class ApiLogic
    {
        public async static Task<List<Beers>> GenerateUrlRandom()
        {
            List<Beers> beers = new List<Beers>();

            var url = Beers.GenerateUrlRandom();

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var beerArray = JsonSerializer.Deserialize<List<Beers>>(json);

                    foreach (var beer in beerArray)
                    {
                        // Add only the desired properties to the list
                        beers.Add(new Beers
                        {
                            name = beer.name,
                            description = beer.description,
                            image_url = beer.image_url,
                            abv = beer.abv
                        });
                    }
                }
            }

            return beers;
        }
    }
}
