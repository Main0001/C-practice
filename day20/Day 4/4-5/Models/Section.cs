using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_5.Models
{
    internal class Section
    {
        public char Letter { get; set; }
        public Dictionary<string,int[]> Words { get; set; }
    }
}
