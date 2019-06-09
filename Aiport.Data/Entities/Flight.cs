using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Aiport.Data.Entities
{
    public class Flight : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        public virtual ICollection<FlightCategory> FlightCategories { get; set; }
        public virtual ICollection<FlightRoute> FlightRoutes { get; set; }
    }
}
