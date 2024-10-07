using SnmpSharpNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteImpressoras
{
    public interface Iimpressora
    {
        string getTotalPagMono(string oid);
        string getInformationByOid(Oid oid, string ip);
        void getInformationByOidV3(Oid oid, string ip, string user, string authPass, string privPassword, int selecaoAut, int selecaoCrip);

        string getTonerBK(string oid);
        string pingar(string ip);
    }
}
