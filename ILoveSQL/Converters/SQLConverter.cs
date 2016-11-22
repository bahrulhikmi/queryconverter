using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILoveSQL.Converters
{
        
    
    class SQLConverter
    {

        public List<IConverterProcess> converterProcesses;

        public DataText DataInput { get; set; }

        public string Result;

        public SQLConverter()
        {
            converterProcesses = new List<IConverterProcess>();
        }


        public void Start()
        {
            //Deep copy the input data to preserve the original data
            DataText processingData = getCopy(DataInput);

            Result = String.Empty;
            foreach (IConverterProcess process in converterProcesses)
            {                        
                process.Convert(processingData);                
                processingData.Input = processingData.Output;                
            }

            DataInput.Output = processingData.Output;        
            
            //Extract the output string
            foreach (string line in DataInput.Output)
            {
                Result += line + System.Environment.NewLine;
            }            
        }


        private DataText getCopy(DataText dataText)
        {

            DataText dt = new DataText();
            dt.Configuration = dataText.Configuration;
            dt.Input = dataText.Input == null ? null : (String[])dataText.Input.Clone();
            dt.Output = dataText.Output == null ? null : (String[])dataText.Output.Clone();
            dt.InputType = dataText.InputType;

            return dt;
        }
    

        public void AddProcess(IConverterProcess converterProcess)
        {
            if (!(converterProcesses.Any(x => x.GetProcessName() == converterProcess.GetProcessName())))
            {
                converterProcesses.Add(converterProcess);
            }
        }


    }
 
}
