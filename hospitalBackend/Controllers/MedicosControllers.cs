using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hospitalBackend.Data;
using hospitalBackend.Dtos;
using hospitalBackend.Mappers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace hospitalBackend.Controllers
{
    [Route("/api/medicos")]
    [ApiController]
    public class MedicosControllers : ControllerBase
    {
        private readonly AppDbContext _context;

        public MedicosControllers(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetMedicos()
        {
            var medicos = await _context.Medicos.ToListAsync();
            return Ok(medicos);
        }

        [HttpPost]
        public async Task<IActionResult> CrearMedico(CrearMedicoRequestDto dto)
        {
            _ = await _context.Medicos.AddAsync(dto.FromCrearMedicoRequestDtoToMedico());
            await _context.SaveChangesAsync();
            return Created();
        }

        [HttpPut]
        public async Task<IActionResult> EditarMedico(EditarMedicoRequestDto dto)
        {
            var usuarioParaEditar = await _context.Medicos.FirstOrDefaultAsync(u => u.Id == dto.Id);
            if (usuarioParaEditar == null)
            {
                return BadRequest("Ese medico no existe.");
            }
            usuarioParaEditar.Nombre = dto.Nombre;
            usuarioParaEditar.ApellidoPaterno = dto.ApellidoPaterno;
            usuarioParaEditar.ApellidoMaterno = dto.ApellidoMaterno;
            usuarioParaEditar.Especialidad = dto.Especialidad;
            await _context.SaveChangesAsync();

            return Ok("Editado Exitosamente!");
        }

        [HttpDelete]
        public async Task<IActionResult> BorrarMedico([FromBody] string id)
        {
            var usuarioEncontrado = await _context.Medicos.FirstOrDefaultAsync(u => u.Id == id);
            if (usuarioEncontrado == null)
            {
                return BadRequest("Ese medico no existe!");
            }
            _context.Medicos.Remove(usuarioEncontrado);
            await _context.SaveChangesAsync();
            return Ok("Medico eliminado");
        }


    }
}