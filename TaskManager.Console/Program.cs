using TaskManager.Core.Entities;

Console.WriteLine("Task Manager iniciado!");

var task = new TaskItem(1, "Estudar C#", "Ler documentação sobre construtores");

Console.WriteLine($"Id: {task.Id}");
Console.WriteLine($"Título: {task.Title}");
Console.WriteLine($"Descrição: {task.Description}");
Console.WriteLine($"Concluída: {task.IsCompleted}");
Console.WriteLine($"Criada em (UTC): {task.CreatedAt}");
