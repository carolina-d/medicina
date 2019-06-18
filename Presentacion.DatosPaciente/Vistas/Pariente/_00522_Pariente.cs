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
using Dominio.DatosPaciente.Interfaces.UnidadDeTrabajo;

namespace Presentacion.DatosPaciente.Vistas.Pariente
{
    public partial class _00522_Pariente : PlantillaFormulario.FormularioConsulta
    {

        private readonly IUnidadDeTrabajoDatosPaciente _uowDatosPaciente;

        public _00522_Pariente(IUnidadDeTrabajoDatosPaciente uowDatosPaciente)
        {
            InitializeComponent();

            this.Name = "_00522_Pariente";
            this.TituloVentana = "Pariente";
            this.Titulo = "Consulta de Parientes";
            this.Leyenda = "Aquí Ud. podrá Agregar, Eliminar o Modificar un Partiente";

            this.ColorTitulo = Color.Black;
            this.ColorLeyenda = Color.Gray;

            this._uowDatosPaciente = uowDatosPaciente;

            this.UsuarioLogin = Thread.CurrentPrincipal.Identity.Name;

            this.EstaModoDiccionario = false;
        }

        public override void FormularioBaseConsulta_Load(object sender, EventArgs e)
        {
            base.FormularioBaseConsulta_Load(sender, e);

            FormatearGrilla();

            this.txtBuscar.Focus();
        }

        private void FormatearGrilla()
        { 
            
        }
    }
}
