using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal class TrueFalse : BaseQuestion
    {

        public TrueFalse(string head,string body ,int marks,string answer):base(head,body,marks,answer)
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









        //Head = "True or False Questions";

        //Console.Write("1-The blue whale is the biggest animal to have ever lived ?:");
        //string ans1=Console.ReadLine();

        //string result1, result2,correct1="true",correct2="false";
        //if (ans1 == "true")
        //    result1 = "true answer";
        //else
        //{
        //    result1 = "false answer";
        //    Console.WriteLine($"correct answer is:{correct1} ");
        //}

        //Console.WriteLine("2- Bats are blind ?");
        //  string ans2 = Console.ReadLine();
        //if (ans2 == "false")
        //    result2 = "true";
        //else
        //{
        //    result2 = "false";
        //    Console.WriteLine($"correct answer is:{correct2} ");

        //}


    }
    
}
