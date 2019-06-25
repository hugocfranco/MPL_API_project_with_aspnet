using System;
using System.Collections.Generic;

namespace Mpl.Models
{
    public class EscArea
    {
        public int EscritorioId { get; set; }
        public Escritorio Escritorio { get; set; }
        public int AreaId { get; set; }
        public Area Area { get; set; }
    }
}