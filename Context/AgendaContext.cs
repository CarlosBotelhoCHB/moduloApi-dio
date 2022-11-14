using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ModuloAPI.Entities;

namespace ModuloAPI.Context
{
    // Herdando da classe DbContext
    public class AgendaContext : DbContext
    {
        // Criando a conexão com o banco de dados e passando para a classe herdada
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {

        }

        // Referenciando a entidade (Contato). É uma classe no meu C# e uma tabela no meu DB
        public DbSet<Contato> Contatos { get; set; }
    }
}