using Microsoft.EntityFrameworkCore;
using UniversityAppBackend.Models.DataModels;

namespace UniversityAppBackend.DataAccess
{
    public class UniversityDBContext:DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options):base(options) { }

        //ADD DbSets
        public DbSet<User>? Users { get; set; } //Usuarios
        public DbSet<Curso>? Cursos { get; set; } //Cursos
    }
}
