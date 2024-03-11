using ConsoleApp11.undo_text;
using ConsoleApp11.redo_stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.appendtext
{
    internal class AppendText
    {
        private string ResultOfAppending;
        private  static string TextToAppend;

        public AppendText(string OriginalText,string textToAppend)
        {
            this.ResultOfAppending = OriginalText;
            TextToAppend = textToAppend;
        }
        public AppendText(string OriginalText)
        {
            this.ResultOfAppending = OriginalText;   
        }


        public string Excute()
        {
            ResultOfAppending += TextToAppend;
            Console.WriteLine(ResultOfAppending);
            //Undo_text x=new Undo_text();
            Undo_text.s_undo.Push(TextToAppend);
            return ResultOfAppending;
        }
        public string Undo() 
        {
            Undo_text undo_Text = new Undo_text();

            return undo_Text.Undo(ResultOfAppending,TextToAppend);
        
        }
        public string Redo()
        {
            Redo_text undo_Text = new Redo_text();
            return undo_Text.Redo(ResultOfAppending);

        }


    }
}
