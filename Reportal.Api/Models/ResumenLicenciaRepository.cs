﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Reportal.Data;
using Reportal.Domain;

namespace Reportal.Api.Models
{
    public class ResumenLicenciaRepository
    {
      

        public TendenciaBarChart ObtenerGraficoBarra(int id)
        {
            TendenciaBarChart retorno = new TendenciaBarChart();
            retorno.datasets = new List<DataSetBarChart>();
            retorno.labels = new List<string>();
            DataSetBarChart dsVc = new DataSetBarChart
            {
                fillColor = "rgba(0, 0, 255, 0.7)",
                highlightFill = "rgba(0, 0, 255, 1)",
                highlightStroke = "rgba(0, 0, 255, 0.9)",
                strokeColor = "rgba(0, 0, 255, 1)",
                data = new List<int>()
            };


            DataRowCollection rwsGraficos = ResumenGlobalLicenciaDataAccess.ObtenerGraficoBarra(id).Rows;
            int meseMotrar = 10;


            for (int i = 0; i < meseMotrar; i++)
            {
                try
                {
                    DataRow vrGr = rwsGraficos[i];
                    retorno.labels.Add(vrGr["Licencia_fInicio"].ToString());
                    dsVc.data.Add(Convert.ToInt32(vrGr["porcentaje"]));
                }
                catch (IndexOutOfRangeException ex)
                {
                    retorno.labels.Add("N/A");
                    dsVc.data.Add(0);
                }
            }

            retorno.datasets.Add(dsVc);
            return retorno;
        }
    }
}