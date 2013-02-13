namespace Validation
{
    public class ValidationHelper
    {
        public static EntityValidationResult ValidateEntity<T>(T entity)
            where T : Entity
        {
            return new EntityValidator<T>().Validate(entity);
        }
    }
}