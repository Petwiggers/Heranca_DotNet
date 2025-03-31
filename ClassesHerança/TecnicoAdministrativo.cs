namespace ClassesHerança;
//Peterson Wiggers
public class TecnicoAdministrativo : Funcionario
{
    public string Funcao {get; set;}
    public TecnicoAdministrativo(string nome = "", string cpf = "", string rg = "", Endereco? logradouro = null, string matricula = "", decimal salario = 0, string funcao = "") 
    : base(nome, cpf, rg, logradouro, matricula, salario)
    {
        Funcao = funcao;
    }

    public TecnicoAdministrativo(Funcionario funcionario, string funcao) : base(funcionario.Nome, funcionario.Cpf, funcionario.Rg, funcionario.Logradouro, funcionario.Matricula, funcionario.Salario)
    {
        Funcao = funcao;
    }
}