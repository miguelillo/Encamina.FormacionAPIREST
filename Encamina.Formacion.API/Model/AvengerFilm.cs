using System.ComponentModel.DataAnnotations;

namespace Encamina.Formacion.API.Model
{
    public class AvengerFilm : Base
    {
        [Required]
        public int AvengerId { get; set; }
        public Avenger Avenger { get; set; }
        [Required]
        public int FilmId { get; set; }
        public Film Film { get; set; }
    }
}