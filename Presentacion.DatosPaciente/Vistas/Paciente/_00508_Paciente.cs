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
using Aplicacion.DatosPaciente.Clases;
using Dominio.DatosPaciente.Interfaces.UnidadDeTrabajo;
using Aplicacion.DatosPaciente.DTOs;
using Presentacion.PlantillaFormulario.Clases;
using Servicio.Seguridad.Seguridad;
using StructureMap;

namespace Presentacion.DatosPaciente.Vistas.Paciente
{
    public partial class _00508_Paciente : Presentacion.PlantillaFormulario.FormularioConsulta
    {
        private readonly IUnidadDeTrabajoDatosPaciente _uowDatosPaciente;
        private readonly ISeguridadServicio _seguridadServicio;

        public _00508_Paciente(IUnidadDeTrabajoDatosPaciente uowDatosPaciente,
            ISeguridadServicio seguridadServicio)
        {
            InitializeComponent();

            this.Name = "_00508_Paciente";
            this.TituloVentana = "Paciente";
            this.Titulo = "Consulta de Pacientes";
            this.Leyenda = "Aquí Ud. podrá Agregar, Eliminar o Modificar un Paciente y Consultar sus Datos";
            
            this.ColorTitulo = Color.Black;
            this.ColorLeyenda = Color.Gray;

            this._uowDatosPaciente = uowDatosPaciente;
            this._seguridadServicio = seguridadServicio;

            this.UsuarioLogin = Thread.CurrentPrincipal.Identity.Name;

            // Sirve para poner los botones nuevo, modificar y eliminar en visible false,
            // ya que no se podra realizar ninguna de las operaciones antes mencionadas
            this.EstaModoDiccionario = false;

             
            // Boton Plan de Vacunacion
            this.MenuConsulta.Items.Add(CrearBotonPlanVacunacion());
            // Boton Patología
            this.MenuConsulta.Items.Add(CrearBotonPatologia());
        }

        private ToolStripButton CrearBotonPlanVacunacion()
        {
            var btnPlanVacunacion = new ToolStripButton
            {
                Image = Presentacion.PlantillaFormulario.Clases.ImagenesFormulario.Empleado,
                ImageTransparentColor = System.Drawing.Color.Magenta,
                Name = "btnPlanVacunacion",
                Size = new System.Drawing.Size(46, 44),
                Text = "Plan Vacunacion",
                TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            };
            btnPlanVacunacion.Click += new System.EventHandler(this.btnPlanVacunacion_Click);

            return btnPlanVacunacion;
        }

