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
using Presentacion.PlantillaFormulario.Clases;
using StructureMap;

namespace Presentacion.DatosPaciente.Vistas.Habito
{
    public partial class _00518_ABM_Habito : Presentacion.PlantillaFormulario.FormularioABM
    {

        private readonly IUnidadDeTrabajoDatosPaciente datosPacienteUoW
            = ObjectFactory.GetInstance<IUnidadDeTrabajoDatosPaciente>();

        private string _tipoOperacion = string.Empty;

        private Dominio.DatosPaciente.Entidades.Habito habito;

        public _00518_ABM_Habito()
        {
            InitializeComponent();
        }

        public _00518_ABM_Habito(string tipoOperacion, int? entidadId)
            : base(tipoOperacion, entidadId)
        {
            InitializeComponent();

            this.Name = "_00518_ABM_Habito";
            this.TituloVentana = "Habito";
            this.Titulo = "ABM de Habitos";
            this.Leyenda = "Aquí Ud podrá dar de Alta, Modificar o Eliminar un Habito";

            base.UsuarioLogin = Thread.CurrentPrincipal.Identity.Name;

            this._tipoOperacion = tipoOperacion;

            // Cargar evento de validacion para datos Obligatorios
            this.txtCodigo.Validated += new EventHandler(base.textBox_Validated);
            this.txtDescripcion.Validated += new EventHandler(base.textBox_Validated);

            // Cargar evento de Validacion de Caracteres 
            this.txtCodigo.KeyPress += new KeyPressEventHandler(base.textBoxSoloNumeros_KeyPress);
            this.txtDescripcion.KeyPress += new KeyPressEventHandler(base.textBoxLetrasNumeros_KeyPress);

            // Color al recibir el Foco
            this.txtCodigo.Enter += new EventHandler(base.control_Enter);
            this.txtDescripcion.Enter += new EventHandler(base.control_Enter);

            // Color al perder el Foco
            this.txtCodigo.Leave += new EventHandler(base.control_Leave);
            this.txtDescripcion.Leave += new EventHandler(base.control_Leave);

            Inicializador(tipoOperacion, entidadId);
        }

        public override void CargarDatos(int? entidadId)
        {
            // Instancion por medio del Inyector el Objeto Grupo
            habito = ObjectFactory.GetInstance<Dominio.DatosPaciente.Entidades.Habito>();

            if (entidadId.HasValue)
            {
                habito = datosPacienteUoW.HabitoRepositorio.ObtenerPorId(entidadId.Value);

                this.txtCodigo.Text = habito.Codigo.ToString();
                this.txtDescripcion.Text = habito.Descripcion;
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
            var habitos = datosPacienteUoW.HabitoRepositorio.ObtenerTodo(string.Empty);

            var codigo = 0;
            int.TryParse(this.txtCodigo.Text, out codigo);

            if (_tipoOperacion == PlantillaFormulario.Clases.TipoOperacion.Nuevo)
            {
                if (habitos.Any(x => x.Codigo.Equals(codigo)))
                {
                    Constantes.Validacion.DatoExistente(this.txtCodigo, errorProvider, string.Format("El Codigo {0} ya Existe", this.txtCodigo.Text));
                    return true;
                }

                if (habitos.Any(x => x.Descripcion.Equals(this.txtDescripcion.Text)))
                {
                    Constantes.Validacion.DatoExistente(this.txtDescripcion, errorProvider, string.Format("La patología {0} ya Existe", this.txtDescripcion.Text));
                    return true;
                }
            }

            if (_tipoOperacion == PlantillaFormulario.Clases.TipoOperacion.Modificar)
            {
                if (habitos.Any(x => x.Codigo.Equals(codigo) && x.Id != habito.Id))
                {
                    Constantes.Validacion.DatoExistente(this.txtCodigo, errorProvider, string.Format("El Codigo {0} ya Existe", this.txtCodigo.Text));
                    return true;
                }

                if (habitos.Any(x => x.Descripcion.Equals(this.txtDescripcion.Text) && x.Id != habito.Id))
                {
                    Constantes.Validacion.DatoExistente(this.txtDescripcion, errorProvider, string.Format("La patología {0} ya Existe", this.txtDescripcion.Text));
                    return true;
                }
            }

            return false;
        }

        public override void NuevoRegistro()
        {
            try
            {
                habito = ObjectFactory.GetInstance<Dominio.DatosPaciente.Entidades.Habito>();

                habito.Codigo = int.Parse(this.txtCodigo.Text);
                habito.Descripcion = this.txtDescripcion.Text;

                datosPacienteUoW.HabitoRepositorio.Insertar(habito);
                datosPacienteUoW.Commit();

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
                datosPacienteUoW.HabitoRepositorio.Eliminar(habito);
                datosPacienteUoW.Commit();
            }
            catch (DataException ex)
            {
                Mensaje.Mostrar("El Habito seleccionado se encuentra vinculado a otro objeto.", Constantes.TipoMensaje.Error);
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
                habito.Codigo = int.Parse(this.txtCodigo.Text);
                habito.Descripcion = this.txtDescripcion.Text;

                datosPacienteUoW.HabitoRepositorio.Modificar(habito);
                datosPacienteUoW.Commit();
            }
            catch (Exception ex)
            {
                Mensaje.Mostrar(ex, Constantes.TipoMensaje.Error);
            }
        }
    }
  }