using Newtonsoft.Json;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fotogalerie.Model
{
    public class Foto
    {
        [JsonProperty("albumId")] // Komplett optional
        public int AlbumID { get; set; }
        [JsonProperty("id")]
        public int FotoID { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("thumbnailUrl")]
        public string ImageURL { get; set; }
    }
}
