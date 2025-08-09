using System.ComponentModel.DataAnnotations;

namespace PersonalTaskManagement.Domain.Entities
{
    public class TaskItem
    {
        public string Id { get; set; } = Guid.NewGuid().ToString("");
        
        [Required]
        public string UserPublicKey { get; set; }

        [Required, MaxLength(100)]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        public TaskStatus Status { get; set; } = TaskStatus.Pending;

        public DateTime? DueDate { get; set; }

        public bool IsDeleted { get; set; } = false;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        // Navigation
        public User User { get; set; }
        public ICollection<TaskTag> TaskTags { get; set; } = [];
    }

    public enum TaskStatus
    {
        Pending,
        InProgress,
        Done
    }

}