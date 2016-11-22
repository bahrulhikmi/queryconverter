using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ILoveSQL
{
    public partial class Form1 : Form
    {       

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                processInput(DataInputType.RawSQL);
            }
            catch(Exception exc)
            {
                string errMessage = exc.Message + "\n" + exc.StackTrace;
                MessageBox.Show("Error occurred: \n"+ errMessage);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                processInput(DataInputType.AdoSQL);
            }
            catch (Exception exc)
            {
                string errMessage = exc.Message + "\n" + exc.StackTrace;
                MessageBox.Show("Error occurred: \n" + errMessage);
            }
        }

        private void processInput(DataInputType inputType)
        {

            RichTextBox rtbInput = inputType == DataInputType.RawSQL ? rtbRawSQL : rtbAdoSQL;
            RichTextBox rtbOutput = inputType == DataInputType.RawSQL ?  rtbAdoSQL: rtbRawSQL;

            DataText dataText = new DataText();
            dataText.Configuration.CodeStringBuilder = tbSQlBuilderString.Text.Trim();
            dataText.Configuration.ChangeSqlFormat = cboChangeFormat.SelectedIndex;
            dataText.InputType = inputType;
            dataText.Input = rtbInput.Text.Split(new[] { "\n" }
                                          , StringSplitOptions.RemoveEmptyEntries);

            Converters.SQLConverter sqlConverter = new Converters.SQLConverter();
            sqlConverter.DataInput = dataText;


               switch (inputType)
                {
                   case DataInputType.RawSQL:            
                    sqlConverter.AddProcess(new Converters.StringToADO());

                    break;
                   case DataInputType.AdoSQL:
                    sqlConverter.AddProcess(new Converters.ADOToString());

                    break;
                }
            
            sqlConverter.Start();
            rtbOutput.Text = sqlConverter.Result;
        }

    }
}
