using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using test1.Models;
using test1.Services;

namespace test1.Pages
{
    public partial class SocioForm : ComponentBase
    {
        private string tipoFormularioSeleccionado = "Socio";

        private void SeleccionarSocio()
        {
            tipoFormularioSeleccionado = "Socio";
        }

        private void SeleccionarEscuelita()
        {
            tipoFormularioSeleccionado = "Escuelita";
        }


        private Socio socio = new Socio
        {
            Archivos = new Archivos(),
            ContactoEmergencia = new ContactoEmergencia()
        };

        private List<TipoDocumento> tipoDocumento = new();
        private bool mensajeExito = false;  // Para mostrar el mensaje de éxito

        [Inject]
        private SocioService SocioService { get; set; }

        [Inject]
        private TipoDocumentoService TipoDocumentoService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            tipoDocumento = await TipoDocumentoService.GetAllAsync();
        }

        private async Task HandleValidSubmit()
        {
            // Crear el socio
            await SocioService.CrearSocioAsync(socio);

            // Vaciar el formulario
            socio = new Socio
            {
                Archivos = new Archivos(),
                ContactoEmergencia = new ContactoEmergencia()
            };

            // Mostrar mensaje de éxito
            mensajeExito = true;

            // Forzar la actualización de la interfaz de usuario
            StateHasChanged();

            // Ocultar el mensaje después de 3 segundos
            await Task.Delay(3000);
            mensajeExito = false;

            // Forzar la actualización de la interfaz después de ocultar el mensaje
            StateHasChanged();
        }
    }
}
