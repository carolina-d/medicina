using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aplicacion.Seguridad.DTOs;
using Dominio.Seguridad.Interfaces.UnidadDeTrabajo;
using Presentacion.PlantillaFormulario.Clases;
using Presentacion.RecursosHumanos;
using Servicio.Seguridad.Seguridad;
using StructureMap;

namespace X_Medicina
{
    public partial class _00001_Principal : Form
    {
        private readonly ISeguridadServicio _seguridadServicio;
        private readonly IUnidadDeTrabajoSeguridad _uowSeguridad;

        public _00001_Principal(ISeguridadServicio seguridadServicio, IUnidadDeTrabajoSeguridad uowSeguridad)
        {
            InitializeComponent();

            this._seguridadServicio = seguridadServicio;
            this._uowSeguridad = uowSeguridad;

            this.BackgroundImage = Properties.Resources.FondoSistemaMedico;

            AsignarImagenesBoton();
        }

        private void AsignarImagenesBoton()
        {
            this.btnSalir.Image = Presentacion.PlantillaFormulario.Clases.ImagenesFormulario.Salir;
            this.btnPaciente.Image = Presentacion.PlantillaFormulario.Clases.ImagenesFormulario.Empleado;
        }

        private void VerificarSiTieneAccesoAlFormulario(Form formulario)
        {
            if (_seguridadServicio.VerificarAccesoFormulario(formulario.Name))
            {
                formulario.ShowDialog();
            }
            else
            {
                Mensaje.Mostrar("Acceso Denegado",
                                Presentacion.PlantillaFormulario.Clases.Constantes.TipoMensaje.Informacion);
            }
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void consultaDeEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form_Empresa = ObjectFactory.GetInstance<Presentacion.RecursosHumanos._00100_Empresa>();
            VerificarSiTieneAccesoAlFormulario(form_Empresa);
        }

        private void nuevaEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form_ABM_Empresa = new _00101_ABM_Empresa(Presentacion.PlantillaFormulario.Clases.TipoOperacion.Nuevo,
                null);
            VerificarSiTieneAccesoAlFormulario(form_ABM_Empresa);
        }

