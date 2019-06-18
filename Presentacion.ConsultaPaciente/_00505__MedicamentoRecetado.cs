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
using Aplicacion.ConsultaPaciente.DTO;
using Dominio.ConsultaPaciente.Interfaces.IUnidadDeTrabajo;

namespace Presentacion.ConsultaPaciente
{
    public partial class _00505__MedicamentoRecetado : Presentacion.PlantillaFormulario.FormularioConsulta
    {
        private readonly IUnidadDeTrabajoConsultaPaciente _uowConsultaPaciente;

        public _00505__MedicamentoRecetado(IUnidadDeTrabajoConsultaPaciente uowConsultaPaciente)
        {
            InitializeComponent();

            this.Name = "_00505__MedicamentoRecetado";
            this.TituloVentana = "Medicamento Recetado";
            this.Titulo = "Medicamento Recetado";
            this.Leyenda = "Aquí Ud. podrá Agregar, Eliminar o Modificar un Medicamento Recetado y Consultar sus Datos";
            this.ColorTitulo = Color.Black;
            this.ColorLeyenda = Color.Gray;

            this._uowConsultaPaciente = uowConsultaPaciente;

            this.EstaModoDiccionario = false;

            base.UsuarioLogin = Thread.CurrentPrincipal.Identity.Name;
        }

        public override void FormularioBaseConsulta_Load(object sender, EventArgs e)
        {
            base.FormularioBaseConsulta_Load(sender, e);

            this.txtBuscar.Focus();
        }

        public override void ActualizarDatosGrilla(string textoBuscar)
        {
            var resultado = _uowConsultaPaciente.MedicamentosRecetadosRepositorio.ObtenerPorFiltro(x => x.Indicaciones.Contains(textoBuscar)
                || x.NombreMedicamento.Contains(textoBuscar), "MedicamentoRecetado")
                .Select(x => new MedicRecetadoDTO
                {
                    Id = x.Id,
                    NombreMedicamento = x.NombreMedicamento,
                    VademecumId = x.VademecumId,
                    Indicaciones = x.Indicaciones,
                    ConsultaId = x.ConsultaId

                }).ToList();
            this.dgvBusqueda.DataSource = resultado;
        }

        public override void btnNuevo_Click(object sender, EventArgs e)
        {
            if (new _00503_ABM_MedicamentoRecetado(PlantillaFormulario.Clases.TipoOperacion.Nuevo, null).ShowDialog() == DialogResult.Yes)
            {
                ActualizarDatosGrilla(string.Empty);
            }
        }

        public override void btnModificar_Click(object sender, EventArgs e)
        {
            if (new _00503_ABM_MedicamentoRecetado(PlantillaFormulario.Clases.TipoOperacion.Modificar, base.EntidadId).ShowDialog() == DialogResult.Yes)
            {
                ActualizarDatosGrilla(string.Empty);
            }
        }

        public override void btnEliminar_Click(object sender, EventArgs e)
        {
            if (new _00503_ABM_MedicamentoRecetado(PlantillaFormulario.Clases.TipoOperacion.Eliminar, base.EntidadId).ShowDialog() == DialogResult.Yes)
            {
                ActualizarDatosGrilla(string.Empty);                
            }
        }

    }
}
