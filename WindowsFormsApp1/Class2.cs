using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp1.Class1;

namespace WindowsFormsApp1
{
    /// <summary>
    /// 匿名メソッドを使う
    /// </summary>
    internal class Class2
    {
        //Class1のデリゲートを使用
        internal WriteString moWriteStringHander;

        internal Class2()
        {
            moWriteStringHander = new WriteString(WriteHowAreYou);
        }

        private void WriteHowAreYou(Form1 oForm, string s)
        {
            string s2 = oForm.AddStringToTextBox1Method("How are you? " + s);
            MessageBox.Show(s2);
        }

        internal void Output(Form1 oForm, Class1 o, string s)
        {
            o.Output(oForm, moWriteStringHander, s);
        }
    }
}
