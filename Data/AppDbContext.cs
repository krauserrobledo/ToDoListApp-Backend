using Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Data
{
<<<<<<< HEAD
<<<<<<< HEAD

=======
>>>>>>> f2584a8 (refactor: add comments and clean implementation)
=======

>>>>>>> 3b811eb (refactor: improve code organization)
    /// <summary>
    /// AppDbContext for Entity Framework Core, integrating IdentityDbContext for user management.
    /// </summary>
    /// <param name="options">DbContextOptions for configuration.</param>
    public class AppDbContext(DbContextOptions options) : IdentityDbContext(options)
    {
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 3b811eb (refactor: improve code organization)

        // DbSet for Tasks
        public DbSet<Domain.Models.Task> Tasks { get; set; } = null!;

        // DbSet for Subtasks
        public DbSet<Subtask> Subtasks { get; set; } = null!;

        // DbSet for Tags
        public DbSet<Tag> Tags { get; set; } = null!;

        // DbSet for Categories
        public DbSet<Category> Categories { get; set; } = null!;

        // DbSet for TaskTags (many-to-many relationship)
        public DbSet<TaskTag> TaskTags { get; set; } = null!;

<<<<<<< HEAD
=======
        // DbSet for Tasks
        public DbSet<Domain.Models.Task> Tasks { get; set; } = null!;
        // DbSet for Subtasks
        public DbSet<Subtask> Subtasks { get; set; } = null!;
        // DbSet for Tags
        public DbSet<Tag> Tags { get; set; } = null!;
        // DbSet for Categories
        public DbSet<Category> Categories { get; set; } = null!;
        // DbSet for TaskTags (many-to-many relationship)
        public DbSet<TaskTag> TaskTags { get; set; } = null!;
>>>>>>> f2584a8 (refactor: add comments and clean implementation)
        // DbSet for TaskCategories (many-to-many relationship)
        public DbSet<TaskCategory> TaskCategories { get; set; } = null!;
        // Apply all configurations from the current assembly
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
<<<<<<< HEAD

=======
>>>>>>> f2584a8 (refactor: add comments and clean implementation)
=======
        // DbSet for TaskCategories (many-to-many relationship)
        public DbSet<TaskCategory> TaskCategories { get; set; } = null!;

        // Apply all configurations from the current assembly
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

>>>>>>> 3b811eb (refactor: improve code organization)
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
     }    
}
        
