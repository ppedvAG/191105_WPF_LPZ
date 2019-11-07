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
        public List<DepartureBoard> GetDepartureBoardForLocation(Location currentLocation)
        {
            // REST-API aufrufen:
            string json;
            using (HttpClient client = new HttpClient())
            {
                json = client.GetStringAsync($"https://api.deutschebahn.com/freeplan/v1/departureBoard/{currentLocation.id}?date={DateTime.Now.ToString("yyyy-MM-dd")}").Result; // Synchron -> Blockiert
            }

            // JSON Deserialisieren
            return JsonConvert.DeserializeObject<List<DepartureBoard>>(json);
        }
        public List<JourneyDetails> GetJourneyDetails(DepartureBoard departure)
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
