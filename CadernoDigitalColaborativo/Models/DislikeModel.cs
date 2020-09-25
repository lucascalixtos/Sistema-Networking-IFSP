using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CadernoDigitalColaborativo.Models
{
    public class DislikeModel
    {
        public int Id { get; set; }

        public int IdUsuario1 { get; set; }
        public Usuario Usario1 { get; set; }
        public int IdUsuario2 { get; set; }
        public Usuario Usario2 { get; set; }

        public DateTimeOffset DislikedAt { get; set; }
    }
}
