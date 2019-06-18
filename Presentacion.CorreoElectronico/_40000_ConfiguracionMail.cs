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
using Aplicacion.Seguridad.Clases;
using Dominio.CorreoElectronico.Entidades;
using Dominio.CorreoElectronico.Interfaces.UnidadDeTrabajo;
using Presentacion.PlantillaFormulario.Clases;
using StructureMap;

namespace Presentacion.CorreoElectronico
{
    public partial class _40000_ConfiguracionMail : PlantillaFormulario.FormularioBase
    {
        private readonly IUnidadDeTrabajoCorreoElectronico _uowCorreoElectronico;
        private string tipoOperacion;
        private ConfiguracionMail config;
            
        public _40000_ConfiguracionMail()
        {
            InitializeComponent();
        }

        public _40000_ConfiguracionMail(IUnidadDeTrabajoCorreoElectronico uowCorreoElectronico)
        {
            InitializeComponent();

            this.Name = "_40000_ConfiguracionMail";
            this.TituloVentana = "Correo Electrónico";
            this.Titulo = "Configuración Mail";
            this.Leyenda = "Aqui Ud. podrá configurar su Servidor de Correo Electrónico";

            this._uowCorreoElectronico = uowCorreoElectronico;

            this.UsuarioLogin = Thread.CurrentPrincipal.Identity.Name;

            // Cargar evento de Validacion de Caracteres 
            this.txtPuerto.KeyPress += new KeyPressEventHandler(base.textBoxSoloNumeros_KeyPress);

            // Cargar evento de validacion para datos Obligatorios
            this.txtNombreUsuario.Validated += new EventHandler(base.textBox_Validated);
            this.txtPassword.Validated += new EventHandler(base.textBox_Validated);
            this.txtConfirmarPassword.Validated += new EventHandler(base.textBox_Validated);
            this.txtPuerto.Validated += new EventHandler(base.textBox_Validated);
            this.txtServidorSMTP.Validated += new EventHandler(base.textBox_Validated);
            
            // Color al recibir el Foco
            this.txtNombreUsuario.Enter += new EventHandler(base.control_Enter);
            this.txtPassword.Enter += new EventHandler(base.control_Enter);
            this.txtConfirmarPassword.Enter += new EventHandler(base.control_Enter);
            this.txtPuerto.Enter += new EventHandler(base.control_Enter);
            this.txtServidorSMTP.Enter += new EventHandler(base.control_Enter);
            
            // Color al perder el Foco
            this.txtNombreUsuario.Leave += new EventHandler(base.control_Leave);
            this.txtPassword.Leave += new EventHandler(base.control_Leave);
            this.txtConfirmarPassword.Leave += new EventHandler(base.control_Leave);
            this.txtPuerto.Leave += new EventHandler(base.control_Leave);
            this.txtServidorSMTP.Leave += new EventHandler(base.control_Leave);
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (this.txtPassword.Text.Equals(this.txtConfirmarPassword.Text))
            {
                if (!ValidarDatosObligatorios())
                {
                    if (tipoOperacion.Equals(PlantillaFormulario.Clases.TipoOperacion.Nuevo))
                    {
                        // Nuevo
                        config = ObjectFactory.GetInstance<ConfiguracionMail>();

                        config.DireccionEnvia = this.txtEmailSalida.Text;
                        config.NombreUsuario = this.txtNombreUsuario.Text;
                        config.OutPort = int.Parse(this.txtPuerto.Text);
                        config.Password = Encriptar.EncriptarCadena(this.txtPassword.Text);
                        config.SMTPServer = this.txtServidorSMTP.Text;
                        config.UsaSSL = this.chkUsaSSL.Checked;
                        config.EnviarCrearUsuario = this.chkCrearUnUsuario.Checked;
                        config.EnviarCancelarTurno = this.chkCancelacionTurno.Checked;
                        config.EnviarCumplirPaciente = this.chkCumplePaciente.Checked;

                        _uowCorreoElectronico.CorreoElectronicoRepositorio.Insertar(config);

                    }
                    else
                    {
                        // Modificar
                        config.DireccionEnvia = this.txtEmailSalida.Text;
                        config.NombreUsuario = this.txtNombreUsuario.Text;
                        config.OutPort = int.Parse(this.txtPuerto.Text);
                        config.Password = Encriptar.EncriptarCadena(this.txtPassword.Text);
                        config.SMTPServer = this.txtServidorSMTP.Text;
                        config.UsaSSL = this.chkUsaSSL.Checked;
                        config.EnviarCrearUsuario = this.chkCrearUnUsuario.Checked;
                        config.EnviarCancelarTurno = this.chkCancelacionTurno.Checked;
                        config.EnviarCumplirPaciente = this.chkCumplePaciente.Checked;

                        _uowCorreoElectronico.CorreoElectronicoRepositorio.Modificar(config);
                    }

                    _uowCorreoElectronico.Commit();

                    Mensaje.Mostrar("Los datos se grabaron correctamente",
                                    PlantillaFormulario.Clases.Constantes.TipoMensaje.Informacion);

                    this.Close();
                }
                else
                {
                    Mensaje.Mostrar("Faltan datos Obligatorios.",
                                    PlantillaFormulario.Clases.Constantes.TipoMensaje.Informacion);
                }
            }
            else
            {
                Mensaje.Mostrar("La contraseña y su Confirmación no son Iguales.",
                                    PlantillaFormulario.Clases.Constantes.TipoMensaje.Informacion);
                this.txtConfirmarPassword.Clear();
                this.txtConfirmarPassword.Focus();
            }
        }

        private bool ValidarDatosObligatorios()
        {
            var faltanDatos = true;

            if (!string.IsNullOrEmpty(this.txtNombreUsuario.Text))
                if (!string.IsNullOrEmpty(this.txtPassword.Text))
                    if (!string.IsNullOrEmpty(this.txtServidorSMTP.Text))
                        if (!string.IsNullOrEmpty(this.txtPuerto.Text))
                            if (!string.IsNullOrEmpty(this.txtEmailSalida.Text))
                                faltanDatos = false;

            return faltanDatos;
        }

        private void _40000_ConfiguracionMail_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            config = _uowCorreoElectronico.CorreoElectronicoRepositorio.ObtenerTodo().FirstOrDefault();

            if (config == null)
            {
                tipoOperacion = PlantillaFormulario.Clases.TipoOperacion.Nuevo;

                LimpiarDatosFormulario();
            }
            else
            {
                tipoOperacion = PlantillaFormulario.Clases.TipoOperacion.Modificar;
                
                this.txtNombreUsuario.Text = config.NombreUsuario;
                this.txtPassword.Text = Encriptar.DesencriptarCadena(config.Password);
                this.txtConfirmarPassword.Text = Encriptar.DesencriptarCadena(config.Password);
                this.chkUsaSSL.Checked = config.UsaSSL;
                this.txtEmailSalida.Text = config.DireccionEnvia;
                this.txtPuerto.Text = config.OutPort.ToString();
                this.txtServidorSMTP.Text = config.SMTPServer;
                this.chkCancelacionTurno.Checked = config.EnviarCancelarTurno;
                this.chkCrearUnUsuario.Checked = config.EnviarCrearUsuario;
                this.chkCumplePaciente.Checked = config.EnviarCumplirPaciente;
            }
        }
    }
}
