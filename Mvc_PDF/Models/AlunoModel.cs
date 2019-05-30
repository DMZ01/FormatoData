using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mvc_PDF.Models
{
    public class Aluno
    {
        [Key]
        public int alunoID { get; set; }
        [Required]
        public string Nome { get; set; }
        public string Classe { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MMM/yyyy}")]
        public DateTime Nascimento { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public List<Aluno> AlunoLista { get; set; }
    }
}