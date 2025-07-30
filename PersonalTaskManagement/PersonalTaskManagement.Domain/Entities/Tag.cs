using System.ComponentModel.DataAnnotations;

namespace PersonalTaskManagement.Domain.Entities
{
    public class Tag
    {
        public string Id { get; set; } = Guid.NewGuid().ToString("N");

        [Required, MaxLength(50)]
        public string Name { get; set; }

        public Guid UserId { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public string PublicKey { get; set; }
        public ICollection<TaskTag> TaskTags { get; set; } = [];
    }
    public class TaskTag
    {
        public string TaskItemId { get; set; }
        public TaskItem TaskItem { get; set; }

        public string TagId { get; set; }
        public Tag Tag { get; set; }
    }

}
