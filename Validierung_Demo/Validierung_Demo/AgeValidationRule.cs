using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Validierung_Demo
{
    public class AgeValidationRule : ValidationRule
    {
        public int Minimum { get; set; }
        public int Maximum { get; set; }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (string.IsNullOrWhiteSpace(value.ToString()))
                return new ValidationResult(false, "Das Textfeld ist leer");

            try
            {
                int alter = Convert.ToInt32(value);

                if(alter < Minimum)
                    return new ValidationResult(false, $"Die Eingabe ist kleiner als das Minimum von {Minimum}");
                else if(alter > Maximum)
                    return new ValidationResult(false, $"Die Eingabe ist größer als das Maximum von {Maximum}");
                else
                    return new ValidationResult(true,null);
            }
            catch (FormatException)
            {
                return new ValidationResult(false, "Ungültige Zahl");
            }
            catch (OverflowException)
            {
                return new ValidationResult(false, "Die eingegebene Zahl ist zu groß oder zu klein");
            }
        }
    }
}
