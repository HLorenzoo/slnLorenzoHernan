using System.ComponentModel.DataAnnotations;
using System;

namespace SistemaWebMisRecetas.Validations
{
    public class EdadAttribute : ValidationAttribute
    {
        public EdadAttribute()
        {
            ErrorMessage = "La edad debe ser mayor o igual a 18";
        }
        public override bool IsValid(object value)
        {


            int year = (int)value;
            if (year >= 18)
            {
                return true;
            }
            return false;
        }
    }
}