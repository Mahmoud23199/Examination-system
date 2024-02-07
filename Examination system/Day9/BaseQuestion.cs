using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal abstract class BaseQuestion
    {
        private string head;
        private string body;
        private int marks;
        private string answer;
        private string model_answer;
        private string type_q;

        public BaseQuestion(string head, string body, int marks)
        {
            this.head = head;
            this.body = body;
            this.marks = marks;
        }
        public BaseQuestion(string head ,string body ,int marks,string model_answer):this(head ,body ,marks)
        {
           
            this.model_answer = model_answer;
            
        }
        public BaseQuestion(string head, string body, int marks, string model_answer,string type_q) : this(head, body, marks,model_answer)
        {

            this.type_q = type_q;

        }



        public string Model_answer { get { return model_answer; } set { model_answer = value; } }
        public string Head { get { return head; } set { head = value; } }
        public string Body { get { return body; } set { body = value; } }
        public string Answer { get { return answer; } set { answer = value; } }
        public string Type_q { get { return type_q; } set { type_q = value; } }
        public int Marks { get {  return marks; } set {  marks = value; } }


        public abstract void type_question();
    }
}
