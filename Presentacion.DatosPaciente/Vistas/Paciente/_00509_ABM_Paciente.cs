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
using Aplicacion.DatosPaciente.Clases;
using Dominio.Comun.Interfaces.UnidadDeTrabajo;
using Dominio.DatosPaciente.Interfaces.UnidadDeTrabajo;
using Presentacion.PlantillaFormulario.Clases;
using Servicio.Seguridad.Seguridad;
using StructureMap;

namespace Presentacion.DatosPaciente.Vistas.Paciente
{
    public partial class _00509_ABM_Paciente : Presentacion.PlantillaFormulario.FormularioABM
    {
        private readonly IUnidadDeTrabajoDatosPaciente datosPacienteUoW
            = ObjectFactory.GetInstance<IUnidadDeTrabajoDatosPaciente>();

        private readonly IUnidadDeTrabajoComun comunUoW
            = ObjectFactory.GetInstance<IUnidadDeTrabajoComun>();

        private readonly ISeguridadServicio _seguridadServicio
            = ObjectFactory.GetInstance<ISeguridadServicio>();

        private string _tipoOperacion = string.Empty;

        // Entidades
        private Dominio.DatosPaciente.Entidades.Paciente paciente;

        public _00509_ABM_Paciente()
        {
            InitializeComponent();
        }

