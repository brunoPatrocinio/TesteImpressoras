using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteImpressoras
{
    public class InfoTrabImpressao
    {
        public int jobID {  get; set; }
        public string documentName { get; set; }
        public string submitter {  get; set; }
        public string status { get; set; }
        public int pagesPrinted { get; set; }
    }
}
