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
    public partial class _00501_ABM_Sintomas : Presentacion.PlantillaFormulario.FormularioABM
    {
        private readonly IUnidadDeTrabajoConsultaPaciente consultaPacienteUoW
            = ObjectFactory.GetInstance<IUnidadDeTrabajoConsultaPaciente>();

        private string _tipoOperacion = string.Empty;
        private Sintoma sintoma;

        public _00501_ABM_Sintomas()
        {
            InitializeComponent();
        }

        public _00501_ABM_Sintomas(string tipoOperacion, int? entidadId)
            : base(tipoOperacion, entidadId)
        {

            InitializeComponent();

            this.Name = "_00501_ABM_Sintomas";
            this.TituloVentana = "Sintomas";
            this.Titulo = "ABM de Sintomas";
            this.Leyenda = "Aquí Ud podrá dar de Alta, Modificar o Eliminar un Sintoma";

            base.UsuarioLogin = Thread.CurrentPrincipal.Identity.Name;

            this._tipoOperacion = tipoOperacion;

            // Cargar evento de validacion para datos Obligatorios
            this.txtCodigoSintomas.Validated += new EventHandler(base.textBox_Validated);
            this.txtDescripcionSintomas.Validated += new EventHandler(base.textBox_Validated);

            // Cargar evento de Validacion de Caracteres 
            this.txtCodigoSintomas.KeyPress += new KeyPressEventHandler(base.textBoxLetrasNumeros_KeyPress);
            this.txtDescripcionSintomas.KeyPress += new KeyPressEventHandler(base.textBoxLetrasNumeros_KeyPress);


            // Color al recibir el Foco
            this.txtCodigoSintomas.Enter += new EventHandler(base.control_Enter);
            this.txtDescripcionSintomas.Enter += new EventHandler(base.control_Enter);


            // Color al perder el Foco
            this.txtCodigoSintomas.Leave += new EventHandler(base.control_Leave);
            this.txtDescripcionSintomas.Leave += new EventHandler(base.control_Leave);



            Inicializador(tipoOperacion, entidadId);
        }

        public override void CargarDatos(int? entidadId)
        {
            // Instancion por medio del Inyector el Objeto Grupo
            sintoma = ObjectFactory.GetInstance<Sintoma>();

            if (entidadId.HasValue)
            {
                sintoma = consultaPacienteUoW.SintomasRepositorio.ObtenerPorId(entidadId.Value);

                this.txtCodigoSintomas.Text = sintoma.Codigo.ToString();
                this.txtDescripcionSintomas.Text = sintoma.Descripcion;
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
            var sintomas= consultaPacienteUoW.SintomasRepositorio.ObtenerTodo(string.Empty);

            if (_tipoOperacion == PlantillaFormulario.Clases.TipoOperacion.Nuevo)
            {
                if (sintomas.Any(x => x.Codigo.Equals(this.txtCodigoSintomas.Text)))
                {
                    Constantes.Validacion.DatoExistente(this.txtCodigoSintomas, errorProvider, string.Format("El codigo {0} ya Existe", this.txtCodigoSintomas.Text));
                    return true;
                }

                if (sintomas.Any(x => x.Descripcion.Equals(this.txtDescripcionSintomas.Text)))
                {
                    Constantes.Validacion.DatoExistente(this.txtDescripcionSintomas, errorProvider, string.Format("La descripcion {0} ya Existe", this.txtDescripcionSintomas.Text));
                    return true;
                }
            }

            if (_tipoOperacion == PlantillaFormulario.Clases.TipoOperacion.Modificar)
            {
                if (sintomas.Any(x => x.Codigo.Equals(this.txtCodigoSintomas.Text) && x.Id != sintoma.Id))
                {
                    Constantes.Validacion.DatoExistente(this.txtCodigoSintomas, errorProvider, string.Format("El Codigo {0} ya Existe", this.txtCodigoSintomas.Text));
                    return true;
                }

                if (sintomas.Any(x => x.Descripcion.Equals(this.txtDescripcionSintomas.Text) && x.Id != sintoma.Id))
                {
                    Constantes.Validacion.DatoExistente(this.txtDescripcionSintomas, errorProvider, string.Format("La Descripcion {0} ya Existe", this.txtDescripcionSintomas.Text));
                    return true;
                }
            }

            return false;
        }

        public override void NuevoRegistro()
        {
            try
            {
                sintoma = new Sintoma()
                {
                   Codigo =Convert.ToInt32(txtCodigoSintomas),
                   Descripcion =txtDescripcionSintomas.Text

                };

                consultaPacienteUoW.SintomasRepositorio.Insertar(sintoma);
                consultaPacienteUoW.Commit();

                this.txtCodigoSintomas.Focus();
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
                consultaPacienteUoW.SintomasRepositorio.Eliminar(sintoma);
                consultaPacienteUoW.Commit();
            }
            catch (DataException ex)
            {
                Mensaje.Mostrar("El Sintoma seleccionado se encuentra vinculado a otro objeto.", Constantes.TipoMensaje.Error);
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
                sintoma.Codigo = Convert.ToInt32(this.txtCodigoSintomas.Text);
                sintoma.Descripcion = this.txtDescripcionSintomas.Text;

                consultaPacienteUoW.SintomasRepositorio.Modificar(sintoma);
                consultaPacienteUoW.Commit();
            }
            catch (Exception ex)
            {
                Mensaje.Mostrar(ex, Constantes.TipoMensaje.Error);
            }
        }


    }
}


