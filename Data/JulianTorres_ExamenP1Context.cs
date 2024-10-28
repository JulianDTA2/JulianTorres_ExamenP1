using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JulianTorres_ExamenP1.Models;

namespace JulianTorres_ExamenP1.Data
{
    public class JulianTorres_ExamenP1Context : DbContext
    {
        public JulianTorres_ExamenP1Context (DbContextOptions<JulianTorres_ExamenP1Context> options)
            : base(options)
        {
        }

        public DbSet<JulianTorres_ExamenP1.Models.JTTabla> JTTabla { get; set; } = default!;
    }
}
