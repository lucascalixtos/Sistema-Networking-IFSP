using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlataformaNetworking.Models {
    public class Empresa : Usuario {
        public string CNPJ { get; set; }
        public string RazaoSocial { get; set; }
        public string Ramo { get; set; }
        //public string Avaliacao { get; set }
    }
}
