using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Aiport.Data.Entities
{
    public class Route : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        public virtual Category Category { get; set; }
        public int CategoryId { get; set; }
        public virtual ICollection<FlightRoute> FlightRoutes { get; set; }
       
    }
}
