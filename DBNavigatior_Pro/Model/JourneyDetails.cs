namespace Model
{
    public class JourneyDetails
    {
        public int stopId { get; set; }
        public string stopName { get; set; }
        public string lat { get; set; }
        public string lon { get; set; }
        public string depTime { get; set; }
        public string train { get; set; }
        public string type { get; set; }
        public string @operator { get; set; }
        public string arrTime { get; set; }
    }
}
