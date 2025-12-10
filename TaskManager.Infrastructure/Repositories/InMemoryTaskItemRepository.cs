using System.Collections.Generic;
using System.Linq;
using TaskManager.Core.Entities;
using TaskManager.Core.Repositories;

namespace TaskManager.Infrastructure.Repositories;

public class InMemoryTaskItemRepository : ITaskItemRepository
{
    private readonly List<TaskItem> _tasks = new();
    private int _nextId = 1;

    public TaskItem Add(TaskItem task)
    {
        var taskWithId = new TaskItem(_nextId++, task.Title, task.Description);
        _tasks.Add(taskWithId);
        return taskWithId;
    }

    public IEnumerable<TaskItem> GetAll()
        => _tasks;

    public TaskItem? GetById(int id)
        => _tasks.FirstOrDefault(t => t.Id == id);

    public void Complete(int id)
    {
        var task = GetById(id);
        task?.Complete();
    }
}
