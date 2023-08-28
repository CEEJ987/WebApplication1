using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab12.Models
{
    public class Rooms
    {
        //internal object Hotel;

        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Layout { get; set; }
        //public List<HotelRoom> readyRooms { get; set; }
        //[NotMapped]
       // public Amenity Amenity { get; set; }
       public List<RoomAmenity> RoomAmenities { get; set; }

        
    }
}
