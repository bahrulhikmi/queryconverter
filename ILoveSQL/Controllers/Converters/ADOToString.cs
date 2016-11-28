using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILoveSQL.Converters
{
    public class ADOToString: IConverterProcess
    {
        public string GetProcessName()
        {
            return "ADOToString";

        }

        public bool Convert(DataText dataText)
        {

            string textToCut = dataText.Configuration.CodeStringBuilder;
            dataText.Output = new String[dataText.Input.Length];
            for (int i = 0; i < dataText.Input.Length; i++)
            {
                dataText.Output[i] = dataText.Input[i].Replace(textToCut, "").Replace("(\"", "").Replace("\")", "").Trim();
            }

            return true;
        }
    }
}
