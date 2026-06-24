using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAppClientNetCoreTreinamento.Models
{
    public class Ceps
    {
        public int Id { get; set; }
        public string Cep { get; set; } = string.Empty;
        public string Logradouro { get; set; } = string.Empty;
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        public string Bairro { get; set; } = string.Empty;
        public string Cidade { get; set; } = string.Empty;
        public string Uf { get; set; } = string.Empty;
    }
}

