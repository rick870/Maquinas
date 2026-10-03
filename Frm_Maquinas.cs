using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Maquinas
{
    public partial class Frm_Maquinas : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private string tokenAcceso = "";

        public Frm_Maquinas()
        {
            InitializeComponent();
        }

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Obtener Token si no existe
                if (string.IsNullOrEmpty(tokenAcceso))
                {
                    await ObtenerTokenAsync();
                }

                // 2. Leer datos con validación para evitar errores de formato
                // Si el campo está vacío, pondrá 0 por defecto
                decimal p = 0, an = 0, la = 0;
                decimal.TryParse(Txtpeso.Text, out p);
                decimal.TryParse(Txtancho.Text, out an);
                decimal.TryParse(Txtlargo.Text, out la);

                var maquinaria = new
                {
                    n_serie = txtserie.Text.Trim(),
                    fabricante = Txtfabricante.Text.Trim(),
                    tipo = Txttipo.Text.Trim(),
                    peso = p,
                    ancho = an,
                    largo = la,
                    alto = 0.00m, // Agregado para que Django no de error de campo faltante
                    descripcion = Txtdescripcion.Text.Trim(),
                    estado = "Operativo"
                };

                // 3. Enviar a Django
                await EnviarMaquinariaAsync(maquinaria);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task ObtenerTokenAsync()
        {
            var authData = new { username = "rafael", password = "123456" };
            var content = new StringContent(JsonConvert.SerializeObject(authData), Encoding.UTF8, "application/json");

            // URL base de tu token
            var response = await client.PostAsync("http://127.0.0.1:8000/api/token/", content);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                dynamic json = JsonConvert.DeserializeObject(result);
                tokenAcceso = json.access;
            }
            else
            {
                throw new Exception("Error de autenticación: Revisa que Django esté encendido.");
            }
        }

        private async Task EnviarMaquinariaAsync(object datos)
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", tokenAcceso);
            var json = JsonConvert.SerializeObject(datos);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            // URL CORREGIDA: Según tu urls.py es 'api/maquinaria/'
            var response = await client.PostAsync("http://127.0.0.1:8000/api/maquinaria/", content);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("¡Guardado en la Base de Datos con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            else
            {
                string errorBody = await response.Content.ReadAsStringAsync();
                // Si el error dice "already exists", es porque el N° de Serie ya está en uso
                if (errorBody.Contains("already exists"))
                {
                    MessageBox.Show("El N° de Serie ya existe. Cambia el número e intenta de nuevo.", "Dato Duplicado");
                }
                else
                {
                    MessageBox.Show("Error del servidor: " + errorBody, "Error API");
                }
            }
        }

        private void LimpiarCampos()
        {
            txtserie.Clear();
            Txtfabricante.Clear();
            Txttipo.Clear();
            Txtpeso.Clear();
            Txtancho.Clear();
            Txtlargo.Clear();
            Txtdescripcion.Clear();
            txtserie.Focus();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}