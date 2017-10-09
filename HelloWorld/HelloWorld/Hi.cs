using System;

namespace HelloWorld
{
    public class Hi
    {
        public string result(string input)
        {
            if (input == "HELLO")
                return "WORLD";
            return "INVALID";
        }
    }
}
