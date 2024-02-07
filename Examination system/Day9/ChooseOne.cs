using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal class ChooseOne : BaseQuestion
    {
        public ChooseOne(string head,string body,int marks,string answer):base(head,body,marks,answer)
        {
            
        }
        public override void type_question()
        {
            Console.WriteLine($"{Head}");
            Console.WriteLine($"Question: {Body}");
            Console.WriteLine($"Marks: {Marks}");

        }
        public override string ToString()
        {
            return $"head :{Head} body :{Body} marks :{Marks}";
        }
    }
}
