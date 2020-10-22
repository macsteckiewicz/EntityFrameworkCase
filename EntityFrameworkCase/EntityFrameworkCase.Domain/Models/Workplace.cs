using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkCase.Domain.Models
{
    public class Workplace
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int CityId { get; set; }
        public virtual City City { get; set; }

        public int StreetId { get; set; }
        public virtual Street Street { get; set; }
    }
}