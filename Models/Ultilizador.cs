using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAlunosMVC.Models{

    public class Ultilizador{

        public int NUtilizador {get;} // ID se incrementa sozinho logo n precisa do SET;
        [Display(nameof="E-Mail")]
        [DataType(DataType.EmailAddress)]
        
        public string Email {get; set;}
        [DataType()DataType.Password]

        public string Password {get; set;}


    }


}
