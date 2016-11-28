using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILoveSQL
{
    interface IConverterProcess
    {
        string GetProcessName();
        bool Convert(DataText dataInput);
    }
}
