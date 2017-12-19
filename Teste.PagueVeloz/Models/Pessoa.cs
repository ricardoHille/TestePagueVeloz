using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Teste.PagueVeloz.Models
{
    [Table("Pessoa")]
    public class Pessoa
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome deve ser preenchido")]
        public string Nome { get; set; }

        [Required(ErrorMessage ="CPF deve ser preenchido")]
        public string CPF { get; set; }

        [Required(ErrorMessage ="Data Cadastro não foi preenchida")]
        public DateTime DataCadastro { get; set; }
        
        [Required(ErrorMessage ="Data de Nascimento deve ser preenchida")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage ="Pelo menos um telefone deve ser preenchido")]
        public List<string> telefones { get; set; }
    }
}