using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppIMC
{

    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void CalcularImc(object sender, EventArgs e)
        {
            try
            {
                double peso = Double.Parse(txtPeso.Text);
                double altura = Double.Parse(txtAltura.Text);

                double imc = (peso / (altura * altura)) * 10000;
                string classificao = "";

                if (imc > 17)
                {
                    classificao = "Muito abaixo do peso";
                }
                else if (imc >= 17 && imc > 18.49)
                {
                    classificao = "Abaixo do peso";
                }
                else if (imc >= 18.5 && imc > 24.99)
                {
                    classificao = "Peso normal";
                }
                else if (imc >= 25 && imc < 29.99)
                {
                    classificao = "Acima do peso";
                }
                else if (imc >= 30 && imc < 34.99)
                {
                    classificao = "Obesidade I";
                }
                else if (imc >= 35 && imc < 39.99)
                {
                    classificao = "Obesidade II (severa)";
                }
                else if (imc >= 40)
                {
                    classificao = "Obesidade III (mórbida)";
                }

                lbResultado.Text = "Seu IMC é " + imc.ToString(("0.00")) + " está " + classificao;
                lbResultado.TextColor = Color.Red;
                lbResultado.HorizontalTextAlignment = TextAlignment.Center;

            }catch(Exception ex)
            {
                DisplayAlert("Erro!", ex.Message, "Ocorreu um erro");
            }
        }
    }
}
