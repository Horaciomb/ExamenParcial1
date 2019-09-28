using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Horacio.Models
{
    public enum Lista
    {
        Hernan,
        Hugo,
        Helga,
    }
    public class Clown
    {
        [Key]
        public int ClownID { get; set; }
        [Required]
        [Display(Name = "Nombre Completo")]
        [StringLength(2, MinimumLength = 24)]
        public string NickName { get; set; }
        [Required]
        public Lista Tricks { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Display(Name = "Cumpleaños")]
        public DateTime Birthdate { get; set; }
    }
}