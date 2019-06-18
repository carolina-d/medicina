using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio.DatosPaciente.Interfaces.UnidadDeTrabajo;
using Dominio.Seguridad.Interfaces.UnidadDeTrabajo;
using Presentacion.PlantillaFormulario.Clases;
using Servicio.Seguridad.Seguridad;
using StructureMap;

namespace Presentacion.DatosPaciente.Vistas.Vacunacion
{
    public partial class _00505_ABM_CalendarioVacunacion : Presentacion.PlantillaFormulario.FormularioABM
    {
        private readonly IUnidadDeTrabajoDatosPaciente _datosPacienteUoW
            = ObjectFactory.GetInstance<IUnidadDeTrabajoDatosPaciente>();

        private readonly ISeguridadServicio _seguridadServicio
            = ObjectFactory.GetInstance<ISeguridadServicio>();

        private string _tipoOperacion = string.Empty;

        // Entidades
        private Dominio.DatosPaciente.Entidades.CalendarioVacunacion calendarioVacunacion;

        public _00505_ABM_CalendarioVacunacion()
        {
            InitializeComponent();
        }

        public _00505_ABM_CalendarioVacunacion(string tipoOperacion, int? entidadId)
            : base(tipoOperacion, entidadId)
        {
            InitializeComponent();

            this.Name = "_00505_ABM_CalendarioVacunacion";
            this.TituloVentana = "Calendario de Vacunación";
            this.Titulo = "ABM de Calendario de Vacunación";
            this.Leyenda = "Aquí Ud podrá dar de Alta, Modificar o Eliminar un Calendario de Vacunación";

            base.UsuarioLogin = Thread.CurrentPrincipal.Identity.Name;

            this._tipoOperacion = tipoOperacion;

            // Color al recibir el Foco
            this.nudAnio.Enter += new EventHandler(base.control_Enter);
            this.nudDia.Enter += new EventHandler(base.control_Enter);
            this.nudMes.Enter += new EventHandler(base.control_Enter);

            // Color al perder el Foco
            this.nudAnio.Leave += new EventHandler(base.control_Leave);
            this.nudDia.Leave += new EventHandler(base.control_Leave);
            this.nudMes.Leave += new EventHandler(base.control_Leave);

            PoblarComboBox(this.cmbVacuna, _datosPacienteUoW.VacunaRepositorio.ObtenerTodo(), "Nombre", "Id");
            PoblarComboBox(this.cmbDosis, _datosPacienteUoW.DosisRepositorio.ObtenerTodo(), "Descripcion", "Id");

            Inicializador(tipoOperacion, entidadId);
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

        public override void CargarDatos(int? entidadId)
        {
            

            // Instancion por medio del Inyector el Objeto Grupo
            calendarioVacunacion = ObjectFactory.GetInstance<Dominio.DatosPaciente.Entidades.CalendarioVacunacion>();

            if (entidadId.HasValue)
            {
                calendarioVacunacion = _datosPacienteUoW.CalendarioVacunacionRepositorio.ObtenerPorId(entidadId.Value);

                this.nudAnio.Value = calendarioVacunacion.Anio;
                this.nudMes.Value = calendarioVacunacion.Mes;
                this.nudDia.Value = calendarioVacunacion.Dia;
                this.cmbVacuna.SelectedValue = calendarioVacunacion.VacunaId;
                this.cmbDosis.SelectedValue = calendarioVacunacion.DosisId;
                this.chkEsObligatoria.Checked = calendarioVacunacion.Obligatoria;
            }
            else
            {
                Mensaje.Mostrar(new Exception("Error al cargar los Datos"), Constantes.TipoMensaje.Error);
            }
        }

        public override void VerificarDatosObligatorios()
        {
            base.VerificarDatosObligatorios();
            this.ValidateChildren();
        }

        public override bool VerificarSiExisteDatos()
        {
            // obtengo todos los grupos de la BD
            var CalendarioVacunaciones = _datosPacienteUoW.CalendarioVacunacionRepositorio.ObtenerTodo(string.Empty);

            if (this.cmbVacuna.Items.Count <= 0)
            {
                Mensaje.Mostrar("No hay vacunas cargadas", Constantes.TipoMensaje.Informacion);
                return false;
            }

            if (this.cmbDosis.Items.Count <= 0)
            {
                Mensaje.Mostrar("No hay Dosis vacunas cargadas", Constantes.TipoMensaje.Informacion);
                return false;
            }

            var vacunaId = Convert.ToInt32(this.cmbVacuna.SelectedValue);
            var dosisId = Convert.ToInt32(this.cmbDosis.SelectedValue);

            if (_tipoOperacion == PlantillaFormulario.Clases.TipoOperacion.Nuevo)
            {
                if (CalendarioVacunaciones.Any(x => x.Anio.Equals(this.nudAnio.Value)
                                                    && x.Mes.Equals(this.nudMes.Value)
                                                    && x.Dia.Equals(this.nudDia.Value)
                                                    && x.VacunaId.Equals(vacunaId)
                                                    && x.DosisId.Equals(dosisId)))
                {
                    Mensaje.Mostrar("La combinacion de datos ya Existe", Constantes.TipoMensaje.Informacion);
                    return false;
                }
            }

            if (_tipoOperacion == PlantillaFormulario.Clases.TipoOperacion.Modificar)
            {
                if (CalendarioVacunaciones.Any(x => x.Anio.Equals(this.nudAnio.Value)
                                                    && x.Mes.Equals(this.nudMes.Value)
                                                    && x.Dia.Equals(this.nudDia.Value)
                                                    && x.VacunaId.Equals(vacunaId)
                                                    && x.DosisId.Equals(dosisId)
                                                    && x.Id != calendarioVacunacion.Id))
                {
                    Mensaje.Mostrar("La combinacion de datos ya Existe", Constantes.TipoMensaje.Informacion);
                    return false;
                }
            }

            return false;
        }

        public override void NuevoRegistro()
        {
            try
            {
                calendarioVacunacion = ObjectFactory.GetInstance<Dominio.DatosPaciente.Entidades.CalendarioVacunacion>();

                calendarioVacunacion.Anio = Convert.ToInt32(this.nudAnio.Value);
                calendarioVacunacion.Mes = Convert.ToInt32(this.nudMes.Value);
                calendarioVacunacion.Dia = Convert.ToInt32(this.nudDia.Value);

                calendarioVacunacion.VacunaId = Convert.ToInt32(this.cmbVacuna.SelectedValue);
                calendarioVacunacion.DosisId = Convert.ToInt32(this.cmbDosis.SelectedValue);
                calendarioVacunacion.Obligatoria = this.chkEsObligatoria.Checked;

                _datosPacienteUoW.CalendarioVacunacionRepositorio.Insertar(calendarioVacunacion);
                _datosPacienteUoW.Commit();

                this.cmbVacuna.Focus();
            }   
            catch(DbEntityValidationException validationException)
            {
                var mensajeDeError = validationException.EntityValidationErrors
                    .SelectMany(x => x.ValidationErrors)
                    .Select(x => x.PropertyName);

            }
            catch (Exception ex)
            {
                Mensaje.Mostrar(ex, Constantes.TipoMensaje.Error);
            }
        }

        public override void EliminarRegistro()
        {
            try
            {
                _datosPacienteUoW.CalendarioVacunacionRepositorio.Eliminar(calendarioVacunacion);
                _datosPacienteUoW.Commit();
            }
            catch (DataException ex)
            {
                Mensaje.Mostrar("El Calendario de Vacunacion seleccionado se encuentra vinculado a otro objeto.",
                                Constantes.TipoMensaje.Error);
            }
            catch (Exception ex)
            {
                Mensaje.Mostrar(ex, Constantes.TipoMensaje.Error);
            }
        }

        public override void ModificarRegistro()
        {
            try
            {
                calendarioVacunacion.Anio = (int) this.nudAnio.Value;
                calendarioVacunacion.Mes = (int) this.nudMes.Value;
                calendarioVacunacion.Dia = (int) this.nudDia.Value;
                calendarioVacunacion.VacunaId = Convert.ToInt32(this.cmbVacuna.SelectedValue);
                calendarioVacunacion.DosisId = Convert.ToInt32(this.cmbDosis.SelectedValue);
                calendarioVacunacion.Obligatoria = this.chkEsObligatoria.Checked;

                _datosPacienteUoW.CalendarioVacunacionRepositorio.Modificar(calendarioVacunacion);
                _datosPacienteUoW.Commit();
            }
            catch (Exception ex)
            {
                Mensaje.Mostrar(ex, Constantes.TipoMensaje.Error);
            }
        }

        private void btnNuevaVacuna_Click(object sender, EventArgs e)
        {
            var form_NuevaVacuna =
                new Presentacion.DatosPaciente.Vistas.Vacunacion._00501_ABM_Vacuna(
                    Presentacion.PlantillaFormulario.Clases.TipoOperacion.Nuevo, null);

            VerificarSiTieneAccesoAlFormulario(form_NuevaVacuna);

            if (form_NuevaVacuna.DialogResult == DialogResult.Yes)
            {
                PoblarComboBox(this.cmbVacuna, _datosPacienteUoW.VacunaRepositorio.ObtenerTodo(), "Nombre", "Id");
            }
        }

        private void btnNuevaDosis_Click(object sender, EventArgs e)
        {
            var form_NuevaDosis =
                new Presentacion.DatosPaciente.Vistas.Vacunacion._00507_ABM_DosisVacuna(
                    Presentacion.PlantillaFormulario.Clases.TipoOperacion.Nuevo, null);

            VerificarSiTieneAccesoAlFormulario(form_NuevaDosis);

            if (form_NuevaDosis.DialogResult == DialogResult.Yes)
            {
                PoblarComboBox(this.cmbDosis, _datosPacienteUoW.DosisRepositorio.ObtenerTodo(), "Descripcion", "Id");
            }
        }
    }
}
