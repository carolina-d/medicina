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
    public partial class _00301_ABM_Sexo : PlantillaFormulario.FormularioABM
    {
        private readonly IUnidadDeTrabajoComun comunUoW
            = ObjectFactory.GetInstance<IUnidadDeTrabajoComun>();

        private string _tipoOperacion = string.Empty;

        // Entidades
        private Dominio.Comun.Entidades.Sexo sexo;

        public _00301_ABM_Sexo()
        {
            InitializeComponent();
        }

        public _00301_ABM_Sexo(string tipoOperacion, int? entidadId)
            : base(tipoOperacion, entidadId)
        {
            InitializeComponent();

            this.Name = "_00301_ABM_Sexo";
            this.TituloVentana = "Sexo";
            this.Titulo = "ABM de Sexo";
            this.Leyenda = "Aquí Ud podrá dar de Alta, Modificar o Eliminar un Sexo";

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
            sexo = ObjectFactory.GetInstance<Dominio.Comun.Entidades.Sexo>();

            if (entidadId.HasValue)
            {
                sexo = comunUoW.SexoRepositorio.ObtenerPorId(entidadId.Value);

                this.txtDescripcion.Text = sexo.Descripcion;
                this.txtCodigo.Text = sexo.Codigo.ToString();
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
            var sexos = comunUoW.SexoRepositorio.ObtenerTodo(string.Empty);

            var codigo = 0;
            int.TryParse(this.txtCodigo.Text, out codigo);

            if (_tipoOperacion == PlantillaFormulario.Clases.TipoOperacion.Nuevo)
            {
                if (sexos.Any(x => x.Codigo.Equals(codigo)))
                {
                    Constantes.Validacion.DatoExistente(this.txtCodigo, errorProvider, string.Format("El Codigo {0} ya Existe", this.txtCodigo.Text));
                    return true;
                }

                if (sexos.Any(x => x.Descripcion.Equals(this.txtDescripcion.Text)))
                {
                    Constantes.Validacion.DatoExistente(this.txtDescripcion, errorProvider, string.Format("El Sexo {0} ya Existe", this.txtDescripcion.Text));
                    return true;
                }
            }

            if (_tipoOperacion == PlantillaFormulario.Clases.TipoOperacion.Modificar)
            {
                if (sexos.Any(x => x.Codigo.Equals(codigo) && x.Id != sexo.Id))
                {
                    Constantes.Validacion.DatoExistente(this.txtCodigo, errorProvider, string.Format("El Codigo {0} ya Existe", this.txtCodigo.Text));
                    return true;
                }

                if (sexos.Any(x => x.Descripcion.Equals(this.txtDescripcion.Text) && x.Id != sexo.Id))
                {
                    Constantes.Validacion.DatoExistente(this.txtDescripcion, errorProvider, string.Format("El Sexo {0} ya Existe", this.txtDescripcion.Text));
                    return true;
                }
            }

            return false;
        }

        public override void NuevoRegistro()
        {
            try
            {
                sexo = ObjectFactory.GetInstance<Dominio.Comun.Entidades.Sexo>();

                sexo.Descripcion = this.txtDescripcion.Text;
                sexo.Codigo = int.Parse(this.txtCodigo.Text);

                comunUoW.SexoRepositorio.Insertar(sexo);
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
                comunUoW.SexoRepositorio.Eliminar(sexo);
                comunUoW.Commit();
            }
            catch (DataException ex)
            {
                Mensaje.Mostrar("El Sexo seleccionado se encuentra vinculado a otro objeto.", Constantes.TipoMensaje.Error);
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
                sexo.Descripcion = this.txtDescripcion.Text;
                sexo.Codigo = int.Parse(this.txtCodigo.Text);

                comunUoW.SexoRepositorio.Modificar(sexo);
                comunUoW.Commit();
            }
            catch (Exception ex)
            {
                Mensaje.Mostrar(ex, Constantes.TipoMensaje.Error);
            }
        }
    }
}
