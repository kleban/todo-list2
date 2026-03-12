using Microsoft.EntityFrameworkCore;
using ToDoApp.Domain.Entities;

namespace ToDoApp.Domain
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options) 
            : base(options)  
        {
            Database.EnsureCreated();        
        }

        public DbSet<ToDo> ToDos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ToDo>().HasData(
                new ToDo { Id = 1, Name = "Видати завдання на лабораторну роботу 1", IsCompleted = false},
                new ToDo { Id = 2, Name = "Надати доступ до записів занять на EduTrack", IsCompleted = true },
                new ToDo { Id = 3, Name = "Видати завдання на лабораторну роботу 2", IsCompleted = false }
                );
        }
    }
}
