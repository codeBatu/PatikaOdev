using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Models
    {
       
        public string Details { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string name { get; set; }

    }
    enum Buyukluk
    {
        XS, S, M, L, XL
    }

    class Kisi
    {

        public int kisiID { get; set; }
        public string Name { get; set; }
    }
}
