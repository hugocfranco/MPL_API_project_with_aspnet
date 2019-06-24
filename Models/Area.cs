using System;
using System.Collections.Generic;

namespace Mpl.Models
{
    public class Area
    {
        public int AreaId { get; set; }
        public string Descricao { get; set; }
        public IEnumerable<Advogado> Advogados { get; set; }
        public IEnumerable<Escritorio> Escritorios { get; set; }
    }
}