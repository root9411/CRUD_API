using Microsoft.EntityFrameworkCore;
using NotesAppApi.Models.DomainModels;

namespace NotesAppApi.Data
{
    public class NotesDbContext : DbContext
    {
        public NotesDbContext(DbContextOptions options) : base(options) 
        {
        }

        public DbSet<Note> Notes { get; set; }
    }
}
