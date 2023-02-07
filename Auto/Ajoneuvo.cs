using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
    public class Ajoneuvo
    {
        public Ajoneuvo(int vuosimalli, string merkki, string malli, int Nopeus)
        {
            Vuosimalli = vuosimalli;
            Merkki = merkki;
            Malli = malli;
            Nopeus = Nopeus;
        }

        public int Vuosimalli { get; set; }
        public string Merkki { get; set; }
        public string Malli  { get; set; }
        public int Nopeus{ get; set; }
       
        public int NopeudenNosto()
        {
            return Nopeus+5;

        }
    }
   
    
    
        
    
}
