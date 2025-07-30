using System.ComponentModel.DataAnnotations;

namespace PersonalTaskManagement.Domain.Entities
{
    public class User
    {
        public string PublicKey { get; set; } = Guid.NewGuid().ToString("N");

        [Required, MaxLength(50)]
        public string Username { get; set; } = null!;

        [Required, MaxLength(100), EmailAddress]
        public string Email { get; set; } = null!;

        [Required]
        public string PasswordHash { get; set; } = null!;

        [Required]
        public UserRole Role { get; set; } = UserRole.User;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public ICollection<TaskItem> Tasks { get; set; } = [];
        public ICollection<Tag> Tags { get; set; } = [];
    }

    public enum UserRole
    {
        User,
        Admin
    }

}
