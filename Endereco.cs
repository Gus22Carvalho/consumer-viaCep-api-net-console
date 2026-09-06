using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumerViaCep
{
    public class Endereco
    {
        //podroa usar [JsonPropertyName("nome_da_propriedade")] caso tenha caracteres divergentes do json original, mas nesse caso não é necessário pois os nomes das propriedades são iguais aos do json retornado pela api
        public String? cep { get; set; }
        public String? logradouro { get; set; }
        public String? complemento { get; set; }
        public String? unidade { get; set; }
        public String? bairro { get; set; }
        public String? localidade { get; set; }
        public String? uf { get; set; }
        public String? estado { get; set; }
        public String? ibge { get; set; }
        public String? gia { get; set; }
        public String? ddd { get; set; }
        public String? siafi { get; set; }


    }
}