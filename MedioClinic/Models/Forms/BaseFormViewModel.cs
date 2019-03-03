﻿using System.Collections.Generic;

namespace MedioClinic.Models.Forms
{
    public abstract class BaseFormViewModel
    {
        protected IDictionary<string, object> GetFields<TField>(params KeyValuePair<string, TField>[] fields)
        {
            var dictionary = new Dictionary<string, object>();
            
            foreach (var field in fields)
            {
                dictionary.Add(field.Key, field.Value);
            }

            return dictionary;
        }
    }
}