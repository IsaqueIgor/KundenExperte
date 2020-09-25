using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeAFuckingSenior.Models
{
    public class Client
    {
        public int Id { get; set; }

        public string ClientName { get; set; }
        public string ClientSurname { get; set; }
        public string Nationality { get; set; }
        public DateTime CreateAt { get; set; }
    }
}