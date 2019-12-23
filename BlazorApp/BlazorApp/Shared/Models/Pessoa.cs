using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Shared.Models
{
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public DateTime DataDeNascimento { get; set; }
        public int Idade { get => DateTime.Now.Year - DataDeNascimento.Year; }
    }
}