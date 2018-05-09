using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PopUps
{
	public partial class MainPage : ContentPage
	{
        async void MostrarPoUP(object sender, System.EventArgs e) {
            //var respuesta = await DisplayAlert("Mi PopUP", "Desea guardar ?", "Si", "No");
            //if (respuesta)
            //    await DisplayAlert("Exito", "Todo fue guardado con exito", "Ok");

            var respuesta = await DisplayActionSheet("Hola Mundo", "Cancelar", "Eliminar", "Copiar","Email","Item 1", "Item 2", "Item 3");
            await DisplayAlert("Respuesta", respuesta, "OK");

        }

        public MainPage()
		{
			InitializeComponent();
		}
	}
}
