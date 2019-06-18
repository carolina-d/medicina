using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion.PlantillaFormulario;
using StructureMap;

namespace Presentacion.ConsultaPaciente.HistoriaClinicaVista
{
    public partial class _00601_HistoriaClinica : FormularioBase
    {
        public _00601_HistoriaClinica()
        {
            InitializeComponent();

        }

        private void dgvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvConsulta.Columns[e.ColumnIndex].Name.Equals("dgvbConsulta"))
            {
                var formulario = ObjectFactory.GetInstance<Presentacion.ConsultaPaciente.ConsultaPacienteVista._ConsultaPaciente>();

                formulario.ShowDialog();
            }
        } 
    }
}
