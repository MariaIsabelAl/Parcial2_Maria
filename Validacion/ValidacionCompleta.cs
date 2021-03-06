﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Windows.Controls;
namespace Parcial2_Maria.Validacion
{
    public class ValidacionCompleta : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string mensaje = value as string;
            if(mensaje != null)
            {
                if (mensaje.Length <= 0)
                    return new ValidationResult(false, "no debe estar vacio");
                return ValidationResult.ValidResult;
            }
            return new ValidationResult(false, "no dejar vacio");
        }
    }
}
