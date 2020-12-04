using PlataformaNetworking.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlataformaNetworking.Models
{
    public class Amizade
    {
        public int Id { get; set; }

        public int IdUsuario1 { get; set; }

        public int IdUsuario2 { get; set; }

        public AmizadeStatus Status { get; set; }
    }
}
