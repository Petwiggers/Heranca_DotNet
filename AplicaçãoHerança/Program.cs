// chama a classe Curso, Aluno, Professor e Endereco do namespace ClassesHerança
// somente é possivel pois o projeto AplicaçãoHerança tem uma referência para o projeto ClassesHerança
using ClassesHerança;
using System;
using System.Reflection;
internal class Program
{
    Program()
    {
        List<Pessoa> pessoas = new List<Pessoa>();

        Curso curso = new Curso("Sistemas de Informação", "O melhor curso", 200);

        Pessoa pessoa = new("Peterson Wiggers", "01221379909", "01221379909", new Endereco("Rua 4", 43, "Bairro 4", "Cidade 4", "Estado 4", "12345-678"));
        pessoas.Add(pessoa);

        Funcionario funcionario = new(pessoa, "0852647", 1500m);
        pessoas.Add(funcionario);

        Aluno aluno1 = new(pessoa, 150, curso);
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
            cursoAluno: new Curso { Nome = "Engenharia de Software", Descricao = "Graduação voltada para a formação de profissionais especializados no desenvolvimento", CargaHoraria = 400 }
        );
        pessoas.Add(aluno1);
        pessoas.Add(aluno2);
        pessoas.Add(aluno3);

        Professor professor = new(funcionario, "mestre", "Tecnologia");
        Professor professor2 = new Professor(
            nome: "João Silva",
            cpf: "123.456.789-00",
            rg: "12.345.678-9",
            logradouro: new Endereco("Rua das Flores", 123, "Centro", "São Paulo", "SP", "01234-567"),
            matricula: "PROF2025001",
            salario: 7500.00m,
            titulacao: "Doutorado",
            area: "Ciência da Computação"
        );
        pessoas.Add(professor);
        pessoas.Add(professor2);

        Coordenador coordenador = new(funcionario, "AbcBolinhas");
        pessoas.Add(coordenador);

        TecnicoAdministrativo tecnico = new(funcionario, "Desenvolvedor");
        TecnicoAdministrativo tecnico2 = new TecnicoAdministrativo(
            nome: "Maria Oliveira",
            cpf: "987.654.321-00",
            rg: "98.765.432-1",
            logradouro: new Endereco("Avenida Central", 456, "Centro", "Rio de Janeiro", "RJ", "12345-678"),
            matricula: "TA2025002",
            salario: 4500.00m,
            funcao: "Assistente Administrativo"
        );
        pessoas.Add(tecnico);
        pessoas.Add(tecnico2);

        foreach (var item in pessoas)
        {
            Type tipo = item.GetType();

            Console.WriteLine($"Listagem de {tipo}\n");
            // Lista todas as propriedades e seus valores
            foreach (PropertyInfo propriedade in tipo.GetProperties())
            {
                if (propriedade.Name == "Endereco")
                {
                    foreach (PropertyInfo x in typeof(Endereco).GetProperties())
                    {
                        object valorEndereco = x.GetValue(item);
                        Console.WriteLine($"{propriedade.Name}: {valorEndereco}");
                    }
                }
                object valor = propriedade.GetValue(item);
                Console.WriteLine($"{propriedade.Name}: {valor}");
            }

            Console.WriteLine("-----------------------------");
        }


    }
    private static void Main(string[] args)
    {
        _ = new Program();
    }
}