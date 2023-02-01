using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using SistemaWebMisRecetas.Validations;

namespace SistemaWebMisRecetas.Models
{
    public class Receta
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar(8)")]
        [Categoria]
        public string Categoria { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar(50)")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar(200)")]
        [DataType(DataType.MultilineText)]
        public string Ingredientes { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar(200)")]
        [DataType(DataType.MultilineText)]
        public string Instrucciones { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar(50)")]
        public string Autor { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        [Column(TypeName = "varchar(50)")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Edad]
        public int Edad { get; set; }

        [Required(ErrorMessage = "El mail es obligatorio")]
        [Column(TypeName = "varchar(100)")]
        [RegularExpression("^[^@]+@[^@]+\\.[a-zA-Z]{2,}$")]
        public string Email { get; set; }

    }
}
