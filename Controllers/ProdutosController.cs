using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIcatalogo.Context;
using APIcatalogo.Models;
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

        [HttpGet]
        public ActionResult<IEnumerable<Produto>> Get()
        {
            var produtos = _context.Produtos.ToList();
            if(produtos is null)
            {
                return NotFound("Produtos não encontrados");
            }
            return produtos;
        }
    }
}
