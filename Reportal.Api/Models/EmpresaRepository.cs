using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reportal.Data;
using Reportal.Domain;
namespace Reportal.Api.Models
{
    public class EmpresaRepository
    {
        public List<Empresa> Listar()
        {
            return EmpresaDataAccess.ListarEmpresa();
        }
        public Empresa Obtener(int RutEmpresas)
        {
            //return CampaniaDataAccess.Obtener(id);
            return EmpresaDataAccess.Obtener(RutEmpresas);

        }

        public IdentidadDetalleEmpresa ObtenerDetalle(int rutEmpresa)
        {
            return DetalleEmpresaDataAccess.Obtener(rutEmpresa);
        }

    }
}