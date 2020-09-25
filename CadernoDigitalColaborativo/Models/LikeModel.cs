using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CadernoDigitalColaborativo.Models
{
    public class LikeModel
    {
        public int Id { get; set; }
        public int IdUsuario1 { get; set; }
        public Usuario Usuario1 { get; set; }
        public int IdUsuario2 { get; set; }
        public Usuario Usuario2 { get; set; }

    }
}

