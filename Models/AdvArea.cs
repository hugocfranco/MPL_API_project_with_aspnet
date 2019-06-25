using System;
using System.Collections.Generic;

namespace Mpl.Models
{
    public class AdvArea
    {
        public int AdvogadoId { get; set; }
        public Advogado Advogados { get; set; }
        public int AreaId { get; set; }
        public Area Areas { get; set; }
    }
}