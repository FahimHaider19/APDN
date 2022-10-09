﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Web;

namespace _MID__Lab_Task_2.CustomAnnotation
{
    public class IdEmailMatch : ValidationAttribute
    {
        public string OtherProperty { get; set; }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            PropertyInfo otherPropertyInfo = validationContext.ObjectType.GetProperty(OtherProperty);
            object otherPropertyValue = otherPropertyInfo.GetValue(validationContext.ObjectInstance, null);
            //String val = ((string)value).Substring(0, 10);
            if(Equals(((string)value).Substring(0,10), otherPropertyValue))
                return null;
            return new ValidationResult(FormatErrorMessage(validationContext.DisplayName));
        }
    }
}