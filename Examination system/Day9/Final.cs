using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal class Final : Exam
    {
        public Final(DateTime time,int number_question) :base(time,number_question)
        {
            
        }
        public override void Show_exam()
        {
            Console.WriteLine("-------------------------------------------- your Final Exam -------------------------------------------------");
            Console.WriteLine($"Exam Time: {Time}");
            Console.WriteLine($"Number of Questions: {Number_question}");
            Console.WriteLine("Final Exam show Answer:");
            Console.WriteLine();
            foreach (var item in question_list)
            {
                item.type_question();
                Console.WriteLine();

            }

        }

        public override void Show_result()
        {
            Console.WriteLine("after finishing ---------------------------------------------------- this is the Question and Answers.");

            foreach (var item in question_list)
            {
                Console.WriteLine($"the Question is : {item.Body}  Answer is: {item.Model_answer}");
            }
        }
    }
}
