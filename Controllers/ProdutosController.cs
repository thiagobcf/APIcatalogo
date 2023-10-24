using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIcatalogo.Context;
using Microsoft.AspNetCore.Mvc;

namespace APIcatalogo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProdutosController(AppDbContext context)
        {
            _context = context;
        }
    }
}
