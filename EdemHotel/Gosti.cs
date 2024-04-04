using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdemHotel
{
    internal class Gosti
    {
        public Guid Id {  get; set; }
        public string Name { get; set; }
        public bool WithPet { get; set; }
        public DateTime Entered {  get; set; }
        public DateTime Left { get; set; }
        public int Nomer {  get; set; }

        public int Status { get; set; }
        public Gosti(Guid id, string name, bool pet, DateTime entered, DateTime left, int nomer, int status) 
        {
            Id = id;
            Name = name;
            WithPet = pet;
            Entered = entered;
            Left = left;
            Nomer = nomer;
            Status = status;
        }
        public Gosti() 
        {
        }
      
    }

}
