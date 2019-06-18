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
using Dominio.Turnos.Interfaces.IUnidadDeTrabajo;
using Servicio.Seguridad.Seguridad;
using Dominio.Base.Repositorios;
using Dominio.RecursosHumanos.Interfaces.UnidadDeTrabajo;
using Presentacion.PlantillaFormulario.Clases;


namespace Presentacion.Turno
{
    public partial class AsignarTurno : Form
    {

        private readonly IUnidadDeTrabajoTurno _uowTurno;
        private readonly ISeguridadServicio _seguridadServicio;
        private readonly IUnidadDeTrabajoRecursosHumanos _uowRecursosHumanos;

        public AsignarTurno(IUnidadDeTrabajoTurno uowTurno, ISeguridadServicio seguridadServicio, 
            IUnidadDeTrabajoRecursosHumanos uowRecursosHumanos)
        {
            InitializeComponent();          

            this._uowTurno = uowTurno;
            this._seguridadServicio = seguridadServicio;
            this._uowRecursosHumanos = uowRecursosHumanos;

            PoblarComboBox(this.cmbEspecialidad, uowRecursosHumanos.EspecialidadRepositorio.ObtenerTodo(), "Descripcion", "Id");
        }

        public virtual void PoblarComboBox(ComboBox cmb, IEnumerable<object> dataSource, string campoMostrar, string campoDevolver)
        {
            if (this.cmbEspecialidad != null)
            {
                cmb.DataSource = dataSource;
                cmb.DisplayMember = campoMostrar;
                cmb.ValueMember = campoDevolver;

                if (dataSource.Count() > 0)
                    cmb.SelectedIndex = 0;
                
            }
            else
            {
                Mensaje.Mostrar(new Exception("Error al cargar los Datos"), Constantes.TipoMensaje.Error);
            }
            
        }

        public void GenerarTurnos(DataGridView dgv)
        {
            DateTime fechainicio = Convert.ToDateTime("8:00 AM");

            DateTime fechafin = Convert.ToDateTime("20:00 PM");

            while (fechainicio < fechafin)
            {
                dgv.Rows.Add(fechainicio.ToString("hh:mm tt"));

                fechainicio.AddMinutes(15);
            }
        }

        private void dgvTurno_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            GenerarTurnos(this.dgvTurno);
        }

        
    }
}
