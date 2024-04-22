using System.ComponentModel.DataAnnotations;

namespace Product.Core.Helper
{
    public class ValidationHelper
    {
        public static void ModelValiation(object obj)
        {
            //Model Validation
            ValidationContext validationContext = new ValidationContext(obj);
            List<ValidationResult> validationResults = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(obj, validationContext, validationResults, true);
            if (!isValid)
            {
                throw new ArgumentException(validationResults.FirstOrDefault()?.ErrorMessage);
            }
        }
    }
}
