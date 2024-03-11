using ConsoleApp11.redo_stack;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.undo_text
{
    internal class Undo_text
    {
        public static Stack<string> s_undo=new Stack<string>();
       
        public string Undo(string proccedtext,string texttoappend) 
        {
            if (s_undo.Count > 0)
            {
                var value = s_undo.Pop();
                Redo_text.s_redo.Push(value);
                //Redo_text command = new Redo_text();
                proccedtext = proccedtext.Substring(0, proccedtext.Length - value.Length);
                //Console.WriteLine(proccedtext);

            }
            else 
            {
                Console.WriteLine("not allowed");
            }
            
              return proccedtext;
        }


    }
}
