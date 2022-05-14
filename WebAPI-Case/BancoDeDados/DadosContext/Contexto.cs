using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace WebAPI_Case.BancoDeDados.DadosContext
{
    public class Contexto : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }


    }
}
