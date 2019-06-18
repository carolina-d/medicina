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
using Dominio.RecursosHumanos.Entidades;
using Dominio.RecursosHumanos.Interfaces.UnidadDeTrabajo;
using Presentacion.PlantillaFormulario.Clases;
using StructureMap;

namespace Presentacion.RecursosHumanos
{
    public partial class _00105_ABM_Empleado : Presentacion.PlantillaFormulario.FormularioABM
    {
        private readonly IUnidadDeTrabajoRecursosHumanos recursosHumanosUoW
            = ObjectFactory.GetInstance<IUnidadDeTrabajoRecursosHumanos>();

        private string _tipoOperacion = string.Empty;

        // Entidades
        private Empleado empleado;

        public _00105_ABM_Empleado()
        {
            InitializeComponent();
        }

        public _00105_ABM_Empleado(string tipoOperacion, int? entidadId)
            : base(tipoOperacion, entidadId)
        {
            InitializeComponent();
            
            PoblarComboBox(this.cmbEspecialidad, recursosHumanosUoW.EspecialidadRepositorio.ObtenerTodo(), "Descripcion", "Id");

            this.Name = "_00105_ABM_Empleado";
            this.TituloVentana = "Empleado";
            this.Titulo = "ABM de Empleado";
            this.Leyenda = "Aquí Ud podrá dar de Alta, Modificar o Eliminar un Empleado";

            base.UsuarioLogin = Thread.CurrentPrincipal.Identity.Name;

            this._tipoOperacion = tipoOperacion;

            // Cargar evento de validacion para datos Obligatorios
            this.txtApellido.Validated += new EventHandler(base.textBox_Validated);
            this.txtNombre.Validated += new EventHandler(base.textBox_Validated);
            this.txtDni.Validated += new EventHandler(base.textBox_Validated);
            this.txtTelefono.Validated += new EventHandler(base.textBox_Validated);
            
            // Cargar evento de Validacion de Caracteres 
            this.txtApellido.KeyPress += new KeyPressEventHandler(base.textBoxLetrasNumeros_KeyPress);
            this.txtNombre.KeyPress += new KeyPressEventHandler(base.textBoxLetrasNumeros_KeyPress);
            this.txtDni.KeyPress += new KeyPressEventHandler(base.textBoxSoloNumeros_KeyPress);
            this.txtTelefono.KeyPress += new KeyPressEventHandler(base.textBoxSoloNumeros_KeyPress);
            this.txtCelular.KeyPress += new KeyPressEventHandler(base.textBoxSoloNumeros_KeyPress);
            this.txtMatriculaProvincial.KeyPress += new KeyPressEventHandler(base.textBoxSoloNumeros_KeyPress);
            this.txtMatriculaNacional.KeyPress += new KeyPressEventHandler(base.textBoxSoloNumeros_KeyPress);

            // Color al recibir el Foco
            this.txtApellido.Enter += new EventHandler(base.control_Enter);
            this.txtNombre.Enter += new EventHandler(base.control_Enter);
            this.txtDni.Enter += new EventHandler(base.control_Enter);
            this.txtTelefono.Enter += new EventHandler(base.control_Enter);
            this.txtCelular.Enter += new EventHandler(base.control_Enter);
            this.txtMatriculaProvincial.Enter += new EventHandler(base.control_Enter);
            this.txtMatriculaNacional.Enter += new EventHandler(base.control_Enter);
            this.dtpFechaIngreso.Enter += new EventHandler(base.control_Enter);
            this.dtpFechaNacimiento.Enter += new EventHandler(base.control_Enter);
            
            // Color al perder el Foco
            this.txtApellido.Leave += new EventHandler(base.control_Leave);
            this.txtDni.Leave += new EventHandler(base.control_Leave);
            this.txtNombre.Leave += new EventHandler(base.control_Leave);
            this.txtTelefono.Leave += new EventHandler(base.control_Leave);
            this.txtCelular.Leave += new EventHandler(base.control_Leave);
            this.txtMatriculaProvincial.Leave += new EventHandler(base.control_Leave);
            this.txtMatriculaNacional.Leave += new EventHandler(base.control_Leave);
            this.dtpFechaIngreso.Leave += new EventHandler(base.control_Leave);
            this.dtpFechaNacimiento.Leave += new EventHandler(base.control_Leave);

            if (!entidadId.HasValue)
                this.imgFotoEmpleado.Image = ImagenesFormulario.Empleado;

            Inicializador(tipoOperacion, entidadId);
        }

