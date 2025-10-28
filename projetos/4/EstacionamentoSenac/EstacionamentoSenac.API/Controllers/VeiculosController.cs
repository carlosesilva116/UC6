using EstacionamentoSenac.API.Data;
using EstacionamentoSenac.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc; 

namespace EstacionamentoSenac.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculosController : ControllerBase
    {
        private AppDbContext _context;

        public VeiculosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult <List<Veiculo>>  GetVeiculos()
        {
            return _context.Veiculos.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Veiculo> GetVeiculoById(int id)
        {
            //_context.Veiculos.FirstOrDefault(v => v.Id == id);
            var veiculo = _context.Veiculos.Find(id);

            if (veiculo == null)
                return NotFound();

            return Ok(veiculo);
        }

        [HttpPost]
        public ActionResult<Veiculo> PostVeiculos(Veiculo veiculo)
        {
            _context.Veiculos.Add(veiculo);
            _context.SaveChanges();

            return Created();
        }

        [HttpPut("{id}")]
       public ActionResult<Veiculo>PutVeiculo(int id,Veiculo veiculoNovo)
        {
            if (id != veiculoNovo.Id)
                return BadRequest("Veiculo informado na URL diferentedo objeto JSON");

            var veiculoExistente = _context.Veiculos.Find(id);
            if (veiculoExistente == null) return NotFound();

            veiculoExistente.Marca = veiculoNovo.Marca;
            veiculoExistente.Modelo = veiculoNovo.Modelo;

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult<Veiculo>DeleteVeiculos(int id)
        {

            var Veiculo = _context.Veiculos.Find(id);
            if (Veiculo == null) return NotFound();

            _context.Veiculos.Remove(Veiculo);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
