using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsumindoWebService.WebServiceCorreios;
using ConsumindoWebService.WebServiceRastreamento;
namespace ConsumindoWebService
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o Cep");
            var cep = Console.ReadLine();
            PesquisarEndereco(cep);
            Console.Clear();
            Console.WriteLine("Digite o código");
            var rastreamento = Console.ReadLine();
            RastrearObjeto(rastreamento);
        }

        static void PesquisarEndereco(string cep)
        {
            using (var ws = new AtendeClienteClient())
            {
                var resposta = ws.consultaCEP(cep);
                Console.Clear();
                Console.WriteLine(string.Format("Endereco : {0}",resposta.end));
                Console.WriteLine(string.Format("Bairro : {0}", resposta.bairro));
                Console.WriteLine(string.Format("Cidade : {0}", resposta.cidade));
                Console.WriteLine(string.Format("UF : {0}", resposta.uf));
                Console.WriteLine(string.Format("Cep : {0}", resposta.cep));
                
            }

            Console.ReadKey();
        }

        static void RastrearObjeto(string codigo)
        {
            using (var ws = new ServiceClient())
            {
                var resposta = ws.buscaEventos("ECT","SRO","L","T","101","PL544730466BR");
                Console.WriteLine(resposta);
            }
            Console.ReadKey();
        }
    }
}
