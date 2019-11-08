using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Interactivity;

namespace Behaviour_Demo
{
    public class NumberTextboxBehavior : Behavior<TextBox>
    {
        // 2 Sachen:
        // Wir fügen der Textbox dynamisch ein Verhalten hinzu:
        // Methode: OnAttached() und OnDetaching()


        // Hier wird das Event für die TextBox registriert
        protected override void OnAttached()
        {
            //base.OnAttached();
            AssociatedObject.TextChanged += CheckIfOnlyNumbers;
        }
        protected override void OnDetaching()
        {
            //base.OnDetaching();
            AssociatedObject.TextChanged -= CheckIfOnlyNumbers;

        }

        string oldText;
        int oldCaretIndex;

        private void CheckIfOnlyNumbers(object sender, TextChangedEventArgs e)
        {
            // Logik:
         
            if(Int32.TryParse(AssociatedObject.Text, out _) == false) // out _ -> Verwirft die Ausgabe
            {
                AssociatedObject.Text = oldText;
                AssociatedObject.CaretIndex = AssociatedObject.Text.Length;
            }
            else
            {
                oldText = AssociatedObject.Text;
            }
        }


    }
}
