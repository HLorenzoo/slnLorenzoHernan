using System.ComponentModel.DataAnnotations;
using System;

namespace SistemaWebMisRecetas.Validations
{
    public class CategoriaAttribute : ValidationAttribute
    {
        public CategoriaAttribute()
        {
            ErrorMessage = "La categoria debe ser Desayuno";
        }
        public override bool IsValid(object value)
        {
            string cat = value.ToString();

            if (cat.ToUpper() == "DESAYUNO")
            {
                return true;
            }
            return false;
        }
    }
}