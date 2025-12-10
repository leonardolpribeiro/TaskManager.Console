using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Core.Entities;

namespace TaskManager.Core.Repositories;

public interface ITaskItemRepository
{
    TaskItem Add(TaskItem task);
    IEnumerable<TaskItem> GetAll();
    TaskItem? GetById(int id);
    void Complete(int id);

}
