namespace Aiport.Data.Entities
{
    public class FlightRoute : BaseEntity
    {
        public int FlightId { get; set; }
        public Flight Flight { get; set; }

        public int RouteId { get; set; }
        public Route Route { get; set; }
    }
}
