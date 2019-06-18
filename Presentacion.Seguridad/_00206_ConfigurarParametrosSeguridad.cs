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
using Dominio.Seguridad.Entidades;
using Dominio.Seguridad.Interfaces.UnidadDeTrabajo;
using Presentacion.PlantillaFormulario.Clases;
using StructureMap;

namespace Presentacion.Seguridad
{
    public partial class _00206_ConfigurarParametrosSeguridad : Presentacion.PlantillaFormulario.FormularioBase
    {
        private readonly IUnidadDeTrabajoSeguridad _uowSeguridad;
        private string tipoOperacion;
        private ConfiguracionSeguridad _configuracionSistema;
            
        public _00206_ConfigurarParametrosSeguridad()
        {
            InitializeComponent();
        }

        public _00206_ConfigurarParametrosSeguridad(IUnidadDeTrabajoSeguridad uowSeguridad)
        {
            InitializeComponent();

            this.Name = "_00206_ConfigurarParametrosSeguridad";
            this.TituloVentana = "Seguridad";
            this.Titulo = "Configuración parámetros de Seguridad";
            this.Leyenda = "Aqui Ud. podrá configurar los parametros básicos de seguridad";

            this._uowSeguridad = uowSeguridad;

            this.UsuarioLogin = Thread.CurrentPrincipal.Identity.Name;

            // Cargar evento de validacion para datos Obligatorios
            this.txtNueva.Validated += new EventHandler(base.textBox_Validated);
            this.txtReNueva.Validated += new EventHandler(base.textBox_Validated);
            
            // Color al recibir el Foco
            this.txtNueva.Enter += new EventHandler(base.control_Enter);
            this.txtReNueva.Enter += new EventHandler(base.control_Enter);
            
            // Color al perder el Foco
            this.txtNueva.Leave += new EventHandler(base.control_Leave);
            this.txtReNueva.Leave += new EventHandler(base.control_Leave);                       
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (this.txtNueva.Text.Equals(this.txtReNueva.Text))
            {
                    if (tipoOperacion.Equals(PlantillaFormulario.Clases.TipoOperacion.Nuevo))
                    {
                        // Nuevo
                        _configuracionSistema = ObjectFactory.GetInstance<ConfiguracionSeguridad>();

                        _configuracionSistema.PasswordDefecto = this.txtNueva.Text;
                        _configuracionSistema.RequerirCambioPassword = this.chkRequerirPwd.Checked;
                        _configuracionSistema.CantMaximoCaracteres = Convert.ToInt32(this.nudMaximos.Value);
                        _configuracionSistema.CantMayusculas = Convert.ToInt32(this.nudMayuscula.Value);
                        _configuracionSistema.CantMinimoCaracteres = Convert.ToInt32(this.nudMinimos.Value);
                        _configuracionSistema.CantMinusculas = Convert.ToInt32(this.nudMinuscula.Value);
                        _configuracionSistema.CantNumeros = Convert.ToInt32(this.nudNumeros.Value);
                        _configuracionSistema.CantSimbolos = Convert.ToInt32(this.nudSimbolos.Value);

                        _uowSeguridad.ConfiguracionSeguridadRepositorio.Insertar(_configuracionSistema);
                    }
                    else
                    {
                        // Modificar

                        _configuracionSistema.PasswordDefecto = this.txtNueva.Text;
                        _configuracionSistema.RequerirCambioPassword = this.chkRequerirPwd.Checked;
                        _configuracionSistema.CantMaximoCaracteres = Convert.ToInt32(this.nudMaximos.Value);
                        _configuracionSistema.CantMayusculas = Convert.ToInt32(this.nudMayuscula.Value);
                        _configuracionSistema.CantMinimoCaracteres = Convert.ToInt32(this.nudMinimos.Value);
                        _configuracionSistema.CantMinusculas = Convert.ToInt32(this.nudMinuscula.Value);
                        _configuracionSistema.CantNumeros = Convert.ToInt32(this.nudNumeros.Value);
                        _configuracionSistema.CantSimbolos = Convert.ToInt32(this.nudSimbolos.Value);

                        _uowSeguridad.ConfiguracionSeguridadRepositorio.Modificar(_configuracionSistema);
                    }

                    _uowSeguridad.Commit();

                    Mensaje.Mostrar("Los datos se grabaron correctamente",
                                    PlantillaFormulario.Clases.Constantes.TipoMensaje.Informacion);

                    this.Close();
            }
            else
            {
                Mensaje.Mostrar("La contraseña y su Confirmación no son Iguales.",
                                    PlantillaFormulario.Clases.Constantes.TipoMensaje.Informacion);
                this.txtReNueva.Clear();
                this.txtReNueva.Focus();
            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _00206_ConfigurarParametrosSeguridad_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            var config = _uowSeguridad.ConfiguracionSeguridadRepositorio.ObtenerTodo();

            if(config.Any())
            {
                tipoOperacion = Presentacion.PlantillaFormulario.Clases.TipoOperacion.Modificar;

                _configuracionSistema = config.First();

                this.txtNueva.Text = _configuracionSistema.PasswordDefecto;
                this.txtReNueva.Text = _configuracionSistema.PasswordDefecto;
                this.chkRequerirPwd.Checked = _configuracionSistema.RequerirCambioPassword;
                this.nudMaximos.Value = _configuracionSistema.CantMaximoCaracteres;
                this.nudMayuscula.Value = _configuracionSistema.CantMayusculas;
                this.nudMinimos.Value = _configuracionSistema.CantMinimoCaracteres;
                this.nudMinuscula.Value = _configuracionSistema.CantMinusculas;
                this.nudNumeros.Value = _configuracionSistema.CantNumeros;
                this.nudSimbolos.Value = _configuracionSistema.CantSimbolos;
            }
            else
            {
                tipoOperacion = Presentacion.PlantillaFormulario.Clases.TipoOperacion.Nuevo;
                LimpiarDatosFormulario();

                this.nudMaximos.Value = 16;
                this.nudMinimos.Value = 4;

                this.nudMayuscula.Value = 0;
                this.nudMinuscula.Value = 0;
                this.nudNumeros.Value = 0;
                this.nudSimbolos.Value = 0;
            }
        }

        private void chkMostrarPassword_CheckedChanged(object sender, EventArgs e)
        {
            this.txtNueva.PasswordChar = this.chkMostrarPassword.Checked ? char.MinValue : Convert.ToChar("*");
        }

        private void chkMostrarRePassword_CheckedChanged(object sender, EventArgs e)
        {
            this.txtReNueva.PasswordChar = this.chkMostrarRePassword.Checked ? char.MinValue : Convert.ToChar("*");
        }
    }
}
