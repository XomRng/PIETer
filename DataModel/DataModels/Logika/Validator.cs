using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels.Logika
{
    static class MyModelState
    {
        public static bool IsValid(object model)
        {
            var context = new ValidationContext(model, null, null);
            var results = new List<ValidationResult>();

            if (Validator.TryValidateObject(model, context, results, true))
            {
                return true;
            }

            return false;
        }
    }
}
