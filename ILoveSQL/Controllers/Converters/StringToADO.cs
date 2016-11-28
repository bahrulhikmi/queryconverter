using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILoveSQL.Converters
{
    public class StringToADO: IConverterProcess
    {
        public string GetProcessName()
        {
            return "StringToADO";

        }

        public bool Convert(DataText dataText)
        {
            string textToAppend = dataText.Configuration.CodeStringBuilder;
            dataText.Output = new String[dataText.Input.Length];
            for (int i = 0; i < dataText.Input.Length; i++)
            {
                dataText.Output[i] = String.Format(" {0}(\" {1} \")", textToAppend, dataText.Input[i]);
            }
            return true;            
        }
        
    }
}
