using System.ComponentModel.DataAnnotations;

namespace Lab12.Models
{
    public class Rooms
    {
        internal object Hotel;

        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Layout { get; set; }
        public List<HotelRoom> readyRooms { get; set; }
        public Amenity Amenity { get; set; }

        
    }
}
