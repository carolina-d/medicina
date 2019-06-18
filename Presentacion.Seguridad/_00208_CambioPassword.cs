using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio.Seguridad.Interfaces.UnidadDeTrabajo;
using Servicio.Seguridad.Seguridad;

namespace Presentacion.Seguridad
{
    public partial class _00208_CambioPassword : Presentacion.PlantillaFormulario.FormularioBase
    {
        private readonly IUnidadDeTrabajoSeguridad _uowSeguridad;
        private readonly ISeguridadServicio _seguridadServicio;

        public _00208_CambioPassword(ISeguridadServicio seguridadServicio,
            IUnidadDeTrabajoSeguridad uowSeguridad)
        {
            InitializeComponent();

            this.Name = "_00208_CambioPassword";
            this.TituloVentana = "Cambio de Contraseña";
            this.Titulo = "Contraseña";
            this.Leyenda = "Aquí Ud. podrá cambiar la contraseña.";

            this.ColorTitulo = Color.Black;
            this.ColorLeyenda = Color.Gray;

            this.UsuarioLogin = Thread.CurrentPrincipal.Identity.Name;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
