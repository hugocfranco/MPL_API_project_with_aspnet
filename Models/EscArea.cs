using System;
using System.Collections.Generic;

namespace Mpl.Models
{
    public class EscArea
    {
        public int EscritorioId { get; set; }
        public Escritorio Escritorios { get; set; }
        public int AreaId { get; set; }
        public Area Areas { get; set; }
    }
}