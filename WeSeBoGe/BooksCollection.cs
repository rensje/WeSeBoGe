using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeSeBoGe
{
    [Serializable()]
    class BooksCollection    
    {
        class Book
        {
            public String title { get; set; }
            public String uri { get; set; }
        }

        public Book[] books
        {
            get;
            set; 
        }
    }
}
