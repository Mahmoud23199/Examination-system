using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal class Practice : Exam
    {
        public Practice(DateTime time, int number_question) : base(time, number_question)
        {

        }
        public override void Show_exam()
        {
            Console.WriteLine("--------------------------------------- your Practice Exam -------------------------------------------------");
            Console.WriteLine($"Exam Time: {Time}");
            Console.WriteLine($"Number of Questions: {Number_question}");
            Console.WriteLine("Practice Exam - Showing Correct Answers:");
            Console.WriteLine();
            foreach (var item in question_list)
            {
                item.type_question();

                Console.WriteLine();

            }

        }
      
        public override void Show_result()
        {
            Console.WriteLine("after finishing ------------------------------------------------ this is the right answer");

            foreach (var item in question_list)
            {
                Console.WriteLine($"the right answer : {item.Model_answer}");
            }
        }
    }
}
