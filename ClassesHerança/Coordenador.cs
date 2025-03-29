namespace ClassesHerança;

public class Coordenador : Funcionario
{
    public string SenhaAlarme { get; set; }

    public Coordenador(string senha_alarme = "", string nome = "", string cpf = "", string rg = "",
         Endereco? logradouro = null, string matricula = "", decimal salario = 0)  : base(nome, cpf, rg, logradouro, matricula, salario) 
    {
        SenhaAlarme = senha_alarme;
    }
}