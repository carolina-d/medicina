using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using Aplicacion.ConexionEntity;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Seguridad
{
    public partial class _00209_ConfiguracionServidorBaseDatos : Presentacion.PlantillaFormulario.FormularioBase
    {
        public _00209_ConfiguracionServidorBaseDatos()
        {
            InitializeComponent();

            this.Name = "_00209_ConfiguracionServidorBaseDatos";
            this.TituloVentana = "Configuración";
            this.Titulo = "Configuración del Servidor de Base de Datos";
            this.Leyenda = "Aquí Ud. podrá configurar la IP o DNS del servidor de la Base de Datos";

            this.ColorTitulo = Color.Black;
            this.ColorLeyenda = Color.Gray;

            this.UsuarioLogin = Thread.CurrentPrincipal.Identity.Name;

            // Asignacion de Imagenes a los Botones
            AsignarImagenBotones();

            //// Cargar evento de Validacion de Caracteres 
            //this.txtBuscar.KeyPress += new KeyPressEventHandler(base.textBoxLetrasNumeros_KeyPress);

            //// Color al recibir el Foco
            //this.txtBuscar.Enter += new EventHandler(base.control_Enter);

            //// Color al perder el Foco
            //this.txtBuscar.Leave += new EventHandler(base.control_Leave);
        }

        private void AsignarImagenBotones()
        {
            this.btnSalir.Image = Presentacion.PlantillaFormulario.Clases.ImagenesFormulario.Salir;
            this.btnGrabar.Image = Presentacion.PlantillaFormulario.Clases.ImagenesFormulario.Grabar;
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Aplicacion.ConexionEntity.ConfiguracionConexion.Default.Servidor = this.txtServidor.Text;
            Aplicacion.ConexionEntity.ConfiguracionConexion.Default.BaseDatos = this.txtBaseDatos.Text;
            
            Aplicacion.ConexionEntity.ConfiguracionConexion.Default.Save();
        }
        
        private void _00209_ConfiguracionServidorBaseDatos_Load(object sender, EventArgs e)
        {
            this.txtServidor.Text = Aplicacion.ConexionEntity.ConfiguracionConexion.Default.Servidor;
            this.txtBaseDatos.Text = Aplicacion.ConexionEntity.ConfiguracionConexion.Default.BaseDatos;
        }
    }
}
