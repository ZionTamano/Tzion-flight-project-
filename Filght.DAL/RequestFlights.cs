using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;
using System.Net.Http.Headers;
using Flight.Model;

namespace Filght.DAL
{
    public class RequestFlights
    {
        public async Task<FlightP> GetFilghtData()
        {
            FlightP flight;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://opensky-network.org/");
            
                client.DefaultRequestHeaders.Accept.Clear();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage pespones = await client.GetAsync($@"api/states/all");

                string lines = await pespones.Content.ReadAsStringAsync();

                flight = JsonSerializer.Deserialize<FlightP>(lines);

                return flight;
            }
        }
       
    }
}
