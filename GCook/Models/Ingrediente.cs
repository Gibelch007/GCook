using System.ComponentModel.DataAnnotations;

namespace GCook.Models;

    public class Ingrediente
    {
        [Key]

        public int Id {get; set;}

        [Required]
        [StringLength(50)]

        public string Nome {get; set;}
    }
