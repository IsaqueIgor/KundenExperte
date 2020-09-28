using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BeAFuckingSenior.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(60, ErrorMessage = "Name too long")]
        [MinLength(2, ErrorMessage = "Name too short")]
        [DisplayName("Name")]
        [Required(ErrorMessage = "Name is required")]
        public string ClientName { get; set; }

        [MaxLength(60, ErrorMessage = "Surname too long")]
        [DisplayName("Surname")]
        [Required(ErrorMessage = "Surname is required")]
        public string ClientSurname { get; set; }

        [DisplayName("Nationality")]
        public string Nationality { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Email invalid")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public DateTime CreateAt { get; set; }
    }
}