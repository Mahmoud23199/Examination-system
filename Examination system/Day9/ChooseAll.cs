using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal class ChooseAll : BaseQuestion
    {

        public ChooseAll(string head, string body, int marks,string answer,string type_q) : base(head, body, marks,answer,type_q)
        {

        }
        public override void type_question()
        {
            Console.WriteLine($"Choose All Question - {Head}");
            Console.WriteLine($"Question: {Body}");
            Console.WriteLine($"Marks: {Marks}");
        }
        public override string ToString()
        {
            return $"head :{Head} body :{Body} marks :{Marks}";
        }
    }
}
