namespace ClassesHerança;

//Peterson Wiggers
public class Curso : Object
{
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public int CargaHoraria { get; set; }

    public Curso(string nome = "", string descricao = "", int cargaHoraria = 0)
    {
        Nome = nome;
        Descricao = descricao;
        CargaHoraria = cargaHoraria;
    }
    public override string ToString()
    {
        return $"{Nome},{CargaHoraria}";
    }
}
