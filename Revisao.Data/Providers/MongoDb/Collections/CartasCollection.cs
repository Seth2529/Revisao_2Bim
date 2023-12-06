using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaH1.Data.Providers.MongoDb.Collections
{
	[BsonCollection("Cartas")]
	public class CartasCollection : Document
	{
        #region 2 - Propriedades

        public string NomeCrianca { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get;  set; }
        public string Cidade { get;  set; }
        public string Estado { get;  set; }
        public int IdadeCriancaEmAnos { get;  set; }
        public string TextoCartaCrianca { get;  set; }

        #endregion
    }
}
