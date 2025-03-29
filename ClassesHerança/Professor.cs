namespace ClassesHerança;
public class Professor : Funcionario 
{
    public int Registro { get; set; }
    public string Titulacao { get; set; }
    public string Area { get; set; }
    public Professor(string nome = "", string cpf = "", string rg = "", Endereco? logradouro = null, string matricula = "", decimal salario = 0, 
    int registro = 0, string titulacao = "", string area = "") 
    : base(nome, cpf, rg, logradouro, matricula, salario)
    {
        Registro = registro;
        Titulacao = titulacao;
        Area = area;
    }
}