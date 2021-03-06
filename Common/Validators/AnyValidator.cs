﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode2020.Common.Validators
{
    class AllValidator<T> : IValidator<T>
    {
        public AllValidator(params IValidator<T>[] validators)
        {
            this.validators = validators;
        }

        public AllValidator(IEnumerable<IValidator<T>> validators)
        {
            this.validators = validators.ToArray();
        }

        public bool Validate(T input)
        {
            return validators.All(x => x.Validate(input));
        }

        private readonly IValidator<T>[] validators;
    }
}