        public override void CargarDatos(int? entidadId)
        {
            // Instancion por medio del Inyector el Objeto Grupo
            empleado = ObjectFactory.GetInstance<Empleado>();

            if (entidadId.HasValue)
            {
                empleado = recursosHumanosUoW.EmpleadoRepositorio.ObtenerPorId(entidadId.Value);

                this.txtApellido.Text = empleado.Apellido;
                this.txtNombre.Text = empleado.Nombre;
                this.txtDni.Text = empleado.Dni;
                this.txtTelefono.Text = empleado.Telefono;
                this.txtCelular.Text = empleado.Celular;
                this.txtMatriculaNacional.Text = empleado.MatriculaNacional;
                this.txtMatriculaProvincial.Text = empleado.MatriculaProvincial;
                this.cmbEspecialidad.SelectedValue = empleado.EspecialidadId;
                this.dtpFechaIngreso.Value = empleado.FechaIngreso;
                this.dtpFechaNacimiento.Value = empleado.FechaNacimiento;
                this.imgFotoEmpleado.Image = Imagen.Convertir_Bytes_Imagen(empleado.FotoEmpleado);

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

            if(this.cmbEspecialidad.Items.Count <= 0)
            {
                _datosObligatorios = false;
            }
        }

        public override bool VerificarSiExisteDatos()
        {
            // obtengo todos los grupos de la BD
            var Empleados = recursosHumanosUoW.EmpleadoRepositorio.ObtenerTodo(string.Empty);

            if (_tipoOperacion == PlantillaFormulario.Clases.TipoOperacion.Nuevo)
            {
                if (Empleados.Any(x => x.Dni.Equals(this.txtDni.Text)))
                {
                    Constantes.Validacion.DatoExistente(this.txtDni, errorProvider, string.Format("El Dni {0} ya Existe", this.txtDni.Text));
                    return true;
                }

                if (Empleados.Any(x => x.MatriculaNacional.Equals(this.txtMatriculaNacional.Text)))
                {
                    Constantes.Validacion.DatoExistente(this.txtMatriculaNacional, errorProvider, string.Format("La Matricula Nacional {0} ya Existe", this.txtMatriculaNacional.Text));
                    return true;
                }

                if (Empleados.Any(x => x.MatriculaProvincial.Equals(this.txtMatriculaProvincial.Text)))
                {
                    Constantes.Validacion.DatoExistente(this.txtMatriculaProvincial, errorProvider, string.Format("La Matricula Provincial {0} ya Existe", this.txtMatriculaProvincial.Text));
                    return true;
                }
            }

            if (_tipoOperacion == PlantillaFormulario.Clases.TipoOperacion.Modificar)
            {
                if (Empleados.Any(x => x.Dni.Equals(this.txtDni.Text) && x.Id != empleado.Id))
                {
                    Constantes.Validacion.DatoExistente(this.txtDni, errorProvider, string.Format("El Dni {0} ya Existe", this.txtDni.Text));
                    return true;
                }

                if (Empleados.Any(x => x.MatriculaNacional.Equals(this.txtMatriculaNacional.Text) && x.Id != empleado.Id))
                {
                    Constantes.Validacion.DatoExistente(this.txtMatriculaNacional, errorProvider, string.Format("La Matricula Nacional {0} ya Existe", this.txtMatriculaNacional.Text));
                    return true;
                }

                if (Empleados.Any(x => x.MatriculaProvincial.Equals(this.txtMatriculaProvincial.Text) && x.Id != empleado.Id))
                {
                    Constantes.Validacion.DatoExistente(this.txtMatriculaProvincial, errorProvider, string.Format("La Matricula Provincial {0} ya Existe", this.txtMatriculaProvincial.Text));
                    return true;
                }
            }

            return false;
        }

        public override void NuevoRegistro()
        {
            try
            {
                empleado = ObjectFactory.GetInstance<Empleado>();

                empleado.Apellido = this.txtApellido.Text;
                empleado.Nombre = this.txtNombre.Text;
                empleado.Dni = this.txtDni.Text;
                empleado.Telefono = this.txtTelefono.Text;
                empleado.MatriculaProvincial = this.txtMatriculaProvincial.Text;
                empleado.MatriculaNacional = this.txtMatriculaNacional.Text;
                empleado.Celular = this.txtCelular.Text;
                empleado.EspecialidadId = Convert.ToInt32(this.cmbEspecialidad.SelectedValue);
                empleado.FotoEmpleado = Imagen.Convertir_Imagen_Bytes(this.imgFotoEmpleado.Image);
                empleado.FechaIngreso = this.dtpFechaIngreso.Value;
                empleado.FechaNacimiento = this.dtpFechaNacimiento.Value;

                recursosHumanosUoW.EmpleadoRepositorio.Insertar(empleado);
                recursosHumanosUoW.Commit();

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
                recursosHumanosUoW.EmpleadoRepositorio.Eliminar(empleado);
                recursosHumanosUoW.Commit();
            }
            catch (DataException ex)
            {
                Mensaje.Mostrar("La Empleado seleccionada se encuentra vinculada a otro objeto.", Constantes.TipoMensaje.Error);
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
                empleado.Apellido = this.txtApellido.Text;
                empleado.Nombre = this.txtNombre.Text;
                empleado.Dni = this.txtDni.Text;
                empleado.Telefono = this.txtTelefono.Text;
                empleado.MatriculaProvincial = this.txtMatriculaProvincial.Text;
                empleado.MatriculaNacional = this.txtMatriculaNacional.Text;
                empleado.Celular = this.txtCelular.Text;
                empleado.EspecialidadId = Convert.ToInt32(this.cmbEspecialidad.SelectedValue);
                empleado.FotoEmpleado = Imagen.Convertir_Imagen_Bytes(this.imgFotoEmpleado.Image);
                empleado.FechaIngreso = this.dtpFechaIngreso.Value;
                empleado.FechaNacimiento = this.dtpFechaNacimiento.Value;

                recursosHumanosUoW.EmpleadoRepositorio.Modificar(empleado);
                recursosHumanosUoW.Commit();
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

                this.imgFotoEmpleado.Image = imagenSeleccionada;
            }
            else
            {
                this.imgFotoEmpleado.Image = ImagenesFormulario.Empleado;
            }
        }
    }
}
