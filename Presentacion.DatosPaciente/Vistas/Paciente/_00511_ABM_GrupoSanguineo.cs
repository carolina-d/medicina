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
using StructureMap;
using Presentacion.PlantillaFormulario.Clases;

namespace Presentacion.DatosPaciente.Vistas.Paciente
{
    public partial class _00511_ABM_GrupoSanguineo : Presentacion.PlantillaFormulario.FormularioABM
    {
        private readonly IUnidadDeTrabajoDatosPaciente datosPacienteUoW
            = ObjectFactory.GetInstance<IUnidadDeTrabajoDatosPaciente>();

        private string _tipoOperacion = string.Empty;

        // Entidades
        private Dominio.DatosPaciente.Entidades.GrupoSanguineo grupoSanguineo;

        public _00511_ABM_GrupoSanguineo()
        {
            InitializeComponent();
        }

        public _00511_ABM_GrupoSanguineo(string tipoOperacion, int? entidadId)
            : base(tipoOperacion, entidadId)
        {
            InitializeComponent();

            this.Name = "_00511_ABM_GrupoSanguineo";
            this.TituloVentana = "Grupo Sanguineo";
            this.Titulo = "ABM de Grupo Sanguineo";
            this.Leyenda = "Aquí Ud podrá dar de Alta, Modificar o Eliminar un Grupo Sanguineo";

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
            grupoSanguineo = ObjectFactory.GetInstance<Dominio.DatosPaciente.Entidades.GrupoSanguineo>();

            if (entidadId.HasValue)
            {
                grupoSanguineo = datosPacienteUoW.GrupoSanguineoRepositorio.ObtenerPorId(entidadId.Value);

                this.txtCodigo.Text = grupoSanguineo.Codigo.ToString();
                this.txtDescripcion.Text = grupoSanguineo.Descripcion;
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
            var grupoSanguineos = datosPacienteUoW.GrupoSanguineoRepositorio.ObtenerTodo(string.Empty);

            var codigo = 0;
            int.TryParse(this.txtCodigo.Text, out codigo);

            if (_tipoOperacion == PlantillaFormulario.Clases.TipoOperacion.Nuevo)
            {
                if (grupoSanguineos.Any(x => x.Codigo.Equals(codigo)))
                {
                    Constantes.Validacion.DatoExistente(this.txtCodigo, errorProvider, string.Format("El Codigo {0} ya Existe", this.txtCodigo.Text));
                    return true;
                }

                if (grupoSanguineos.Any(x => x.Descripcion.Equals(this.txtDescripcion.Text)))
                {
                    Constantes.Validacion.DatoExistente(this.txtDescripcion, errorProvider, string.Format("El Grupo Sanguineo {0} ya Existe", this.txtDescripcion.Text));
                    return true;
                }
            }

            if (_tipoOperacion == PlantillaFormulario.Clases.TipoOperacion.Modificar)
            {
                if (grupoSanguineos.Any(x => x.Codigo.Equals(codigo) && x.Id != grupoSanguineo.Id))
                {
                    Constantes.Validacion.DatoExistente(this.txtCodigo, errorProvider, string.Format("El Codigo {0} ya Existe", this.txtCodigo.Text));
                    return true;
                }

                if (grupoSanguineos.Any(x => x.Descripcion.Equals(this.txtDescripcion.Text) && x.Id != grupoSanguineo.Id))
                {
                    Constantes.Validacion.DatoExistente(this.txtDescripcion, errorProvider, string.Format("El Grupo Sanguineo {0} ya Existe", this.txtDescripcion.Text));
                    return true;
                }
            }

            return false;
        }

        public override void NuevoRegistro()
        {
            try
            {
                grupoSanguineo = ObjectFactory.GetInstance<Dominio.DatosPaciente.Entidades.GrupoSanguineo>();

                grupoSanguineo.Codigo = int.Parse(this.txtCodigo.Text);
                grupoSanguineo.Descripcion = this.txtDescripcion.Text;

                datosPacienteUoW.GrupoSanguineoRepositorio.Insertar(grupoSanguineo);
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
                datosPacienteUoW.GrupoSanguineoRepositorio.Eliminar(grupoSanguineo);
                datosPacienteUoW.Commit();
            }
            catch (DataException ex)
            {
                Mensaje.Mostrar("La Grupo Sanguineo seleccionado se encuentra vinculado a otro objeto.", Constantes.TipoMensaje.Error);
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
                grupoSanguineo.Codigo = int.Parse(this.txtCodigo.Text);
                grupoSanguineo.Descripcion = this.txtDescripcion.Text;

                datosPacienteUoW.GrupoSanguineoRepositorio.Modificar(grupoSanguineo);
                datosPacienteUoW.Commit();
            }
            catch (Exception ex)
            {
                Mensaje.Mostrar(ex, Constantes.TipoMensaje.Error);
            }
        }
    }
}
