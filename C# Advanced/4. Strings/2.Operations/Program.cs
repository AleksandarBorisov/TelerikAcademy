using System;

namespace _2.Operations
{
    class Program
    {
        static void Main()
        {
            string text = "Telerik Academy";
            string text1 = "Telerik academy";
            Console.WriteLine("Equallity with ==: " + (text == text1));
            Console.WriteLine("Equals(): " + text.Equals(text1));
            Console.WriteLine("Equals() + IgnoreCase: " + text.Equals(text1, StringComparison.CurrentCultureIgnoreCase));
            Console.WriteLine("Compare(): " + string.Compare(text, text1, false));
            Console.WriteLine("Compare() + IgnoreCase: " + string.Compare(text, text1, true));
            Console.WriteLine("IndexOf() found : " + text.IndexOf('T'));
            Console.WriteLine("IndexOf() not found : " + text.IndexOf('t'));

            var splitSymbols = new char[] { ' ', ',' };
            // ["Telerik", "Academy"]
            string[] arr = text.Split(splitSymbols, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Length of the array: " + arr.Length);
            Console.WriteLine("Print elements with string.Join " + string.Join(", ", arr));
        }
    }
}
