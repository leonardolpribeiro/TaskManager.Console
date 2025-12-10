using TaskManager.Core.Entities;
using TaskManager.Infrastructure.Repositories;

Console.WriteLine("Task Manager iniciado!");

var repository = new InMemoryTaskItemRepository();

var task1 = repository.Add(new TaskItem(0, "Estudar C#", "Ler sobre construtores"));
var task2 = repository.Add(new TaskItem(0, "Implementar repositório", "Criar repositório em memória"));
var task3 = repository.Add(new TaskItem(0, " Pequeno menu interativo", ""));

repository.Complete(task1.Id);

foreach (var task in repository.GetAll())
{   
    Console.WriteLine($"Id: {task.Id} | Título: {task.Title} | Concluída: {task.IsCompleted == false} | Criada: {task.CreatedAt}");
}