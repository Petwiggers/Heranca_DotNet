namespace ClassesHerança;
// classe com uso de construtor primário com parâmetros opcionais
public abstract class Pessoa(string nome = "", string cpf = "", string rg = "", Endereco? logradouro = null)
{
    public string Nome { get; set; } = nome;
    public string Cpf { get; set; } = cpf;
    public string Rg { get; set; } = rg;
    public Endereco Logradouro { get; set; } = logradouro ?? new Endereco();

    // método abstrato, não tem implementação, deve ser implementado nas classes derivadas
    public abstract List<(string campo, string valor)> RetornarDados();

}