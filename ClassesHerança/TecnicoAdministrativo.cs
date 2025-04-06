namespace ClassesHerança;

public class TecnicoAdministrativo : Funcionario // herança, TecnicoAdmistrativo é uma subclasse de Funcionario que é uma subclasse de Pessoa que é uma subclasse de Object
{
    public string Funcao { get; set; }

    // construtor com parâmetros opcionais e uso de construtor da classe base
    public TecnicoAdministrativo(
        string nome = "",
        string cpf = "",
        string rg = "",
        Endereco? logradouro = null,
        decimal salario = 0,
        string matricula = "",
        string funcao = ""
    ) : base(nome, cpf, rg, logradouro, salario, matricula)
    {
        // os atributos da classe base são herdados e inicializados pelo construtor da classe base
        // atributos específicos da classe derivada
        Funcao = funcao;
    }

    // implementa membro abstrato herdado "Pessoa.RetornarDados()
    public override List<(string campo, string valor)> RetornarDados()
    {
        // cria uma lista de tuplas com os dados do aluno,
        // utilizando variavel temporaria embutida para criar a lista de tuplas
        return new List<(string campo, string valor)>
        {
            ("Nome", Nome),
            ("Cpf", Cpf),
            ("Rg", Rg),
            ("Rua", Logradouro.Rua),
            ("Numero", Logradouro.Numero.ToString()),
            ("Bairro", Logradouro.Bairro),
            ("Cidade", Logradouro.Cidade),
            ("Estado", Logradouro.Estado),
            ("Cep", Logradouro.Cep.ToString()),
            ("Salário", Salario.ToString()),
            ("Matricula", Matricula.ToString()),
            ("Função", Funcao)
        };
    }

    public override string ToString()
    {
        return $"{Nome},{Funcao}";
    }
}
