namespace Unit_Test
{
    public class BasicProgramForPractise
    {
        public int Add(int x, int y)
        {
            int sum = x + y;
            return sum;
        }

        public bool OddEven(int a)
        {
            bool result = a % 2 == 0;
            if (result)
            {
                Console.WriteLine("number is even");
                return true;
            }
            else
            {
                Console.WriteLine("number is odd");
                return false;
            }
        }
    }
}
