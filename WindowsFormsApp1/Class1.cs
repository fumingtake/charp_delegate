using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    /// <summary>
    /// 匿名メソッド
    /// </summary>
    internal class Class1
    {
        internal void Output(Form1 oForm, string sPara)
        {

            //デリゲートで受け取るメソッドを呼び出す
            Output(oForm, WriteHello, sPara);
        }

        //デリゲートの型
        internal delegate void WriteString(Form1 oForm, string s);

        //デリゲートを使用するクラス
        internal void Output(Form1 oForm, WriteString method, string s)
        {
            method(oForm, s);
        }

        //デリゲートで起動したい処理
        private void WriteHello(Form1 oForm, string s)
        {
            string s1 = oForm.AddStringToTextBox1Method("Hello, " + s);
            MessageBox.Show(s1);
        }
    }
}
