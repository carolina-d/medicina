using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Aplicacion.Seguridad.DTOs;
using Dominio.Seguridad.Interfaces.UnidadDeTrabajo;
using StructureMap;

namespace Servicio.Seguridad.Formulario
{
    public class FormularioServicio : IFormularioServicio
    {
        private readonly IUnidadDeTrabajoSeguridad _uowSeguridad;

        public FormularioServicio(IUnidadDeTrabajoSeguridad uowSeguridad)
        {
            this._uowSeguridad = uowSeguridad;
        }

        public void CargarFormularios(ref List<FormularioDTO> _formAsembly)
        {
            var formulariosBase = _uowSeguridad.FormularioRepositorio.ObtenerTodo()
                .Select(x => new FormularioDTO
                {
                    Id = x.Id,
                    Codigo = x.Codigo,
                    Descripcion = x.Descripcion,
                    DescripcionLarga = x.DescripcionLarga,
                    ExisteBase = true
                });

            foreach (var form in _formAsembly)
            {
                if (formulariosBase.Any(x => x.Codigo.Equals(form.Codigo)))
                {
                    form.ExisteBase = true;
                }
            }
        }

        public void ActualizarBaseDeDatos(List<FormularioDTO> _listaFormularios)
        {
            using (var tran = new TransactionScope())
            {
                try
                {
                    var formsActualizar = _listaFormularios.Where(x => x.ExisteBase == false);

                    foreach (var form in formsActualizar)
                    {
                        var formularioNuevo = ObjectFactory.GetInstance<Dominio.Seguridad.Entidades.Formulario>();

                        formularioNuevo.Codigo = form.Codigo;
                        formularioNuevo.Descripcion = form.Descripcion;
                        formularioNuevo.DescripcionLarga = form.DescripcionLarga;

                        _uowSeguridad.FormularioRepositorio.Insertar(formularioNuevo);
                    }

                    _uowSeguridad.Commit();

                    tran.Complete();
                }
                catch (Exception ex)
                {
                    tran.Dispose();
                    throw new Exception(ex.Message);
                }
            }
        }
    }
}
