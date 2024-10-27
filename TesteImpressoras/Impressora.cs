using Lextm.SharpSnmpLib.Messaging;
using Lextm.SharpSnmpLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SnmpSharpNet;
using Lextm.SharpSnmpLib.Security;
using System.Net.NetworkInformation;
using System.Diagnostics;


namespace TesteImpressoras
{
    public class Impressora : Iimpressora
    {
        public string ip;
        public string modelo;
        public string marca;
        public int qtdTonerBK;
        public int totalPag;
        public int totalPagMono;
        int cont;

        public Impressora()
        {
           
        }

        public string getTonerBK(string oid)
        {
            throw new NotImplementedException();
        }

        //Pega total Pag. da impressora, usando snmp V1
        public string getInformationByOid(Oid oid, string ip)
        {
            string totalPag = string.Empty;
            try
            {
                // Consulta SNMP
                var result = Messenger.Get(VersionCode.V1,
                                         new IPEndPoint(IPAddress.Parse(ip), 161),
                                         new Lextm.SharpSnmpLib.OctetString("public"), // Comunidade SNMP (geralmente "public")
                                         new List<Variable> { new Variable(new ObjectIdentifier(oid.ToString())) },
                                         5000);

                if (result != null && result.Count > 0)
                {
                    Console.WriteLine($"Info: {result[0].Data}"); //só pra fins de teste no console
                    MessageBox.Show(result[0].Data.ToString());
                }
                else
                {
                    Console.WriteLine("Não foi possível obter informações da impressora.");
                    MessageBox.Show("Não foi possível obter a informação desejada.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                totalPag = result[0].Data.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro! Exceção lançada." + ex, "Erro",  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                        
            return totalPag;
        }

        public string getTotalPagMono(string oid)
        {
            throw new NotImplementedException();
        }


        public void getInformationByOidV3(Oid oid, string ip, string user, string authPass, string privPassword, int selecaoAut, int selecaoCrip)
        { //só passar os parametros cadastrados onde fica o snmp V3 na impressora.
            string result = string.Empty;
            try
            {
                Discovery discovery = Messenger.GetNextDiscovery(SnmpType.GetRequestPdu);
                ReportMessage report = discovery.GetResponse(60000, new IPEndPoint(IPAddress.Parse(ip), 161));

                if (selecaoAut == 1 && selecaoCrip == 1)
                {
                    var auth = new SHA1AuthenticationProvider(new Lextm.SharpSnmpLib.OctetString(authPass));
                    var priv = new AESPrivacyProvider(new Lextm.SharpSnmpLib.OctetString(privPassword), auth);

                    GetRequestMessage request = new GetRequestMessage(VersionCode.V3, Messenger.NextMessageId, Messenger.NextRequestId, new Lextm.SharpSnmpLib.OctetString(user), new List<Variable> { new Variable(new ObjectIdentifier(oid.ToString())) }, priv, Messenger.MaxMessageSize, report);
                    ISnmpMessage reply = request.GetResponse(5000, new IPEndPoint(IPAddress.Parse(ip), 161));
                    if (reply.Pdu().ErrorStatus.ToInt32() != 0)
                    {
                        throw ErrorException.Create(
                            "error ao responder",
                            IPAddress.Parse(ip),
                            reply);
                    }
                    result = reply.Pdu().Variables[0].ToString();
                    MessageBox.Show(result.ToString());
                    
                }
                else if(selecaoAut == 1 && selecaoCrip == 2)
                {
                    var auth = new SHA1AuthenticationProvider(new Lextm.SharpSnmpLib.OctetString(authPass));
                    var priv = new DESPrivacyProvider(new Lextm.SharpSnmpLib.OctetString(privPassword), auth);

                    GetRequestMessage request = new GetRequestMessage(VersionCode.V3, Messenger.NextMessageId, Messenger.NextRequestId, new Lextm.SharpSnmpLib.OctetString(user), new List<Variable> { new Variable(new ObjectIdentifier(oid.ToString())) }, priv, Messenger.MaxMessageSize, report);
                    ISnmpMessage reply = request.GetResponse(5000, new IPEndPoint(IPAddress.Parse(ip), 161));
                    if (reply.Pdu().ErrorStatus.ToInt32() != 0)
                    {
                        throw ErrorException.Create(
                            "error ao responder",
                            IPAddress.Parse(ip),
                            reply);
                    }
                    result = reply.Pdu().Variables[0].ToString();
                    MessageBox.Show(result.ToString());
                }
                else if(selecaoAut == 2 && selecaoCrip == 1)
                {
                    var auth = new MD5AuthenticationProvider(new Lextm.SharpSnmpLib.OctetString(authPass));
                    var priv = new AESPrivacyProvider(new Lextm.SharpSnmpLib.OctetString(privPassword), auth);
                    GetRequestMessage request = new GetRequestMessage(VersionCode.V3, Messenger.NextMessageId, Messenger.NextRequestId, new Lextm.SharpSnmpLib.OctetString(user), new List<Variable> { new Variable(new ObjectIdentifier(oid.ToString())) }, priv, Messenger.MaxMessageSize, report);
                    ISnmpMessage reply = request.GetResponse(5000, new IPEndPoint(IPAddress.Parse(ip), 161));
                    if (reply.Pdu().ErrorStatus.ToInt32() != 0)
                    {
                        throw ErrorException.Create(
                            "error ao responder",
                            IPAddress.Parse(ip),
                            reply);
                    }
                    result = reply.Pdu().Variables[0].ToString();
                    MessageBox.Show(result.ToString());
                }
                else if (selecaoAut == 2 && selecaoCrip == 2)
                {
                    var auth = new MD5AuthenticationProvider(new Lextm.SharpSnmpLib.OctetString(authPass));
                    var priv = new DESPrivacyProvider(new Lextm.SharpSnmpLib.OctetString(privPassword), auth);

                    GetRequestMessage request = new GetRequestMessage(VersionCode.V3, Messenger.NextMessageId, Messenger.NextRequestId, new Lextm.SharpSnmpLib.OctetString(user), new List<Variable> { new Variable(new ObjectIdentifier(oid.ToString())) }, priv, Messenger.MaxMessageSize, report);
                    ISnmpMessage reply = request.GetResponse(5000, new IPEndPoint(IPAddress.Parse(ip), 161));
                    if (reply.Pdu().ErrorStatus.ToInt32() != 0)
                    {
                        throw ErrorException.Create(
                            "error ao responder",
                            IPAddress.Parse(ip),
                            reply);
                    }
                    result = reply.Pdu().Variables[0].ToString();
                    MessageBox.Show(result.ToString());
                    
                }
                else if(selecaoAut == 3 && selecaoCrip == 3)
                {
                    var auth = DefaultAuthenticationProvider.Instance;
                    var priv = new DefaultPrivacyProvider(auth);

                    GetRequestMessage request = new GetRequestMessage(VersionCode.V3, Messenger.NextMessageId, Messenger.NextRequestId, new Lextm.SharpSnmpLib.OctetString(user), new List<Variable> { new Variable(new ObjectIdentifier(oid.ToString())) }, priv, Messenger.MaxMessageSize, report);
                    ISnmpMessage reply = request.GetResponse(5000, new IPEndPoint(IPAddress.Parse(ip), 161));
                    if (reply.Pdu().ErrorStatus.ToInt32() != 0)
                    {
                        throw ErrorException.Create(
                            "error ao responder",
                            IPAddress.Parse(ip),
                            reply);
                    }
                    result = reply.Pdu().Variables[0].ToString();
                    MessageBox.Show(result.ToString());
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro! Exceção lançada." + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public string pingar(string ip)
        {
            Ping envioPing = new Ping();
            string situacao = string.Empty;
            try
            {
                PingReply reply = envioPing.Send(ip);
                if(reply.Status == IPStatus.Success)
                {
                    situacao = "conectado";                    
                }
                else
                {
                    situacao = "desconectado";                   
                }               
            }
            catch(Exception ex)
            {
                Console.WriteLine("Erro!" + ex);
                MessageBox.Show("Erro! Exceção lançada.\n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return situacao;
        }

        public List<string> printInfoSpool()
        {
            List<string> listaFilas = new List<string>();

            PrintServer printServer = new PrintServer();
            PrintQueueCollection printQueues = printServer.GetPrintQueues(new[] {EnumeratedPrintQueueTypes.Local, EnumeratedPrintQueueTypes.Connections});

            foreach(PrintQueue pq in printQueues)
            {
                //listaFilas.Add(pq.ToString());
                listaFilas.Add(pq.Name);
            }
            return listaFilas;
        }

        public InfoTrabImpressao[] printJobsInfo()
        {
            List<InfoTrabImpressao> printJobs = new List<InfoTrabImpressao>();

            PrintServer printServer = new PrintServer();
            PrintQueueCollection pq = printServer.GetPrintQueues(new[] {EnumeratedPrintQueueTypes.Local, EnumeratedPrintQueueTypes.Connections});

            foreach(PrintQueue ptq in pq)
            {
                PrintJobInfoCollection jobs = ptq.GetPrintJobInfoCollection();
                foreach(PrintSystemJobInfo job in jobs)
                {
                    printJobs.Add(new InfoTrabImpressao
                    {
                        jobID = job.JobIdentifier,
                        documentName = job.Name,
                        submitter = job.Submitter,
                        status = job.JobStatus.ToString(),
                        pagesPrinted = job.NumberOfPagesPrinted
                    });
                }
            }
            return printJobs.ToArray();            
        }

        public void chacaNovosTrab()
        {
            List<string> listaFilas = new List<string>();
            Dictionary<string, bool> dictImpress = new Dictionary<string, bool>();
            int qtPag = 0;
            PrintQueue printQueue;
            PrintServer printServer = new PrintServer();
            PrintQueueCollection printQueues = printServer.GetPrintQueues(new[] { EnumeratedPrintQueueTypes.Local, EnumeratedPrintQueueTypes.Connections });

            foreach (PrintQueue pq in printQueues)
            {
                PrintJobInfoCollection jobs = pq.GetPrintJobInfoCollection();
                if(pq.IsPrinting == true)
                {
                    foreach(PrintSystemJobInfo job in jobs)
                    {
                        qtPag += job.NumberOfPagesPrinted;
                    }
                }                
            }
                       
        }

        public int checkForNewPrintJobs(List<string> listaImpressoras) 
        {           
            PrintQueue printQueue;
            LocalPrintServer localPrintServer = new LocalPrintServer();
            
            for (int i = 0; i < listaImpressoras.Count; i++)
            {
                printQueue = localPrintServer.GetPrintQueue(listaImpressoras[i]);
                printQueue.Refresh();
                var printJobs = printQueue.GetPrintJobInfoCollection();

                foreach (PrintSystemJobInfo printJob in printJobs)
                {
                    cont += printJob.NumberOfPagesPrinted;
                    
                }
            }
                                                   
            Console.WriteLine("Contador: " +  cont);
            return cont;
        }
    }
}
