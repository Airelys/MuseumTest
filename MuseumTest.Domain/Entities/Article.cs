using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MuseumTest.Domain.Entities
{
    public class Article: BaseEntity
    {
        [Required]
        [StringLength(300)]
        public string? Title { get; set; }

        [Required]
        [StringLength(1000)]
        public string? Description { get; set; }

        [Required]
        public bool? IsDamaged { get; set; }

        [Required]
        public int? MuseumId { get; set; }

        public Museum? Museum { get; set; }
    }
}
