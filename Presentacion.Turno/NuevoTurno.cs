using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio.Turnos.Interfaces.IUnidadDeTrabajo;
using Presentacion.PlantillaFormulario;

namespace Presentacion.Turno
{
    public partial class NuevoTurno : FormularioBase
    {
        private readonly IUnidadDeTrabajoTurno _uowTurno; 

        public NuevoTurno(IUnidadDeTrabajoTurno uowTurno)
        {
            InitializeComponent();

            this.Name = "_00508_Paciente";
            this.TituloVentana = "Paciente";
            this.Titulo = "Consulta de Pacientes";
            this.Leyenda = "Aquí Ud. podrá Agregar, Eliminar o Modificar un Paciente y Consultar sus Datos";

            this.ColorTitulo = Color.Black;
            this.ColorLeyenda = Color.Gray;

            this._uowTurno = uowTurno;
        }
    }
}