        private void consultaEspecialidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form_Especialidad = ObjectFactory.GetInstance<Presentacion.RecursosHumanos._00102_Especialidad>();
            VerificarSiTieneAccesoAlFormulario(form_Especialidad);
        }

        private void consultaEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form_Empleado = ObjectFactory.GetInstance<Presentacion.RecursosHumanos._00104_Empleado>();
            VerificarSiTieneAccesoAlFormulario(form_Empleado);
        }

        private void nuevoEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form_ABM_Empleado = new _00105_ABM_Empleado(Presentacion.PlantillaFormulario.Clases.TipoOperacion.Nuevo,
                null);
            VerificarSiTieneAccesoAlFormulario(form_ABM_Empleado);
        }

        private void consultaSexoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form_Sexo = ObjectFactory.GetInstance<Presentacion.Comun._00300_Sexo>();
            VerificarSiTieneAccesoAlFormulario(form_Sexo);
        }

        private void consultaEstadoCivilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form_EstadoCivil = ObjectFactory.GetInstance<Presentacion.Comun._00302_EstadoCivil>();
            VerificarSiTieneAccesoAlFormulario(form_EstadoCivil);
        }

        private void asignarEmpleadoAEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form_AsignarEmpleadoEmpresa =
                ObjectFactory.GetInstance<Presentacion.RecursosHumanos._00106_AsignarEmpleadoEmpresa>();
            VerificarSiTieneAccesoAlFormulario(form_AsignarEmpleadoEmpresa);
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form_Usuario = ObjectFactory.GetInstance<Presentacion.Seguridad._00200_Usuario>();
            VerificarSiTieneAccesoAlFormulario(form_Usuario);
        }

        private void configuracionCorreoElectronicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form_config_Correo =
                ObjectFactory.GetInstance<Presentacion.CorreoElectronico._40000_ConfiguracionMail>();
            VerificarSiTieneAccesoAlFormulario(form_config_Correo);
        }

        private void consultaPerfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form_Perfil = ObjectFactory.GetInstance<Presentacion.Seguridad._00201_Perfil>();
            VerificarSiTieneAccesoAlFormulario(form_Perfil);
        }

        private void nuevoPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form_ABM_Perfil =
                new Presentacion.Seguridad._00202_ABM_Perfil(
                    Presentacion.PlantillaFormulario.Clases.TipoOperacion.Nuevo, null);
            VerificarSiTieneAccesoAlFormulario(form_ABM_Perfil);
        }

        private void asignarUsuarioAPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form_AsignarUsuarioPerfil =
                ObjectFactory.GetInstance<Presentacion.Seguridad._00203_AsignarUsuarioPerfil>();
            VerificarSiTieneAccesoAlFormulario(form_AsignarUsuarioPerfil);
        }

        private void asignarFormularioAPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form_AsignarFormularioPerfil =
                ObjectFactory.GetInstance<Presentacion.Seguridad._00205_AsignarFormularioPerfil>();
            VerificarSiTieneAccesoAlFormulario(form_AsignarFormularioPerfil);

            _seguridadServicio.CargarFormulariosPerfil(Thread.CurrentPrincipal.Identity.Name);
        }

        private void configuraciónSeguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form_ConfiguracionSeguridad =
                ObjectFactory.GetInstance<Presentacion.Seguridad._00206_ConfigurarParametrosSeguridad>();
            VerificarSiTieneAccesoAlFormulario(form_ConfiguracionSeguridad);
        }

        private void formulariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formulariosAssembly = new List<FormularioDTO>();

            ObtenerTodosFormularios(ref formulariosAssembly, Presentacion.Comun.ComunAsembly.SegAssembly);
            ObtenerTodosFormularios(ref formulariosAssembly, Presentacion.CorreoElectronico.CorreoElectronicoAsembly.SegAssembly);
            ObtenerTodosFormularios(ref formulariosAssembly, Presentacion.RecursosHumanos.RecursosHumanosAsembly.SegAssembly);
            ObtenerTodosFormularios(ref formulariosAssembly, Presentacion.Seguridad.SeguridadAsembly.SegAssembly);
            ObtenerTodosFormularios(ref formulariosAssembly, Presentacion.DatosPaciente.DatosPacienteAsembly.SegAssembly);
            
            var form_Formularios = new Presentacion.Seguridad._00204_Formulario(formulariosAssembly);
            VerificarSiTieneAccesoAlFormulario(form_Formularios);
        }

        private void ObtenerTodosFormularios(ref List<FormularioDTO> listaForms, Assembly ass)
        {
            foreach (Type t in ass.GetTypes())
            {
                if (t.Name[0].ToString().Equals("_"))
                {
                    var formularioDTONuevo = ObjectFactory.GetInstance<FormularioDTO>();

                    formularioDTONuevo.Codigo = int.Parse(t.Name.Substring(1, 5));
                    formularioDTONuevo.Descripcion = t.Name.Substring(7, (t.Name.Length - 7));
                    formularioDTONuevo.DescripcionLarga = t.Name;
                    formularioDTONuevo.ExisteBase = false;

                    listaForms.Add(formularioDTONuevo);
                }
            }
        }

        private void _00001_Principal_Load(object sender, EventArgs e)
        {
            LoginUsuario();
        }

        private void cambioDeContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form_CambioPassword = ObjectFactory.GetInstance<Presentacion.Seguridad._00208_CambioPassword>();
            VerificarSiTieneAccesoAlFormulario(form_CambioPassword);
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginUsuario();
        }

        private void LoginUsuario()
        {
            var form_Login = ObjectFactory.GetInstance<Presentacion.Seguridad._00207_Login>();
            form_Login.ShowDialog();

            if (!form_Login.TieneAcceso)
            {
                Application.Exit();
            }
            else
            {
                _seguridadServicio.CargarFormulariosPerfil(form_Login.UsuarioLogin);
                this.lblUsuarioLogin.Text = string.Format("Usuario: {0}", Thread.CurrentPrincipal.Identity.Name);
            }
        }

        private void configuracionServidorBaseDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form_ServidorBD =
                ObjectFactory.GetInstance<Presentacion.Seguridad._00209_ConfiguracionServidorBaseDatos>();

            form_ServidorBD.ShowDialog();
        }

        private void consultaVacunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form_vacunas = ObjectFactory.GetInstance<Presentacion.DatosPaciente.Vistas.Vacunacion._00500_Vacunas>();
            VerificarSiTieneAccesoAlFormulario(form_vacunas);
        }

        private void nuevaVacunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form_ABM_Vacuna =
                new Presentacion.DatosPaciente.Vistas.Vacunacion._00501_ABM_Vacuna(
                    Presentacion.PlantillaFormulario.Clases.TipoOperacion.Nuevo, null);
            VerificarSiTieneAccesoAlFormulario(form_ABM_Vacuna);
        }

        private void consultaCalendarioVacunacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form_Calendariovacunacion = ObjectFactory.GetInstance<Presentacion.DatosPaciente.Vistas.Vacunacion._00504_CalendarioVacunacion>();
            VerificarSiTieneAccesoAlFormulario(form_Calendariovacunacion);
        }

        private void nuevoCalendarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form_ABM_Calendariovacunacion =
                new Presentacion.DatosPaciente.Vistas.Vacunacion._00505_ABM_CalendarioVacunacion(
                    Presentacion.PlantillaFormulario.Clases.TipoOperacion.Nuevo, null);
            VerificarSiTieneAccesoAlFormulario(form_ABM_Calendariovacunacion);
        }

        private void consultaObraScoialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form_obraSocial = ObjectFactory.GetInstance<Presentacion.Comun._00304_ObraSocial>();
            VerificarSiTieneAccesoAlFormulario(form_obraSocial);
        }

        private void nuevaObraSocialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form_ABM_ObraSocial =
                new Presentacion.Comun._00305_ABM_ObraSocial(Presentacion.PlantillaFormulario.Clases.TipoOperacion.Nuevo, null);
            VerificarSiTieneAccesoAlFormulario(form_ABM_ObraSocial);
        }

        private void consultarGrupoSanguineoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form_GrupoSanguineo = ObjectFactory.GetInstance<Presentacion.DatosPaciente.Vistas.Paciente._00510_GrupoSanguineo>();
            VerificarSiTieneAccesoAlFormulario(form_GrupoSanguineo);
        }

        private void nuevoGrupoSanguineoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form_NuevoGrupoSanguineo =
                new Presentacion.DatosPaciente.Vistas.Paciente._00511_ABM_GrupoSanguineo(Presentacion.PlantillaFormulario.Clases.TipoOperacion.Nuevo, null);
            VerificarSiTieneAccesoAlFormulario(form_NuevoGrupoSanguineo);
        }

        private void consultaPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form_paciente = ObjectFactory.GetInstance<Presentacion.DatosPaciente.Vistas.Paciente._00508_Paciente>();
            VerificarSiTieneAccesoAlFormulario(form_paciente);
        }

        private void nuevoPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form_NuevoPaciente =
                new Presentacion.DatosPaciente.Vistas.Paciente._00509_ABM_Paciente(Presentacion.PlantillaFormulario.Clases.TipoOperacion.Nuevo, null);
            VerificarSiTieneAccesoAlFormulario(form_NuevoPaciente);
        }

        private void consultaPatologiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form_patologia = ObjectFactory.GetInstance<Presentacion.DatosPaciente.Vistas.Patologia._00513_Patologia>();
            VerificarSiTieneAccesoAlFormulario(form_patologia);
        }

        private void nuevaPatologiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form_NuevoPatologia =
                new Presentacion.DatosPaciente.Vistas.Patologia._00514_ABM_Patologia(Presentacion.PlantillaFormulario.Clases.TipoOperacion.Nuevo, null);
            VerificarSiTieneAccesoAlFormulario(form_NuevoPatologia);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var form_ABM_HorarioDeTrabajo = new _00108_ABM_HorarioDeTrabajo(Presentacion.PlantillaFormulario.Clases.TipoOperacion.Nuevo, null);

            form_ABM_HorarioDeTrabajo.ShowDialog();

        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form_HorarioDeTrabajo = ObjectFactory.GetInstance<Presentacion.RecursosHumanos._00107_HorarioDeTrabajo>();
            form_HorarioDeTrabajo.ShowDialog();
        }

        private void asignarEmpleadoAEspecialidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form_EmpleadoAEspecialidad = ObjectFactory.GetInstance<Presentacion.RecursosHumanos._00109_AsignarEmpleadoEspecialidad>();

            form_EmpleadoAEspecialidad.ShowDialog();
        }

        private void medicamentosRecetadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form_MedicRecetado = ObjectFactory.GetInstance<Presentacion.ConsultaPaciente._00503_ABM_MedicamentoRecetado>();
            VerificarSiTieneAccesoAlFormulario(form_MedicRecetado);
        }

        private void consultaMedicRecetadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form_MedicRec = ObjectFactory.GetInstance<Presentacion.ConsultaPaciente._00505__MedicamentoRecetado>();
            VerificarSiTieneAccesoAlFormulario(form_MedicRec);
        }

        private void nuevaConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var a = new Presentacion.ConsultaPaciente.ConsultaPacienteVista._ABM_ConsultaPaciente();
            //a.ShowDialog();

            var Form_ABMConsulta = ObjectFactory.GetInstance<Presentacion.ConsultaPaciente.ConsultaPacienteVista._ABM_ConsultaPaciente>();
            VerificarSiTieneAccesoAlFormulario(Form_ABMConsulta);
        }

        private void tsbHistoriaClinica_Click(object sender, EventArgs e)
        {
            var formularioHC = ObjectFactory.GetInstance<Presentacion.ConsultaPaciente.HistoriaClinicaVista._00601_HistoriaClinica>();

            formularioHC.ShowDialog();
        }

        private void tsbTurno_Click(object sender, EventArgs e)
        {
            var formTurno = ObjectFactory.GetInstance<Presentacion.Turno.AsignarTurno>();

            VerificarSiTieneAccesoAlFormulario(formTurno);
        }

    }
}
