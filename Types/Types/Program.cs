using System;

namespace VariableTypes
{
    public class Program
    {
        public void changeString(string str)
        {
            str = "Hi " + str;
        }

        static void Main(string[] args)
        {
            var obj = new Program();

            string stringUnderTest = "Hello World";

            obj.changeString(stringUnderTest);
            Console.WriteLine(stringUnderTest);
        }
    }
}