using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Validation
{
    public class EntityValidator<T> where T : Entity
    {
        public List<ValidationResult> Validate(T entity)
        {
            var validationResults = new List<ValidationResult>();
            var vc = new ValidationContext(entity, null, null);
            Validator.TryValidateObject(entity, vc, validationResults, true);

            return validationResults;
        }
    }
}