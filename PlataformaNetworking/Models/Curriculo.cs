using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlataformaNetworking.Models {
    public class Curriculo {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public byte[] Dados { get; set; }
    }
}
