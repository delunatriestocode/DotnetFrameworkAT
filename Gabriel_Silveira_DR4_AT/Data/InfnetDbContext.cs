using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Gabriel_Silveira_DR4_AT.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Gabriel_Silveira_DR4_AT.Data
{
    public class InfnetDbContext : IdentityDbContext
    {
        public InfnetDbContext (DbContextOptions<InfnetDbContext> options)
            : base(options)
        {
        }

        public DbSet<Gabriel_Silveira_DR4_AT.Models.Aluno> Aluno { get; set; } = default!;
    }
}
