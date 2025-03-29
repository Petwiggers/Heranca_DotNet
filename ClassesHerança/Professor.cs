namespace ClassesHerança;
public class Professor : Funcionario 
{
    public string Titulacao { get; set; }
    public string Area { get; set; }
    public Professor(string nome = "", string cpf = "", string rg = "", Endereco? logradouro = null, string matricula = "", decimal salario = 0, 
    string titulacao = "", string area = "") 
    : base(nome, cpf, rg, logradouro, matricula, salario)
    {
        Titulacao = titulacao;
        Area = area;
    }

    public Professor(Funcionario funcionario, string titulacao, string area) : base(funcionario.Nome, funcionario.Cpf, funcionario.Rg, funcionario.Logradouro, funcionario.Matricula, funcionario.Salario)
    {
        Titulacao = titulacao;
        Area = area;
    }
}