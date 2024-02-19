using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIDotNETCore.Entities
{
    
    public class LocationEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        public string? LocationName { get; set; }
        public TimeOnly OpeningTime { get; set; }
        public TimeOnly EndingTime { get; set; }
    }
}
