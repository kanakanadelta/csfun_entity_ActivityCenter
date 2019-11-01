using System.Diagnostics.Tracing;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ActivityCenter.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Title { get; set; }

        [Required]
        [NotMapped]
        [DataType(DataType.Date)]
        [Display(Name = "Date")]
        [Startup.MyDate(ErrorMessage ="Must be set in the future")]
        public DateTime EventDate { get; set; }

        [Required]
        [NotMapped]
        [Display(Name = "Time")]
        [DataType(DataType.Time)]
        public DateTime EventTime { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime EventDateTime { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Duration { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Description { get; set; }

        public User Planner { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public List<Association> Associations { get; set; }
        public Event()
        {
            Associations = new List<Association>();
        }
    }
}