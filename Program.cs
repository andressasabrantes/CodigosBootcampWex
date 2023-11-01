using System.Data.Common;
using System.Globalization;
using CodigosBootcampWex.Models;

string dataString = "2022-04-17 18:00";

bool sucesso = DateTime.TryParseExact(dataString,
                        "yyyy-MM-dd HH:mm", 
                        CultureInfo.InvariantCulture, 
                        DateTimeStyles.None, out DateTime data);

if (sucesso) 
{   
    Console.WriteLine($"Conversão feita com sucesso! Data: {data}");
}
else 
{
    Console.WriteLine($"{dataString} não é uma data válida!");

}



// DateTime data = DateTime.Now;

// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
// Console.WriteLine(data.ToShortDateString());
// Console.WriteLine(data.ToShortTimeString());


// DateTime data2 = DateTime.Parse("31/10/2023 22:01");
// Console.WriteLine(data2);



// decimal valorMonetario = 1522.40M;

// Console.WriteLine($"{valorMonetario:C}");



// Pessoa pessoa1 = new Pessoa("Andressa", "Abrantes");
// Pessoa pessoa2 = new Pessoa("Andreza", "Abrantes");
// Pessoa pessoa3 = new Pessoa("Mari", "Azevedo");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Inglês";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(pessoa1);
// cursoDeIngles.AdicionarAluno(pessoa2);
// cursoDeIngles.AdicionarAluno(pessoa3);

// cursoDeIngles.ListarAlunos();
