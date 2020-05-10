using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escape_From_The_Woods
{
    class Aap
    {
        private int _Id { get; set; }
        private string _Naam { get; set; }

        public int _X { get; set; }
        public int _Y { get; set; }
        public boom _startBoom { get; set; }

    public Aap(int id, string naam,int x, int y, boom startboom)
    {
        _Id = id;
        _Naam = naam;
            _X = x;
            _Y = y;
        _startBoom = startboom;
    }

    }

    
        
}
