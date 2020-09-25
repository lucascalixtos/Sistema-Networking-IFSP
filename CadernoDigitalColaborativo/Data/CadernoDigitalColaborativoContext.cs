using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CadernoDigitalColaborativo.Models;

namespace CadernoDigitalColaborativo.Data
{
    public class CadernoDigitalColaborativoContext : DbContext
    {
        public CadernoDigitalColaborativoContext (DbContextOptions<CadernoDigitalColaborativoContext> options)
            : base(options)
        {
        }

        public DbSet<CadernoDigitalColaborativo.Models.Usuario> Usuario { get; set; }
        public DbSet<CadernoDigitalColaborativo.Models.PostModel> Post { get; set; }
        public DbSet<CadernoDigitalColaborativo.Models.LikeModel> Like { get; set; }
        public DbSet<CadernoDigitalColaborativo.Models.DislikeModel> Dislike { get; set; }
        public DbSet<CadernoDigitalColaborativo.Models.CommentModel> Comment { get; set; }
    }
}
