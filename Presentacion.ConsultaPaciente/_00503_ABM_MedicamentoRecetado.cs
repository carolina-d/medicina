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
using Presentacion.PlantillaFormulario;
using Presentacion.ConsultaPaciente;
using Presentacion.PlantillaFormulario.Clases;

namespace Presentacion.ConsultaPaciente
{
    public partial class _00503_ABM_MedicamentoRecetado : FormularioABM
    {
        private readonly IUnidadDeTrabajoConsultaPaciente consultaPacienteUoW 
            = ObjectFactory.GetInstance<IUnidadDeTrabajoConsultaPaciente>();

        private string _tipoOperacion = string.Empty;

        private MedicamentoRecetado medicamentoRecetado;

        public _00503_ABM_MedicamentoRecetado()
        {
            InitializeComponent();
        }

        public _00503_ABM_MedicamentoRecetado(string tipoOperacion, int? entidadId)
            : base(tipoOperacion, entidadId)
        {
            InitializeComponent();

            this.Name = "_00503_ABM_MedicamentoRecetado";
            this.TituloVentana = "Medicamento Recetado";
            this.Titulo = "ABM de Medicamento Recetado";
            this.Leyenda = "Aquí Ud podrá dar de Alta, Modificar o Eliminar un Medicamento Recetado";

            base.UsuarioLogin = Thread.CurrentPrincipal.Identity.Name;

            this._tipoOperacion = tipoOperacion;

            Inicializador(tipoOperacion, entidadId);
        }

        public override void VerificarDatosObligatorios()
        {
            base.VerificarDatosObligatorios();
            this.ValidateChildren();
        }

        public override void CargarDatos(int? entidadId)
        {
            medicamentoRecetado = ObjectFactory.GetInstance<MedicamentoRecetado>();

            if (entidadId.HasValue)
            {
                medicamentoRecetado = consultaPacienteUoW.MedicamentosRecetadosRepositorio.ObtenerPorId(entidadId.Value);

                this.txtIndicaciones.Text = medicamentoRecetado.Indicaciones;
                this.txtMedicRecetado.Text = medicamentoRecetado.NombreMedicamento;
            }
            else
            {
                Mensaje.Mostrar(new Exception("Error al cargar los Datos"), Constantes.TipoMensaje.Error);
            }
        }

        public override void NuevoRegistro()
        {
            try
            {
                medicamentoRecetado = new MedicamentoRecetado
                {
                    NombreMedicamento = this.txtMedicRecetado.Text,
                    Indicaciones = this.txtIndicaciones.Text,
                    ConsultaId = Convert.ToInt32(this.cmbConsulta.ValueMember)
                };

                consultaPacienteUoW.MedicamentosRecetadosRepositorio.Insertar(medicamentoRecetado);
                consultaPacienteUoW.Commit();

                this.txtMedicRecetado.Focus();
            }
            catch (Exception ex)
            {
                Mensaje.Mostrar(ex, Constantes.TipoMensaje.Error);
            }
        }

        public override void EliminarRegistro()
        {
            try
            {
                consultaPacienteUoW.MedicamentosRecetadosRepositorio.Eliminar(medicamentoRecetado);
                consultaPacienteUoW.Commit();

            }
            catch (DataException ex)
            {
                Mensaje.Mostrar("El medicamento seleccionado se encuentra vinculado  a otro objeto.", Constantes.TipoMensaje.Error);

            }
            catch(Exception ex)
            {
                Mensaje.Mostrar(ex, Constantes.TipoMensaje.Error); 
            }
        }

        public override void ModificarRegistro()
        {
            try
            {
                medicamentoRecetado.Indicaciones = this.txtIndicaciones.Text;
                medicamentoRecetado.NombreMedicamento = this.txtMedicRecetado.Text;

                consultaPacienteUoW.MedicamentosRecetadosRepositorio.Modificar(medicamentoRecetado);
                consultaPacienteUoW.Commit();
            }
            catch (Exception ex)
            {
                Mensaje.Mostrar(ex, Constantes.TipoMensaje.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        

    }
}
