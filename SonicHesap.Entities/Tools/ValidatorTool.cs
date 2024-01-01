using FluentValidation;
using SonicHesap.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonicHesap.Entities.Tools
{
    public static class ValidatorTool
    {
        public static bool Validate(IValidator validator,IEntity entity)
        {
            bool result = true;
            var validationResult = validator.Validate((IValidationContext)entity);
            if (!validationResult.IsValid)
            {
                string message = null;
                foreach (var error in validationResult.Errors)
                {
                    message += error.ErrorMessage+System.Environment.NewLine;
                }
                MessageBox.Show(message);
                result = false; 
            }
            return result;
        }
    }
}
