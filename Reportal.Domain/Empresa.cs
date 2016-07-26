﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reportal.Domain
{
    public class Empresa
    {
        public int Id { get; set; }
        public string NombreEmpresa { get; set; }
        public string HoldingEmpresa { get; set; }
        public string RubroEmpresa { get; set; }
        public string TipoEntidadEmpresa { get; set; }
        public string ClasificacionRiegoEmpresa { get; set; }
        public string ClasificacionComercial { get; set; }
        public int TotalAfiliados { get; set; }
        public int TotalAfiliadosCredito { get; set; }

    }
}
