namespace ClassesHerança;

public abstract class Funcionario : Pessoa
{
    public decimal Salario { get; set; }
    public string Matricula { get; set; }

    public Funcionario(
        string nome = "",
        string cpf = "",
        string rg = "",
        Endereco? logradouro = null,
        decimal salario = 0,
        string matricula = ""
    ) : base(nome, cpf, rg, logradouro)
    {
        Salario = salario;
        Matricula = matricula;
    }
}
