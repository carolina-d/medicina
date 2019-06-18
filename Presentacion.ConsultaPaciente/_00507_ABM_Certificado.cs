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
    public partial class _00507_ABM_Certificado : Presentacion.PlantillaFormulario.FormularioABM
    {

        private readonly IUnidadDeTrabajoConsultaPaciente consultaPacienteUoW
            = ObjectFactory.GetInstance<IUnidadDeTrabajoConsultaPaciente>();

        private string _tipoOperacion = string.Empty;
        private Certificado certificado;
        public _00507_ABM_Certificado()
        {
            InitializeComponent();
        }

        
        public _00507_ABM_Certificado(string tipoOperacion, int? entidadId)
            : base(tipoOperacion, entidadId)
        {

            InitializeComponent();

            this.Name = "_00507_ABM_Certificado";
            this.TituloVentana = "Certificado";
            this.Titulo = "ABM de Certificado";
            this.Leyenda = "Aquí Ud podrá dar de Alta, Modificar o Eliminar un Certificado";

           

            this._tipoOperacion = tipoOperacion;

            // Cargar evento de validacion para datos Obligatorios
            this.txtCodigo.Validated += new EventHandler(base.textBox_Validated);
            this.txtDescripcion.Validated += new EventHandler(base.textBox_Validated);

            // Cargar evento de Validacion de Caracteres 
            this.txtCodigo.KeyPress += new KeyPressEventHandler(base.textBoxLetrasNumeros_KeyPress);
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
            certificado = ObjectFactory.GetInstance<Certificado>();

            if (entidadId.HasValue)
            {
                certificado = consultaPacienteUoW.CertificadoRepositorio.ObtenerPorId(entidadId.Value);

                this.txtCodigo.Text = certificado.Codigo.ToString();
                this.txtDescripcion.Text = certificado.Descripcion;
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
            var certificados = consultaPacienteUoW.CertificadoRepositorio.ObtenerTodo(string.Empty);

            if (_tipoOperacion == PlantillaFormulario.Clases.TipoOperacion.Nuevo)
            {
                if (certificados.Any(x => x.Codigo.Equals(this.txtCodigo.Text)))
                {
                    Constantes.Validacion.DatoExistente(this.txtCodigo, errorProvider, string.Format("El codigo {0} ya Existe", this.txtCodigo.Text));
                    return true;
                }

                if (certificados.Any(x => x.Descripcion.Equals(this.txtDescripcion.Text)))
                {
                    Constantes.Validacion.DatoExistente(this.txtDescripcion, errorProvider, string.Format("La descripcion {0} ya Existe", this.txtDescripcion.Text));
                    return true;
                }
            }

            if (_tipoOperacion == PlantillaFormulario.Clases.TipoOperacion.Modificar)
            {
                if (certificados.Any(x => x.Codigo.Equals(this.txtCodigo.Text) && x.Id != certificado.Id))
                {
                    Constantes.Validacion.DatoExistente(this.txtCodigo, errorProvider, string.Format("El Codigo {0} ya Existe", this.txtCodigo.Text));
                    return true;
                }

                if (certificados.Any(x => x.Descripcion.Equals(this.txtDescripcion.Text) && x.Id != certificado.Id))
                {
                    Constantes.Validacion.DatoExistente(this.txtDescripcion, errorProvider, string.Format("La Descripcion {0} ya Existe", this.txtDescripcion.Text));
                    return true;
                }
            }

            return false;
        }

        public override void NuevoRegistro()
        {
            try
            {
                certificado = new Certificado();
                {
                    certificado.Codigo = Convert.ToInt32(txtCodigo);
                    certificado.Descripcion = txtDescripcion.Text;

                };

                consultaPacienteUoW.CertificadoRepositorio.Insertar(certificado);
                consultaPacienteUoW.Commit();

            
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
                consultaPacienteUoW.CertificadoRepositorio.Eliminar(certificado);
                consultaPacienteUoW.Commit();
            }
            catch (DataException ex)
            {
                Mensaje.Mostrar("El Certificado seleccionado se encuentra vinculado a otro objeto.", Constantes.TipoMensaje.Error);
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
                certificado.Codigo = Convert.ToInt32(this.txtCodigo.Text);
                certificado.Descripcion = this.txtDescripcion.Text;

                consultaPacienteUoW.CertificadoRepositorio.Modificar(certificado);
                consultaPacienteUoW.Commit();
            }
            catch (Exception ex)
            {
                Mensaje.Mostrar(ex, Constantes.TipoMensaje.Error);
            }
        }
    }
}