        private ToolStripButton CrearBotonPatologia()
        {
            var btnPatologia = new ToolStripButton
            {
                Image = Presentacion.PlantillaFormulario.Clases.ImagenesFormulario.Empleado,
                ImageTransparentColor = System.Drawing.Color.Magenta,
                Name = "btnPatologia",
                Size = new System.Drawing.Size(46, 44),
                Text = "Patología",
                TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            };

            btnPatologia.Click += new System.EventHandler(this.btnPatologia_Click);

            return btnPatologia;
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

        public virtual void btnPlanVacunacion_Click(object sender, EventArgs e)
        {
            var form_Plan =
                ObjectFactory.GetInstance<Presentacion.DatosPaciente.Vistas.Paciente._00502_PlanVacunacion>();
                
            var paciente = _uowDatosPaciente.PacienteRepositorio.ObtenerPorId(base.EntidadId.Value);

            if(paciente!=null)
            {
                form_Plan.Titulo = paciente.ApyNom;
                form_Plan.Leyenda = string.Format("OS: {0} Nro Afil: {1} - Edad: {2}",
                                                  paciente.ObraSocial.Descripcion, paciente.NumeroAfiliado, paciente.Edad);
                form_Plan.imgTitulo.Image = Imagen.Convertir_Bytes_Imagen(paciente.Foto);

                form_Plan.PacienteId = paciente.Id;

                VerificarSiTieneAccesoAlFormulario(form_Plan);
            }
        }

        public virtual void btnPatologia_Click(object sender, EventArgs e)
        {
            var form_Patologia =
                ObjectFactory.GetInstance<Presentacion.DatosPaciente.Vistas.Patologia._00515_PatologiaPaciente>();

            var paciente = _uowDatosPaciente.PacienteRepositorio.ObtenerPorId(base.EntidadId.Value);

            if (paciente != null)
            {
                form_Patologia.Titulo = paciente.ApyNom;
                form_Patologia.Leyenda = string.Format("OS: {0} Nro Afil: {1} - Edad: {2}",
                                                  paciente.ObraSocial.Descripcion, paciente.NumeroAfiliado, paciente.Edad);
                form_Patologia.imgTitulo.Image = Imagen.Convertir_Bytes_Imagen(paciente.Foto);

                form_Patologia.PacienteId = paciente.Id;

                VerificarSiTieneAccesoAlFormulario(form_Patologia);
            }
        }

        public override void FormularioBaseConsulta_Load(object sender, EventArgs e)
        {
            base.FormularioBaseConsulta_Load(sender, e);
            
            FormatearGrilla();
            
            this.txtBuscar.Focus();
        }

        public override void ActualizarDatosGrilla(string textoBuscar)
        {
            var resultado = _uowDatosPaciente.PacienteRepositorio.ObtenerPorFiltro(x => x.Apellido.Contains(textoBuscar)
                                                                                        ||
                                                                                        x.Nombre.Contains(textoBuscar)
                                                                                        || x.Dni.Equals(textoBuscar))
                .Select(x => new PacienteDTO
                                 {
                                     Id = x.Id,
                                     ApyNom = x.ApyNom,
                                     Celular = x.Celular,
                                     Dni = x.Dni,
                                     NumeroAfiliado = x.NumeroAfiliado,
                                     FechaNacimiento = x.FechaNacimiento,
                                     Telefono = x.Telefono,
                                     Edad = x.Edad,
                                     ObraSocial = x.ObraSocial.Descripcion
                                 })
                .ToList();
            this.dgvBusqueda.DataSource = resultado;            
        }

        private void FormatearGrilla()
        {
            this.dgvBusqueda.Columns["ApyNom"].Visible = true;
            this.dgvBusqueda.Columns["ApyNom"].HeaderText = "Apellido y Nombre";
            this.dgvBusqueda.Columns["ApyNom"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dgvBusqueda.Columns["ApyNom"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dgvBusqueda.Columns["Dni"].Visible = true;
            this.dgvBusqueda.Columns["Dni"].HeaderText = "DNI";
            this.dgvBusqueda.Columns["Dni"].Width = 70;
            this.dgvBusqueda.Columns["Dni"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dgvBusqueda.Columns["Celular"].Visible = true;
            this.dgvBusqueda.Columns["Celular"].HeaderText = "Celular";
            this.dgvBusqueda.Columns["Celular"].Width = 70;
            this.dgvBusqueda.Columns["Celular"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dgvBusqueda.Columns["Edad"].Visible = true;
            this.dgvBusqueda.Columns["Edad"].HeaderText = "Edad";
            this.dgvBusqueda.Columns["Edad"].Width = 120;
            this.dgvBusqueda.Columns["Edad"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            this.dgvBusqueda.Columns["ObraSocial"].Visible = true;
            this.dgvBusqueda.Columns["ObraSocial"].HeaderText = "Obra Social";
            this.dgvBusqueda.Columns["ObraSocial"].Width = 150;
            this.dgvBusqueda.Columns["ObraSocial"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dgvBusqueda.Columns["NumeroAfiliado"].Visible = true;
            this.dgvBusqueda.Columns["NumeroAfiliado"].HeaderText = "Nro Af.";
            this.dgvBusqueda.Columns["NumeroAfiliado"].Width = 70;
            this.dgvBusqueda.Columns["NumeroAfiliado"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        public override void btnNuevo_Click(object sender, EventArgs e)
        {
            if (new _00509_ABM_Paciente(PlantillaFormulario.Clases.TipoOperacion.Nuevo, null).ShowDialog() == DialogResult.Yes)
            {
                ActualizarDatosGrilla(string.Empty);
            }
        }

        public override void btnModificar_Click(object sender, EventArgs e)
        {
            if (new _00509_ABM_Paciente(PlantillaFormulario.Clases.TipoOperacion.Modificar, base.EntidadId).ShowDialog() == DialogResult.Yes)
            {
                ActualizarDatosGrilla(string.Empty);
            }
        }

        public override void btnEliminar_Click(object sender, EventArgs e)
        {
            if (new _00509_ABM_Paciente(PlantillaFormulario.Clases.TipoOperacion.Eliminar, base.EntidadId).ShowDialog() == DialogResult.Yes)
            {
                ActualizarDatosGrilla(string.Empty);
            }
        }
    }
}
