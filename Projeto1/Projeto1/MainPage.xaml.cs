using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Projeto1
{
    public partial class Projeto1 : ContentPage
    {
        public Projeto1()
        {
            InitializeComponent();

        }

        void CALCULARP3(object sender, System.EventArgs e)
        {
            double NotaP1 = Convert.ToDouble(txt_Nota_P1.Text);
            double NotaP2 = Convert.ToDouble(txt_Nota_P2.Text);
            double NotaAT = Convert.ToDouble(txt_Nota_AT.Text);


            if (NotaP1 >= 10.1 || NotaP2 >= 10.1 || NotaAT >= 10.1)

            {
                lbl_Mensagem.Text = "Somente Nota de 0 a 10";
            }

            else
            {
                lbl_Mensagem.Text = "";

                double Nota1 = (((NotaP1 * 0.4 + NotaP2 * 0.6) * 0.8) + NotaAT * 0.2);
                lbl_Resultado1.Text = ($"Sua Nota Final é: {Nota1}");

                if (Nota1 < 6)
                {
                    lbl_Resultado2.Text = ($"Reprovado");
                    lbl_Resultado2.TextColor = Color.Red;
                    lbl_Resultado2.FontAttributes = FontAttributes.Bold;
                }

                else
                {
                    lbl_Resultado2.Text = ($"APROVADO");
                    lbl_Resultado2.TextColor = Color.Green;
                }
            }

        }

        void bt_limpar(object sender, System.EventArgs e)
        {
            txt_Nota_P1.Text = "";
            txt_Nota_P2.Text = "";
            txt_Nota_AT.Text = "";
            lbl_Mensagem.Text = "";
            lbl_Resultado1.Text = "";
            lbl_Resultado2.Text = "";
        }

 



    }


}


