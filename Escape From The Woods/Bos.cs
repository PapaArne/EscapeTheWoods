using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escape_From_The_Woods
{
    class Bos
    {
        private int _X { get; set; }
        private int _Y { get; set; }
        private List<boom> _Bomen { get; set; }

        public Bos (List<boom> bomen)
        {
            _X = 0;
            _Y = 0;
            _Bomen = bomen;
        }
    }
}
