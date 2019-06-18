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
using Dominio.DatosPaciente.Interfaces.UnidadDeTrabajo;
using Presentacion.PlantillaFormulario.Clases;
using StructureMap;

namespace Presentacion.DatosPaciente.Vistas.Vacunacion
{
    public partial class _00501_ABM_Vacuna : Presentacion.PlantillaFormulario.FormularioABM
    {
        private readonly IUnidadDeTrabajoDatosPaciente datosPacienteUoW
            = ObjectFactory.GetInstance<IUnidadDeTrabajoDatosPaciente>();

        private string _tipoOperacion = string.Empty;

        // Entidades
        private Dominio.DatosPaciente.Entidades.Vacuna vacuna;

        public _00501_ABM_Vacuna()
        {
            InitializeComponent();
        }

        public _00501_ABM_Vacuna(string tipoOperacion, int? entidadId)
            : base(tipoOperacion, entidadId)
        {
            InitializeComponent();

            this.Name = "_00501_ABM_Vacuna";
            this.TituloVentana = "vacuna";
            this.Titulo = "ABM de Vacuna";
            this.Leyenda = "Aquí Ud podrá dar de Alta, Modificar o Eliminar una Vacuna";

            base.UsuarioLogin = Thread.CurrentPrincipal.Identity.Name;

            this._tipoOperacion = tipoOperacion;

            // Cargar evento de validacion para datos Obligatorios
            this.txtAbreviatura.Validated += new EventHandler(base.textBox_Validated);
            this.txtVacuna.Validated += new EventHandler(base.textBox_Validated);

            // Cargar evento de Validacion de Caracteres 
            this.txtAbreviatura.KeyPress += new KeyPressEventHandler(base.textBoxLetrasNumeros_KeyPress);
            this.txtVacuna.KeyPress += new KeyPressEventHandler(base.textBoxLetrasNumeros_KeyPress);

            // Color al recibir el Foco
            this.txtAbreviatura.Enter += new EventHandler(base.control_Enter);
            this.txtVacuna.Enter += new EventHandler(base.control_Enter);

            // Color al perder el Foco
            this.txtAbreviatura.Leave += new EventHandler(base.control_Leave);
            this.txtVacuna.Leave += new EventHandler(base.control_Leave);
            
            Inicializador(tipoOperacion, entidadId);
        }

        public override void CargarDatos(int? entidadId)
        {
            // Instancion por medio del Inyector el Objeto Grupo
            vacuna = ObjectFactory.GetInstance<Dominio.DatosPaciente.Entidades.Vacuna>();

            if (entidadId.HasValue)
            {
                vacuna = datosPacienteUoW.VacunaRepositorio.ObtenerPorId(entidadId.Value);

                this.txtAbreviatura.Text = vacuna.Abreviatura;
                this.txtVacuna.Text = vacuna.Nombre;
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

        public override bool VerificarSiExisteDatos()
        {
            // obtengo todos los grupos de la BD
            var vacunas = datosPacienteUoW.VacunaRepositorio.ObtenerTodo(string.Empty);

            if (_tipoOperacion == PlantillaFormulario.Clases.TipoOperacion.Nuevo)
            {
                if (vacunas.Any(x => x.Abreviatura.Equals(this.txtAbreviatura.Text)))
                {
                    Constantes.Validacion.DatoExistente(this.txtAbreviatura, errorProvider, string.Format("La Abreviatura {0} ya Existe", this.txtAbreviatura.Text));
                    return true;
                }

                if (vacunas.Any(x => x.Nombre.Equals(this.txtVacuna.Text)))
                {
                    Constantes.Validacion.DatoExistente(this.txtVacuna, errorProvider, string.Format("El nombre de la vacuna {0} ya Existe", this.txtVacuna.Text));
                    return true;
                }
            }

            if (_tipoOperacion == PlantillaFormulario.Clases.TipoOperacion.Modificar)
            {
                if (vacunas.Any(x => x.Abreviatura.Equals(this.txtAbreviatura.Text) && x.Id != vacuna.Id))
                {
                    Constantes.Validacion.DatoExistente(this.txtAbreviatura, errorProvider, string.Format("La Abreviatura {0} ya Existe", this.txtAbreviatura.Text));
                    return true;
                }

                if (vacunas.Any(x => x.Nombre.Equals(this.txtVacuna.Text) && x.Id != vacuna.Id))
                {
                    Constantes.Validacion.DatoExistente(this.txtVacuna, errorProvider, string.Format("El nombre de la vacuna {0} ya Existe", this.txtVacuna.Text));
                    return true;
                }
            }

            return false;
        }

        public override void NuevoRegistro()
        {
            try
            {
                vacuna = ObjectFactory.GetInstance<Dominio.DatosPaciente.Entidades.Vacuna>();

                vacuna.Abreviatura = this.txtAbreviatura.Text;
                vacuna.Nombre = this.txtVacuna.Text;

                datosPacienteUoW.VacunaRepositorio.Insertar(vacuna);
                datosPacienteUoW.Commit();

                this.txtAbreviatura.Focus();
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
                datosPacienteUoW.VacunaRepositorio.Eliminar(vacuna);
                datosPacienteUoW.Commit();
            }
            catch (DataException ex)
            {
                Mensaje.Mostrar("La Vacuna seleccionada se encuentra vinculada a otro objeto.", Constantes.TipoMensaje.Error);
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
                vacuna.Abreviatura = this.txtAbreviatura.Text;
                vacuna.Nombre = this.txtVacuna.Text;

                datosPacienteUoW.VacunaRepositorio.Modificar(vacuna);
                datosPacienteUoW.Commit();
            }
            catch (Exception ex)
            {
                Mensaje.Mostrar(ex, Constantes.TipoMensaje.Error);
            }
        }
    }
}
