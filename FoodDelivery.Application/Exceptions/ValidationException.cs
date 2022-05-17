﻿using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDelivery.Application.Exceptions
{
    public class ValidationException : Exception
    {
        public List<string> Errors { get; set; } = new List<string>();
        public ValidationException(ValidationResult validationResult)
        {
            foreach(var error in validationResult.Errors)
            {
                Errors.Add(error.ErrorMessage);
            }

        }
    }
}
