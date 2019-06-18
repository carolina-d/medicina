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
    public partial class _00505_ABM_Vademecum : Presentacion.PlantillaFormulario.FormularioABM
    {
        private readonly IUnidadDeTrabajoConsultaPaciente consultaPacienteUoW
            = ObjectFactory.GetInstance<IUnidadDeTrabajoConsultaPaciente>();

        private string _tipoOperacion = string.Empty;
        private Vademecum vademecum;
        public _00505_ABM_Vademecum()
        {
            InitializeComponent();
        }

       public _00505_ABM_Vademecum(string tipoOperacion, int? entidadId)
           : base(tipoOperacion, entidadId)
       {
           InitializeComponent();

           this.Name = "_00505_ABM_Vademecum";
           this.TituloVentana = "Vademecum";
           this.Titulo = "ABM de Vademecum";
           this.Leyenda = "Aquí Ud podrá dar de Alta, Modificar o Eliminar un Vademecum";

           base.UsuarioLogin = Thread.CurrentPrincipal.Identity.Name;

           this._tipoOperacion = tipoOperacion;

           // Cargar evento de validacion para datos Obligatorios
           this.txtAccionTerapeutica.Validated += new EventHandler(base.textBox_Validated);
           this.txtAdvertencias.Validated += new EventHandler(base.textBox_Validated);
           this.txtComposicion.Validated += new EventHandler(base.textBox_Validated);
           this.txtContraIndicacionesPA.Validated += new EventHandler(base.textBox_Validated);
           this.txtContraindicaciones.Validated += new EventHandler(base.textBox_Validated);
           this.txtDosificacion.Validated += new EventHandler(base.textBox_Validated);
           this.txtFarmacocinetica.Validated += new EventHandler(base.textBox_Validated);
           this.txtFarmacodinamia.Validated += new EventHandler(base.textBox_Validated);
           this.txtFarmacologia.Validated += new EventHandler(base.textBox_Validated);
           this.txtIndicaciones.Validated += new EventHandler(base.textBox_Validated);
           this.txtInteracciones.Validated += new EventHandler(base.textBox_Validated);
           this.txtNombre.Validated += new EventHandler(base.textBox_Validated);
           this.txtNombreComercial.Validated += new EventHandler(base.textBox_Validated);
           this.txtPrecauciones.Validated += new EventHandler(base.textBox_Validated);
           this.txtPresentaciones.Validated += new EventHandler(base.textBox_Validated);
           this.txtPrincipioActivo.Validated += new EventHandler(base.textBox_Validated);
           this.txtReaccionesAdversas.Validated += new EventHandler(base.textBox_Validated);
           this.txtSobredosificacion.Validated += new EventHandler(base.textBox_Validated);
        

           // Cargar evento de Validacion de Caracteres 
           this.txtAccionTerapeutica.KeyPress += new KeyPressEventHandler(base.textBoxLetrasNumeros_KeyPress);
           this.txtAdvertencias.KeyPress += new KeyPressEventHandler(base.textBoxLetrasNumeros_KeyPress);
           this.txtComposicion.KeyPress += new KeyPressEventHandler(base.textBoxLetrasNumeros_KeyPress);
           this.txtContraIndicacionesPA.KeyPress += new KeyPressEventHandler(base.textBoxLetrasNumeros_KeyPress);
           this.txtContraindicaciones.KeyPress += new KeyPressEventHandler(base.textBoxLetrasNumeros_KeyPress);
           this.txtDosificacion.KeyPress += new KeyPressEventHandler(base.textBoxLetrasNumeros_KeyPress);
           this.txtFarmacocinetica.KeyPress += new KeyPressEventHandler(base.textBoxLetrasNumeros_KeyPress);
           this.txtFarmacodinamia.KeyPress += new KeyPressEventHandler(base.textBoxLetrasNumeros_KeyPress);
           this.txtFarmacologia.KeyPress += new KeyPressEventHandler(base.textBoxLetrasNumeros_KeyPress);
           this.txtIndicaciones.KeyPress += new KeyPressEventHandler(base.textBoxLetrasNumeros_KeyPress);
           this.txtInteracciones.KeyPress += new KeyPressEventHandler(base.textBoxLetrasNumeros_KeyPress);
           this.txtNombre.KeyPress += new KeyPressEventHandler(base.textBoxLetrasNumeros_KeyPress);
           this.txtNombreComercial.KeyPress += new KeyPressEventHandler(base.textBoxLetrasNumeros_KeyPress);
           this.txtPrecauciones.KeyPress += new KeyPressEventHandler(base.textBoxLetrasNumeros_KeyPress);
           this.txtPresentaciones.KeyPress += new KeyPressEventHandler(base.textBoxLetrasNumeros_KeyPress);
           this.txtPrincipioActivo.KeyPress += new KeyPressEventHandler(base.textBoxLetrasNumeros_KeyPress);
           this.txtReaccionesAdversas.KeyPress += new KeyPressEventHandler(base.textBoxLetrasNumeros_KeyPress);
           this.txtSobredosificacion.KeyPress += new KeyPressEventHandler(base.textBoxLetrasNumeros_KeyPress);


           // Color al recibir el Foco
           this.txtAccionTerapeutica.Enter += new EventHandler(base.control_Enter);
           this.txtAdvertencias.Enter += new EventHandler(base.control_Enter);
           this.txtComposicion.Enter += new EventHandler(base.control_Enter);
           this.txtContraIndicacionesPA.Enter += new EventHandler(base.control_Enter);
           this.txtContraindicaciones.Enter += new EventHandler(base.control_Enter);
           this.txtDosificacion.Enter += new EventHandler(base.control_Enter);
           this.txtFarmacocinetica.Enter += new EventHandler(base.control_Enter);
           this.txtFarmacodinamia.Enter += new EventHandler(base.control_Enter);
           this.txtFarmacologia.Enter += new EventHandler(base.control_Enter);
           this.txtIndicaciones.Enter += new EventHandler(base.control_Enter);
           this.txtInteracciones.Enter += new EventHandler(base.control_Enter);
           this.txtNombre.Enter += new EventHandler(base.control_Enter);
           this.txtNombreComercial.Enter += new EventHandler(base.control_Enter);
           this.txtPrecauciones.Enter += new EventHandler(base.control_Enter);
           this.txtPresentaciones.Enter += new EventHandler(base.control_Enter);
           this.txtPrincipioActivo.Enter += new EventHandler(base.control_Enter);
           this.txtReaccionesAdversas.Enter += new EventHandler(base.control_Enter);
           this.txtSobredosificacion.Enter += new EventHandler(base.control_Enter);
          


           // Color al perder el Foco
           this.txtAccionTerapeutica.Leave += new EventHandler(base.control_Leave);
           this.txtAdvertencias.Leave += new EventHandler(base.control_Leave);
           this.txtComposicion.Leave += new EventHandler(base.control_Leave);
           this.txtContraIndicacionesPA.Leave += new EventHandler(base.control_Leave);
           this.txtContraindicaciones.Leave += new EventHandler(base.control_Leave);
           this.txtDosificacion.Leave += new EventHandler(base.control_Leave);
           this.txtFarmacocinetica.Leave += new EventHandler(base.control_Leave);
           this.txtFarmacodinamia.Leave += new EventHandler(base.control_Leave);
           this.txtFarmacologia.Leave += new EventHandler(base.control_Leave);
           this.txtIndicaciones.Leave += new EventHandler(base.control_Leave);
           this.txtInteracciones.Leave += new EventHandler(base.control_Leave);
           this.txtNombre.Leave += new EventHandler(base.control_Leave);
           this.txtNombreComercial.Leave += new EventHandler(base.control_Leave);
           this.txtPrecauciones.Leave += new EventHandler(base.control_Leave);
           this.txtPresentaciones.Leave += new EventHandler(base.control_Leave);
           this.txtPrincipioActivo.Leave += new EventHandler(base.control_Leave);
           this.txtReaccionesAdversas.Leave += new EventHandler(base.control_Leave);
           this.txtSobredosificacion.Leave += new EventHandler(base.control_Leave);
          



           Inicializador(tipoOperacion, entidadId);

       }

       public override void CargarDatos(int? entidadId)
       {
           // Instancion por medio del Inyector el Objeto Grupo
           vademecum = ObjectFactory.GetInstance<Vademecum>();

           if (entidadId.HasValue)
           {
               vademecum = consultaPacienteUoW.VademecumRepositorio.ObtenerPorId(entidadId.Value);

               this.txtAccionTerapeutica.Text = vademecum.AccionTerapeutica.ToString();
               this.txtAdvertencias.Text = vademecum.Advertencia;
               this.txtComposicion.Text = vademecum.Composicion;
               this.txtContraIndicacionesPA.Text = vademecum.ContraindicacionesPA;
               this.txtContraindicaciones.Text = vademecum.Contraindicacion;
               this.txtDosificacion.Text = vademecum.Dosificacion;
               this.txtFarmacocinetica.Text = vademecum.Farmacocinetica;
               this.txtFarmacodinamia.Text = vademecum.Farmacodinamia;
               this.txtFarmacologia.Text = vademecum.Farmacologia;
               this.txtIndicaciones.Text = vademecum.Indicacion;
               this.txtInteracciones.Text = vademecum.Interaccion;
               this.txtNombre.Text = vademecum.Nombre;
               this.txtNombreComercial.Text = vademecum.NombreComercial;
               this.txtPrecauciones.Text = vademecum.Precaucion;
               this.txtPresentaciones.Text = vademecum.Presentacion;
               this.txtPrincipioActivo.Text = vademecum.PrincipioActivo;
               this.txtReaccionesAdversas.Text = vademecum.ReaccionesAdversa;
               this.txtSobredosificacion.Text = vademecum.Sobredosificacion;

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
           var vademecums = consultaPacienteUoW.VademecumRepositorio.ObtenerTodo(string.Empty);

           if (_tipoOperacion == PlantillaFormulario.Clases.TipoOperacion.Nuevo)
           {
               if (vademecums.Any(x => x.AccionTerapeutica.Equals(this.txtAccionTerapeutica.Text)))
               {
                   Constantes.Validacion.DatoExistente(this.txtAccionTerapeutica, errorProvider, string.Format("La Accion Terapeutica {0} ya Existe", this.txtAccionTerapeutica.Text));
                   return true;
               }

               if (vademecums.Any(x => x.Advertencia.Equals(this.txtAdvertencias.Text)))
               {
                   Constantes.Validacion.DatoExistente(this.txtAdvertencias, errorProvider, string.Format("La Advertencia {0} ya Existe", this.txtAdvertencias.Text));
                   return true;
               }


               if (vademecums.Any(x => x.Composicion.Equals(this.txtComposicion.Text)))
               {
                   Constantes.Validacion.DatoExistente(this.txtComposicion, errorProvider, string.Format("La Composicion {0} ya Existe", this.txtComposicion.Text));
                   return true;
               }

               if (vademecums.Any(x => x.Contraindicacion.Equals(this.txtContraindicaciones.Text)))
               {
                   Constantes.Validacion.DatoExistente(this.txtContraindicaciones, errorProvider, string.Format("La Contraindicacion {0} ya Existe", this.txtContraindicaciones.Text));
                   return true;
               }

               if (vademecums.Any(x => x.ContraindicacionesPA.Equals(this.txtContraIndicacionesPA.Text)))
               {
                   Constantes.Validacion.DatoExistente(this.txtContraIndicacionesPA, errorProvider, string.Format("La ContraIndicacionPA {0} ya Existe", this.txtAdvertencias.Text));
                   return true;
               }

               if (vademecums.Any(x => x.Dosificacion.Equals(this.txtDosificacion.Text)))
               {
                   Constantes.Validacion.DatoExistente(this.txtDosificacion, errorProvider, string.Format("La Dosificacion {0} ya Existe", this.txtDosificacion.Text));
                   return true;
               }

               if (vademecums.Any(x => x.Farmacocinetica.Equals(this.txtFarmacocinetica.Text)))
               {
                   Constantes.Validacion.DatoExistente(this.txtFarmacocinetica, errorProvider, string.Format("La Farmacocinetica {0} ya Existe", this.txtFarmacocinetica.Text));
                   return true;
               }

               if (vademecums.Any(x => x.Farmacodinamia.Equals(this.txtFarmacodinamia.Text)))
               {
                   Constantes.Validacion.DatoExistente(this.txtFarmacodinamia, errorProvider, string.Format("La Farmacodinamia {0} ya Existe", this.txtFarmacodinamia.Text));
                   return true;
               }

               if (vademecums.Any(x => x.Farmacologia.Equals(this.txtFarmacologia.Text)))
               {
                   Constantes.Validacion.DatoExistente(this.txtFarmacologia, errorProvider, string.Format("La Farmacologia {0} ya Existe", this.txtFarmacologia.Text));
                   return true;
               }

               if (vademecums.Any(x => x.Indicacion.Equals(this.txtIndicaciones.Text)))
               {
                   Constantes.Validacion.DatoExistente(this.txtIndicaciones, errorProvider, string.Format("Las Indicaciones {0} ya Existe", this.txtIndicaciones.Text));
                   return true;
               }
               if (vademecums.Any(x => x.Interaccion.Equals(this.txtInteracciones.Text)))
               {
                   Constantes.Validacion.DatoExistente(this.txtInteracciones, errorProvider, string.Format("Las Interacciones {0} ya Existe", this.txtInteracciones.Text));
                   return true;
               }
               if (vademecums.Any(x => x.Nombre.Equals(this.txtNombre.Text)))
               {
                   Constantes.Validacion.DatoExistente(this.txtNombre, errorProvider, string.Format("El Nombre {0} ya Existe", this.txtNombre.Text));
                   return true;
               }
               if (vademecums.Any(x => x.NombreComercial.Equals(this.txtNombreComercial.Text)))
               {
                   Constantes.Validacion.DatoExistente(this.txtNombreComercial, errorProvider, string.Format("El Nombre Comercial {0} ya Existe", this.txtNombreComercial.Text));
                   return true;
               }
               if (vademecums.Any(x => x.Precaucion.Equals(this.txtPrecauciones.Text)))
               {
                   Constantes.Validacion.DatoExistente(this.txtPrecauciones, errorProvider, string.Format("Las Precauciones {0} ya Existe", this.txtPrecauciones.Text));
                   return true;
               }
               if (vademecums.Any(x => x.Presentacion.Equals(this.txtPresentaciones.Text)))
               {
                   Constantes.Validacion.DatoExistente(this.txtPresentaciones, errorProvider, string.Format("Las Presentaciones {0} ya Existe", this.txtPresentaciones.Text));
                   return true;
               }
               if (vademecums.Any(x => x.PrincipioActivo.Equals(this.txtPrincipioActivo.Text)))
               {
                   Constantes.Validacion.DatoExistente(this.txtPrincipioActivo, errorProvider, string.Format("El Principio Activo {0} ya Existe", this.txtPrincipioActivo.Text));
                   return true;
               }
               if (vademecums.Any(x => x.ReaccionesAdversa.Equals(this.txtReaccionesAdversas.Text)))
               {
                   Constantes.Validacion.DatoExistente(this.txtReaccionesAdversas, errorProvider, string.Format("Las ReaccionesAdversas {0} ya Existe", this.txtReaccionesAdversas.Text));
                   return true;
               }
               if (vademecums.Any(x => x.Sobredosificacion.Equals(this.txtSobredosificacion.Text)))
               {
                   Constantes.Validacion.DatoExistente(this.txtSobredosificacion, errorProvider, string.Format("La Sobredosificacion {0} ya Existe", this.txtSobredosificacion.Text));
                   return true;
               }
           }

           if (_tipoOperacion == PlantillaFormulario.Clases.TipoOperacion.Modificar)
           {
               if (vademecums.Any(x => x.AccionTerapeutica.Equals(this.txtAccionTerapeutica.Text) && x.Id != vademecum.Id))
               {
                   Constantes.Validacion.DatoExistente(this.txtAccionTerapeutica, errorProvider, string.Format("La Accion Terapeutica {0} ya Existe", this.txtAccionTerapeutica.Text));
                   return true;
               }

               if (vademecums.Any(x => x.Advertencia.Equals(this.txtAdvertencias.Text) && x.Id != vademecum.Id))
               {
                   Constantes.Validacion.DatoExistente(this.txtAdvertencias, errorProvider, string.Format("La Advertencia {0} ya Existe", this.txtAdvertencias.Text));
                   return true;
               }


               if (vademecums.Any(x => x.Composicion.Equals(this.txtComposicion.Text) && x.Id != vademecum.Id))
               {
                   Constantes.Validacion.DatoExistente(this.txtComposicion, errorProvider, string.Format("La Composicion {0} ya Existe", this.txtComposicion.Text));
                   return true;
               }

               if (vademecums.Any(x => x.Contraindicacion.Equals(this.txtContraindicaciones.Text) && x.Id != vademecum.Id))
               {
                   Constantes.Validacion.DatoExistente(this.txtContraindicaciones, errorProvider, string.Format("La Contraindicacion {0} ya Existe", this.txtContraindicaciones.Text));
                   return true;
               }

               if (vademecums.Any(x => x.ContraindicacionesPA.Equals(this.txtContraIndicacionesPA.Text) && x.Id != vademecum.Id))
               {
                   Constantes.Validacion.DatoExistente(this.txtContraIndicacionesPA, errorProvider, string.Format("La ContraIndicacionPA {0} ya Existe", this.txtAdvertencias.Text));
                   return true;
               }

               if (vademecums.Any(x => x.Dosificacion.Equals(this.txtDosificacion.Text) && x.Id != vademecum.Id))
               {
                   Constantes.Validacion.DatoExistente(this.txtDosificacion, errorProvider, string.Format("La Dosificacion {0} ya Existe", this.txtDosificacion.Text));
                   return true;
               }

               if (vademecums.Any(x => x.Farmacocinetica.Equals(this.txtFarmacocinetica.Text) && x.Id != vademecum.Id))
               {
                   Constantes.Validacion.DatoExistente(this.txtFarmacocinetica, errorProvider, string.Format("La Farmacocinetica {0} ya Existe", this.txtFarmacocinetica.Text));
                   return true;
               }

               if (vademecums.Any(x => x.Farmacodinamia.Equals(this.txtFarmacodinamia.Text) && x.Id != vademecum.Id))
               {
                   Constantes.Validacion.DatoExistente(this.txtFarmacodinamia, errorProvider, string.Format("La Farmacodinamia {0} ya Existe", this.txtFarmacodinamia.Text));
                   return true;
               }

               if (vademecums.Any(x => x.Farmacologia.Equals(this.txtFarmacologia.Text) && x.Id != vademecum.Id))
               {
                   Constantes.Validacion.DatoExistente(this.txtFarmacologia, errorProvider, string.Format("La Farmacologia {0} ya Existe", this.txtFarmacologia.Text));
                   return true;
               }

               if (vademecums.Any(x => x.Indicacion.Equals(this.txtIndicaciones.Text) && x.Id != vademecum.Id))
               {
                   Constantes.Validacion.DatoExistente(this.txtIndicaciones, errorProvider, string.Format("Las Indicaciones {0} ya Existe", this.txtIndicaciones.Text));
                   return true;
               }
               if (vademecums.Any(x => x.Interaccion.Equals(this.txtInteracciones.Text) && x.Id != vademecum.Id))
               {
                   Constantes.Validacion.DatoExistente(this.txtInteracciones, errorProvider, string.Format("Las Interacciones {0} ya Existe", this.txtInteracciones.Text));
                   return true;
               }
               if (vademecums.Any(x => x.Nombre.Equals(this.txtNombre.Text) && x.Id != vademecum.Id))
               {
                   Constantes.Validacion.DatoExistente(this.txtNombre, errorProvider, string.Format("El Nombre {0} ya Existe", this.txtNombre.Text));
                   return true;
               }
               if (vademecums.Any(x => x.NombreComercial.Equals(this.txtNombreComercial.Text) && x.Id != vademecum.Id))
               {
                   Constantes.Validacion.DatoExistente(this.txtNombreComercial, errorProvider, string.Format("El Nombre Comercial {0} ya Existe", this.txtNombreComercial.Text));
                   return true;
               }
               if (vademecums.Any(x => x.Precaucion.Equals(this.txtPrecauciones.Text) && x.Id != vademecum.Id))
               {
                   Constantes.Validacion.DatoExistente(this.txtPrecauciones, errorProvider, string.Format("Las Precauciones {0} ya Existe", this.txtPrecauciones.Text));
                   return true;
               }
               if (vademecums.Any(x => x.Presentacion.Equals(this.txtPresentaciones.Text) && x.Id != vademecum.Id))
               {
                   Constantes.Validacion.DatoExistente(this.txtPresentaciones, errorProvider, string.Format("Las Presentaciones {0} ya Existe", this.txtPresentaciones.Text));
                   return true;
               }
               if (vademecums.Any(x => x.PrincipioActivo.Equals(this.txtPrincipioActivo.Text) && x.Id != vademecum.Id))
               {
                   Constantes.Validacion.DatoExistente(this.txtPrincipioActivo, errorProvider, string.Format("El Principio Activo {0} ya Existe", this.txtPrincipioActivo.Text));
                   return true;
               }
               if (vademecums.Any(x => x.ReaccionesAdversa.Equals(this.txtReaccionesAdversas.Text) && x.Id != vademecum.Id))
               {
                   Constantes.Validacion.DatoExistente(this.txtReaccionesAdversas, errorProvider, string.Format("Las ReaccionesAdversas {0} ya Existe", this.txtReaccionesAdversas.Text));
                   return true;
               }
               if (vademecums.Any(x => x.Sobredosificacion.Equals(this.txtSobredosificacion.Text) && x.Id != vademecum.Id))
               {
                   Constantes.Validacion.DatoExistente(this.txtSobredosificacion, errorProvider, string.Format("La Sobredosificacion {0} ya Existe", this.txtSobredosificacion.Text));
                   return true;
               }
           }

           return false;
       }

       public override void NuevoRegistro()
       {
           try
           {
               vademecum = new Vademecum();
               {
                   vademecum.Advertencia = txtAdvertencias.Text;
                   vademecum.AccionTerapeutica = txtAccionTerapeutica.Text;
                   vademecum.Composicion = txtComposicion.Text;
                   vademecum.Contraindicacion = txtContraindicaciones.Text;
                   vademecum.ContraindicacionesPA = txtContraIndicacionesPA.Text;
                   vademecum.Dosificacion = txtDosificacion.Text;
                   vademecum.Farmacocinetica = txtFarmacocinetica.Text;
                   vademecum.Farmacodinamia = txtFarmacodinamia.Text;
                   vademecum.Farmacologia = txtFarmacologia.Text;
                   vademecum.Indicacion = txtIndicaciones.Text;
                   vademecum.Interaccion = txtInteracciones.Text;
                   vademecum.Nombre = txtNombre.Text;
                   vademecum.NombreComercial = txtNombreComercial.Text;
                   vademecum.Precaucion = txtPrecauciones.Text;
                   vademecum.Presentacion = txtPresentaciones.Text;
                   vademecum.PrincipioActivo = txtPrincipioActivo.Text;
                   vademecum.ReaccionesAdversa = txtReaccionesAdversas.Text;
                   vademecum.Sobredosificacion = txtSobredosificacion.Text;



               };

               consultaPacienteUoW.VademecumRepositorio.Insertar(vademecum);
               consultaPacienteUoW.Commit();

              
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
               consultaPacienteUoW.VademecumRepositorio.Eliminar(vademecum);
               consultaPacienteUoW.Commit();
           }
           catch (DataException ex)
           {
               Mensaje.Mostrar("El Vademecum seleccionado se encuentra vinculado a otro objeto.", Constantes.TipoMensaje.Error);
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
               vademecum.Advertencia = txtAdvertencias.Text;
               vademecum.AccionTerapeutica = txtAccionTerapeutica.Text;
               vademecum.Composicion = txtComposicion.Text;
               vademecum.Contraindicacion = txtContraindicaciones.Text;
               vademecum.ContraindicacionesPA = txtContraIndicacionesPA.Text;
               vademecum.Dosificacion = txtDosificacion.Text;
               vademecum.Farmacocinetica = txtFarmacocinetica.Text;
               vademecum.Farmacodinamia = txtFarmacodinamia.Text;
               vademecum.Farmacologia = txtFarmacologia.Text;
               vademecum.Indicacion = txtIndicaciones.Text;
               vademecum.Interaccion = txtInteracciones.Text;
               vademecum.Nombre = txtNombre.Text;
               vademecum.NombreComercial = txtNombreComercial.Text;
               vademecum.Precaucion = txtPrecauciones.Text;
               vademecum.Presentacion = txtPresentaciones.Text;
               vademecum.PrincipioActivo = txtPrincipioActivo.Text;
               vademecum.ReaccionesAdversa = txtReaccionesAdversas.Text;
               vademecum.Sobredosificacion = txtSobredosificacion.Text;

               consultaPacienteUoW.VademecumRepositorio.Modificar(vademecum);
               consultaPacienteUoW.Commit();
           }
           catch (Exception ex)
           {
               Mensaje.Mostrar(ex, Constantes.TipoMensaje.Error);
           }
       }














































































































































































































































            

       

       
        

        

    }
}
