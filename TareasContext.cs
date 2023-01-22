using Microsoft.EntityFrameworkCore;
using projectEF.Models;

namespace projectEF;

public class TareasContext: DbContext
{
    DbSet<Categoria> Categorias {get;set;}
    DbSet<Tarea> Tareas {get;set;}

    public TareasContext(DbContextOptions<TareasContext> options):base(options) {}
}