using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_and_Delegate.Core
{
   public class EnteryArgs:EventArgs
    {
        public string NameSurname { get; set; }
        public double Oratlama { get; set; }
    }
}
