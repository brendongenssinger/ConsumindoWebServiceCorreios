# Consumindo Web Service Correios
Sistema que consome webservice dos correios.

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
