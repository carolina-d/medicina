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

namespace Presentacion.DatosPaciente.Vistas.Patologia
{
    public partial class _00514_ABM_Patologia : Presentacion.PlantillaFormulario.FormularioABM
    {
        private readonly IUnidadDeTrabajoDatosPaciente datosPacienteUoW
            = ObjectFactory.GetInstance<IUnidadDeTrabajoDatosPaciente>();

        private string _tipoOperacion = string.Empty;

        // Entidades
        private Dominio.DatosPaciente.Entidades.Patologia patologia;

        public _00514_ABM_Patologia()
        {
            InitializeComponent();
        }

        public _00514_ABM_Patologia(string tipoOperacion, int? entidadId)
            : base(tipoOperacion, entidadId)
        {
            InitializeComponent();

            this.Name = "_00514_ABM_Patologia";
            this.TituloVentana = "Patologia";
            this.Titulo = "ABM de Patologia";
            this.Leyenda = "Aquí Ud podrá dar de Alta, Modificar o Eliminar un Patologia";

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
            patologia = ObjectFactory.GetInstance<Dominio.DatosPaciente.Entidades.Patologia>();

            if (entidadId.HasValue)
            {
                patologia = datosPacienteUoW.PatologiaRepositorio.ObtenerPorId(entidadId.Value);

                this.txtCodigo.Text = patologia.Codigo.ToString();
                this.txtDescripcion.Text = patologia.Descripcion;
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
            var patologias = datosPacienteUoW.PatologiaRepositorio.ObtenerTodo(string.Empty);

            var codigo = 0;
            int.TryParse(this.txtCodigo.Text, out codigo);

            if (_tipoOperacion == PlantillaFormulario.Clases.TipoOperacion.Nuevo)
            {
                if (patologias.Any(x => x.Codigo.Equals(codigo)))
                {
                    Constantes.Validacion.DatoExistente(this.txtCodigo, errorProvider, string.Format("El Codigo {0} ya Existe", this.txtCodigo.Text));
                    return true;
                }

                if (patologias.Any(x => x.Descripcion.Equals(this.txtDescripcion.Text)))
                {
                    Constantes.Validacion.DatoExistente(this.txtDescripcion, errorProvider, string.Format("La patología {0} ya Existe", this.txtDescripcion.Text));
                    return true;
                }
            }

            if (_tipoOperacion == PlantillaFormulario.Clases.TipoOperacion.Modificar)
            {
                if (patologias.Any(x => x.Codigo.Equals(codigo) && x.Id != patologia.Id))
                {
                    Constantes.Validacion.DatoExistente(this.txtCodigo, errorProvider, string.Format("El Codigo {0} ya Existe", this.txtCodigo.Text));
                    return true;
                }

                if (patologias.Any(x => x.Descripcion.Equals(this.txtDescripcion.Text) && x.Id != patologia.Id))
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
                patologia = ObjectFactory.GetInstance<Dominio.DatosPaciente.Entidades.Patologia>();

                patologia.Codigo = int.Parse(this.txtCodigo.Text);
                patologia.Descripcion = this.txtDescripcion.Text;

                datosPacienteUoW.PatologiaRepositorio.Insertar(patologia);
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
                datosPacienteUoW.PatologiaRepositorio.Eliminar(patologia);
                datosPacienteUoW.Commit();
            }
            catch (DataException ex)
            {
                Mensaje.Mostrar("La patologia seleccionada se encuentra vinculada a otro objeto.", Constantes.TipoMensaje.Error);
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
                patologia.Codigo = int.Parse(this.txtCodigo.Text);
                patologia.Descripcion = this.txtDescripcion.Text;

                datosPacienteUoW.PatologiaRepositorio.Modificar(patologia);
                datosPacienteUoW.Commit();
            }
            catch (Exception ex)
            {
                Mensaje.Mostrar(ex, Constantes.TipoMensaje.Error);
            }
        }
    }
}
