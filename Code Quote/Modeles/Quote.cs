using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Quote.Modeles
{
    public class Quote
    {
        public string _id { get; set; }
        public string content { get; set; }
        public string author { get; set; }
        public string authorSlug { get; set; }
        public int length { get; set; }
        public string[] tag { get; set; }
    }
}
