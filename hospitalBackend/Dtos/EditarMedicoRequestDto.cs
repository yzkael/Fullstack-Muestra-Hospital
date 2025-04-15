using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hospitalBackend.Dtos
{
    public class EditarMedicoRequestDto
    {
        public string Id { get; init; } = null!;
        public string Nombre { get; init; } = null!;
        public string ApellidoPaterno { get; init; } = null!;
        public string ApellidoMaterno { get; init; } = null!;
        public string Especialidad { get; init; } = null!;
    }
}