using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio.DatosPaciente.Interfaces.UnidadDeTrabajo;

namespace Presentacion.DatosPaciente.Vistas.Paciente
{
    public partial class _00512_AgregarVacunaPaciente : Presentacion.PlantillaFormulario.FormularioBase
    {
        public string Vacuna
        {
            set { this.txtVacuna.Text = value; }
        }
        public string Dosis
        {
            set { this.txtDosis.Text = value; }
        }
        public string FechaCalendario
        {
            set { this.txtFechaCalendario.Text = value; }
            get { return this.txtFechaCalendario.Text; }
        }

        public int PlanVacunacionId { get; set; }

        private readonly IUnidadDeTrabajoDatosPaciente _uowDatosPaciente;

        public _00512_AgregarVacunaPaciente(IUnidadDeTrabajoDatosPaciente uowDatosPaciente)
        {
            InitializeComponent();

            this.Name = "_00512_AgregarVacunaPaciente";
            this.TituloVentana = "Vacuna";
            
            this.ColorTitulo = Color.Black;
            this.ColorLeyenda = Color.Gray;

            this._uowDatosPaciente = uowDatosPaciente;

            this.btnSalir.Image = Presentacion.PlantillaFormulario.Clases.ImagenesFormulario.Salir;
            this.btnGrabar.Image = Presentacion.PlantillaFormulario.Clases.ImagenesFormulario.Grabar;
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            var planVacunacion = _uowDatosPaciente.PlanVacunacionRepositorio.ObtenerPorId(this.PlanVacunacionId);

            if(planVacunacion == null) throw new Exception("No se encontro el Plan Seleccionado");

            planVacunacion.Observacion = this.txtObservacion.Text;
            planVacunacion.FechaReal = this.dtpFechaAplicacion.Value;
            planVacunacion.Estado = true;

            _uowDatosPaciente.PlanVacunacionRepositorio.Modificar(planVacunacion);
            _uowDatosPaciente.Commit();

            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void _00512_AgregarVacunaPaciente_Load(object sender, EventArgs e)
        {
            this.dtpFechaAplicacion.MinDate = Convert.ToDateTime(FechaCalendario);
            this.dtpFechaAplicacion.MaxDate = DateTime.Today;
        }
    }
}
