namespace ClassesHerança;
//Peterson Wiggers
public class Funcionario : Pessoa
{
    public decimal Salario { get; set; }
    public string Matricula { get; set; }

    public Funcionario(string nome = "", string cpf = "", string rg = "", Endereco? logradouro = null, string matricula = "", decimal salario = 0) : base(nome, cpf, rg, logradouro)
    {
        Salario = salario;
        Matricula = matricula;
    }

    public Funcionario(Pessoa pessoa, string matricula = "", decimal salario = 0)
        : base(pessoa.Nome, pessoa.Cpf, pessoa.Rg, pessoa.Logradouro)
    {
        Salario = salario;
        Matricula = matricula;
    }
}