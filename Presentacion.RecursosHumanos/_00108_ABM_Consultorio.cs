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
    public partial class _00108_ABM_Consultorio : Presentacion.PlantillaFormulario.FormularioABM
    {
        private readonly IUnidadDeTrabajoRecursosHumanos recursosHumanosUoW
            = ObjectFactory.GetInstance<IUnidadDeTrabajoRecursosHumanos>();

        private string _tipoOperacion = string.Empty;

        private Consultorio consultorio;

        public _00108_ABM_Consultorio()
        {
            InitializeComponent();
        }

        public _00108_ABM_Consultorio(string tipoOperacion, int? entidadId)
            : base(tipoOperacion, entidadId)
        {
            InitializeComponent();

            this.Name = "_00108_ABM_Consultorio";
            this.TituloVentana = "Consultorio";
            this.Titulo = "ABM de Consultorio";
            this.Leyenda = "Aquí Ud podrá dar de Alta, Modificar o Eliminar un Consultorio";

            base.UsuarioLogin = Thread.CurrentPrincipal.Identity.Name;

            this._tipoOperacion = tipoOperacion;

            // Cargar evento de validacion para datos Obligatorios
            this.txtDescripcion.Validated += new EventHandler(base.textBox_Validated);
            this.txtNumero.Validated += new EventHandler(base.textBox_Validated);

            // Cargar evento de Validacion de Caracteres 
            this.txtDescripcion.KeyPress += new KeyPressEventHandler(base.textBoxLetrasNumeros_KeyPress);
            this.txtNumero.KeyPress += new KeyPressEventHandler(base.textBoxSoloNumeros_KeyPress);

            // Color al recibir el Foco
            this.txtDescripcion.Enter += new EventHandler(base.control_Enter);
            this.txtNumero.Enter += new EventHandler(base.control_Enter);

            // Color al perder el Foco
            this.txtDescripcion.Leave += new EventHandler(base.control_Leave);
            this.txtNumero.Leave += new EventHandler(base.control_Leave);
            
            Inicializador(tipoOperacion, entidadId);
        }


    }
}
