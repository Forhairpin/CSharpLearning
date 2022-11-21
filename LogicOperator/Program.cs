namespace LogicOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Runtime does not go to the method Calculate(), it returns ture directly.
            var a = true || Calculate();
            Console.WriteLine(a);

            // Method Calculate() runs, it returns false because that method returns false.
            var b = false || Calculate();
            Console.WriteLine(b);
        }

        static bool Calculate()
        {
            // this breakpoint only hit once
            return false;
        }
    }
}