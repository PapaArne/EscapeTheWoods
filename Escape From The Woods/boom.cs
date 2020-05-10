using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Escape_From_The_Woods
{
    class boom
    {
        public int _x { get; set; }
        public int _y { get; set; }

        private int _boomId { get; set; }

      

        public boom (int x, int y, int id)
        {
            _x = x;
            _y = y;
            _boomId = id;
        }
        
    }
}
