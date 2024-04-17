using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            //別スレッドで処理＋別スレッドでForm描画する場合はInvokeを使ってFormのスレッドで描画する。
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += ProcButton1;
            worker.RunWorkerAsync();

            while(worker.IsBusy)
            {
                Application.DoEvents();
            }
        }

        private void ProcButton1(object sender, DoWorkEventArgs e)
        {
            Class1 o = new Class1();
            o.Output(this, "taka");

            Class2 o2 = new Class2();
            o2.Output(this, o, "chiikawa");
        }

        private delegate string AddStringToTextBox1(string s);

        internal string AddStringToTextBox1Method(string text)
        {
            if(this.InvokeRequired)
            {
                //return (string)this.Invoke(new AddStringToTextBox1(AddStringToTextBox1Method), new object[] { text });
                //newしなくても下記でOK
                return (string)this.Invoke((AddStringToTextBox1)AddStringToTextBox1Method, new object[] { text });
            }

            this.textBox1.Text += text;
            this.textBox1.Text += Environment.NewLine;

            return this.textBox1.Text;
        }
    }
}
