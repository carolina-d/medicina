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

namespace Presentacion.DatosPaciente.Vistas.Antecedente
{
    public partial class _00520_ABM_Antecedente : PlantillaFormulario.FormularioABM
    {

        private readonly IUnidadDeTrabajoDatosPaciente datosPacienteUoW
            = ObjectFactory.GetInstance<IUnidadDeTrabajoDatosPaciente>();

        private string _tipoOperacion = string.Empty;

        private Dominio.DatosPaciente.Entidades.Antecedente antecendente;

        public _00520_ABM_Antecedente()
        {
            InitializeComponent();
        }

        public _00520_ABM_Antecedente(string tipoOperacion, int? entidadId)
            : base(tipoOperacion, entidadId)
        {
            InitializeComponent();

            this.Name = "_00520_ABM_Antecedente";
            this.TituloVentana = "Antecedente";
            this.Titulo = "ABM de Antecedente";
            this.Leyenda = "Aquí Ud podrá dar de Alta, Modificar o Eliminar un Antecedente";

            base.UsuarioLogin = Thread.CurrentPrincipal.Identity.Name;

            this._tipoOperacion = tipoOperacion;

            // Cargar evento de validacion para datos Obligatorios
            this.txtCodigo.Validated += new EventHandler(base.textBox_Validated);
            this.txtAntecedentes.Validated += new EventHandler(base.textBox_Validated);
            this.cmbPariente.Validated += new EventHandler(base.textBox_Validated);

            // Cargar evento de Validacion de Caracteres 
            this.txtCodigo.KeyPress += new KeyPressEventHandler(base.textBoxSoloNumeros_KeyPress);
            this.txtAntecedentes.KeyPress += new KeyPressEventHandler(base.textBoxLetrasNumeros_KeyPress);

            // Color al recibir el Foco
            this.txtCodigo.Enter += new EventHandler(base.control_Enter);
            this.txtAntecedentes.Enter += new EventHandler(base.control_Enter);

            // Color al perder el Foco
            this.txtCodigo.Leave += new EventHandler(base.control_Leave);
            this.txtAntecedentes.Leave += new EventHandler(base.control_Leave);

            Inicializador(tipoOperacion, entidadId);
        }

            public override void CargarDatos(int? entidadId)
        {
            // Instancion por medio del Inyector el Objeto Grupo
            antecendente = ObjectFactory.GetInstance<Dominio.DatosPaciente.Entidades.Antecedente>();

            if (entidadId.HasValue)
            {
                antecendente = datosPacienteUoW.AntecedenteRepositorio.ObtenerPorId(entidadId.Value);

                this.txtCodigo.Text = antecendente.Codigo.ToString();
                this.cmbPariente.ValueMember = antecendente.AntecedentesPersonales;
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
            var antecedentes = datosPacienteUoW.AntecedenteRepositorio.ObtenerTodo(string.Empty);

            var codigo = 0;
            int.TryParse(this.txtCodigo.Text, out codigo);

            if (_tipoOperacion == PlantillaFormulario.Clases.TipoOperacion.Nuevo)
            {
                if (antecedentes.Any(x => x.Codigo.Equals(codigo)))
                {
                    Constantes.Validacion.DatoExistente(this.txtCodigo, errorProvider, string.Format("El Codigo {0} ya Existe", this.txtCodigo.Text));
                    return true;
                }

                if (antecedentes.Any(x => x.AntecedentesPersonales.Equals(this.txtAntecedentes.Text)))
                {
                    Constantes.Validacion.DatoExistente(this.txtAntecedentes, errorProvider, string.Format("El antecedente {0} ya Existe", this.txtAntecedentes.Text));
                    return true;
                }
            }

            if (_tipoOperacion == PlantillaFormulario.Clases.TipoOperacion.Modificar)
            {
                if (antecedentes.Any(x => x.Codigo.Equals(codigo) && x.Id != antecendente.Id))
                {
                    Constantes.Validacion.DatoExistente(this.txtCodigo, errorProvider, string.Format("El Codigo {0} ya Existe", this.txtCodigo.Text));
                    return true;
                }

                if (antecedentes.Any(x => x.AntecedentesPersonales.Equals(this.txtAntecedentes.Text) && x.Id != antecendente.Id))
                {
                    Constantes.Validacion.DatoExistente(this.txtAntecedentes, errorProvider, string.Format("La patología {0} ya Existe", this.txtAntecedentes.Text));
                    return true;
                }
            }

            return false;
        }

        public override void NuevoRegistro()
        {
            try
            {
                antecendente = ObjectFactory.GetInstance<Dominio.DatosPaciente.Entidades.Antecedente>();

                antecendente.Codigo = int.Parse(this.txtCodigo.Text);
                antecendente.AntecedentesPersonales = this.txtAntecedentes.Text;

                datosPacienteUoW.AntecedenteRepositorio.Insertar(antecendente);
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
                datosPacienteUoW.AntecedenteRepositorio.Eliminar(antecendente);
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
                antecendente.Codigo = int.Parse(this.txtCodigo.Text);
                antecendente.AntecedentesPersonales = this.txtAntecedentes.Text;

                datosPacienteUoW.AntecedenteRepositorio.Modificar(antecendente);
                datosPacienteUoW.Commit();
            }
            catch (Exception ex)
            {
                Mensaje.Mostrar(ex, Constantes.TipoMensaje.Error);
            }
        }

    }
}
