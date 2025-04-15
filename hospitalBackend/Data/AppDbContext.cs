using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hospitalBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace hospitalBackend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var medicoSeeder = new List<Medico>
            {
                new(){
                    Id = "dok1od21kod12",
                    Nombre = "Ismael",
                    ApellidoPaterno = "Moron",
                    ApellidoMaterno = "Pedraza",
                    Especialidad = "Cirujano"
                },
                new(){
                    Id = "123",
                    Nombre = "Juan",
                    ApellidoPaterno = "Perez",
                    ApellidoMaterno = "Lopez",
                    Especialidad = "Pediatra"
                },
                new(){
                    Id = "321",
                    Nombre = "Roberto",
                    ApellidoPaterno = "Peredo",
                    ApellidoMaterno = "Redes 2",
                    Especialidad = "Docente"
                },
                new(){
                    Id= "1231",
                    Nombre="Cristian",
                    ApellidoPaterno = "Mercado",
                    ApellidoMaterno = "Duran",
                    Especialidad = "Medico"
                }
            };

            modelBuilder.Entity<Medico>().HasData(medicoSeeder);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Medico> Medicos { get; set; } = null!;

    }
}