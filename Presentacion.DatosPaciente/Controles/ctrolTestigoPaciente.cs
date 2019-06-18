using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.DatosPaciente.Controles
{
    public partial class ctrolTestigoPaciente : UserControl
    {
        public int PacienteId { get; set; }

        public string ApyNomPaciente
        {
            set { this.lblPaciente.Text = string.IsNullOrEmpty(value) ? "Paciente" : value; }
        }

        public string LeyendaPaciente
        {
            set { this.lblLeyenda.Text = string.IsNullOrEmpty(value) ? "Datos del Paciente" : value; }
        }

        public Image FotoPaciente { 
            set { this.imgFotoPaciente.Image = value ?? Imagenes.RecursosPaciente.Paciente; }
        }

        public ctrolTestigoPaciente()
        {
            InitializeComponent();
        }
    }
}
