using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hospitalBackend.Models
{
    public class Medico : PersonaBase
    {
        public string Especialidad { get; set; } = null!;
    }
}