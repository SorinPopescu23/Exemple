using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1_2019.Models
{
    public class Masini
    {
        public Guid Id { get; set; }
        public string Zona { get; set; }

        public string Model_masina { get; set; }

    }
}