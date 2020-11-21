using PlataformaNetworking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlataformaNetworking.ViewModels
{
    public class PostLikeViewModel
    {
        public PostModel Post { get; set; }
        public LikeModel Like { get; set; }
    }
}
