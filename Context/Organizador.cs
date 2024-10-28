using Microsoft.EntityFrameworkCore;
using AgendamentodeTarefasAPI.Models;

namespace AgendamentodeTarefasAPI.Context
{
    public class Organizador(DbContextOptions<Organizador> options) : DbContext(options)
    {
        public DbSet<Tarefa> Tarefas { get; set; }

        internal void Update(Tarefa tarefa, Tarefa tarefaBanco)
        {
            throw new NotImplementedException();
        }
    }
}