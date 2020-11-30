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
        Random randomerare = new Random();
        int tal;
        int räknare = 0;
        public Form1()
        {
            InitializeComponent();
            tal = randomerare.Next(1, 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gissning = 0;


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
