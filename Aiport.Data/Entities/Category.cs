using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Aiport.Data.Entities
{
    public class Category : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        public virtual ICollection<FlightCategory> FlightCategories { get; set; }
        public virtual ICollection<Route> Routes { get; set; }
    }
}
