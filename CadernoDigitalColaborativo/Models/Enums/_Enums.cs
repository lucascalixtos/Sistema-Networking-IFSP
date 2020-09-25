using System.ComponentModel.DataAnnotations;

namespace CadernoDigitalColaborativo.Models.Enums
{
    public enum Situacao
    {
        [Display(Name = "Ativo")]
        Ativo,
        [Display(Name = "Inativo")]
        Inativo
    }
    public enum RelationshipStatus
    {
        [Display(Name = "Pendente")]
        Pending = 1,
        [Display(Name = "Ativo")]
        Active = 2,
        [Display(Name = "Bloqueado")]
        Blocked = 3
    }
}
