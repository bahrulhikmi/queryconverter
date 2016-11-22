using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILoveSQL
{

    public enum DataInputType
    {
        RawSQL,
        AdoSQL
    }

    public class DataText
    {
        public DataText()
        {
           Configuration = new Configuration ();
        }
        public String[] Input  { get; set; }
        public DataInputType InputType { get; set; }

        public String[] Output { get; set; }
        public Configuration Configuration { get; set; }
        
    }

   
}
