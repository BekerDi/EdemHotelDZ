using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdemHotel
{
    internal class StatusNomera
    {
        public int Id { get; set; }
        public string StName { get; set; }
        public StatusNomera(int id, string stName)
        {
            Id = id;
            StName = stName;
    }
        public StatusNomera() { }
    }
    
    
}
