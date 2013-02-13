using System.Collections.Generic;
using System.Linq;

namespace Validation
{
    public class Entity : EntityBase
    {
        private List<string> validationErrors = new List<string>();

        public override bool IsValid
        {
            get
            {
                if (ValidationErrors.Count > 0)
                {
                    return false;
                }
                return true;
            }
        }
        public override List<string> ValidationErrors
        {
            get { return validationErrors; }
            protected set { validationErrors = value; }
        }

        public override bool Validate()
        {
            ValidateAttributes();
            ValidateBusinessRules();

            return IsValid;
        }

        private void ValidateAttributes()
        {
            var result = ValidationHelper.ValidateEntity(this);
            ValidationErrors.AddRange(result.Errors.Select(x=>x.ErrorMessage));
        }

        protected virtual void ValidateBusinessRules()
        {

        }
    }
}