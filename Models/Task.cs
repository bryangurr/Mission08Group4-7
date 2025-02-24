﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission08Group4_7.Models
{
    public class Task
    {
        [Key]
        public int TaskId { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime? DueDate { get; set; }
        [Required]
        public int Quadrant { get; set; }
        public bool? Completed { get; set; }

        [ForeignKey(name:"CategoryId")]
        public int CategoryId { get; set; }
        public Categories Category { get; set; }
    }
}
