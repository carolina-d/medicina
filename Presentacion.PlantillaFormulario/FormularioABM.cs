using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion.PlantillaFormulario.Clases;
using Constantes = Dominio.Base.Clases.Constantes;

namespace Presentacion.PlantillaFormulario
{
    public partial class FormularioABM : Presentacion.PlantillaFormulario.FormularioBase
    {
        // Declaracion de Variables Privadas
        private string _tipoOperacion;
        private bool _realizoAlgunaOperacion;
        
        public FormularioABM()
        {
            InitializeComponent();
        }

        public FormularioABM(string tipoOperacion, int? entidadId)
        {
            InitializeComponent();

            AsignarImagenBotones();
        }

        public virtual void AsignarImagenBotones()
        {
            this.BtnGrabar.Image = ImagenesFormulario.Nuevo;
            this.BtnLimpiar.Image = ImagenesFormulario.Modificar;
            this.BtnSalir.Image = ImagenesFormulario.Salir;
        }

        public virtual void Inicializador(string tipoOperacion, int? entidadId)
        {
            _realizoAlgunaOperacion = false;
            _tipoOperacion = tipoOperacion;
            LimpiarDatosFormulario();

            if (tipoOperacion == Clases.TipoOperacion.Nuevo)
            {
                this.BtnGrabar.Text = "Grabar";
            }
            else if (tipoOperacion == Clases.TipoOperacion.Modificar)
            {
                this.BtnGrabar.Text = Clases.TipoOperacion.Modificar;
                CargarDatos(entidadId);
            }
            else if (tipoOperacion == Clases.TipoOperacion.Eliminar)
            {
                this.BtnGrabar.Text = Clases.TipoOperacion.Eliminar;
                CargarDatos(entidadId);
                ActivarControles(false);
            }
        }

        public virtual void CargarDatos(int? entidadId)
        {
            // Este metodo se debe Reescribir en cada formulario
        }

        public virtual void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public virtual void BtnLimpiar_Click(object sender, EventArgs e)
        {
            if (_tipoOperacion != Clases.TipoOperacion.Eliminar)
                LimpiarDatosFormulario();
        }

        public virtual void BtnGrabar_Click(object sender, EventArgs e)
        {
            EfectuarLosCambios();
        }

        private void EfectuarLosCambios()
        {
            VerificarDatosObligatorios();

            switch (_tipoOperacion)
            {
                case Clases.TipoOperacion.Nuevo:
                    if (_datosObligatorios)
                    {
                        if (!VerificarSiExisteDatos())
                        {
                            NuevoRegistro();
                            _realizoAlgunaOperacion = true;
                            LimpiarDatosFormulario();
                        }
                    }
                    break;
                case Clases.TipoOperacion.Eliminar:
                    if (Mensaje.Mostrar("Esta seguro de Eliminar el registro seleccionado?", Clases.Constantes.TipoMensaje.Pregunta) ==
                        DialogResult.Yes)
                    {
                        EliminarRegistro();
                        _realizoAlgunaOperacion = true;
                    }
                    this.Close();
                    break;
                case Clases.TipoOperacion.Modificar:
                    if (_datosObligatorios)
                    {
                        if (!VerificarSiExisteDatos())
                        {
                            ModificarRegistro();
                            _realizoAlgunaOperacion = true;
                            this.Close();
                        }
                    }
                    break;
            }
        }

        // <summary>
        // Metodo para Verificar si estan todos los Datos Obligatorios cargados
        // </summary>
        // <returns>retorna True si cumple con todos los campos Obligatorios</returns>
        public virtual void VerificarDatosObligatorios()
        {
            _datosObligatorios = true;
            errorProvider.Clear();
        }

        public virtual bool VerificarSiExisteDatos()
        {
            return true;
        }

        /// <summary>
        /// Metodo para modificar los registros
        /// </summary>
        public virtual void ModificarRegistro()
        {
        }

        /// <summary>
        /// Metodo para Eliminar los Registros
        /// </summary>
        public virtual void EliminarRegistro()
        {
        }

        /// <summary>
        /// Metodo para un nuevo registro
        /// </summary>
        public virtual void NuevoRegistro()
        {
        }

        private void FormularioBaseABM_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = _realizoAlgunaOperacion ? DialogResult.Yes : DialogResult.No;
        }

        
    }
}
