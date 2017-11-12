using System;
using System.ComponentModel.DataAnnotations;

namespace app.web.mvc.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
 //todo: fix edit & display format (no time)       [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
//todo: fix decimal format (globalisation): See https://github.com/aspnet/Docs/issues/4076 and Additional resources for more information. 
        public decimal Price { get; set; }
    }
}
