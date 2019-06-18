using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion.PlantillaFormulario.Clases;

namespace Presentacion.PlantillaFormulario
{
    public partial class FormularioConsulta : FormularioBase
    {
        private int _identificador;

        public bool EstaModoDiccionario
        {
            set
            {
                this.btnEliminar.Visible = !value;
                this.btnModificar.Visible = !value;
                this.btnNuevo.Visible = !value;
                this.separador.Visible = !value;
            }
        }

        public FormularioConsulta()
        {
            InitializeComponent();

            AsignarImagenBotones();

            this.EntidadId = null;
        }

        public virtual void AsignarImagenBotones()
        {
            this.btnNuevo.Image = ImagenesFormulario.Nuevo;
            this.btnModificar.Image = ImagenesFormulario.Modificar;
            this.btnEliminar.Image = ImagenesFormulario.Eliminar;
            this.btnActualizar.Image = ImagenesFormulario.Actualizar;
            this.btnImprimir.Image = ImagenesFormulario.Imprimir;
            this.btnSalir.Image = ImagenesFormulario.Salir;
            
            this.imgBuscar.Image = ImagenesFormulario.Buscar;
        }

        public virtual void ActualizarDatosGrilla(string textoBuscar)
        {

        }

        public virtual void FormularioBaseConsulta_Load(object sender, EventArgs e)
        {
            ActualizarDatosGrilla(string.Empty);
            LimpiarCamposGrilla(dgvBusqueda);
        }

        /// <summary>
        /// Metodo para limpiar las columnas de la grilla
        /// </summary>
        /// <param name="grilla"></param>
        public virtual void LimpiarCamposGrilla(DataGridView grilla)
        {
            for (var i = 0; i < grilla.ColumnCount; i++)
            {
                grilla.Columns[i].Visible = false;
            }
        }

        #region Botones

        public virtual void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public virtual void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        public virtual void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarDatosGrilla(string.Empty);
        }

        public virtual void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvBusqueda.RowCount <= 0)
            {
                Mensaje.Mostrar("No hay Datos Cargados",
                                Presentacion.PlantillaFormulario.Clases.Constantes.TipoMensaje.Informacion);

                return;
            }
        }

        public virtual void btnModificar_Click(object sender, EventArgs e)
        {

        }

        public virtual void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        public virtual void btnBuscar_Click(object sender, EventArgs e)
        {
            ActualizarDatosGrilla(this.txtBuscar.Text);
        }

        public override void control_Enter(object sender, EventArgs e)
        {
            base.control_Enter(sender, e);
        }

        public override void control_Leave(object sender, EventArgs e)
        {
            base.control_Leave(sender, e);
        }

        public virtual void dgvBusqueda_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBusqueda.RowCount > 0)
            {
                if (int.TryParse(this.dgvBusqueda["Id", e.RowIndex].Value.ToString(), out _identificador))
                {
                    EntidadId = _identificador;
                }
                else
                {
                    EntidadId = null;
                }
            }
            else
            {
                EntidadId = null;
            }
        }

        #endregion
    }
}
