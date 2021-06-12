using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ApiTelas.Models
{
    public class Telas
    {
        [Key]
        public int id { get; set; }
        public string marca { get; set; }

        public string ancho { get; set; }

        public string largo { get; set; }

        public string tipoDeTela { get; set; }

        public string color { get; set; }
        public string pais { get; set; }

        public bool estado { get; set; }

    }
}
