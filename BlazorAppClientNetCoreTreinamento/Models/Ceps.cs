using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAppClientNetCoreTreinamento.Models
{
    public class Ceps
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O Cep é obrigatório")]
        [StringLength(9)]
        public string Cep { get; set; } = string.Empty;

        [Required(ErrorMessage = "O Logradouro é obrigatório")]
        [StringLength(100)]
        public string Logradouro { get; set; } = string.Empty;
        public string? Numero { get; set; }
        public string? Complemento { get; set; }

        [Required(ErrorMessage = "O bairro é obrigatório")]
        [StringLength(100)]
        public string Bairro { get; set; } = string.Empty;

        [Required(ErrorMessage = "A cidade é obrigatória")]
        [StringLength(100)]
        public string Cidade { get; set; } = string.Empty;

        [Required(ErrorMessage = "A Uf é obrigatória")]
        [StringLength(2)]
        public string Uf { get; set; } = string.Empty;
    }
}

