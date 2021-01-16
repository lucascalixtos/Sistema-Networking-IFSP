using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlataformaNetworking.Models
{
    public class Candidato
    {
        public int Id { get; set; }
        public int IdVaga { get; set; }
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public bool EntrevistaAgendada { get; set; }
    }
}
