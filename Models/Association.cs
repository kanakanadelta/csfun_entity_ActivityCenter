using System.ComponentModel.DataAnnotations;
using System;

namespace ActivityCenter.Models
{
    public class Association
    {
        [Key]
        public int AssociationId { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
        public int EventId { get; set; }
        public Event Event { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        // // // // // // /
        // constructors //

        // overlaod //
        public Association(int userId, User u, int eventId, Event e)
        {
            UserId = userId;
            User = u;
            EventId = eventId;
            Event = e;
        }
        public Association()
        {

        }
        
    }
}