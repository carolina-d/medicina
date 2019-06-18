﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.DatosPaciente.Entidades.Validaciones
{
    public interface IValidacionGrupoSanguineo
    {
        [Range(1, 999999, ErrorMessage = "El valor debe estar entre 1 y 999999")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        int Codigo { get; set; }

        [MaxLength(250, ErrorMessage = "La cantidad Maxima de Caracteres es de 250")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        string Descripcion { get; set; }
    }
}
