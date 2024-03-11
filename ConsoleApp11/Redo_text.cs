using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp11;
using ConsoleApp11.undo_text;
namespace ConsoleApp11.redo_stack
{
    internal class Redo_text
     {
        public static Stack<string> s_redo = new Stack<string>();
        public string Redo(string proccedtext ) 
        {
            if (s_redo.Count > 0) 
            {
                 var command = s_redo.Pop();
                // Undo_text undo_Text = new Undo_text();
                 Undo_text.s_undo.Push(command);
                 proccedtext += command;
                 Console.WriteLine(proccedtext);
                        
            }
                 return proccedtext;
        }
        



    }
}
