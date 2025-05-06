// Dentro de Models 
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieMVC.Models{

    public class Filme
    {
            [Required]
            [Display(nameof  = "Id Filme")]
            public int Id Filme {get; set;}


            [Required]
            [Display(nameof  = "Nome do Filme")]
            public int Id NomeDoFilme{get; set;}

            [Required]
            [Display(nameof  = "Realizador")]
            public int Id Realizador{get; set;}

    // Ator principal, Atriz principal, Classificação.

    public double Classificação      




    }

    // add banco de dados "Gestão Filmes"
    //  





}