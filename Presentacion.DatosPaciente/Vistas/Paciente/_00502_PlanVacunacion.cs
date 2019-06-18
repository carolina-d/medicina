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
using Aplicacion.DatosPaciente.DTOs;
using Dominio.DatosPaciente.Interfaces.UnidadDeTrabajo;
using Presentacion.PlantillaFormulario.Clases;
using Servicio.DatosPaciente.PlanVacunacion;
using StructureMap;

namespace Presentacion.DatosPaciente.Vistas.Paciente
{
    public partial class _00502_PlanVacunacion : Presentacion.PlantillaFormulario.FormularioBase
    {
        public int PacienteId { get; set; }

        private readonly IUnidadDeTrabajoDatosPaciente _uowDatosPaciente;
        private readonly IPlanVacunacionServicio _planServicio;

        public _00502_PlanVacunacion(IUnidadDeTrabajoDatosPaciente uowDatosPaciente,
            IPlanVacunacionServicio planServicio)
        {
            InitializeComponent();

            this.Name = "_00502_PlanVacunacion";
            this.TituloVentana = "Plan de Vacunación";
            
            base.UsuarioLogin = Thread.CurrentPrincipal.Identity.Name;

            this._uowDatosPaciente = uowDatosPaciente;
            this._planServicio = planServicio;

            // Cargar evento de Validacion de Caracteres 
            this.txtBuscar.KeyPress += new KeyPressEventHandler(base.textBoxLetrasNumeros_KeyPress);

            // Color al recibir el Foco
            this.txtBuscar.Enter += new EventHandler(base.control_Enter);

            // Color al perder el Foco
            this.txtBuscar.Leave += new EventHandler(base.control_Leave);

            this.btnSalir.Image = Presentacion.PlantillaFormulario.Clases.ImagenesFormulario.Salir;
        }

        private void ActualizarDatos(string textoBuscar)
        {
            var resultado =
                _uowDatosPaciente.PlanVacunacionRepositorio.ObtenerPorFiltro(x => x.PacienteId == PacienteId
                && x.CalendarioVacunacion.Vacuna.Nombre.Contains(textoBuscar), "CalendarioVacunacion, CalendarioVacunacion.Vacuna, CalendarioVacunacion.Dosis")
                .Select(x=> new PlanVacunacionDTO
                                {
                                    Id = x.Id,
                                    FechaReal = x.FechaReal.HasValue ? x.FechaReal.Value.ToShortDateString() : string.Empty,
                                    FechaTentativa = x.FechaPlan.ToShortDateString(),
                                    Estado = x.Estado ? "SI" : "NO",
                                    Vacuna = x.CalendarioVacunacion.Vacuna.Nombre,
                                    Dosis = x.CalendarioVacunacion.Dosis.Descripcion
                                });

            this.dgvPlan.DataSource = resultado.ToList();

            FormatearGrilla();
        }

        private void FormatearGrilla()
        {
            this.dgvPlan.Columns["Id"].Visible = false;

            this.dgvPlan.Columns["Vacuna"].Visible = true;
            this.dgvPlan.Columns["Vacuna"].HeaderText = "Vacuna";
            this.dgvPlan.Columns["Vacuna"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvPlan.Columns["Vacuna"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dgvPlan.Columns["Dosis"].Visible = true;
            this.dgvPlan.Columns["Dosis"].HeaderText = "Dósis";
            this.dgvPlan.Columns["Dosis"].Width = 150;
            this.dgvPlan.Columns["Dosis"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvPlan.Columns["Dosis"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dgvPlan.Columns["FechaReal"].Visible = true;
            this.dgvPlan.Columns["FechaReal"].HeaderText = "Fecha Real";
            this.dgvPlan.Columns["FechaReal"].Width = 85;
            this.dgvPlan.Columns["FechaReal"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvPlan.Columns["FechaReal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dgvPlan.Columns["FechaTentativa"].Visible = true;
            this.dgvPlan.Columns["FechaTentativa"].HeaderText = "Fecha Plan";
            this.dgvPlan.Columns["FechaTentativa"].Width = 85;
            this.dgvPlan.Columns["FechaTentativa"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvPlan.Columns["FechaTentativa"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dgvPlan.Columns["Estado"].Visible = true;
            this.dgvPlan.Columns["Estado"].HeaderText = "Estado";
            this.dgvPlan.Columns["Estado"].Width = 70;
            this.dgvPlan.Columns["Estado"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvPlan.Columns["Estado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerarPlan_Click(object sender, EventArgs e)
        {
            this._planServicio.GenerarPlanDeVacunacionParaUnPaciente(PacienteId);
            ActualizarDatos(string.Empty);
        }

        private void _00502_PlanVacunacion_Load(object sender, EventArgs e)
        {
            ActualizarDatos(string.Empty);
        }

        private void dgvPlan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
                if (dgvPlan["Estado", dgvPlan.CurrentRow.Index].Value.ToString() == "NO")
                {
                    var form_AgregarVacuna =
                        ObjectFactory.GetInstance
                            <Presentacion.DatosPaciente.Vistas.Paciente._00512_AgregarVacunaPaciente>();

                    form_AgregarVacuna.Titulo = this.Titulo;
                    form_AgregarVacuna.Leyenda = this.Leyenda;
                    form_AgregarVacuna.imgTitulo.Image = this.imgTitulo.Image;

                    form_AgregarVacuna.Vacuna = dgvPlan["Vacuna", dgvPlan.CurrentRow.Index].Value.ToString();
                    form_AgregarVacuna.Dosis = dgvPlan["Dosis", dgvPlan.CurrentRow.Index].Value.ToString();
                    form_AgregarVacuna.FechaCalendario = dgvPlan["FechaTentativa", dgvPlan.CurrentRow.Index].Value.ToString();

                    form_AgregarVacuna.PlanVacunacionId =
                        Convert.ToInt32(dgvPlan["Id", dgvPlan.CurrentRow.Index].Value.ToString());

                    if(form_AgregarVacuna.ShowDialog() == DialogResult.Yes)
                    {
                        ActualizarDatos(string.Empty);
                    }
                }
                else
                {
                    Mensaje.Mostrar("La vacuna ya fue Cargada",
                                    Presentacion.PlantillaFormulario.Clases.Constantes.TipoMensaje.Informacion);
                }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ActualizarDatos(this.txtBuscar.Text);
        }
    }
}
