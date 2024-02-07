namespace Day9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello," +
                "Enter 1 for Parctice Exam or Enter 2 for Final Exam");
            int type;
            bool check = int.TryParse(Console.ReadLine(), out type);




            TrueFalse trueFalseQ = new("True or False Questions", "1-The blue whale is the biggest animal to have ever lived ?:", 5, "true");
            TrueFalse trueFalseQ2 = new("True or False Questions", "2- Bats are blind ?", 5, "false");
            ChooseOne chooseOneQ = new("Choose the correct answer", "What is the capital of Egypt?", 5, "cairo");
            ChooseAll chooseAllQ = new("Choose all the correct answer", "4-which of the following is a programming language ? a- C++  b- html  c- c#",5,"a,c", "ChooseAll");


            if (type == 1)
            {
                Practice p = new Practice(DateTime.Now, 2);
                p.question_list.Add(trueFalseQ);
                p.question_list.Add(trueFalseQ2);
                p.question_list.Add(chooseOneQ);
                p.question_list.Add(chooseAllQ);

                p.Show_exam();

                List<BaseQuestion> l = new List<BaseQuestion>();
                l.Add(trueFalseQ);
                l.Add(trueFalseQ2);
                l.Add(chooseOneQ);
                l.Add(chooseAllQ);
                Console.WriteLine($"your grade is :{Solve_Exam(l)}");
                Console.WriteLine();
                p.Show_result();


            }
            else if (type == 2)
            {

                Final f = new Final(DateTime.Now, 4);
                f.question_list.Add(trueFalseQ);
                f.question_list.Add(trueFalseQ2);
                f.question_list.Add(chooseOneQ);
                f.question_list.Add(chooseAllQ);

                f.Show_exam();

                List<BaseQuestion> l = new List<BaseQuestion>();
                l.Add(trueFalseQ);
                l.Add(trueFalseQ2);
                l.Add(chooseOneQ);
                l.Add(chooseAllQ);

                Console.WriteLine($"your grade is :{Solve_Exam(l)}");
                Console.WriteLine();
                f.Show_result();

            }


            #region WithRef and WithoutRef
            //int[] myArray = { 10, 20, 30 };
            //Console.WriteLine($" hash  arr{myArray.GetHashCode()}");

            //ModifyArr(myArray);
            //Console.WriteLine(myArray[0]);
            //Console.WriteLine($" hash without ref{myArray.GetHashCode()}");
            //foreach (var item in myArray)
            //{
            //    Console.WriteLine($"without ref {item}");
            //}

            //ModifyArrWithRef(ref myArray);
            //Console.WriteLine(myArray[0]);
            //Console.WriteLine($" hash by ref{myArray.GetHashCode()}");

            //foreach (var item in myArray)
            //{
            //    Console.WriteLine($"by ref {item}");
            //} 
            #endregion

        }
        public static int Solve_Exam(List<BaseQuestion> questions)
        {
            Console.WriteLine("Please Answer Your Exam");
            int grade = 0;
            int i = 0;
            
            foreach (var item in questions)
            {
                i++;
                Console.WriteLine($"enter your answer for question {i}");
                string ans = Console.ReadLine();

                if (item.Type_q=="ChooseAll")//handel choose all
                {
                    string ans1,ans2,mans1,mans2;

                    string[] ans12 = ans.ToLower().Split(',');//answer
                    ans1 = ans12[0];
                    ans2 = ans12[1];
                    ans12=item.Model_answer.Split(',');//model answer
                    mans1 = ans12[0];
                    mans2 = ans12[1];
                    if (ans1 == mans1 || ans1 == mans2 || ans2 == mans1 || ans2 == mans2) 
                    {
                      grade += item.Marks;

                    }

                }
               else if (ans.ToLower() == item.Model_answer)
                {
                    grade += item.Marks;
                }

            }
            return grade;
        }

        //public static void add_exam() 
        //{



        //}


        static void ModifyArr(int[] arr)
        {
            arr[0] = 100; 
        }

        static void ModifyArrWithRef(ref int[] arr)
        {
            arr = new int[] { 1, 2, 3 }; 
        }

    
                
    }
    
}
