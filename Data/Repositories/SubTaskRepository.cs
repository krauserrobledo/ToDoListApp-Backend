using Domain.Abstractions;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories
{
    public class SubTaskRepository : ISubTaskRepository
    {
        // DB Context
        private readonly AppDbContext _context;
<<<<<<< HEAD
        // Dependency Injection of DbContext would be here
        public SubTaskRepository(AppDbContext context)
=======
        // Dependency Injection of DbContext
        public SubtaskRepository(AppDbContext context)
>>>>>>> f9b275d (feat(linq): Method syntax queries added to repositories)
        {
            _context = context;
        }
        public async Task<SubTask> CreateSubTask(SubTask subTask)
        {
<<<<<<< HEAD
            // Validate input
            if (string.IsNullOrWhiteSpace(subTask.Title))
                throw new ArgumentException("SubTask title cannot be null or WhiteSpace.", nameof(subTask.Title));
            
            if (subTask.Title.Length > 100)
                throw new ArgumentException("SubTask title cannot exceed 100 characters.", nameof(subTask.Title));

            if (string.IsNullOrEmpty(subTask.Title))
                throw new ArgumentException("Task ID cannot be null or empty.", nameof(subTask.TaskId));

            if (string.IsNullOrWhiteSpace(subTask.TaskId))
                throw new ArgumentException("Task ID cannot be whitespace.", nameof(subTask.TaskId));


            // Generate a new GUID for the ID if not provided
            if (string.IsNullOrEmpty(subTask.Id) || string.IsNullOrWhiteSpace(subTask.Id))
                subTask.Id = Guid.NewGuid().ToString();


            // Clean up Title and TaskId
            subTask.Title = subTask.Title.Trim();
            subTask.TaskId = subTask.TaskId.Trim();
            // subTask.Task = null!; // Avoid EF Core tracking issues

            // Add to DbContext and save changes    
            await _context.Subtasks.AddAsync(subTask);
=======
            // Validation using LINQ
            var existingSubtask = await _context.Subtasks
                .FirstOrDefaultAsync(st => st.Title == subtask.Title && st.TaskId == subtask.TaskId);

            if (existingSubtask != null)
                {
                throw new InvalidOperationException("A subtask with the same title already exists for this task.");
            }
            // Add to DbContext and save changes
            await _context.Subtasks.AddAsync(subtask);
>>>>>>> f9b275d (feat(linq): Method syntax queries added to repositories)
            await _context.SaveChangesAsync();
            return subTask;
        }

        public async Task<bool> DeleteSubTask(string id)
        {
            // Verify Id with LINQ
            var subtaskExist = await _context.Subtasks
                .Where(st => st.Id == id)
                .FirstOrDefaultAsync();
 
            if (subtaskExist != null)
            {

                _context.Subtasks.Remove(subtaskExist);
                await _context.SaveChangesAsync();
                return true;
            }

            return false;
        }

        public async Task<ICollection<SubTask>> GetAllSubTasksByTask(string taskId)
        {
            // Get using linq
            return await _context.Subtasks
                .Where(st => st.TaskId == taskId)
                .OrderByDescending(st => st.Id)
                .ToListAsync();

        }

<<<<<<< HEAD
        public Task<SubTask?> GetSubTaskById(string subTaskId)
=======
        public async Task<Subtask?> GetSubtaskById(string subTaskId)
>>>>>>> f9b275d (feat(linq): Method syntax queries added to repositories)
        {
            // Get using Linq
            return await _context.Subtasks
                .FirstOrDefaultAsync(st =>  st.Id == subTaskId );
        }

        public async Task<SubTask?> UpdateSubTask(SubTask subTask)
        {
            // Find subtask using LINQ
            var subtaskExist = await _context.Subtasks
                .Where(t =>  t.Id == subTask.Id)
                .FirstOrDefaultAsync();

            if(subtaskExist != null)
            {
                // Update attribute
                subtaskExist.Title = subTask.Title ?? subtaskExist.Title;
                
                // Save changes
                await _context.SaveChangesAsync();
                return subtaskExist;

            }
            return null;
        }
    
    }
}
