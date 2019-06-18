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
using StructureMap;
using Dominio.ConsultaPaciente.Entidades;
using System.Threading;

namespace Presentacion.ConsultaPaciente.ConsultaPacienteVista
{
    public partial class _ABM_ConsultaPaciente : Presentacion.PlantillaFormulario.FormularioBase
    {
        private readonly IUnidadDeTrabajoConsultaPaciente consultaPacienteUoW
            = ObjectFactory.GetInstance<IUnidadDeTrabajoConsultaPaciente>();

        private string _tipoOperacion = string.Empty;

        public _ABM_ConsultaPaciente()
        {
            InitializeComponent();
        }

        public _ABM_ConsultaPaciente(string tipoOperacion, int? entidadId)
            : base()
        {
            InitializeComponent();


            this.Name = "_00503_ABM_ConsultaPaciente";
            this.TituloVentana = "Consulta Paciente";
            this.Titulo = "ABM de Consulta Paciente";
            this.Leyenda = "Aquí Ud podrá dar de Alta una Consulta de un Paciente";

            base.UsuarioLogin = Thread.CurrentPrincipal.Identity.Name;
        }

        private void _ABM_ConsultaPaciente_Load(object sender, EventArgs e)
        {
            //PoblarComboBox(this.cmbMotivoConsulta, consultaPacienteUoW.MotivoConsultaRepositorio.ObtenerTodo(), "Descripcion", "Id");
        }

        
         
    }
}
