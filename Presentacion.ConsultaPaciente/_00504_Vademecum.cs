using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio.ConsultaPaciente.Interfaces.IUnidadDeTrabajo;

namespace Presentacion.ConsultaPaciente
{
    public partial class _00504_Vademecum : Presentacion.PlantillaFormulario.FormularioConsulta
    {
       private readonly IUnidadDeTrabajoConsultaPaciente _uowConsultaPaciente;
       public _00504_Vademecum(IUnidadDeTrabajoConsultaPaciente uowConsultaPaciente)
        {
            InitializeComponent();
            this.Name = "_00500_Vademecum";
            this.TituloVentana = "Vademecum";
            this.Titulo = "Consulta de Vademecum";
            this.Leyenda = "Aquí Ud. podrá Agregar, Eliminar o Modificar un Vademecum y Consultar sus Datos";

            this.ColorTitulo = Color.Black;
            this.ColorLeyenda = Color.Gray;

            this._uowConsultaPaciente = uowConsultaPaciente;
            this.EstaModoDiccionario = true;
        }


       public override void FormularioBaseConsulta_Load(object sender, EventArgs e)
       {
           base.FormularioBaseConsulta_Load(sender, e);

           FormatearGrilla();

           this.txtBuscar.Focus();
       }

       public override void ActualizarDatosGrilla(string textoBuscar)
       {
           int codigo = -1;

           int.TryParse(textoBuscar, out codigo);

           var resultado = _uowConsultaPaciente.MotivoConsultaRepositorio.ObtenerPorFiltro(x => x.Descripcion.Contains(textoBuscar)
               || x.Codigo.Equals(codigo)).ToList();

           this.dgvBusqueda.DataSource = resultado;
       }

