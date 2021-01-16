using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlataformaNetworking.Models
{
    public class Entrevista
    {
        public int Id { get; set; }
        public int IdAluno { get; set; }
        public int IdVaga { get; set; }
        public DateTime Data { get; set; }
        public string Endereco { get; set; }
    }
}
