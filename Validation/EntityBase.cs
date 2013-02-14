using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Validation
{
    public abstract class EntityBase
    {
        public abstract bool IsValid { get; }
        public abstract List<ValidationResult> ValidationErrors { get; protected set; }
        public abstract bool Validate();
    }
}