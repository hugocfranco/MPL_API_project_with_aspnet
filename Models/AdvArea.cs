using System;
using System.Collections.Generic;

namespace Mpl.Models
{
    public class AdvArea
    {
        public int AdvogadoId { get; set; }
        public Advogado Advogado { get; set; }
        public int AreaId { get; set; }
        public Area Area { get; set; }
    }
}