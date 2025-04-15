using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hospitalBackend.Dtos;
using hospitalBackend.Models;

namespace hospitalBackend.Mappers
{
    public static class MedicoMappers
    {
        public static Medico FromCrearMedicoRequestDtoToMedico(this CrearMedicoRequestDto dto)
        {
            return new Medico
            {
                Nombre = dto.Nombre,
                ApellidoPaterno = dto.ApellidoPaterno,
                ApellidoMaterno = dto.ApellidoMaterno,
                Especialidad = dto.Especialidad
            };
        }
    }
}