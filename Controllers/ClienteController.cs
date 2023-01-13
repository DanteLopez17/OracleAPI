using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OracleAPI.Data;
using OracleAPI.Models;

namespace OracleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly ContextOracle _contexto;
        public ClienteController(ContextOracle contexto)
        {
            _contexto = contexto;
        }

        [HttpGet]
        [Route("ListaCliente")]
        public async Task<List<CLIENTE>> listadoCliente()
        {
            return await _contexto.CLIENTE.ToListAsync();
        }
    }
}
