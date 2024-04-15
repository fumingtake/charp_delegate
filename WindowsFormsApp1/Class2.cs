using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void WriteHowAreYou(string s)
        {
            Console.WriteLine("How are you? " + s);
        }

        internal void Output(Class1 o, string s)
        {
            o.Output(moWriteStringHander, s);
        }
    }
}
