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
using Dominio.DatosPaciente.Entidades;
using Dominio.DatosPaciente.Interfaces.UnidadDeTrabajo;
using Presentacion.PlantillaFormulario.Clases;
using Servicio.Seguridad.Seguridad;
using StructureMap;

namespace Presentacion.DatosPaciente.Vistas.Patologia
{
    public partial class _00516_AgregarPatologiaPaciente : Presentacion.PlantillaFormulario.FormularioABM
    {
        public int PacienteId { get; set; }

        private readonly IUnidadDeTrabajoDatosPaciente datosPacienteUoW
            = ObjectFactory.GetInstance<IUnidadDeTrabajoDatosPaciente>();

        private readonly ISeguridadServicio _seguridadServicio
            = ObjectFactory.GetInstance<ISeguridadServicio>();

        private string _tipoOperacion = string.Empty;

        // Entidades
        private Dominio.DatosPaciente.Entidades.PacientePatologia pacientePatologia;

        public _00516_AgregarPatologiaPaciente()
        {
            InitializeComponent();
        }

        public _00516_AgregarPatologiaPaciente(string tipoOperacion, int? entidadId)
            : base(tipoOperacion, entidadId)
        {
            InitializeComponent();

            this.Name = "_00516_AgregarPatologiaPaciente";
            this.TituloVentana = "Patologia Paciente";
            
            base.UsuarioLogin = Thread.CurrentPrincipal.Identity.Name;

            this._tipoOperacion = tipoOperacion;

            // Color al recibir el Foco
            this.txtObservacion.Enter += new EventHandler(base.control_Enter);
            
            // Color al perder el Foco
            this.txtObservacion.Leave += new EventHandler(base.control_Leave);

            PoblarComboBox(this.cmbPatologia, datosPacienteUoW.PatologiaRepositorio.ObtenerTodo(), "Descripcion", "Id");

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
            pacientePatologia = ObjectFactory.GetInstance<Dominio.DatosPaciente.Entidades.PacientePatologia>();

            if (entidadId.HasValue)
            {
                pacientePatologia = datosPacienteUoW.PacientePatologiaRepositorio.ObtenerPorId(entidadId.Value);

                this.cmbPatologia.SelectedValue = pacientePatologia.PatologiaId;
                this.nudAnio.Value = pacientePatologia.Anio;
                this.nudMes.Value = pacientePatologia.Mes;
                this.txtObservacion.Text = pacientePatologia.Observacion;
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

            if (this.cmbPatologia.Items.Count <= 0)
                _datosObligatorios = true;
        }

        public override bool VerificarSiExisteDatos()
        {
            var patologiaId = Convert.ToInt32(this.cmbPatologia.SelectedValue);
            var anio = Convert.ToInt32(this.nudAnio.Value);
            var mes = Convert.ToInt32(this.nudMes.Value);

            var patologiaPacientes =
                datosPacienteUoW.PacientePatologiaRepositorio.ObtenerPorFiltro(x => x.PacienteId == PacienteId
                                                                                    && x.PatologiaId == patologiaId
                                                                                    && x.Anio == anio
                                                                                    && x.Mes == mes);
            if (patologiaPacientes.Any())
            {
                Mensaje.Mostrar("Los datos cargados ya Existen",
                                Presentacion.PlantillaFormulario.Clases.Constantes.TipoMensaje.Informacion);
                return true;
            }

            return false;
        }
        
        public override void NuevoRegistro()
        {
            try
            {
                pacientePatologia = ObjectFactory.GetInstance<Dominio.DatosPaciente.Entidades.PacientePatologia>();
                
                pacientePatologia.Anio = Convert.ToInt32(this.nudAnio.Value);
                pacientePatologia.Mes = Convert.ToInt32(this.nudMes.Value);
                pacientePatologia.Observacion = this.txtObservacion.Text;
                pacientePatologia.PacienteId = PacienteId;
                pacientePatologia.PatologiaId = Convert.ToInt32(this.cmbPatologia.SelectedValue);
                
                datosPacienteUoW.PacientePatologiaRepositorio.Insertar(pacientePatologia);
                datosPacienteUoW.Commit();

                this.nudAnio.Focus();
            }
            //catch ()
            catch (Exception ex)
            {
                Mensaje.Mostrar(ex, Constantes.TipoMensaje.Error);
            }
        }

        public override void EliminarRegistro()
        {
            try
            {
                datosPacienteUoW.PacientePatologiaRepositorio.Eliminar(pacientePatologia);
                datosPacienteUoW.Commit();
            }
            catch (DataException ex)
            {
                Mensaje.Mostrar("La Patologia seleccionada se encuentra vinculado a otro objeto.", Constantes.TipoMensaje.Error);
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
                pacientePatologia.Anio = Convert.ToInt32(this.nudAnio.Value);
                pacientePatologia.Mes = Convert.ToInt32(this.nudMes.Value);
                pacientePatologia.Observacion = this.txtObservacion.Text;
                pacientePatologia.PacienteId = PacienteId;
                pacientePatologia.PatologiaId = Convert.ToInt32(this.cmbPatologia.SelectedValue);

                datosPacienteUoW.PacientePatologiaRepositorio.Modificar(pacientePatologia);
                datosPacienteUoW.Commit();
            }
            catch (Exception ex)
            {
                Mensaje.Mostrar(ex, Constantes.TipoMensaje.Error);
            }
        }

        private void btnNuevaPatologia_Click(object sender, EventArgs e)
        {
            var form_NuevaPatologia =
                new Presentacion.DatosPaciente.Vistas.Patologia._00514_ABM_Patologia(
                    Presentacion.PlantillaFormulario.Clases.TipoOperacion.Nuevo, null);

            VerificarSiTieneAccesoAlFormulario(form_NuevaPatologia);

            if(form_NuevaPatologia.DialogResult == DialogResult.Yes)
            {
                PoblarComboBox(this.cmbPatologia, datosPacienteUoW.PatologiaRepositorio.ObtenerTodo(), "Descripcion", "Id");
            }
        }
    }
}
