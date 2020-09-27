using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlataformaNetworking.Models {
    public class Vaga {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public DateTime DataPostagem { get; set; }
        //public List<Usuario> Candidatos { get; set; }

        public Vaga()
        {
        }

        public Vaga(int id, int idUsuario, string titulo, string conteudo, DateTime dataPostagem)
        {
            Id = id;
            IdUsuario = idUsuario;
            Titulo = titulo;
            Conteudo = conteudo;
            DataPostagem = dataPostagem;
          //  Candidatos = candidatos;
        }

       


    }

    
    
}
