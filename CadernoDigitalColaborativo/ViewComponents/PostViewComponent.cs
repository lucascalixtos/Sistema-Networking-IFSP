using CadernoDigitalColaborativo.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadernoDigitalColaborativo.ViewComponents
{

    public class PostViewComponent : ViewComponent
    {
        private readonly CadernoDigitalColaborativoContext _context;

        public PostViewComponent(CadernoDigitalColaborativoContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _context.Post.ToListAsync());
        }
    }
}
