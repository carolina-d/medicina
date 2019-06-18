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
using Dominio.ConsultaPaciente.Entidades;
using Dominio.ConsultaPaciente.Interfaces.IUnidadDeTrabajo;
using Presentacion.PlantillaFormulario.Clases;
using StructureMap;
using Dominio.Base;

namespace Presentacion.ConsultaPaciente
{
    public partial class _00505_ABM_EstudiosPedidos : Presentacion.PlantillaFormulario.FormularioABM
    {
        private readonly IUnidadDeTrabajoConsultaPaciente consultaPacienteUoW
           = ObjectFactory.GetInstance<IUnidadDeTrabajoConsultaPaciente>();

        private string _tipoOperacion = string.Empty;
        private EstudioPedido estudiopedido;

        public _00505_ABM_EstudiosPedidos()
        {
            InitializeComponent();
        }

        public _00505_ABM_EstudiosPedidos(string tipoOperacion, int? entidadId)
            : base(tipoOperacion, entidadId)
        {

            InitializeComponent();

            this.Name = "_00505_ABM_EstudiosPedidos";
            this.TituloVentana = "EstudiosPedidos";
            this.Titulo = "ABM de Estudios Pedidos";
            this.Leyenda = "Aquí Ud podrá dar de Alta, Modificar o Eliminar un Estudio";

            base.UsuarioLogin = Thread.CurrentPrincipal.Identity.Name;

            this._tipoOperacion = tipoOperacion;

            // Cargar evento de validacion para datos Obligatorios
            this.txtNombreEstudio.Validated += new EventHandler(base.textBox_Validated);
            this.txtObservaciones.Validated += new EventHandler(base.textBox_Validated);
            this.txtUbicacion.Validated += new EventHandler(base.textBox_Validated);

            // Cargar evento de Validacion de Caracteres 
            this.txtNombreEstudio.KeyPress += new KeyPressEventHandler(base.textBoxLetrasNumeros_KeyPress);
            this.txtObservaciones.KeyPress += new KeyPressEventHandler(base.textBoxLetrasNumeros_KeyPress);
            this.txtUbicacion.KeyPress += new KeyPressEventHandler(base.textBoxLetrasNumeros_KeyPress);


            // Color al recibir el Foco
            this.txtNombreEstudio.Enter += new EventHandler(base.control_Enter);
            this.txtObservaciones.Enter += new EventHandler(base.control_Enter);
            this.txtUbicacion.Enter += new EventHandler(base.control_Enter);


            // Color al perder el Foco
            this.txtNombreEstudio.Leave += new EventHandler(base.control_Leave);
            this.txtObservaciones.Leave += new EventHandler(base.control_Leave);
            this.txtUbicacion.Leave += new EventHandler(base.control_Leave);



            Inicializador(tipoOperacion, entidadId);
        }

        public override void CargarDatos(int? entidadId)
        {
            // Instancion por medio del Inyector el Objeto Grupo
            estudiopedido = ObjectFactory.GetInstance<EstudioPedido>();

            if (entidadId.HasValue)
            {
                estudiopedido = consultaPacienteUoW.EstudiosPedidosRepositorio.ObtenerPorId(entidadId.Value);

                this.txtNombreEstudio.Text = estudiopedido.NombreEstudio.ToString();
                this.txtObservaciones.Text = estudiopedido.Obsevaciones;
                this.txtUbicacion.Text = estudiopedido.Ubicacion;
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
            var estudiopedido = consultaPacienteUoW.EstudiosPedidosRepositorio.ObtenerTodo(string.Empty);

            if (_tipoOperacion == PlantillaFormulario.Clases.TipoOperacion.Nuevo)
            {
                if (estudiopedido.Any(x => x.NombreEstudio.Equals(this.txtNombreEstudio.Text)))
                {
                    Constantes.Validacion.DatoExistente(this.txtNombreEstudio, errorProvider, string.Format("El nombre de estudio {0} ya Existe", this.txtNombreEstudio.Text));
                    return true;
                }

                if (estudiopedido.Any(x => x.Obsevaciones.Equals(this.txtObservaciones.Text)))
                {
                    Constantes.Validacion.DatoExistente(this.txtObservaciones, errorProvider, string.Format("La Observacion {0} ya Existe", this.txtObservaciones.Text));
                    return true;
                }

                if (estudiopedido.Any(x => x.Ubicacion.Equals(this.txtUbicacion.Text)))
                {
                    Constantes.Validacion.DatoExistente(this.txtUbicacion, errorProvider, string.Format("La Ubicacion {0} ya Existe", this.txtUbicacion.Text));
                    return true;
                }
            }
            return false;
        }

        public override void EliminarRegistro()
        {
            try
            {
                consultaPacienteUoW.EstudiosPedidosRepositorio.Eliminar(estudiopedido);
                consultaPacienteUoW.Commit();
            }
            catch (DataException ex)
            {
                Mensaje.Mostrar("El Estudio seleccionado se encuentra vinculado a otro objeto.", Constantes.TipoMensaje.Error);
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
                estudiopedido.NombreEstudio = this.txtNombreEstudio.Text;
                estudiopedido.Obsevaciones = this.txtObservaciones.Text;
                estudiopedido.Ubicacion = this.txtUbicacion.Text;

                consultaPacienteUoW.EstudiosPedidosRepositorio.Modificar(estudiopedido);
                consultaPacienteUoW.Commit();
            }
            catch (Exception ex)
            {
                Mensaje.Mostrar(ex, Constantes.TipoMensaje.Error);
            }
        }
    }
}
