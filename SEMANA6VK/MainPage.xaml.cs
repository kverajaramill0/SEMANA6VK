using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SEMANA6VK
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private  void btnInsertar_Clicked(object sender, EventArgs e)
        {
            try
            {
                WebClient cliente = new WebClient();
                var parametros = new System.Collections.Specialized.NameValueCollection();
                parametros.Add("codigo",txtCodigo.Text);
                parametros.Add("nombre", txtNombre.Text);
                parametros.Add("apellido",txtApellido.Text);
                parametros.Add("edad",txtEdad.Text);

                cliente.UploadValues("http://130.1.23.131/moviles/post.php", "POST", parametros);
                DisplayAlert("Alerta", "Registro Ingresado", "Cerrar");
                
            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "Cerrar");
            }

            
        }
        private async void btnRegresar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Vista());
        }

        private void btnUpdate_Clicked(object sender, EventArgs e)
        {
            try
            {
                WebClient cliente = new WebClient();
                var parametros = new System.Collections.Specialized.NameValueCollection();
                parametros.Add("codigo", txtCodigo.Text);
                parametros.Add("nombre", txtNombre.Text);
                parametros.Add("apellido", txtApellido.Text);
                parametros.Add("edad", txtEdad.Text);

                cliente.UploadValues("http://130.1.23.131/moviles/post.php", "PUT", parametros);
                DisplayAlert("Alerta", "Registro Actualizado", "Cerrar");
            }
            catch(Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "Cerrar");
            }
        }

        private void btnEliminar_Clicked(object sender, EventArgs e)
        {
            try
            {
                WebClient cliente = new WebClient();
                var parametros = new System.Collections.Specialized.NameValueCollection();
                parametros.Add("codigo", txtCodigo.Text);

                cliente.UploadValues("http://130.1.23.131/moviles/post.php", "DELETE", parametros);
                DisplayAlert("Alerta", "Registro Eliminado", "Cerrar");
            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "Cerrar");
            }
        }
    }
}
