using System.ComponentModel.DataAnnotations;

namespace EdunovaAPP.Models
{
    public abstract class Entitet
    {
        [Key] // dio entity framework orm, to je za primarni kljuc, EF ORM
        public int? Sifra { get; set; }
    }
}
