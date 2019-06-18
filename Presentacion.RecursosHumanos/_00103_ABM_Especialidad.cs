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
    public partial class _00103_ABM_Especialidad : Presentacion.PlantillaFormulario.FormularioABM
    {
        private readonly IUnidadDeTrabajoRecursosHumanos recursosHumanosUoW
            = ObjectFactory.GetInstance<IUnidadDeTrabajoRecursosHumanos>();

        private string _tipoOperacion = string.Empty;

        // Entidades
        private Especialidad especialidad;

        public _00103_ABM_Especialidad()
        {
            InitializeComponent();
        }

        public _00103_ABM_Especialidad(string tipoOperacion, int? entidadId)
            : base(tipoOperacion, entidadId)
        {
            InitializeComponent();

            this.Name = "_00103_ABM_Especialidad";
            this.TituloVentana = "Especialidad";
            this.Titulo = "ABM de Especialidad";
            this.Leyenda = "Aquí Ud podrá dar de Alta, Modificar o Eliminar una Especialidad";

            base.UsuarioLogin = Thread.CurrentPrincipal.Identity.Name;

            this._tipoOperacion = tipoOperacion;

            // Cargar evento de validacion para datos Obligatorios
            this.txtDescripcion.Validated += new EventHandler(base.textBox_Validated);
            this.txtCodigo.Validated += new EventHandler(base.textBox_Validated);

            // Cargar evento de Validacion de Caracteres 
            this.txtDescripcion.KeyPress += new KeyPressEventHandler(base.textBoxLetrasNumeros_KeyPress);
            this.txtCodigo.KeyPress += new KeyPressEventHandler(base.textBoxSoloNumeros_KeyPress);

            // Color al recibir el Foco
            this.txtDescripcion.Enter += new EventHandler(base.control_Enter);
            this.txtCodigo.Enter += new EventHandler(base.control_Enter);

            // Color al perder el Foco
            this.txtDescripcion.Leave += new EventHandler(base.control_Leave);
            this.txtCodigo.Leave += new EventHandler(base.control_Leave);
            
            Inicializador(tipoOperacion, entidadId);
        }

        public override void CargarDatos(int? entidadId)
        {
            // Instancion por medio del Inyector el Objeto Grupo
            especialidad = ObjectFactory.GetInstance<Especialidad>();

            if (entidadId.HasValue)
            {
                especialidad = recursosHumanosUoW.EspecialidadRepositorio.ObtenerPorId(entidadId.Value);

                this.txtDescripcion.Text = especialidad.Descripcion;
                this.txtCodigo.Text = especialidad.Codigo.ToString();
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
            var especialidades = recursosHumanosUoW.EspecialidadRepositorio.ObtenerTodo(string.Empty);

            var codigo = 0;
            int.TryParse(this.txtCodigo.Text, out codigo);

            if (_tipoOperacion == PlantillaFormulario.Clases.TipoOperacion.Nuevo)
            {
                if (especialidades.Any(x => x.Descripcion.Equals(this.txtDescripcion.Text)))
                {
                    Constantes.Validacion.DatoExistente(this.txtDescripcion, errorProvider, string.Format("La especialidad {0} ya Existe", this.txtDescripcion.Text));
                    return true;
                }

                if (especialidades.Any(x => x.Codigo.Equals(codigo)))
                {
                    Constantes.Validacion.DatoExistente(this.txtCodigo, errorProvider, string.Format("El Código {0} ya Existe", this.txtCodigo.Text));
                    return true;
                }
            }

            if (_tipoOperacion == PlantillaFormulario.Clases.TipoOperacion.Modificar)
            {
                if (especialidades.Any(x => x.Descripcion.Equals(this.txtDescripcion.Text) && x.Id != especialidad.Id))
                {
                    Constantes.Validacion.DatoExistente(this.txtDescripcion, errorProvider, string.Format("La especialidad {0} ya Existe", this.txtDescripcion.Text));
                    return true;
                }

                if (especialidades.Any(x => x.Codigo.Equals(codigo) && x.Id != especialidad.Id))
                {
                    Constantes.Validacion.DatoExistente(this.txtCodigo, errorProvider, string.Format("El Código {0} ya Existe", this.txtCodigo.Text));
                    return true;
                }
            }

            return false;
        }

        public override void NuevoRegistro()
        {
            try
            {
                especialidad = ObjectFactory.GetInstance<Especialidad>();

                especialidad.Descripcion = this.txtDescripcion.Text;
                especialidad.Codigo = int.Parse(this.txtCodigo.Text);

                recursosHumanosUoW.EspecialidadRepositorio.Insertar(especialidad);
                recursosHumanosUoW.Commit();

                this.txtCodigo.Focus();
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
                recursosHumanosUoW.EspecialidadRepositorio.Eliminar(especialidad);
                recursosHumanosUoW.Commit();
            }
            catch (DataException ex)
            {
                Mensaje.Mostrar("La Especialidad seleccionada se encuentra vinculada a otro objeto.", Constantes.TipoMensaje.Error);
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
                especialidad.Descripcion = this.txtDescripcion.Text;
                especialidad.Codigo = int.Parse(this.txtCodigo.Text);

                recursosHumanosUoW.EspecialidadRepositorio.Modificar(especialidad);
                recursosHumanosUoW.Commit();
            }
            catch (Exception ex)
            {
                Mensaje.Mostrar(ex, Constantes.TipoMensaje.Error);
            }
        }
    }
}
