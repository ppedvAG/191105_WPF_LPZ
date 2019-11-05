using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimalForms
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Windows.Forms.Application.Run(new MeinFormular());

            Console.ReadKey();
        }
    }

    class MeinFormular : System.Windows.Forms.Form
    {
        public MeinFormular()
        {
            // 
            // button1
            // 
            var button1 = new System.Windows.Forms.Button();
            button1.Location = new System.Drawing.Point(12, 26);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Klick mich aus der Konsole !!!!!";
            button1.UseVisualStyleBackColor = true;

            this.Controls.Add(button1);

        }
    }

}
