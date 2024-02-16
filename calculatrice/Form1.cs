using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculatrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonAddNumber(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button != null)
            {
                if( (resultat == "0" && button.Text != ",") || resultat == "ERROR")
                {
                    resultat = "";
                }
                resultat += button.Text;
                this.resultatButon.Text = resultat;
            }
        }

        private void ButtonCalcul(object sender, EventArgs e)
        {
            try
            {
                resultat = resultat.Replace('×', '*');
                resultat = resultat.Replace('÷', '/');
                resultat = resultat.Replace(',', '.');

                DataTable table = new DataTable();
                object result = table.Compute(resultat, "");

                double finalResult = Convert.ToDouble(result);

                resultat = Convert.ToString(finalResult);
                resultat = resultat.Replace('.', ',');
            }
            catch(Exception ex)
            {
                resultat = "ERROR";

            }
            finally
            {
                this.resultatButon.Text = resultat;

            }

        }

        private void ButtonReinit(object sender, EventArgs e)
        {
            resultat = "0";
            this.resultatButon.Text = resultat;
        }

    }
}
