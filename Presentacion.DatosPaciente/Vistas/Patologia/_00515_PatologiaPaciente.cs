using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aplicacion.DatosPaciente.DTOs;
using Dominio.DatosPaciente.Interfaces.UnidadDeTrabajo;
using Presentacion.PlantillaFormulario.Clases;
using Servicio.Seguridad.Seguridad;
using StructureMap;

namespace Presentacion.DatosPaciente.Vistas.Patologia
{
    public partial class _00515_PatologiaPaciente : Presentacion.PlantillaFormulario.FormularioConsulta
    {
        public int PacienteId { get; set; }

        private readonly IUnidadDeTrabajoDatosPaciente _uowDatosPaciente;
        private readonly ISeguridadServicio _seguridadServicio;

        public _00515_PatologiaPaciente(IUnidadDeTrabajoDatosPaciente uowDatosPaciente,
                                        ISeguridadServicio seguridadServicio)
        {
            InitializeComponent();

            this._uowDatosPaciente = uowDatosPaciente;
            this._seguridadServicio = seguridadServicio;

            this.Name = "_00515_PatologiaPaciente";
            this.TituloVentana = "Patología del Paciente";

            this.ColorTitulo = Color.Black;
            this.ColorLeyenda = Color.Gray;

            // Cargar evento de Validacion de Caracteres 
            this.txtBuscar.KeyPress += new KeyPressEventHandler(base.textBoxLetrasNumeros_KeyPress);

            // Color al recibir el Foco
            this.txtBuscar.Enter += new EventHandler(base.control_Enter);

            // Color al perder el Foco
            this.txtBuscar.Leave += new EventHandler(base.control_Leave);

            this.btnSalir.Image = Presentacion.PlantillaFormulario.Clases.ImagenesFormulario.Salir;
        }

        private void VerificarSiTieneAccesoAlFormulario(Form formulario)
        {
            if (_seguridadServicio.VerificarAccesoFormulario(formulario.Name))
            {
                formulario.ShowDialog();
            }
            else
            {
                Mensaje.Mostrar("Acceso Denegado",
                                Presentacion.PlantillaFormulario.Clases.Constantes.TipoMensaje.Informacion);
            }
        }

        private void FormatearGrilla()
        {
            this.dgvBusqueda.Columns["Id"].Visible = false;
            this.dgvBusqueda.Columns["PacienteId"].Visible = false;
            this.dgvBusqueda.Columns["PatologiaId"].Visible = false;
            this.dgvBusqueda.Columns["Observacion"].Visible = false;

            this.dgvBusqueda.Columns["Patologia"].Visible = true;
            this.dgvBusqueda.Columns["Patologia"].HeaderText = "Patologia";
            this.dgvBusqueda.Columns["Patologia"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvBusqueda.Columns["Patologia"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dgvBusqueda.Columns["Anio"].Visible = true;
            this.dgvBusqueda.Columns["Anio"].HeaderText = "Año";
            this.dgvBusqueda.Columns["Anio"].Width = 100;
            this.dgvBusqueda.Columns["Anio"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvBusqueda.Columns["Anio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dgvBusqueda.Columns["Mes"].Visible = true;
            this.dgvBusqueda.Columns["Mes"].HeaderText = "Mes";
            this.dgvBusqueda.Columns["Mes"].Width = 100;
            this.dgvBusqueda.Columns["Mes"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvBusqueda.Columns["Mes"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        public override void FormularioBaseConsulta_Load(object sender, EventArgs e)
        {
            base.FormularioBaseConsulta_Load(sender, e);

            FormatearGrilla();

            this.txtBuscar.Focus();
        }

        public override void ActualizarDatosGrilla(string textoBuscar)
        {
            var resultado = _uowDatosPaciente.PacientePatologiaRepositorio.ObtenerPorFiltro(
                x => x.PacienteId == PacienteId
                && x.Patologia.Descripcion.Contains(textoBuscar), "Patologia")
                .Select(x => new PacientePatologiaDTO
                                 {
                                     Id = x.Id,
                                     Anio = x.Anio,
                                     Mes = x.Mes,
                                     PacienteId = x.PacienteId,
                                     PatologiaId = x.PatologiaId,
                                     Patologia = x.Patologia.Descripcion,
                                     Observacion = x.Observacion
                                 }).ToList();

            this.dgvBusqueda.DataSource = resultado;

            FormatearGrilla();
        }

        public override void btnNuevo_Click(object sender, EventArgs e)
        {
            var form_ABM_Nuevo = new _00516_AgregarPatologiaPaciente(PlantillaFormulario.Clases.TipoOperacion.Nuevo,
                                                                     null);

            form_ABM_Nuevo.Titulo = this.Titulo;
            form_ABM_Nuevo.Leyenda = this.Leyenda;
            form_ABM_Nuevo.imgTitulo.Image = this.imgTitulo.Image;
            form_ABM_Nuevo.PacienteId = PacienteId;
            VerificarSiTieneAccesoAlFormulario(form_ABM_Nuevo);

            if (form_ABM_Nuevo.DialogResult == DialogResult.Yes)
            {
                ActualizarDatosGrilla(string.Empty);
            }
        }

        public override void btnModificar_Click(object sender, EventArgs e)
        {
            var form_ABM_Modificar =
                new _00516_AgregarPatologiaPaciente(PlantillaFormulario.Clases.TipoOperacion.Modificar, base.EntidadId);

            form_ABM_Modificar.Titulo = this.Titulo;
            form_ABM_Modificar.Leyenda = this.Leyenda;
            form_ABM_Modificar.imgTitulo.Image = this.imgTitulo.Image;
            form_ABM_Modificar.PacienteId = PacienteId;
            VerificarSiTieneAccesoAlFormulario(form_ABM_Modificar);

            if (form_ABM_Modificar.DialogResult == DialogResult.Yes)
            {
                ActualizarDatosGrilla(string.Empty);
            }
        }

        public override void btnEliminar_Click(object sender, EventArgs e)
        {
            base.btnEliminar_Click(sender, e);

            var form_ABM_Eliminar =
                new _00516_AgregarPatologiaPaciente(PlantillaFormulario.Clases.TipoOperacion.Eliminar, base.EntidadId);

            form_ABM_Eliminar.Titulo = this.Titulo;
            form_ABM_Eliminar.Leyenda = this.Leyenda;
            form_ABM_Eliminar.imgTitulo.Image = this.imgTitulo.Image;
            form_ABM_Eliminar.PacienteId = PacienteId;
            VerificarSiTieneAccesoAlFormulario(form_ABM_Eliminar);

            if (form_ABM_Eliminar.DialogResult == DialogResult.Yes)
            {
                ActualizarDatosGrilla(string.Empty);
            }
        }
    }
}
