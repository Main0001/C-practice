using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

namespace _30_1.Models
{
    public class TuristDBContext : DataContext
    {
        public TuristDBContext(string fileOrServerOrConnection) : base(fileOrServerOrConnection)
        { }

        public Table<Turist> Turists { get; set; }
    }
}
