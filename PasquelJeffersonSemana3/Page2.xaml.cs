using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PasquelJeffersonSemana3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        //  aqui añado los datos añadidos en el mainpage
        public Page2(String usuario, String clave)
        {
            InitializeComponent();
            //lblUsuario.Text = usuario;
            //lblClave.Text = clave;
        }

        private void btnSumar_Clicked(object sender, EventArgs e)
        {
            try
            {
                double dato1 = Convert.ToDouble(txtNota1.Text);
                double dato2 = Convert.ToDouble(txtNota2.Text);
                double dato3 = Convert.ToDouble(txtNota3.Text);
                double dato4 = Convert.ToDouble(txtNota4.Text);
                double nota1 = dato1 * 0.3;
                double nota2 = dato2 * 0.2;
                double nota3 = dato3 * 0.3;
                double nota4 = dato4 * 0.2;
                double parcial1 = nota1 + nota2;
                double parcial2 = nota3 + nota4;
                double total = parcial1 + parcial2;
                if (total >= 7)
                {
                    txtEstado.Text = "APROBADO";
                }
                else
                {
                    txtEstado.Text = "REPROBADO";
                }

                txtNotaParcial1.Text = parcial1.ToString();
                txtNotaParcial2.Text = parcial2.ToString();
                txtNotaFinal.Text = total.ToString();


            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "Gracias");
            }
        }
    }
}