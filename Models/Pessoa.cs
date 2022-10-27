using System;
using System.ComponentModel.DataAnnotations;

namespace API_com_ASP.NET_Core.Models
{
    public class Pessoa
    {
        [Key]
        public int Id {get;set;}
        public string Nome {get;set;}
        public string Cidade {get;set;}
        public int idade {get;set;}
    }
}