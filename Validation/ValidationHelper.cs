using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Validation
{
    public class ValidationHelper
    {
        public static List<ValidationResult> ValidateEntity<T>(T entity)
            where T : Entity
        {
            return new EntityValidator<T>().Validate(entity);
        }
    }
}