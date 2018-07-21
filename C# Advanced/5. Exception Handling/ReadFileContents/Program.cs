using System;
using System.IO;

namespace ReadFileContents
{
    class Program
    {
        static void Main()
        {
            try
            {
                string reader = "../../../../../CreatingInfographic.txt";
                string text = File.ReadAllText(reader);
                Console.WriteLine(text);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The path is null object!");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The path you specified is not a valid string object!");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("The path to the file is too long!");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The directory is not found!");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file is not in the specified directory!");
            }
            catch (IOException)
            {
                Console.WriteLine("Error reading from the file!");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("You dont have privileges to enter that directory!");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("You cannot read from this file!");
            }
        }
    }
}
