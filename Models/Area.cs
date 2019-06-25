using System;
using System.Collections.Generic;

namespace Mpl.Models
{
    public class Area
    {
        public int AreaId { get; set; }
        public string Descricao { get; set; }
        public IEnumerable<AdvArea> AdvAreas { get; set; }
        public IEnumerable<EscArea> EscAreas { get; set; }
    }
}