using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MuseumTest.Domain.Entities
{
    public class Museum : BaseEntity
    {
        [Required]
        [StringLength(300)]
        public string? Name { get; set; }

        [Required]
        [StringLength(300)]
        public string? Address { get; set; }

        [Required]
        [StringLength(300)]
        public string? City { get; set; }

        [Required]
        [StringLength(300)]
        public string? Type { get; set; }


        public IEnumerable<Article>? Articles { get; set; }

    } }
