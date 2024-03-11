using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using ConsoleApp11.appendtext;
using ConsoleApp11.redo_stack;
using ConsoleApp11.undo_text;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ProccedText = "";

            while (true)
            {
                Console.Write("please enter your appending text else choose operation[ Exit ,Undo,redo]: ");
                string input = Console.ReadLine();
                if (input.Equals("exit",StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                else if (input.Equals("undo",StringComparison.OrdinalIgnoreCase))
                {
                    var undo = new AppendText(ProccedText);
                    ProccedText=undo.Undo();
                    Console.WriteLine(ProccedText);
                }
                else if(input.Equals("redo",StringComparison.OrdinalIgnoreCase))
                {
                    var redo = new AppendText(ProccedText);
                    ProccedText=redo.Redo();

                }
                else 
                { 
                    var value = new AppendText(ProccedText,input);
                    ProccedText= value.Excute();
                }



            }



        }
    }
}
