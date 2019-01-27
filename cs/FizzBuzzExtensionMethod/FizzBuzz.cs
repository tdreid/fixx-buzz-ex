using System;

namespace FizzBuzz
{
    public static class FizzBuzzExtension
    {
        public static string FizzBuzz(this int n)
        {
            string substitute = String.Format(
                "{0}{1}",
                n % 3 == 0 ? "Fizz" : String.Empty,
                n % 5 == 0 ? "Buzz" : String.Empty);
            return string.IsNullOrEmpty(substitute) ? n.ToString() : substitute;
        }
    }
}
