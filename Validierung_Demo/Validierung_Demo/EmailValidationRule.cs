using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Validierung_Demo
{
    class EmailValidationRule : ValidationRule // abstrakte Klasse
    {
        // Validate:
        // value -> Wert, den wir validieren wollen
        // ValidationResult -> Ist der Wert Valide ist ...
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (string.IsNullOrWhiteSpace(value.ToString()))
                return new ValidationResult(false,"Das Textfeld ist leer");

            try
            {
                new MailAddress(value.ToString());
                return new ValidationResult(true, "");
            }
            catch (Exception)
            {
                return new ValidationResult(false, "Kein gültiges Email-Format");
            }
        }
    }
}
