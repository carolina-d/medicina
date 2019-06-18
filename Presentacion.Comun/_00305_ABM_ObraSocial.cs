using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio.Comun.Interfaces.UnidadDeTrabajo;
using Presentacion.PlantillaFormulario.Clases;
using StructureMap;
using System.Threading;

namespace Presentacion.Comun
{
    public partial class _00305_ABM_ObraSocial : Presentacion.PlantillaFormulario.FormularioABM
    {
        private readonly IUnidadDeTrabajoComun comunUoW
            = ObjectFactory.GetInstance<IUnidadDeTrabajoComun>();

        private string _tipoOperacion = string.Empty;

        // Entidades
        private Dominio.Comun.Entidades.ObraSocial obraSocial;

        public _00305_ABM_ObraSocial()
        {
            InitializeComponent();
        }

        public _00305_ABM_ObraSocial(string tipoOperacion, int? entidadId)
            : base(tipoOperacion, entidadId)
        {
            InitializeComponent();

            this.Name = "_00305_ABM_ObraSocial";
            this.TituloVentana = "Obra ocial";
            this.Leyenda = "Aquí Ud podrá dar de Alta, Modificar o Eliminar una Obra Social";

            base.UsuarioLogin = Thread.CurrentPrincipal.Identity.Name;

            this._tipoOperacion = tipoOperacion;

            // Cargar evento de validacion para datos Obligatorios
            this.txtDescripcion.Validated += new EventHandler(base.textBox_Validated);
            this.txtCodigo.Validated += new EventHandler(base.textBox_Validated);

            // Cargar evento de Validacion de Caracteres 
            this.txtDescripcion.KeyPress += new KeyPressEventHandler(base.textBoxLetrasNumeros_KeyPress);
            this.txtAbreviatura.KeyPress += new KeyPressEventHandler(base.textBoxLetrasNumeros_KeyPress);
            this.txtCodigo.KeyPress += new KeyPressEventHandler(base.textBoxSoloNumeros_KeyPress);

            // Color al recibir el Foco
            this.txtDescripcion.Enter += new EventHandler(base.control_Enter);
            this.txtAbreviatura.Enter += new EventHandler(base.control_Enter);
            this.txtCodigo.Enter += new EventHandler(base.control_Enter);

            // Color al perder el Foco
            this.txtDescripcion.Leave += new EventHandler(base.control_Leave);
            this.txtAbreviatura.Leave += new EventHandler(base.control_Leave);
            this.txtCodigo.Leave += new EventHandler(base.control_Leave);
            
            Inicializador(tipoOperacion, entidadId);
        }

        public override void CargarDatos(int? entidadId)
        {
            // Instancion por medio del Inyector el Objeto Grupo
            obraSocial = ObjectFactory.GetInstance<Dominio.Comun.Entidades.ObraSocial>();

            if (entidadId.HasValue)
            {
                obraSocial = comunUoW.ObraSocialRepositorio.ObtenerPorId(entidadId.Value);

                this.txtDescripcion.Text = obraSocial.Descripcion;
                this.txtCodigo.Text = obraSocial.Codigo.ToString();
                this.txtAbreviatura.Text = obraSocial.Abreviatura;
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
            var ObraSocials = comunUoW.ObraSocialRepositorio.ObtenerTodo(string.Empty);

            var codigo = 0;
            int.TryParse(this.txtCodigo.Text, out codigo);

            if (_tipoOperacion == PlantillaFormulario.Clases.TipoOperacion.Nuevo)
            {
                if (ObraSocials.Any(x => x.Codigo.Equals(codigo)))
                {
                    Constantes.Validacion.DatoExistente(this.txtCodigo, errorProvider, string.Format("El Codigo {0} ya Existe", this.txtCodigo.Text));
                    return true;
                }

                if (ObraSocials.Any(x => x.Descripcion.Equals(this.txtDescripcion.Text)))
                {
                    Constantes.Validacion.DatoExistente(this.txtDescripcion, errorProvider, string.Format("El ObraSocial {0} ya Existe", this.txtDescripcion.Text));
                    return true;
                }

                if (ObraSocials.Any(x => x.Abreviatura.Equals(this.txtAbreviatura.Text)))
                {
                    Constantes.Validacion.DatoExistente(this.txtAbreviatura, errorProvider, string.Format("La Abreviatura {0} ya Existe", this.txtAbreviatura.Text));
                    return true;
                }
            }

            if (_tipoOperacion == PlantillaFormulario.Clases.TipoOperacion.Modificar)
            {
                if (ObraSocials.Any(x => x.Codigo.Equals(codigo) && x.Id != obraSocial.Id))
                {
                    Constantes.Validacion.DatoExistente(this.txtCodigo, errorProvider, string.Format("El Codigo {0} ya Existe", this.txtCodigo.Text));
                    return true;
                }

                if (ObraSocials.Any(x => x.Descripcion.Equals(this.txtDescripcion.Text) && x.Id != obraSocial.Id))
                {
                    Constantes.Validacion.DatoExistente(this.txtDescripcion, errorProvider, string.Format("El ObraSocial {0} ya Existe", this.txtDescripcion.Text));
                    return true;
                }

                if (ObraSocials.Any(x => x.Abreviatura.Equals(this.txtAbreviatura.Text) && x.Id != obraSocial.Id))
                {
                    Constantes.Validacion.DatoExistente(this.txtAbreviatura, errorProvider, string.Format("La Abreviatura {0} ya Existe", this.txtAbreviatura.Text));
                    return true;
                }
            }

            return false;
        }

        public override void NuevoRegistro()
        {
            try
            {
                obraSocial = ObjectFactory.GetInstance<Dominio.Comun.Entidades.ObraSocial>();

                obraSocial.Descripcion = this.txtDescripcion.Text;
                obraSocial.Codigo = int.Parse(this.txtCodigo.Text);
                obraSocial.Abreviatura = this.txtAbreviatura.Text;

                comunUoW.ObraSocialRepositorio.Insertar(obraSocial);
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
                comunUoW.ObraSocialRepositorio.Eliminar(obraSocial);
                comunUoW.Commit();
            }
            catch (DataException ex)
            {
                Mensaje.Mostrar("El Obra Social seleccionada se encuentra vinculada a otro objeto.", Constantes.TipoMensaje.Error);
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
                obraSocial.Descripcion = this.txtDescripcion.Text;
                obraSocial.Codigo = int.Parse(this.txtCodigo.Text);
                obraSocial.Abreviatura = this.txtAbreviatura.Text;

                comunUoW.ObraSocialRepositorio.Modificar(obraSocial);
                comunUoW.Commit();
            }
            catch (Exception ex)
            {
                Mensaje.Mostrar(ex, Constantes.TipoMensaje.Error);
            }
        }
    }
}
