using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal abstract class Exam 
    {
        DateTime time;
        int number_question;

        public List<BaseQuestion> question_list {  get; set; }
        public DateTime Time { get; set; }
        public int Number_question { get { return number_question; } set {number_question=value; } }


        public Exam(DateTime time , int number_question)
        {
            this.number_question = number_question;
            this.time = time;
            question_list = new List<BaseQuestion>();
        }

        public abstract void Show_exam();
        public abstract void Show_result();


    }
}
