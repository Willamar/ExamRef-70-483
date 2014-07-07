﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3._01_001
{
    public static class GenericValidator<T>
    {

        public static IList<ValidationResult> Validate(T entity)
        {
            var results = new List<ValidationResult>();

            var context = new ValidationContext(entity, null, null);

            Validator.TryValidateObject(entity, context, results);

            return results;

        }
    }
}
