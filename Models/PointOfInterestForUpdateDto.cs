using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TodoItem3.Models
{
    public class PointOfInterestForUpdateDto
    {
        private string name;
        private string description;
        [Required(ErrorMessage = "You should provide a name value.")]
        [MaxLength(50)]
        public string Name { get => name; set => name = value; }
        [MaxLength(200)]
        public string Description { get => description; set => description = value; }
    }
}
