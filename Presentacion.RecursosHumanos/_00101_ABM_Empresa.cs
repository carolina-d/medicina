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
using Dominio.RecursosHumanos.Entidades;
using Dominio.RecursosHumanos.Interfaces.UnidadDeTrabajo;
using Presentacion.PlantillaFormulario.Clases;
using StructureMap;

namespace Presentacion.RecursosHumanos
{
    public partial class _00101_ABM_Empresa : Presentacion.PlantillaFormulario.FormularioABM
    {
        private readonly IUnidadDeTrabajoRecursosHumanos recursosHumanosUoW
            = ObjectFactory.GetInstance<IUnidadDeTrabajoRecursosHumanos>();

        private string _tipoOperacion = string.Empty;

        // Entidades
        private Empresa empresa;

        public _00101_ABM_Empresa()
        {
            InitializeComponent();
        }

        public _00101_ABM_Empresa(string tipoOperacion, int? entidadId)
            : base(tipoOperacion, entidadId)
        {
            InitializeComponent();
            
            this.Name = "_00101_ABM_Empresa";
            this.TituloVentana = "Empresa";
            this.Titulo = "ABM de Empresa";
            this.Leyenda = "Aquí Ud podrá dar de Alta, Modificar o Eliminar una Empresa";

            base.UsuarioLogin = Thread.CurrentPrincipal.Identity.Name;

            this._tipoOperacion = tipoOperacion;

            // Cargar evento de validacion para datos Obligatorios
            this.txtRazonSocial.Validated += new EventHandler(base.textBox_Validated);
            this.txtNombreFantasia.Validated += new EventHandler(base.textBox_Validated);
            this.txtDomicilio.Validated += new EventHandler(base.textBox_Validated);
            this.txtTelefono.Validated += new EventHandler(base.textBox_Validated);
            this.txtCuitCuil.Validated += new EventHandler(base.textBox_Validated);
            
            // Cargar evento de Validacion de Caracteres 
            this.txtRazonSocial.KeyPress += new KeyPressEventHandler(base.textBoxLetrasNumeros_KeyPress);
            this.txtNombreFantasia.KeyPress += new KeyPressEventHandler(base.textBoxLetrasNumeros_KeyPress);
            this.txtDomicilio.KeyPress += new KeyPressEventHandler(base.textBoxLetrasNumeros_KeyPress);
            this.txtTelefono.KeyPress += new KeyPressEventHandler(base.textBoxSoloNumeros_KeyPress);
            this.txtCuitCuil.KeyPress += new KeyPressEventHandler(base.textBoxSoloNumeros_KeyPress);

            // Color al recibir el Foco
            this.txtRazonSocial.Enter += new EventHandler(base.control_Enter);
            this.txtNombreFantasia.Enter += new EventHandler(base.control_Enter);
            this.txtDomicilio.Enter += new EventHandler(base.control_Enter);
            this.txtCuitCuil.Enter += new EventHandler(base.control_Enter);
            this.txtIngresosBrutos.Enter += new EventHandler(base.control_Enter);
            this.txtTelefono.Enter += new EventHandler(base.control_Enter);
            this.dtpInicioActividades.Enter += new EventHandler(base.control_Enter);
            
            // Color al perder el Foco
            this.txtRazonSocial.Leave += new EventHandler(base.control_Leave);
            this.txtCuitCuil.Leave += new EventHandler(base.control_Leave);
            this.txtDomicilio.Leave += new EventHandler(base.control_Leave);
            this.txtIngresosBrutos.Leave += new EventHandler(base.control_Leave);
            this.txtNombreFantasia.Leave += new EventHandler(base.control_Leave);
            this.txtTelefono.Leave += new EventHandler(base.control_Leave);
            this.dtpInicioActividades.Leave += new EventHandler(base.control_Leave);
            
            if (!entidadId.HasValue)
                this.imgLogo.Image = ImagenesFormulario.Empresa;

            Inicializador(tipoOperacion, entidadId);
        }

