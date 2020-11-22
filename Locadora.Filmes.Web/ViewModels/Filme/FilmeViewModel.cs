using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Locadora.Filmes.Web.ViewModels.Filme
{
    public class FilmeViewModel
    {
        [Required(ErrorMessage ="Id obrigatorio")]
        public long IdFilme { get; set; }
        [Required(ErrorMessage = "Nome filem Obrigatorio")]
        [Display(Name = "Nome do Filme")]
        public string NomeFilme { get; set; }
        [Required(ErrorMessage = "Selecione um  album")]
        [Display(Name = "Nome do Album")]
        public string IdAlbum { get; set; }
    }
}