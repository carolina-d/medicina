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

namespace Presentacion.DatosPaciente.Vistas.Vacunacion
{
    public partial class _00507_ABM_DosisVacuna : Presentacion.PlantillaFormulario.FormularioABM
    {
        private readonly IUnidadDeTrabajoDatosPaciente _datosPacienteUoW
            = ObjectFactory.GetInstance<IUnidadDeTrabajoDatosPaciente>();

        private string _tipoOperacion = string.Empty;

        // Entidades
        private Dominio.DatosPaciente.Entidades.Dosis dosis;

        public _00507_ABM_DosisVacuna()
        {
            InitializeComponent();
        }

        public _00507_ABM_DosisVacuna(string tipoOperacion, int? entidadId)
            : base(tipoOperacion, entidadId)
        {
            InitializeComponent();

            this.Name = "_00507_ABM_DosisVacuna";
            this.TituloVentana = "Dosis Vacuna";
            this.Titulo = "ABM de Dosis";
            this.Leyenda = "Aquí Ud podrá dar de Alta, Modificar o Eliminar una Dosis";

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
            dosis = ObjectFactory.GetInstance<Dominio.DatosPaciente.Entidades.Dosis>();

            if (entidadId.HasValue)
            {
                dosis = _datosPacienteUoW.DosisRepositorio.ObtenerPorId(entidadId.Value);

                this.txtDescripcion.Text = dosis.Descripcion;
                this.txtCodigo.Text = dosis.Codigo.ToString();
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
            var dosiss = _datosPacienteUoW.DosisRepositorio.ObtenerTodo(string.Empty);

            var codigo = 0;
            int.TryParse(this.txtCodigo.Text, out codigo);

            if (_tipoOperacion == PlantillaFormulario.Clases.TipoOperacion.Nuevo)
            {
                if (dosiss.Any(x => x.Codigo.Equals(codigo)))
                {
                    Constantes.Validacion.DatoExistente(this.txtCodigo, errorProvider, string.Format("El Codigo {0} ya Existe", this.txtCodigo.Text));
                    return true;
                }

                if (dosiss.Any(x => x.Descripcion.Equals(this.txtDescripcion.Text)))
                {
                    Constantes.Validacion.DatoExistente(this.txtDescripcion, errorProvider, string.Format("El Estado Civil {0} ya Existe", this.txtDescripcion.Text));
                    return true;
                }
            }

            if (_tipoOperacion == PlantillaFormulario.Clases.TipoOperacion.Modificar)
            {
                if (dosiss.Any(x => x.Codigo.Equals(codigo) && x.Id != dosis.Id))
                {
                    Constantes.Validacion.DatoExistente(this.txtCodigo, errorProvider, string.Format("El Codigo {0} ya Existe", this.txtCodigo.Text));
                    return true;
                }

                if (dosiss.Any(x => x.Descripcion.Equals(this.txtDescripcion.Text) && x.Id != dosis.Id))
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
                dosis = ObjectFactory.GetInstance<Dominio.DatosPaciente.Entidades.Dosis>();

                dosis.Descripcion = this.txtDescripcion.Text;
                dosis.Codigo = int.Parse(this.txtCodigo.Text);

                _datosPacienteUoW.DosisRepositorio.Insertar(dosis);
                _datosPacienteUoW.Commit();

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
                _datosPacienteUoW.DosisRepositorio.Eliminar(dosis);
                _datosPacienteUoW.Commit();
            }
            catch (DataException ex)
            {
                Mensaje.Mostrar("La dosis seleccionada se encuentra vinculada a otro objeto.", Constantes.TipoMensaje.Error);
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
                dosis.Descripcion = this.txtDescripcion.Text;
                dosis.Codigo = int.Parse(this.txtCodigo.Text);

                _datosPacienteUoW.DosisRepositorio.Modificar(dosis);
                _datosPacienteUoW.Commit();
            }
            catch (Exception ex)
            {
                Mensaje.Mostrar(ex, Constantes.TipoMensaje.Error);
            }
        }
    }
}
