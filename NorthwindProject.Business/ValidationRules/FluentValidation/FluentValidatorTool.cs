using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindProject.Business.ValidationRules.FluentValidation
{
    public class FluentValidatorTool
    {
        public static void Validate(IValidator validator, object entityToValidate)
        {
            var result = validator.Validate(entityToValidate);
            throw new ValidationException(result.Errors);
        }
    }
}
