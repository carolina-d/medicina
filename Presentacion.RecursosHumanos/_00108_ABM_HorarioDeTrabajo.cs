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
using Dominio.RecursosHumanos.Entidades;
using Dominio.RecursosHumanos.Interfaces.UnidadDeTrabajo;
using Presentacion.PlantillaFormulario.Clases;
using StructureMap;

namespace Presentacion.RecursosHumanos
{
    public partial class _00108_ABM_HorarioDeTrabajo : Presentacion.PlantillaFormulario.FormularioABM
    {
        private readonly IUnidadDeTrabajoRecursosHumanos recursosHumanosUoW
            = ObjectFactory.GetInstance<IUnidadDeTrabajoRecursosHumanos>();

        private string _tipoOperacion = string.Empty;

        //Entidades
        private HorarioDeTrabajo horariodetrabajo;

        public _00108_ABM_HorarioDeTrabajo(string tipoOperacion, int? entidadId)
            : base(tipoOperacion, entidadId)
        {
            InitializeComponent();

            this.Name = "_00108_ABM_HorarioDeTrabajo";
            this.TituloVentana = "Horarios De Trabajo";
            this.Titulo = "ABM de Horarios De Trabajo";
            this.Leyenda = "Aquí Ud podrá dar de Alta, Modificar o Eliminar un Horario De Trabajo";

            base.UsuarioLogin = Thread.CurrentPrincipal.Identity.Name;

            this._tipoOperacion = tipoOperacion;

        }

        public override void CargarDatos(int? entidadId)
        {
            horariodetrabajo = ObjectFactory.GetInstance<HorarioDeTrabajo>();

            if (entidadId.HasValue)
            {
                horariodetrabajo = recursosHumanosUoW.HorarioDeTrabajoRepositorio.ObtenerPorId(EntidadId.Value);

                this.cmbConsultorio.SelectedValue = horariodetrabajo.ConsultorioId;
                this.cmbEmpleadoHdT.SelectedValue = horariodetrabajo.EmpleadoId;
                this.dtpHorarioEntradaManiana.Value = Convert.ToDateTime(horariodetrabajo.HoraInM);
                this.dtpHorarioEntradaTarde.Value = Convert.ToDateTime(horariodetrabajo.HoraInT);
                this.dtpHorarioSalidaManiana.Value = Convert.ToDateTime(horariodetrabajo.HoraOutM);
                this.dtpHorarioSalidaTarde.Value = Convert.ToDateTime(horariodetrabajo.HoraOutT);

            }
            else
            {
                Mensaje.Mostrar(new Exception("Error al cargar los Datos"), Constantes.TipoMensaje.Error);
            }
        }

        public override void VerificarDatosObligatorios()
        {
            base.VerificarDatosObligatorios();
            this.ValidateChildren();
        }

        public override void NuevoRegistro()
        {
            try
            {
                horariodetrabajo = new HorarioDeTrabajo
                {
                    ConsultorioId = Convert.ToInt32(this.cmbConsultorio.ValueMember),
                    EmpleadoId = Convert.ToInt32(this.cmbEmpleadoHdT.ValueMember),
                    HoraInM = this.dtpHorarioEntradaManiana.Value.Hour.ToString(),
                    HoraOutM = this.dtpHorarioSalidaManiana.Value.Hour.ToString(),
                    HoraInT = this.dtpHorarioEntradaTarde.Value.Hour.ToString(),
                    HoraOutT = this.dtpHorarioSalidaTarde.Value.Hour.ToString()
                };

                recursosHumanosUoW.HorarioDeTrabajoRepositorio.Insertar(horariodetrabajo);
                recursosHumanosUoW.Commit();

                this.cmbConsultorio.Focus();
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
                recursosHumanosUoW.HorarioDeTrabajoRepositorio.Eliminar(horariodetrabajo);
                recursosHumanosUoW.Commit();

            }
            catch (DataException ex)
            {
                Mensaje.Mostrar("El Empleado que quiere seleccionar se encuentra vinculado a otro objeto.", Constantes.TipoMensaje.Error);
            }
            catch (Exception ex)
            {
                Mensaje.Mostrar(ex, Constantes.TipoMensaje.Error);
            }
        }

        public override void ModificarRegistro()
        {
            try
            {
                horariodetrabajo.ConsultorioId = Convert.ToInt32(this.cmbConsultorio.ValueMember);
                horariodetrabajo.EmpleadoId = Convert.ToInt32(this.cmbEmpleadoHdT.ValueMember);
                horariodetrabajo.HoraInM = this.dtpHorarioEntradaManiana.Value.Hour.ToString();
                horariodetrabajo.HoraOutM = this.dtpHorarioSalidaManiana.Value.Hour.ToString();
                horariodetrabajo.HoraInT = this.dtpHorarioEntradaTarde.Value.Hour.ToString();
                horariodetrabajo.HoraOutT = this.dtpHorarioSalidaTarde.Value.Hour.ToString();

                recursosHumanosUoW.HorarioDeTrabajoRepositorio.Modificar(horariodetrabajo);
                recursosHumanosUoW.Commit();

            }
            catch (Exception ex)
            {
                Mensaje.Mostrar(ex, Constantes.TipoMensaje.Error);
            }
        }

    }
}
