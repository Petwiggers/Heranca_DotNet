using ClassesHerança;
using System;
using System.Reflection;

//Peterson Wiggers
internal class Program
{
    Program()
    {
        List<Pessoa> pessoas = new();
        Endereco logradouro = new Endereco { Rua = "Rua das Flores", Cidade = "São Paulo" };
        Curso curso = new Curso("Sistemas de Informação", "O melhor curso", 200);
        Aluno aluno1 = new();
        Aluno aluno2 = new Aluno(
            nome: "João Silva",
            cpf: "12345678900",
            rg: "MG1234567",
            logradouro: new Endereco { Rua = "Rua das Flores", Cidade = "São Paulo" },
            matricula: 20231001,
            cursoAluno: curso
        );
        Aluno aluno3 = new Aluno(
            nome: "Carlos Souza",
            cpf: "32165498700",
            rg: "RJ1122334",
            logradouro: new Endereco { Rua = "Avenida Central", Cidade = "Rio de Janeiro" },
            matricula: 20242001,
            cursoAluno: new Curso
            {
                Nome = "Engenharia de Software",
                Descricao =
                    "Graduação voltada para a formação de profissionais especializados no desenvolvimento",
                CargaHoraria = 400
            }
        );
        pessoas.Add(aluno1);
        pessoas.Add(aluno2);
        pessoas.Add(aluno3);

        Professor professor2 = new Professor(
            nome: "João Silva",
            cpf: "123.456.789-00",
            rg: "12.345.678-9",
            logradouro: new Endereco(
                "Rua das Flores",
                123,
                "Centro",
                "São Paulo",
                "SP",
                "01234-567"
            ),
            matricula: "PROF2025001",
            salario: 7500.00m,
            titulacao: "Doutorado",
            area: "Ciência da Computação"
        );

        pessoas.Add(professor2);

        Coordenador coordenador = new("Peterson Wiggers", "012213", "012213", logradouro);
        pessoas.Add(coordenador);

        TecnicoAdministrativo tecnico2 = new TecnicoAdministrativo(
            nome: "Maria Oliveira",
            cpf: "987.654.321-00",
            rg: "98.765.432-1",
            logradouro: new Endereco(
                "Avenida Central",
                456,
                "Centro",
                "Rio de Janeiro",
                "RJ",
                "12345-678"
            ),
            matricula: "TA2025002",
            salario: 4500.00m,
            funcao: "Assistente Administrativo"
        );
        pessoas.Add(tecnico2);

        //listar todo o conteúdo do list mostrando todos os dados de cada classe
        foreach (var item in pessoas)
        {
            Console.Write($"{item.GetType().Name} => ");
            foreach (var (campo, valor) in item.RetornarDados())
            {
                Console.Write($"{campo}: {valor}, ");
            }
            Console.WriteLine("");
        }
    }

    private static void Main(string[] args)
    {
        _ = new Program();
    }
}
