// chama a classe Curso, Aluno, Professor e Endereco do namespace ClassesHerança
// somente é possivel pois o projeto AplicaçãoHerança tem uma referência para o projeto ClassesHerança
using ClassesHerança;
internal class Program
{
    Program()
    {
        Curso curso = new Curso("Sistemas de Informação");

        Pessoa pessoa = new("Peterson Wiggers", "01221379909", "01221379909", new Endereco("Rua 4", 43, "Bairro 4", "Cidade 4", "Estado 4", "12345-678"));
        
        Funcionario funcionario = new(pessoa, "0852647", 1500m);

        Aluno aluno1 = new(pessoa, 150, curso);

        Aluno aluno2 = new Aluno(
            nome: "João Silva",
            cpf: "12345678900",
            rg: "MG1234567",
            logradouro: new Endereco { Rua = "Rua das Flores", Cidade = "São Paulo" },
            matricula: 20231001,
            cursoAluno: new Curso { Nome = "Sistemas de Informação" }
        );

        Aluno aluno3 = new Aluno(
            nome: "Carlos Souza",
            cpf: "32165498700",
            rg: "RJ1122334",
            logradouro: new Endereco { Rua = "Avenida Central", Cidade = "Rio de Janeiro" },
            matricula: 20242001,
            cursoAluno: new Curso { Nome = "Engenharia de Software"}
        );

        List<Pessoa> pessoas = new List<Pessoa>();
        foreach (var item in pessoas)
        {
            if (item.GetType() == typeof(Aluno))
            {
                Console.WriteLine($"{item.GetType().Name} => Nome: {item.Nome}, CPF: {item.Cpf}, RG: {item.Rg}, Endereço: {item.Logradouro.Rua}, Matrícula: {((Aluno)item).Matricula}, Curso: {((Aluno)item).CursoAluno.Nome}\n");
            }
            else if (item is Professor p) // verifica o tipo do objeto e referência em uma variável auxiliar do tipo correto
            {
                Console.WriteLine($"{item.GetType().Name} => Nome: {p.Nome}, CPF: {p.Cpf}, RG: {p.Rg}, Endereço: {p.Logradouro.Rua}, Registro: {p.Registro}, Titulação: {p.Titulacao}, Área: {p.Area}\n");
            }
        }
    }
    private static void Main(string[] args)
    {
        _ = new Program();
    }
}