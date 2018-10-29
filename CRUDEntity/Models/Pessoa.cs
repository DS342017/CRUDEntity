using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUDEntity.Models
{
    public class Pessoa
    {
        [Key]
        public int IdPessoa { get; set; }
        public String Nome { get; set; }
        public String Cpf { get; set; }
        public String Telefone { get; set; }
    }
}