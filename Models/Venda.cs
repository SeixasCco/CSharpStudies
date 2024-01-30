using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CSharpStudies.Models
{
    public class Venda(int id, string produto, decimal preco, DateTime datavenda)
    {
        public int Id { get; set; } = id;

        [JsonProperty("nome_produto")]
        public string Produto { get; set; } = produto;
        public decimal Preco { get; set; } = preco;
        public DateTime DataVenda { get; set; } = datavenda;
    }
}
