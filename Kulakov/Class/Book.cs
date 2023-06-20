using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kulakov.Class
{
    class Book
    {
        int id { get; set; }
        string namae { get; set; }
        bool access { get; set; }
        Autor autor { get; set; }
        Genry genry { get; set; }
        Publisher publisher { get; set; }
    }
}
