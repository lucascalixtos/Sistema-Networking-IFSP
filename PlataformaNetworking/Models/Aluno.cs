
namespace PlataformaNetworking.Models {
    public class Aluno : Usuario{
        public string Curso { get; set; }
        public int AnoIngresso { get; set; }
        public string Habilidades { get; set; }
        //public ??? Recomendacoes { get; set; }
        //Candidaturas
        public Curriculo Curriculo { get; set;}
    }
}
