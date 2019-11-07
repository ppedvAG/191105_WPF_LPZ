using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace Model
{
    public class DBService
    {
        public List<Location> GetLocation(string searchString)
        {
            // REST-API aufrufen:
            string json;
            using (HttpClient client = new HttpClient())
            {
                json = client.GetStringAsync($"https://api.deutschebahn.com/freeplan/v1/location/{searchString}").Result; // Synchron -> Blockiert
            }

            // JSON Deserialisieren
            return JsonConvert.DeserializeObject<List<Location>>(json);
        }
        public List<ArrivalBoard> GetDepartureBoardForLocation(Location currentLocation)
        {
            // REST-API aufrufen:
            string json;
            using (HttpClient client = new HttpClient())
            {
                json = client.GetStringAsync($"https://api.deutschebahn.com/freeplan/v1/arrivalBoard/{currentLocation.id}?date={DateTime.Now.ToString("yyyy-MM-dd")}T{DateTime.Now.ToString("HH:mm:ss")}").Result; // Synchron -> Blockiert
            }

            // JSON Deserialisieren
            return JsonConvert.DeserializeObject<List<ArrivalBoard>>(json);
        }
        public List<JourneyDetails> GetJourneyDetails(ArrivalBoard departure)
        {
            // REST-API aufrufen:
            string json;
            using (HttpClient client = new HttpClient())
            {
                json = client.GetStringAsync($"https://api.deutschebahn.com/freeplan/v1/journeyDetails/{departure.detailsId}").Result; // Synchron -> Blockiert
            }

            // JSON Deserialisieren
            return JsonConvert.DeserializeObject<List<JourneyDetails>>(json);
        }
    }
}
