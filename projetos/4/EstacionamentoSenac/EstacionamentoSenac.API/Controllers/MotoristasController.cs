using EstacionamentoSenac.API.Data;
using EstacionamentoSenac.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace EstacionamentoSenac.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MotoristasController : ControllerBase

    {
        private AppDbContext _context;

        public MotoristasController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult<List<Motorista>> GetMotoristas()
        {
            return _context.Motoristas.ToList();
        }
        [HttpGet("{id}")]
        public ActionResult<Motorista> GetMotoristaById(int id)
        {
            var motorista = _context.Motoristas.Find();

            if (motorista == null)
                return NotFound();

            return Ok(motorista);
        }

        [HttpPost]
        public ActionResult<Motorista> PostMotorista(Motorista motoristaNovo)
        {
            _context.Motoristas.Add(motoristaNovo);
            _context.SaveChanges();
            return Created();
        }
        [HttpPut("{id}")]
        public ActionResult<Motorista> PutMotorista(int id, Motorista motoristaNovo)
        {
            if (id != motoristaNovo.Id)
                return BadRequest("Motorista informado na URL diferente do objeto JSON");

            var motoristaExistente = _context.Motoristas.Find(id);
            if (motoristaExistente == null) return NotFound();

            motoristaExistente.Nome = motoristaNovo.Nome;
            motoristaExistente.VeiculoId = motoristaNovo.VeiculoId;
            
            _context.SaveChanges();
            return NoContent();

        }
        [HttpDelete("{id}")]
        public ActionResult DeleteMotorista(int id)
        {
            var motorista = _context.Motoristas.Find(id);
            if (motorista == null) return NotFound();

            _context.Motoristas.Remove(motorista);
            _context.SaveChanges();
            return Created();
        }

    }
}
