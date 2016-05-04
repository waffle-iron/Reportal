using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reportal.Domain
{
    public class TendenciaBarChart
    {
        public List<string> labels { get; set; }
        public List<DataSetBarChart> datasets { get; set; }

        public TendenciaBarChart()
        {
            labels = new List<string>();
            datasets = new List<DataSetBarChart>();
        }
    }


    public class DataSetBarChart
    {
        public string fillColor { get; set; }
        public string strokeColor { get; set; }
        public string highlightFill { get; set; }
        public string highlightStroke { get; set; }
        public List<int> data { get; set; }
    }
}
