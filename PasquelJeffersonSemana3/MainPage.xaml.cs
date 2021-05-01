using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PasquelJeffersonSemana3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //async para mostrar flecha de regreso
        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            String usuario = txtUsuario.Text;
            String clave = txtClave.Text;
            //condicion
            if (usuario == "estudiante2021" && clave == "uisrael2021")
                //await ejecuta cada linea
                //sale erro en page 2 porque se debe modificar los parametros en el page
                await Navigation.PushAsync(new Page2(usuario, clave));
            
            else
                await DisplayAlert("Advertencia", "¡Usuario o clave incorrectas!", "OK");

        }
    }
}
