using System.ComponentModel.DataAnnotations;

namespace PlataformaNetworking.Models.Enums
{
    public enum Situacao
    {
        [Display(Name = "Ativo")]
        Ativo,
        [Display(Name = "Inativo")]
        Inativo
    }
    public enum AmizadeStatus
    {
        [Display(Name = "Pendente")]
        Pendente = 1,
        [Display(Name = "Ativo")]
        Ativo = 2,
        [Display(Name = "Bloqueado")]
        Bloqueado = 3
    }
}
