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
using Dominio.ConsultaPaciente.Entidades;
using Dominio.ConsultaPaciente.Interfaces.IUnidadDeTrabajo;
using Presentacion.PlantillaFormulario.Clases;
using StructureMap;
using Dominio.Base;

namespace Presentacion.ConsultaPaciente
{
    public partial class _00503_ABM_MotivoConsulta : Presentacion.PlantillaFormulario.FormularioABM
    {
        private readonly IUnidadDeTrabajoConsultaPaciente consultaPacienteUoW
            = ObjectFactory.GetInstance<IUnidadDeTrabajoConsultaPaciente>();

        private string _tipoOperacion = string.Empty;
        private TextBox txtDescripcionMotivoConsulta;
        private TextBox txtCodigoMotivoConsulta;
        private Label label1;
        private Label label2;
        private MotivoConsulta motivoConsulta;

        public _00503_ABM_MotivoConsulta()
        {
            InitializeComponent();
        }

        public _00503_ABM_MotivoConsulta(string tipoOperacion, int? entidadId)
            : base(tipoOperacion, entidadId)
        {
            InitializeComponent();

            this.Name = "_00503_ABM_MotivoConsulta";
            this.TituloVentana = "MotivoConsulta";
            this.Titulo = "ABM de MotivoConsulta";
            this.Leyenda = "Aquí Ud podrá dar de Alta, Modificar o Eliminar un MotivoConsulta";

            this._tipoOperacion = tipoOperacion;

            // Cargar evento de validacion para datos Obligatorios
            this.txtCodigoMotivoConsulta.Validated += new EventHandler(base.textBox_Validated);
            this.txtDescripcionMotivoConsulta.Validated += new EventHandler(base.textBox_Validated);

            // Cargar evento de Validacion de Caracteres 
            this.txtCodigoMotivoConsulta.KeyPress += new KeyPressEventHandler(base.textBoxLetrasNumeros_KeyPress);
            this.txtDescripcionMotivoConsulta.KeyPress += new KeyPressEventHandler(base.textBoxLetrasNumeros_KeyPress);


            // Color al recibir el Foco
            this.txtCodigoMotivoConsulta.Enter += new EventHandler(base.control_Enter);
            this.txtDescripcionMotivoConsulta.Enter += new EventHandler(base.control_Enter);


            // Color al perder el Foco
            this.txtCodigoMotivoConsulta.Leave += new EventHandler(base.control_Leave);
            this.txtDescripcionMotivoConsulta.Leave += new EventHandler(base.control_Leave);



            Inicializador(tipoOperacion, entidadId);
        }

        public override void VerificarDatosObligatorios()
        {
            base.VerificarDatosObligatorios();
            this.ValidateChildren();
        }

        public override bool VerificarSiExisteDatos()
        {
            // obtengo todos los grupos de la BD
            var motivoConsultas = consultaPacienteUoW.SintomasRepositorio.ObtenerTodo(string.Empty);

            if (_tipoOperacion == PlantillaFormulario.Clases.TipoOperacion.Nuevo)
            {
                if (motivoConsultas.Any(x => x.Codigo.Equals(this.txtCodigoMotivoConsulta.Text)))
                {
                    Constantes.Validacion.DatoExistente(this.txtCodigoMotivoConsulta, errorProvider, string.Format("El codigo {0} ya Existe", this.txtCodigoMotivoConsulta.Text));
                    return true;
                }

                if (motivoConsultas.Any(x => x.Descripcion.Equals(this.txtDescripcionMotivoConsulta.Text)))
                {
                    Constantes.Validacion.DatoExistente(this.txtDescripcionMotivoConsulta, errorProvider, string.Format("La descripcion {0} ya Existe", this.txtDescripcionMotivoConsulta.Text));
                    return true;
                }
            }

            if (_tipoOperacion == PlantillaFormulario.Clases.TipoOperacion.Modificar)
            {
                if (motivoConsultas.Any(x => x.Codigo.Equals(this.txtCodigoMotivoConsulta.Text) && x.Id != motivoConsulta.Id))
                {
                    Constantes.Validacion.DatoExistente(this.txtCodigoMotivoConsulta, errorProvider, string.Format("El Codigo {0} ya Existe", this.txtCodigoMotivoConsulta.Text));
                    return true;
                }

                if (motivoConsultas.Any(x => x.Descripcion.Equals(this.txtDescripcionMotivoConsulta.Text) && x.Id != motivoConsulta.Id))
                {
                    Constantes.Validacion.DatoExistente(this.txtDescripcionMotivoConsulta, errorProvider, string.Format("La Descripcion {0} ya Existe", this.txtDescripcionMotivoConsulta.Text));
                    return true;
                }
            }

            return false;
        }

        public override void NuevoRegistro()
        {
            try
            {
                motivoConsulta = new MotivoConsulta
                {
                     Codigo= Convert.ToInt32(this.txtCodigoMotivoConsulta.Text),
                    Descripcion = this.txtDescripcionMotivoConsulta.Text,


                };

                consultaPacienteUoW.MotivoConsultaRepositorio.Insertar(motivoConsulta);
                consultaPacienteUoW.Commit();

                this.txtCodigoMotivoConsulta.Focus();
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
                consultaPacienteUoW.MotivoConsultaRepositorio.Eliminar(motivoConsulta);
                consultaPacienteUoW.Commit();
            }
            catch (DataException ex)
            {
                Mensaje.Mostrar("El MotivoConsulta seleccionado se encuentra vinculado a otro objeto.", Constantes.TipoMensaje.Error);
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
                motivoConsulta.Codigo = Convert.ToInt32(this.txtCodigoMotivoConsulta.Text);
                motivoConsulta.Descripcion = this.txtDescripcionMotivoConsulta.Text;

                consultaPacienteUoW.MotivoConsultaRepositorio.Modificar(motivoConsulta);
                consultaPacienteUoW.Commit();
            }
            catch (Exception ex)
            {
                Mensaje.Mostrar(ex, Constantes.TipoMensaje.Error);
            }
        }

        private void InitializeComponent()
        {
            this.txtDescripcionMotivoConsulta = new System.Windows.Forms.TextBox();
            this.txtCodigoMotivoConsulta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescripcionMotivoConsulta
            // 
            this.txtDescripcionMotivoConsulta.Location = new System.Drawing.Point(192, 172);
            this.txtDescripcionMotivoConsulta.Name = "txtDescripcionMotivoConsulta";
            this.txtDescripcionMotivoConsulta.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcionMotivoConsulta.TabIndex = 5;
            // 
            // txtCodigoMotivoConsulta
            // 
            this.txtCodigoMotivoConsulta.Location = new System.Drawing.Point(192, 146);
            this.txtCodigoMotivoConsulta.Name = "txtCodigoMotivoConsulta";
            this.txtCodigoMotivoConsulta.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoMotivoConsulta.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Descripcion";
            // 
            // _00503_ABM_MotivoConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(484, 312);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigoMotivoConsulta);
            this.Controls.Add(this.txtDescripcionMotivoConsulta);
            this.Name = "_00503_ABM_MotivoConsulta";
            this.Controls.SetChildIndex(this.txtDescripcionMotivoConsulta, 0);
            this.Controls.SetChildIndex(this.txtCodigoMotivoConsulta, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.imgTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    }
}
