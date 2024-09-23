namespace Curso___Projeto___Setembro.Models
{
    public class Curso
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public DateTime DataInicio { get; set; } 
        public DateTime DataFim { get; set; } 
        public int CargaHoraria { get; set; }
    }
}
