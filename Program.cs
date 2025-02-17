using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Test
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Unit Testing");
            BasicProgramForPractise basicProgram = new BasicProgramForPractise();
            basicProgram.Add(10, 20);
        }
    }
}
