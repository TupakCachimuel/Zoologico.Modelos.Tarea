using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Zoologico.Modelos.Tarea;

    public class ZoologicoAPIContext : DbContext
    {
        public ZoologicoAPIContext (DbContextOptions<ZoologicoAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Zoologico.Modelos.Tarea.Animal> Animales { get; set; } = default!;

public DbSet<Zoologico.Modelos.Tarea.Especie> Especies { get; set; } = default!;

public DbSet<Zoologico.Modelos.Tarea.Raza> Razas { get; set; } = default!;
    }
