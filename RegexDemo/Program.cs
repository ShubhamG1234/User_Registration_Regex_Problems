namespace RegexDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Pattern pattern = new Pattern();

            Console.WriteLine("Enter the Pattern");
            string reg = Console.ReadLine();

            bool val = pattern.validatePinCode(reg);

            if (val)
                Console.WriteLine("Pattern Matched");
            else
                Console.WriteLine("Pattern Not Matched") ;
        }
    }
}