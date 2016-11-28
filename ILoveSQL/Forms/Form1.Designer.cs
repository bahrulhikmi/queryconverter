namespace ILoveSQL
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbAdoSQL = new System.Windows.Forms.RichTextBox();
            this.rtbRawSQL = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbSQlBuilderString = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cboChangeFormat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.inputPanelTop = new System.Windows.Forms.Panel();
            this.inputPanelBot = new System.Windows.Forms.Panel();
            this.inputPanelMid = new System.Windows.Forms.Panel();
            this.outputPanelTop = new System.Windows.Forms.Panel();
            this.outputPanelBottom = new System.Windows.Forms.Panel();
            this.outputPanelMid = new System.Windows.Forms.Panel();
            this.controlPanelTop = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.midPanelBot = new System.Windows.Forms.Panel();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.inputPanelTop.SuspendLayout();
            this.inputPanelMid.SuspendLayout();
            this.outputPanelMid.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbAdoSQL
            // 
            this.rtbAdoSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbAdoSQL.Location = new System.Drawing.Point(0, 0);
            this.rtbAdoSQL.Name = "rtbAdoSQL";
            this.rtbAdoSQL.Size = new System.Drawing.Size(472, 310);
            this.rtbAdoSQL.TabIndex = 1;
            this.rtbAdoSQL.Text = "";
            // 
            // rtbRawSQL
            // 
            this.rtbRawSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbRawSQL.Location = new System.Drawing.Point(0, 0);
            this.rtbRawSQL.Name = "rtbRawSQL";
            this.rtbRawSQL.Size = new System.Drawing.Size(408, 310);
            this.rtbRawSQL.TabIndex = 0;
            this.rtbRawSQL.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "To Code >>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbSQlBuilderString
            // 
            this.tbSQlBuilderString.Location = new System.Drawing.Point(30, 107);
            this.tbSQlBuilderString.Name = "tbSQlBuilderString";
            this.tbSQlBuilderString.Size = new System.Drawing.Size(150, 20);
            this.tbSQlBuilderString.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(55, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "<< To SQL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cboChangeFormat
            // 
            this.cboChangeFormat.DisplayMember = "Keep format";
            this.cboChangeFormat.FormattingEnabled = true;
            this.cboChangeFormat.Items.AddRange(new object[] {
            "NA",
            "Change to Oracle format",
            "Change to SQL Server format"});
            this.cboChangeFormat.Location = new System.Drawing.Point(121, 12);
            this.cboChangeFormat.Name = "cboChangeFormat";
            this.cboChangeFormat.Size = new System.Drawing.Size(150, 21);
            this.cboChangeFormat.TabIndex = 5;
            this.cboChangeFormat.Tag = "";
            this.cboChangeFormat.ValueMember = "Change to Oracle format, Change to SQL Server format";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "String Builder code:";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.splitContainer1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1101, 397);
            this.panelMain.TabIndex = 7;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.inputPanelMid);
            this.splitContainer1.Panel1.Controls.Add(this.inputPanelBot);
            this.splitContainer1.Panel1.Controls.Add(this.inputPanelTop);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1101, 397);
            this.splitContainer1.SplitterDistance = 408;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.button1);
            this.splitContainer2.Panel1.Controls.Add(this.midPanelBot);
            this.splitContainer2.Panel1.Controls.Add(this.controlPanelTop);
            this.splitContainer2.Panel1.Controls.Add(this.button2);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.tbSQlBuilderString);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.outputPanelMid);
            this.splitContainer2.Panel2.Controls.Add(this.outputPanelBottom);
            this.splitContainer2.Panel2.Controls.Add(this.outputPanelTop);
            this.splitContainer2.Size = new System.Drawing.Size(689, 397);
            this.splitContainer2.SplitterDistance = 213;
            this.splitContainer2.TabIndex = 0;
            // 
            // inputPanelTop
            // 
            this.inputPanelTop.Controls.Add(this.label2);
            this.inputPanelTop.Controls.Add(this.cboChangeFormat);
            this.inputPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.inputPanelTop.Location = new System.Drawing.Point(0, 0);
            this.inputPanelTop.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.inputPanelTop.Name = "inputPanelTop";
            this.inputPanelTop.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.inputPanelTop.Size = new System.Drawing.Size(408, 42);
            this.inputPanelTop.TabIndex = 1;
            // 
            // inputPanelBot
            // 
            this.inputPanelBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.inputPanelBot.Location = new System.Drawing.Point(0, 352);
            this.inputPanelBot.Name = "inputPanelBot";
            this.inputPanelBot.Size = new System.Drawing.Size(408, 45);
            this.inputPanelBot.TabIndex = 2;
            // 
            // inputPanelMid
            // 
            this.inputPanelMid.Controls.Add(this.rtbRawSQL);
            this.inputPanelMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputPanelMid.Location = new System.Drawing.Point(0, 42);
            this.inputPanelMid.Name = "inputPanelMid";
            this.inputPanelMid.Size = new System.Drawing.Size(408, 310);
            this.inputPanelMid.TabIndex = 3;
            // 
            // outputPanelTop
            // 
            this.outputPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.outputPanelTop.Location = new System.Drawing.Point(0, 0);
            this.outputPanelTop.Name = "outputPanelTop";
            this.outputPanelTop.Size = new System.Drawing.Size(472, 42);
            this.outputPanelTop.TabIndex = 2;
            // 
            // outputPanelBottom
            // 
            this.outputPanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.outputPanelBottom.Location = new System.Drawing.Point(0, 352);
            this.outputPanelBottom.Name = "outputPanelBottom";
            this.outputPanelBottom.Size = new System.Drawing.Size(472, 45);
            this.outputPanelBottom.TabIndex = 3;
            // 
            // outputPanelMid
            // 
            this.outputPanelMid.Controls.Add(this.rtbAdoSQL);
            this.outputPanelMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputPanelMid.Location = new System.Drawing.Point(0, 42);
            this.outputPanelMid.Name = "outputPanelMid";
            this.outputPanelMid.Size = new System.Drawing.Size(472, 310);
            this.outputPanelMid.TabIndex = 4;
            // 
            // controlPanelTop
            // 
            this.controlPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlPanelTop.Location = new System.Drawing.Point(0, 0);
            this.controlPanelTop.Name = "controlPanelTop";
            this.controlPanelTop.Size = new System.Drawing.Size(213, 42);
            this.controlPanelTop.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Change SQL format:";
            // 
            // midPanelBot
            // 
            this.midPanelBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.midPanelBot.Location = new System.Drawing.Point(0, 355);
            this.midPanelBot.Name = "midPanelBot";
            this.midPanelBot.Size = new System.Drawing.Size(213, 42);
            this.midPanelBot.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 397);
            this.Controls.Add(this.panelMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMain.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.inputPanelTop.ResumeLayout(false);
            this.inputPanelTop.PerformLayout();
            this.inputPanelMid.ResumeLayout(false);
            this.outputPanelMid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbAdoSQL;
        private System.Windows.Forms.RichTextBox rtbRawSQL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbSQlBuilderString;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cboChangeFormat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel inputPanelMid;
        private System.Windows.Forms.Panel inputPanelBot;
        private System.Windows.Forms.Panel inputPanelTop;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel outputPanelMid;
        private System.Windows.Forms.Panel outputPanelBottom;
        private System.Windows.Forms.Panel outputPanelTop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel controlPanelTop;
        private System.Windows.Forms.Panel midPanelBot;
    }
}

