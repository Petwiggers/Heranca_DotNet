namespace ClassesHerança;
//Peterson Wiggers
public class Aluno : Pessoa
{
    public int Matricula { get; set; }
    public Curso CursoAluno { get; set; } 
    public Aluno(string nome = "", string cpf = "", string rg = "", Endereco? logradouro = null, int matricula = 0, Curso? cursoAluno = null) 
        : base(nome, cpf, rg, logradouro)
    {
        Matricula = matricula;
        CursoAluno = cursoAluno ?? new Curso();
    }

    public Aluno(Pessoa pessoa, int matricula, Curso curso) : base (pessoa.Nome, pessoa.Cpf, pessoa.Rg, pessoa.Logradouro)
    {
        Matricula = matricula;
        CursoAluno = curso; 
    }
}