        public _00509_ABM_Paciente(string tipoOperacion, int? entidadId)
            : base(tipoOperacion, entidadId)
        {
            InitializeComponent();

            PoblarComboBox(this.cmbGrupoSanguineo, datosPacienteUoW.GrupoSanguineoRepositorio.ObtenerTodo(), "Descripcion", "Id");
            PoblarComboBox(this.cmbObraSocial, comunUoW.ObraSocialRepositorio.ObtenerTodo(), "Descripcion", "Id");
            PoblarComboBox(this.cmbSexo, comunUoW.SexoRepositorio.ObtenerTodo(), "Descripcion", "Id");

            this.Name = "_00509_ABM_Paciente";
            this.TituloVentana = "Paciente";
            this.Titulo = "ABM de Paciente";
            this.Leyenda = "Aquí Ud podrá dar de Alta, Modificar o Eliminar un Paciente";

            base.UsuarioLogin = Thread.CurrentPrincipal.Identity.Name;

            this._tipoOperacion = tipoOperacion;

            // Cargar evento de validacion para datos Obligatorios
            this.txtApellido.Validated += new EventHandler(base.textBox_Validated);
            this.txtNombre.Validated += new EventHandler(base.textBox_Validated);
            
            // Cargar evento de Validacion de Caracteres 
            this.txtApellido.KeyPress += new KeyPressEventHandler(base.textBoxLetrasNumeros_KeyPress);
            this.txtNombre.KeyPress += new KeyPressEventHandler(base.textBoxLetrasNumeros_KeyPress);
            this.txtDni.KeyPress += new KeyPressEventHandler(base.textBoxSoloNumeros_KeyPress);
            this.txtDireccion.KeyPress += new KeyPressEventHandler(base.textBoxLetrasNumeros_KeyPress);
            this.txtTelefono.KeyPress += new KeyPressEventHandler(base.textBoxSoloNumeros_KeyPress);
            this.txtNroAfiliado.KeyPress += new KeyPressEventHandler(base.textBoxLetrasNumeros_KeyPress);
            this.txtPlanObraSocial.KeyPress += new KeyPressEventHandler(base.textBoxLetrasNumeros_KeyPress);
            this.txtMail.KeyPress += new KeyPressEventHandler(base.textBoxMail_KeyPress);
            
            // Color al recibir el Foco
            this.txtApellido.Enter += new EventHandler(base.control_Enter);
            this.txtNombre.Enter += new EventHandler(base.control_Enter);
            this.txtDni.Enter += new EventHandler(base.control_Enter);
            this.txtTelefono.Enter += new EventHandler(base.control_Enter);
            this.txtDireccion.Enter += new EventHandler(base.control_Enter);
            this.txtNroAfiliado.Enter += new EventHandler(base.control_Enter);
            this.txtPlanObraSocial.Enter += new EventHandler(base.control_Enter);
            this.txtMail.Enter += new EventHandler(base.control_Enter);

            // Color al perder el Foco
            this.txtApellido.Leave += new EventHandler(base.control_Leave);
            this.txtDni.Leave += new EventHandler(base.control_Leave);
            this.txtNombre.Leave += new EventHandler(base.control_Leave);
            this.txtTelefono.Leave += new EventHandler(base.control_Leave);
            this.txtDireccion.Leave += new EventHandler(base.control_Leave);
            this.txtNroAfiliado.Leave += new EventHandler(base.control_Leave);
            this.txtPlanObraSocial.Leave += new EventHandler(base.control_Leave);
            this.txtMail.Leave += new EventHandler(base.control_Leave);

            this.dtpFechaNacimiento.MaxDate = DateTime.Today;

            if (!entidadId.HasValue)
            {
                this.imgFotoPaciente.Image = Presentacion.PlantillaFormulario.Clases.ImagenesFormulario.Empleado;
            }

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
            paciente = ObjectFactory.GetInstance<Dominio.DatosPaciente.Entidades.Paciente>();

            if (cmbGrupoSanguineo.Items.Count > 0)
                this.cmbGrupoSanguineo.SelectedIndex = 3;

            if (entidadId.HasValue)
            {
                paciente = datosPacienteUoW.PacienteRepositorio.ObtenerPorId(entidadId.Value);

                this.txtApellido.Text = paciente.Apellido;
                this.txtNombre.Text = paciente.Nombre;
                this.txtDni.Text = paciente.Dni;
                this.txtTelefono.Text = paciente.Telefono;
                this.txtNroAfiliado.Text = paciente.NumeroAfiliado;
                this.txtPlanObraSocial.Text = paciente.PlanObraSocial;
                this.txtCelular.Text = paciente.Celular;
                this.txtMail.Text = paciente.Mail;
                this.txtDireccion.Text = paciente.Domicilio;
                this.dtpFechaNacimiento.Value = paciente.FechaNacimiento;
                this.dtpFechaNacimiento.MaxDate = DateTime.Today;

                this.imgFotoPaciente.Image = Imagen.Convertir_Bytes_Imagen(paciente.Foto);

                this.cmbGrupoSanguineo.SelectedValue = paciente.GrupoSanguineoId;
                this.cmbObraSocial.SelectedValue = paciente.ObraSocialId;
                this.cmbSexo.SelectedValue = paciente.SexoId;

                this.chkEsDown.Checked = paciente.EsDown;

                this.txtEdad.Text = Edad.Calcular(paciente.FechaNacimiento, DateTime.Today);

                this.txtApellido.Focus();
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

            if(this.cmbGrupoSanguineo.Items.Count <= 0
                || this.cmbObraSocial.Items.Count <= 0
                || this.cmbSexo.Items.Count <= 0)
            {
                _datosObligatorios = false;
            }
        }

        public override bool VerificarSiExisteDatos()
        {
            // obtengo todos los grupos de la BD
            var pacientes = datosPacienteUoW.PacienteRepositorio.ObtenerTodo(string.Empty);

            if (_tipoOperacion == PlantillaFormulario.Clases.TipoOperacion.Nuevo)
            {
                if (pacientes.Any(x => x.Dni.Equals(this.txtDni.Text)))
                {
                    Constantes.Validacion.DatoExistente(this.txtDni, errorProvider, string.Format("El Dni {0} ya Existe", this.txtDni.Text));
                    return true;
                }
            }

            if (_tipoOperacion == PlantillaFormulario.Clases.TipoOperacion.Modificar)
            {
                if (pacientes.Any(x => x.Dni.Equals(this.txtDni.Text) && x.Id != paciente.Id))
                {
                    Constantes.Validacion.DatoExistente(this.txtDni, errorProvider, string.Format("El Dni {0} ya Existe", this.txtDni.Text));
                    return true;
                }
            }

            return false;
        }

        public override void NuevoRegistro()
        {
            try
            {
                paciente = ObjectFactory.GetInstance<Dominio.DatosPaciente.Entidades.Paciente>();

                paciente.Apellido = this.txtApellido.Text;
                paciente.Nombre = this.txtNombre.Text;
                paciente.Dni = this.txtDni.Text;
                paciente.Telefono = this.txtTelefono.Text;
                paciente.NumeroAfiliado = this.txtNroAfiliado.Text;
                paciente.PlanObraSocial = this.txtPlanObraSocial.Text;
                paciente.Domicilio = this.txtDireccion.Text;
                paciente.Celular = this.txtCelular.Text;
                paciente.SexoId = Convert.ToInt32(this.cmbSexo.SelectedValue);
                paciente.ObraSocialId = Convert.ToInt32(this.cmbObraSocial.SelectedValue);
                paciente.GrupoSanguineoId = Convert.ToInt32(this.cmbGrupoSanguineo.SelectedValue);
                paciente.Foto = Imagen.Convertir_Imagen_Bytes(this.imgFotoPaciente.Image);
                paciente.FechaNacimiento = this.dtpFechaNacimiento.Value;
                paciente.Mail = this.txtMail.Text;
                paciente.EsDown = this.chkEsDown.Checked;

                datosPacienteUoW.PacienteRepositorio.Insertar(paciente);
                datosPacienteUoW.Commit();

                this.txtApellido.Focus();
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
                datosPacienteUoW.PacienteRepositorio.Eliminar(paciente);
                datosPacienteUoW.Commit();
            }
            catch (DataException ex)
            {
                Mensaje.Mostrar("La Paciente seleccionado se encuentra vinculado a otro objeto.", Constantes.TipoMensaje.Error);
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
                paciente.Apellido = this.txtApellido.Text;
                paciente.Nombre = this.txtNombre.Text;
                paciente.Dni = this.txtDni.Text;
                paciente.Telefono = this.txtTelefono.Text;
                paciente.NumeroAfiliado = this.txtNroAfiliado.Text;
                paciente.PlanObraSocial = this.txtPlanObraSocial.Text;
                paciente.Domicilio = this.txtDireccion.Text;
                paciente.Celular = this.txtCelular.Text;
                paciente.SexoId = Convert.ToInt32(this.cmbSexo.SelectedValue);
                paciente.ObraSocialId = Convert.ToInt32(this.cmbObraSocial.SelectedValue);
                paciente.GrupoSanguineoId = Convert.ToInt32(this.cmbGrupoSanguineo.SelectedValue);
                paciente.Foto = Imagen.Convertir_Imagen_Bytes(this.imgFotoPaciente.Image);
                paciente.FechaNacimiento = this.dtpFechaNacimiento.Value;
                paciente.Mail = this.txtMail.Text;
                paciente.EsDown = this.chkEsDown.Checked;

                datosPacienteUoW.PacienteRepositorio.Modificar(paciente);
                datosPacienteUoW.Commit();
            }
            catch (Exception ex)
            {
                Mensaje.Mostrar(ex, Constantes.TipoMensaje.Error);
            }
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                var imagenSeleccionada = Image.FromFile(openFile.FileName);

                this.imgFotoPaciente.Image = imagenSeleccionada;
            }
            else
            {
                this.imgFotoPaciente.Image = ImagenesFormulario.Empleado;
            }
        }

        private void btnNuevaObraSocial_Click(object sender, EventArgs e)
        {
            var form_NuevaObraSocial =
                new Presentacion.Comun._00305_ABM_ObraSocial(
                    Presentacion.PlantillaFormulario.Clases.TipoOperacion.Nuevo, null);

            VerificarSiTieneAccesoAlFormulario(form_NuevaObraSocial);
            
            if (form_NuevaObraSocial.DialogResult == DialogResult.Yes)
            {
                PoblarComboBox(this.cmbObraSocial, comunUoW.ObraSocialRepositorio.ObtenerTodo(), "Descripcion", "Id");
            }
        }

        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            this.txtEdad.Text = Edad.Calcular(((DateTimePicker) sender).Value, DateTime.Today);
        }
    }
}
