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
using Dominio.Comun.Interfaces.UnidadDeTrabajo;
using Presentacion.PlantillaFormulario.Clases;
using StructureMap;

namespace Presentacion.Comun
{
    public partial class _00303_ABM_EstadoCivil : PlantillaFormulario.FormularioABM
    {
        private readonly IUnidadDeTrabajoComun comunUoW
            = ObjectFactory.GetInstance<IUnidadDeTrabajoComun>();

        private string _tipoOperacion = string.Empty;

        // Entidades
        private Dominio.Comun.Entidades.EstadoCivil estadoCivil;

        public _00303_ABM_EstadoCivil()
        {
            InitializeComponent();
        }

        public _00303_ABM_EstadoCivil(string tipoOperacion, int? entidadId)
            : base(tipoOperacion, entidadId)
        {
            InitializeComponent();

            this.Name = "_00303_ABM_EstadoCivil";
            this.TituloVentana = "Estado Civil";
            this.Titulo = "ABM de Estado Civil";
            this.Leyenda = "Aquí Ud podrá dar de Alta, Modificar o Eliminar un Estado Civil";

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
            estadoCivil = ObjectFactory.GetInstance<Dominio.Comun.Entidades.EstadoCivil>();

            if (entidadId.HasValue)
            {
                estadoCivil = comunUoW.EstadoCivilRepositorio.ObtenerPorId(entidadId.Value);

                this.txtDescripcion.Text = estadoCivil.Descripcion;
                this.txtCodigo.Text = estadoCivil.Codigo.ToString();
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
            var EstadoCivils = comunUoW.EstadoCivilRepositorio.ObtenerTodo(string.Empty);

            var codigo = 0;
            int.TryParse(this.txtCodigo.Text, out codigo);

            if (_tipoOperacion == PlantillaFormulario.Clases.TipoOperacion.Nuevo)
            {
                if (EstadoCivils.Any(x => x.Codigo.Equals(codigo)))
                {
                    Constantes.Validacion.DatoExistente(this.txtCodigo, errorProvider, string.Format("El Codigo {0} ya Existe", this.txtCodigo.Text));
                    return true;
                }

                if (EstadoCivils.Any(x => x.Descripcion.Equals(this.txtDescripcion.Text)))
                {
                    Constantes.Validacion.DatoExistente(this.txtDescripcion, errorProvider, string.Format("El Estado Civil {0} ya Existe", this.txtDescripcion.Text));
                    return true;
                }
            }

            if (_tipoOperacion == PlantillaFormulario.Clases.TipoOperacion.Modificar)
            {
                if (EstadoCivils.Any(x => x.Codigo.Equals(codigo) && x.Id != estadoCivil.Id))
                {
                    Constantes.Validacion.DatoExistente(this.txtCodigo, errorProvider, string.Format("El Codigo {0} ya Existe", this.txtCodigo.Text));
                    return true;
                }

                if (EstadoCivils.Any(x => x.Descripcion.Equals(this.txtDescripcion.Text) && x.Id != estadoCivil.Id))
                {
                    Constantes.Validacion.DatoExistente(this.txtDescripcion, errorProvider, string.Format("El Estado Civil {0} ya Existe", this.txtDescripcion.Text));
                    return true;
                }
            }

            return false;
        }

        public override void NuevoRegistro()
        {
            try
            {
                estadoCivil = ObjectFactory.GetInstance<Dominio.Comun.Entidades.EstadoCivil>();

                estadoCivil.Descripcion = this.txtDescripcion.Text;
                estadoCivil.Codigo = int.Parse(this.txtCodigo.Text);

                comunUoW.EstadoCivilRepositorio.Insertar(estadoCivil);
                comunUoW.Commit();

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
                comunUoW.EstadoCivilRepositorio.Eliminar(estadoCivil);
                comunUoW.Commit();
            }
            catch (DataException ex)
            {
                Mensaje.Mostrar("El Estado Civil seleccionado se encuentra vinculado a otro objeto.", Constantes.TipoMensaje.Error);
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
                estadoCivil.Descripcion = this.txtDescripcion.Text;
                estadoCivil.Codigo = int.Parse(this.txtCodigo.Text);

                comunUoW.EstadoCivilRepositorio.Modificar(estadoCivil);
                comunUoW.Commit();
            }
            catch (Exception ex)
            {
                Mensaje.Mostrar(ex, Constantes.TipoMensaje.Error);
            }
        }
    }
}
