namespace CodigosBootcampWex.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno) 
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos() 
        {
            Console.WriteLine($"Alunos matriculados no curso de: {Nome}");

            for (int i = 0; i < Alunos.Count; i++) 
            {
                //string texto = "Nº " + i + " - " + Alunos[i].NomeCompleto;
                string texto = $"Nº {i + 1} - {Alunos[i].NomeCompleto}";
                Console.WriteLine(texto);
            }
        }
    }
}