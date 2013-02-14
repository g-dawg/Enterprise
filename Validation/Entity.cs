using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Validation
{
    public class Entity : EntityBase
    {
        private List<ValidationResult> validationErrors = new List<ValidationResult>();

        public override bool IsValid
        {
            get { return Validate(); }
        }

        public override List<ValidationResult> ValidationErrors
        {
            get { return validationErrors; }
            protected set { validationErrors = value; }
        }

        public override bool Validate()
        {
            ValidationErrors.AddRange(ValidateAttributes());
            ValidationErrors.AddRange(ValidateBusinessRules());

            return !ValidationErrors.Any();
        }

        private List<ValidationResult> ValidateAttributes()
        {
            return  ValidationHelper.ValidateEntity(this);
        }

        protected virtual List<ValidationResult> ValidateBusinessRules()
        {
            return new List<ValidationResult>();
        }
    }
}