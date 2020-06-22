using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProWebSite.Models
{
    public class Pessoa
    {
        [Key]
        public int PessoaId { get; set; }
        [Required(ErrorMessage = "O campo é obrigatório", AllowEmptyStrings = false)]

        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo é obrigatório", AllowEmptyStrings = false)]
        public string Exames { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório", AllowEmptyStrings = false)]
        public string Procedimentos { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Data da Consulta")]
        [Required(ErrorMessage = "Informe a data da Consulta")]
        public DateTime Data { get; set; }


        [DataType(DataType.Time)]
        [Display(Name = "Horário da Consulta")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = @"{0:HH:mm}")]
        public TimeSpan? Horas { get; set; }


    }
}