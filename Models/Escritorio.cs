using System;
using System.Collections.Generic;

namespace Mpl.Models
{
    public class Escritorio
    {
        public int EscritorioId { get; set; }
		public string Nome { get; set; }
		public string Email { get; set; }
		public int Telefone { get; set; }
		public string Senha { get; set; }
		public IEnumerable<EscArea> EscAreas { get; set; }
    }
}