using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    /// <summary>
    /// 匿名メソッド
    /// </summary>
    internal class Class1
    {
        internal void Output(string sPara)
        {

            //デリゲートで受け取るメソッドを呼び出す
            Output(WriteHello, sPara);
        }

        //デリゲートの型
        internal delegate void WriteString(string s);

        //デリゲートを使用するクラス
        internal void Output(WriteString method, string s)
        {
            method(s);
        }

        //デリゲートで起動したい処理
        static void WriteHello(string s)
        {
            Console.WriteLine("Hello, " + s);
        }
    }
}
