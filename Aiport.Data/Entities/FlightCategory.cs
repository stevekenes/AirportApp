namespace Aiport.Data.Entities
{
    public class FlightCategory: BaseEntity
    {
        public int FlightId { get; set; }
        public Flight Flight { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
       
    }
}
