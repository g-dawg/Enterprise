using System.Collections.Generic;

namespace Validation
{
    public abstract class EntityBase
    {
        public abstract bool IsValid { get; }
        public abstract List<string> ValidationErrors { get; protected set; }
        public abstract bool Validate();
    }
}