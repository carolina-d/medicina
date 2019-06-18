using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using Aplicacion.Seguridad.DTOs;
using Dominio.Seguridad.Entidades;
using Dominio.Seguridad.Interfaces.UnidadDeTrabajo;
using Servicio.Seguridad.Formulario;
using StructureMap;

namespace Presentacion.Seguridad
{
    public partial class _00204_Formulario : Presentacion.PlantillaFormulario.FormularioBase
    {
        private readonly IFormularioServicio _formServicio = ObjectFactory.GetInstance<IFormularioServicio>();

        private List<FormularioDTO> _listaFormularios;

        public _00204_Formulario(List<FormularioDTO> listaFormularios)
        {
            InitializeComponent();

            this.Name = "_00204_Formulario";
            this.TituloVentana = "Formularios";
            this.Titulo = "Pantallas del Sistema";
            this.Leyenda = "Aquí Actualizar su Base de Datos con las pantallas nuevas del sistema";

            this.ColorTitulo = Color.Black;
            this.ColorLeyenda = Color.Gray;

            this._listaFormularios = listaFormularios;

            this.UsuarioLogin = Thread.CurrentPrincipal.Identity.Name;

            // Cargar evento de Validacion de Caracteres 
            this.txtBuscar.KeyPress += new KeyPressEventHandler(base.textBoxLetrasNumeros_KeyPress);
            
            // Color al recibir el Foco
            this.txtBuscar.Enter += new EventHandler(base.control_Enter);
            
            // Color al perder el Foco
            this.txtBuscar.Leave += new EventHandler(base.control_Leave);
            
            AsignarImagenBotones();

            _formServicio.CargarFormularios(ref _listaFormularios);
        }

        private void AsignarImagenBotones()
        {
            this.btnSalir.Image = Presentacion.PlantillaFormulario.Clases.ImagenesFormulario.Salir;
            this.imgBuscar.Image = Presentacion.PlantillaFormulario.Clases.ImagenesFormulario.Buscar;
        }
        
        private void MostrarDatosGrilla(string cadena)
        {
            var codigo = int.MinValue;
            
            int.TryParse(cadena, out codigo);

            this.dgvGrilla.DataSource = _listaFormularios.Where(x => x.Descripcion.ToUpper().Contains(cadena.ToUpper())
                                                                     || x.DescripcionLarga.ToUpper().Contains(cadena.ToUpper())
                                                                     || x.Codigo.Equals(codigo)).Select(x => new
                                                                     {
                                                                         Id = x.Id,
                                                                         Codigo = x.Codigo,
                                                                         Descripcion = x.Descripcion,
                                                                         DescripcionLarga = x.DescripcionLarga,
                                                                         EnBase = x.ExisteBase ? "SI" : "NO"
                                                                     }).ToList();

            FormatearGrilla();

            btnActualizarBase.Visible = _listaFormularios.Any(x => x.ExisteBase == false);
        }

        private void FormatearGrilla()
        {
            this.dgvGrilla.Columns["Id"].Visible = false;

            this.dgvGrilla.Columns["Codigo"].Visible = true;
            this.dgvGrilla.Columns["Codigo"].HeaderText = "Código";
            this.dgvGrilla.Columns["Codigo"].Width = 50;
            this.dgvGrilla.Columns["Codigo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvGrilla.Columns["Codigo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dgvGrilla.Columns["Descripcion"].Visible = true;
            this.dgvGrilla.Columns["Descripcion"].HeaderText = "Nombre Pantalla";
            this.dgvGrilla.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvGrilla.Columns["Descripcion"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dgvGrilla.Columns["DescripcionLarga"].Visible = true;
            this.dgvGrilla.Columns["DescripcionLarga"].HeaderText = "Nombre Completo Pantalla";
            this.dgvGrilla.Columns["DescripcionLarga"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvGrilla.Columns["DescripcionLarga"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dgvGrilla.Columns["EnBase"].Visible = true;
            this.dgvGrilla.Columns["EnBase"].HeaderText = "BD";
            this.dgvGrilla.Columns["EnBase"].Width = 50;
            this.dgvGrilla.Columns["EnBase"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvGrilla.Columns["EnBase"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _00204_Formulario_Load(object sender, EventArgs e)
        {
            MostrarDatosGrilla(string.Empty);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MostrarDatosGrilla(this.txtBuscar.Text);
        }

        private void btnActualizarBase_Click(object sender, EventArgs e)
        {
            _formServicio.ActualizarBaseDeDatos(_listaFormularios);
            _formServicio.CargarFormularios(ref _listaFormularios);
            MostrarDatosGrilla(string.Empty);
        }
    }
}
