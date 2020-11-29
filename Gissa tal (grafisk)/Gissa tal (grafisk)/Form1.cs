using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gissa_tal__grafisk_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random randomerare = new Random();
            int tal = randomerare.Next(1, 100);
            int räknare = 0;
            int gissning = 0;

            while (gissning != tal)
            {
                gissning = int.Parse(textboxgissning.Text);
                räknare++;

                if (gissning != tal)
                {
                    if (gissning < tal)
                        textboxresultat.Text = "Gissningen är för låg";

                    if (gissning > tal)
                        textboxresultat.Text = "Gissningen är för hög";
                }
                else
                    textboxresultat.Text = "Gissningen är rätt!" + " \nAntal gissningar: " + räknare;
            }

        }
    }
}