        public override void CargarDatos(int? entidadId)
        {
            // Instancion por medio del Inyector el Objeto Grupo
            empresa = ObjectFactory.GetInstance<Empresa>();

            if (entidadId.HasValue)
            {
                empresa = recursosHumanosUoW.EmpresaRepositorio.ObtenerPorId(entidadId.Value);

                this.txtRazonSocial.Text = empresa.RazonSocial;
                this.txtNombreFantasia.Text = empresa.NombreFantasia;
                this.txtDomicilio.Text = empresa.Direccion;
                this.txtTelefono.Text = empresa.Telefono;
                this.imgLogo.Image = Imagen.Convertir_Bytes_Imagen(empresa.Logo);
                this.txtIngresosBrutos.Text = empresa.IngresosBrutos;
                this.txtCuitCuil.Text = empresa.CuitCuil;
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
            var empresas = recursosHumanosUoW.EmpresaRepositorio.ObtenerTodo(string.Empty);

            if (_tipoOperacion == PlantillaFormulario.Clases.TipoOperacion.Nuevo)
            {
                if (empresas.Any(x => x.RazonSocial.Equals(this.txtRazonSocial.Text)))
                {
                    Constantes.Validacion.DatoExistente(this.txtRazonSocial, errorProvider, string.Format("La razón social {0} ya Existe", this.txtRazonSocial.Text));
                    return true;
                }

                if (empresas.Any(x => x.NombreFantasia.Equals(this.txtNombreFantasia.Text)))
                {
                    Constantes.Validacion.DatoExistente(this.txtNombreFantasia, errorProvider, string.Format("El nombre de fantasia {0} ya Existe", this.txtNombreFantasia.Text));
                    return true;
                }
            }

            if (_tipoOperacion == PlantillaFormulario.Clases.TipoOperacion.Modificar)
            {
                if (empresas.Any(x => x.RazonSocial.Equals(this.txtRazonSocial.Text) && x.Id != empresa.Id))
                {
                    Constantes.Validacion.DatoExistente(this.txtRazonSocial, errorProvider, string.Format("La razón social {0} ya Existe", this.txtRazonSocial.Text));
                    return true;
                }

                if (empresas.Any(x => x.NombreFantasia.Equals(this.txtNombreFantasia.Text) && x.Id != empresa.Id))
                {
                    Constantes.Validacion.DatoExistente(this.txtNombreFantasia, errorProvider, string.Format("El nombre de fantasia {0} ya Existe", this.txtNombreFantasia.Text));
                    return true;
                }
            }

            return false;
        }

        public override void NuevoRegistro()
        {
            try
            {
                empresa = new Empresa
                {
                    RazonSocial = this.txtRazonSocial.Text,
                    NombreFantasia = this.txtNombreFantasia.Text,
                    Direccion = this.txtDomicilio.Text,
                    Telefono = this.txtTelefono.Text,
                    FechaInicioActividades = this.dtpInicioActividades.Value,
                    Logo = Imagen.Convertir_Imagen_Bytes(this.imgLogo.Image),
                    CuitCuil = this.txtCuitCuil.Text,
                    IngresosBrutos = this.txtIngresosBrutos.Text
                };

                recursosHumanosUoW.EmpresaRepositorio.Insertar(empresa);
                recursosHumanosUoW.Commit();

                this.txtRazonSocial.Focus();
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
                recursosHumanosUoW.EmpresaRepositorio.Eliminar(empresa);
                recursosHumanosUoW.Commit();
            }
            catch (DataException ex)
            {
                Mensaje.Mostrar("La Empresa seleccionada se encuentra vinculada a otro objeto.", Constantes.TipoMensaje.Error);
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
                empresa.RazonSocial = this.txtRazonSocial.Text;
                empresa.NombreFantasia = this.txtNombreFantasia.Text;
                empresa.Direccion = this.txtDomicilio.Text;
                empresa.Telefono = this.txtTelefono.Text;
                empresa.Logo = Imagen.Convertir_Imagen_Bytes(this.imgLogo.Image);
                empresa.FechaInicioActividades = this.dtpInicioActividades.Value;
                empresa.CuitCuil = this.txtCuitCuil.Text;
                empresa.IngresosBrutos = this.txtIngresosBrutos.Text;

                recursosHumanosUoW.EmpresaRepositorio.Modificar(empresa);
                recursosHumanosUoW.Commit();
            }
            catch (Exception ex)
            {
                Mensaje.Mostrar(ex, Constantes.TipoMensaje.Error);
            }
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                var imagenSeleccionada = Image.FromFile(openFile.FileName);

                this.imgLogo.Image = imagenSeleccionada;
            }
            else
            {
                this.imgLogo.Image = ImagenesFormulario.Empresa;
            }
        }
    }
}
