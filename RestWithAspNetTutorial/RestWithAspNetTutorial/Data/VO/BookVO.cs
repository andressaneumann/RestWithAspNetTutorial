using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace RestWithAspNetTutorial.Data.VO
{
    [DataContract]
    public class BookVO
    {        
        public int? Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public decimal Price { get; set; }
    }
}
