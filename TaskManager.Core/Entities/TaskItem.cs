using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace TaskManager.Core.Entities
{
    public class TaskItem
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public string? Description { get; private set; }
        public bool IsCompleted { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? CompletedAt { get; private set; }

        public TaskItem(int id, string title, string? description)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentNullException("Titulo não pode estar vazio", nameof(title));
            Id = id;
            Title = title;
            Description = description;
            IsCompleted = false;
            CreatedAt = DateTime.Now;
            CompletedAt = null;
        }
        public void Complete()
        {
            if (!IsCompleted)
                return;
            IsCompleted=true;
            CompletedAt = DateTime.Now;
        }
    }
    
}
