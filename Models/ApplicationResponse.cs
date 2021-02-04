using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace JoelHiltonFilmCollection.Models
{
    public class ApplicationResponse
    {
        [Required(ErrorMessage = "Please enter a title.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter a year.")]
        [Range(1887, 2100, ErrorMessage = "Please enter a valid year.")]
        public int Year { get; set; }
        [Required(ErrorMessage = "Please enter a director.")]
        public string Director { get; set; }
        [Required(ErrorMessage = "Please enter a rating.")]
        public string Rating { get; set; }
        public bool? Edited { get; set; }
        public string LentTo { get; set; }
        [MaxLength(25)]
        public string Notes { get; set; }
    }
}
