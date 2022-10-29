namespace Eventos.API.Models
{
    public class Evento
    {
        public int EventoId { get; set; }
        public String Tema { get; set; }
        public string Local { get; set; }
        public int Lote { get; set; }
        public int QtdPessoas { get; set; }
        public string DataEvento { get; set; }
        public string ImagemURL { get; set; }
    };
}