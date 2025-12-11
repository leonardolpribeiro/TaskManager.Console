Estou usando uma IA (Pexplexity) para ser meu " tech leader sênior " que me mande projetos e  tarefas diárias em C# para que eu me aprimore na linguagem e ganhe conhecimento e organização de código, a ideia é que todos os dias tenham "commits" com comentários sinalizando em qual dia estamos e as alterações no projeto. 

Dia 1 => Adicione referências: Console referencia Core e Infrastructure; Infrastructure referencia Core.​
  Teste o setup: No Program.cs do Console, escreva um "Olá Mundo" simples (Console.WriteLine("Task Manager iniciado!");) e      execute (F5).

Dia 2 => Tarefas no projeto Core
  No projeto TaskManager.Core, crie uma pasta Entities e dentro dela uma classe TaskItem com as seguintes propriedades:
  Id (int), Title (string, obrigatório), Description (string?), IsCompleted (bool), CreatedAt (DateTime),                       CompletedAt(DateTime?). 
  
Adicione um construtor que garanta:
  Title não nulo ou vazio (se vier vazio, lance uma exceção ArgumentException).
  CreatedAt definido com DateTime.UtcNow.
  IsCompleted começa como false.​
  Adicione um método na entidade:
  Complete() que marque IsCompleted = true e preencha CompletedAt com DateTime.UtcNow
  
Integração simples no Console
  No Program.cs do TaskManager.Console, substitua o código atual por:
  Criar uma instância de TaskItem com um título e uma descrição.
  Imprimir no console o Id (pode usar um valor fixo por enquanto), o título, se está concluída e a data de criação usando       Console.WriteLine.

  Dia 3 => Vamos usar o Dia 3 para criar um repositório em memória de TaskItem e ligar isso ao console. A ideia é ter uma       “fonte de dados fake” usando List<TaskItem>, o que é bem comum para prototipar domínio sem banco.
  
  Implementar o repositório em memória
  
  No projeto TaskManager.Infrastructure, crie a pasta Repositories e o arquivo InMemoryTaskItemRepository.cs
  Rodar o console e garantir que:

  São criadas pelo menos duas tarefas.
  Uma delas é marcada como concluída.
  Todas aparecem listadas no console com seus estados corretos.
