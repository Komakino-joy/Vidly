using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class InStockMustBeGreaterThan0 : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movie = (Movie) validationContext.ObjectInstance;

            if (movie.InStock > 0 && movie.InStock < 21)
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("The field Number In Stock must be between 1 and 20");
        }
    }
}