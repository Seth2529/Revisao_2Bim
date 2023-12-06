using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Domain.Entities
{
    public class Cartas
    {
        public Cartas(string nomeCrianca, string rua, string numero, string bairro,string cidade, string estado, int idadeCriancaEmAnos,string textoCartaCrianca)
        {
            NomeCrianca = nomeCrianca;
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            IdadeCriancaEmAnos = idadeCriancaEmAnos;
            TextoCartaCrianca = textoCartaCrianca;
        }
        public string NomeCrianca { get; private set; }
        public string Rua { get; private set; }
        public string Numero { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public int IdadeCriancaEmAnos { get; private set; }
        public string TextoCartaCrianca { get; private set; }
    }
}
