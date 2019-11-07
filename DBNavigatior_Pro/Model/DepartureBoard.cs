namespace Model
{
    public class DepartureBoard
    {
        public string name { get; set; }
        public string type { get; set; }
        public int boardId { get; set; }
        public int stopId { get; set; }
        public string stopName { get; set; }
        public string dateTime { get; set; }
        public string track { get; set; }
        public string detailsId { get; set; }
    }
}
