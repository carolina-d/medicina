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
using Dominio.Seguridad.Entidades;
using Dominio.Seguridad.Interfaces.UnidadDeTrabajo;
using Presentacion.PlantillaFormulario.Clases;
using StructureMap;

namespace Presentacion.Seguridad
{
    public partial class _00202_ABM_Perfil : Presentacion.PlantillaFormulario.FormularioABM
    {
        private readonly IUnidadDeTrabajoSeguridad recursosHumanosUoW
            = ObjectFactory.GetInstance<IUnidadDeTrabajoSeguridad>();

        private string _tipoOperacion = string.Empty;

        // Entidades
        private Perfil perfil;

        public _00202_ABM_Perfil()
        {
            InitializeComponent();
        }

        public _00202_ABM_Perfil(string tipoOperacion, int? entidadId)
            : base(tipoOperacion, entidadId)
        {
            InitializeComponent();

            this.Name = "_00202_ABM_Perfil";
            this.TituloVentana = "Perfil";
            this.Titulo = "ABM de Perfil";
            this.Leyenda = "Aquí Ud podrá dar de Alta, Modificar o Eliminar un Perfil";

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
            perfil = ObjectFactory.GetInstance<Perfil>();

            if (entidadId.HasValue)
            {
                perfil = recursosHumanosUoW.PerfilRepositorio.ObtenerPorId(entidadId.Value);

                this.txtDescripcion.Text = perfil.Descripcion;
                this.txtCodigo.Text = perfil.Codigo.ToString();
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
            var Perfiles = recursosHumanosUoW.PerfilRepositorio.ObtenerTodo(string.Empty);

            var codigo = 0;
            int.TryParse(this.txtCodigo.Text, out codigo);

            if (_tipoOperacion == PlantillaFormulario.Clases.TipoOperacion.Nuevo)
            {
                if (Perfiles.Any(x => x.Descripcion.Equals(this.txtDescripcion.Text)))
                {
                    Constantes.Validacion.DatoExistente(this.txtDescripcion, errorProvider, string.Format("La Perfil {0} ya Existe", this.txtDescripcion.Text));
                    return true;
                }

                if (Perfiles.Any(x => x.Codigo.Equals(codigo)))
                {
                    Constantes.Validacion.DatoExistente(this.txtCodigo, errorProvider, string.Format("El Código {0} ya Existe", this.txtCodigo.Text));
                    return true;
                }
            }

            if (_tipoOperacion == PlantillaFormulario.Clases.TipoOperacion.Modificar)
            {
                if (Perfiles.Any(x => x.Descripcion.Equals(this.txtDescripcion.Text) && x.Id != perfil.Id))
                {
                    Constantes.Validacion.DatoExistente(this.txtDescripcion, errorProvider, string.Format("La Perfil {0} ya Existe", this.txtDescripcion.Text));
                    return true;
                }

                if (Perfiles.Any(x => x.Codigo.Equals(codigo) && x.Id != perfil.Id))
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
                perfil = ObjectFactory.GetInstance<Perfil>();

                perfil.Descripcion = this.txtDescripcion.Text;
                perfil.Codigo = int.Parse(this.txtCodigo.Text);

                recursosHumanosUoW.PerfilRepositorio.Insertar(perfil);
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
                recursosHumanosUoW.PerfilRepositorio.Eliminar(perfil);
                recursosHumanosUoW.Commit();
            }
            catch (DataException ex)
            {
                Mensaje.Mostrar("El Perfil seleccionado se encuentra vinculado a otro objeto.", Constantes.TipoMensaje.Error);
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
                perfil.Descripcion = this.txtDescripcion.Text;
                perfil.Codigo = int.Parse(this.txtCodigo.Text);

                recursosHumanosUoW.PerfilRepositorio.Modificar(perfil);
                recursosHumanosUoW.Commit();
            }
            catch (Exception ex)
            {
                Mensaje.Mostrar(ex, Constantes.TipoMensaje.Error);
            }
        }
    }
}
