using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;

namespace Fotogalerie.Model
{
    public class FotoService
    {
        public List<Foto> GetFotos()
        {
            using(HttpClient client = new HttpClient())
            {
                string json = client.GetStringAsync("https://jsonplaceholder.typicode.com/photos").Result;
                Thread.Sleep(5000); // Absicht: Anwendung soll "einfrieren"

                return JsonConvert.DeserializeObject<List<Foto>>(json);
            }
        }
    }
}
