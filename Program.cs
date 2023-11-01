using CodigosBootcampWex.Models;

// decimal valorMonetario = 1522.40M;

// Console.WriteLine($"{valorMonetario:C}");




Pessoa pessoa1 = new Pessoa("Andressa", "Abrantes");
Pessoa pessoa2 = new Pessoa("Andreza", "Abrantes");
Pessoa pessoa3 = new Pessoa("Mari", "Azevedo");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(pessoa1);
cursoDeIngles.AdicionarAluno(pessoa2);
cursoDeIngles.AdicionarAluno(pessoa3);

cursoDeIngles.ListarAlunos();
