namespace Day9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Abstract
            //Shape s1 = new Circle(5);
            //s1.Area();
            //Rect r1= new Rect();
            //r1.Show();

            //ClacArea(r1); 
            #endregion

            ClassB classB = new();

            classB.Test(new ClassA());
            Console.WriteLine("--------------------------");
            classB.Test(new ClassC());

            classB.Test(new structD());
        }
        public static void ClacArea(Shape s1)
        {
            Console.WriteLine(s1.Area());

        }
    }
}