       private void FormatearGrilla()
       {
           this.dgvBusqueda.Columns["PrincipioActivo"].Visible = true;
           this.dgvBusqueda.Columns["PrincipioActivo"].HeaderText = "Vademecum";
           this.dgvBusqueda.Columns["PrincipioActivo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
           this.dgvBusqueda.Columns["PrincipioActivo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
           this.dgvBusqueda.Columns["PrincipioActivo"].Visible = true;

           this.dgvBusqueda.Columns["Dosificacion"].HeaderText = "Vademecum";
           this.dgvBusqueda.Columns["Dosificacion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
           this.dgvBusqueda.Columns["Dosificacion"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
           this.dgvBusqueda.Columns["Dosificacion"].Visible = true;

           this.dgvBusqueda.Columns["NombreComercial"].HeaderText = "Vademecum";
           this.dgvBusqueda.Columns["NombreComercial"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
           this.dgvBusqueda.Columns["NombreComercial"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

           this.dgvBusqueda.Columns["NombreComercial"].Visible = true;
           this.dgvBusqueda.Columns["Composicion"].HeaderText = "Vademecum";
           this.dgvBusqueda.Columns["Composicion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
           this.dgvBusqueda.Columns["Composicion"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

           this.dgvBusqueda.Columns["Composicion"].Visible = true;
           this.dgvBusqueda.Columns["ContraindicacionesPA"].HeaderText = "Vademecum";
           this.dgvBusqueda.Columns["ContraindicacionesPA"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
           this.dgvBusqueda.Columns["ContraindicacionesPA"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

           this.dgvBusqueda.Columns["ContraindicacionesPA"].Visible = true;
           this.dgvBusqueda.Columns["Precauciones"].HeaderText = "Vademecum";
           this.dgvBusqueda.Columns["Precauciones"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
           this.dgvBusqueda.Columns["Precauciones"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

           this.dgvBusqueda.Columns["Precauciones"].Visible = true;
           this.dgvBusqueda.Columns["Interacciones"].HeaderText = "Vademecum";
           this.dgvBusqueda.Columns["Interacciones"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
           this.dgvBusqueda.Columns["Interacciones"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

           this.dgvBusqueda.Columns["Interacciones"].Visible = true;
           this.dgvBusqueda.Columns["Nombre"].HeaderText = "Vademecum";
           this.dgvBusqueda.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
           this.dgvBusqueda.Columns["Nombre"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

           this.dgvBusqueda.Columns["Nombre"].Visible = true;
           this.dgvBusqueda.Columns["Farmacologia"].HeaderText = "Vademecum";
           this.dgvBusqueda.Columns["Farmacologia"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
           this.dgvBusqueda.Columns["Farmacologia"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

           this.dgvBusqueda.Columns["Farmacologia"].Visible = true;
           this.dgvBusqueda.Columns["Farmacodinamia"].HeaderText = "Vademecum";
           this.dgvBusqueda.Columns["Farmacodinamia"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
           this.dgvBusqueda.Columns["Farmacodinamia"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

           this.dgvBusqueda.Columns["Farmacodinamia"].Visible = true;
           this.dgvBusqueda.Columns["Farmacocinetica"].HeaderText = "Vademecum";
           this.dgvBusqueda.Columns["Farmacocinetica"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
           this.dgvBusqueda.Columns["Farmacocinetica"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

           this.dgvBusqueda.Columns["Farmacocinetica"].Visible = true;
           this.dgvBusqueda.Columns["ReaccionesAdversas"].HeaderText = "Vademecum";
           this.dgvBusqueda.Columns["ReaccionesAdversas"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
           this.dgvBusqueda.Columns["ReaccionesAdversas"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

           this.dgvBusqueda.Columns["ReaccionesAdversas"].Visible = true;
           this.dgvBusqueda.Columns["Indicaciones"].HeaderText = "Vademecum";
           this.dgvBusqueda.Columns["Indicaciones"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
           this.dgvBusqueda.Columns["Indicaciones"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

           this.dgvBusqueda.Columns["Indicaciones"].Visible = true;
           this.dgvBusqueda.Columns["Sobredosificacion"].HeaderText = "Vademecum";
           this.dgvBusqueda.Columns["Sobredosificacion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
           this.dgvBusqueda.Columns["Sobredosificacion"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

           this.dgvBusqueda.Columns["Sobredosificacion"].Visible = true;
           this.dgvBusqueda.Columns["Presentaciones"].HeaderText = "Vademecum";
           this.dgvBusqueda.Columns["Presentaciones"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
           this.dgvBusqueda.Columns["Presentaciones"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

           this.dgvBusqueda.Columns["Presentaciones"].Visible = true;
           this.dgvBusqueda.Columns["Advertencias"].HeaderText = "Vademecum";
           this.dgvBusqueda.Columns["Advertencias"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
           this.dgvBusqueda.Columns["Advertencias"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

           this.dgvBusqueda.Columns["Advertencias"].Visible = true;
           this.dgvBusqueda.Columns["AccionTerapeutica"].HeaderText = "Vademecum";
           this.dgvBusqueda.Columns["AccionTerapeutica"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
           this.dgvBusqueda.Columns["AccionTerapeutica"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

           this.dgvBusqueda.Columns["AccionTerapeutica"].Visible = true;
           this.dgvBusqueda.Columns["Contraindicaciones"].HeaderText = "Vademecum";
           this.dgvBusqueda.Columns["Contraindicaciones"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
           this.dgvBusqueda.Columns["Contraindicaciones"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

           this.dgvBusqueda.Columns["Contraindicaciones"].Visible = true;

       }

       public override void btnNuevo_Click(object sender, EventArgs e)
       {
           if (new _00505_ABM_Vademecum(PlantillaFormulario.Clases.TipoOperacion.Nuevo, null).ShowDialog() == DialogResult.Yes)
           {
               ActualizarDatosGrilla(string.Empty);
           }
       }

       public override void btnModificar_Click(object sender, EventArgs e)
       {
           if (new _00505_ABM_Vademecum(PlantillaFormulario.Clases.TipoOperacion.Modificar, base.EntidadId).ShowDialog() == DialogResult.Yes)
           {
               ActualizarDatosGrilla(string.Empty);
           }
       }

       public override void btnEliminar_Click(object sender, EventArgs e)
       {
           if (new _00505_ABM_Vademecum(PlantillaFormulario.Clases.TipoOperacion.Eliminar, base.EntidadId).ShowDialog() == DialogResult.Yes)
           {
               ActualizarDatosGrilla(string.Empty);
           }
       }
       
    }
}
