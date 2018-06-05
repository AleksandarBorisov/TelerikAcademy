using System;
using System.Collections.Generic;

namespace NumberCalculations
{
    class Program
    {
        static void Main()
        {
            string[] numbers = Console.ReadLine().Split(' ');
            int a = int.Parse(numbers[0]);
            int b = int.Parse(numbers[1]);
            int c = int.Parse(numbers[2]);
            int d = int.Parse(numbers[3]);
            int e = int.Parse(numbers[4]);
            Console.WriteLine(Minimum(a, b, c, d, e));
            Console.WriteLine(Maximum(a, b, c, d, e));
            Console.WriteLine("{0:F2}", Average(a, b, c, d, e));
            Console.WriteLine(Sum(a, b, c, d, e));
            Console.WriteLine(Product(a, b, c, d, e));
        }
        //<T> е дефиниран тип с произволно име, и означава че метода е generic, т.е. този тип може да бъде всеки възможен в C#
        static T Minimum<T>(params T[] numbers) where T : IComparable<T>//where е constraint и ни позволява 
        {//да извършваме определени операции с параметъра от тип T
            //Constraints ни позволяват да правим overload на оператори
            T min = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (min.CompareTo(numbers[i]) > 0)//ако min е по-голям от numbers[i]
                {
                    min = numbers[i];
                }
            }
            return min;
        }

        static T Maximum<T>(params T[] numbers) where T : IComparable<T>
        {
            T max = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (max.CompareTo(numbers[i]) < 0)//ако max е по-малък от numbers[i]
                {
                    max = numbers[i];
                }
            }
            return max;
        }

        static double Average<T>(params T[] numbers)
        {
            dynamic sum = 0;
            foreach (T number in numbers)
            {
                sum += number;
            }
            return sum / (double)numbers.Length;
        }

        static dynamic Sum<T>(params T[] numbers)
        {
            dynamic sum = 0;
            foreach (T number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        static dynamic Product<T>(params T[] numbers)
        {
            dynamic product = 1;
            foreach (T number in numbers)
            {
                product *= number;
            }
            return product;
        }
    }
}
//Теория:
//When you define a generic class, you can apply restrictions to the kinds of types that client code can
//use for type arguments when it instantiates your class. If client code tries to instantiate your class
//by using a type that is not allowed by a constraint, the result is a compile-time error.These restrictions
//are called constraints. If you want to examine an item in a generic list to determine whether it is valid or
//to compare it to some other item, the compiler must have some guarantee that the operator or method it has
//to call will be supported by any type argument that might be specified by client code. This guarantee is 
//obtained by applying one or more constraints to your generic class definition. Once the compiler
//has this guarantee, it can allow methods of that type to be called in the generic class. Constraints are
//applied by using the contextual keyword 'where'. 
//By constraining the type parameter, you increase the number of allowable operations and method calls to
//those supported by the constraining type and all types in its inheritance hierarchy.Therefore, when you
//design generic classes or methods, if you will be performing any operation on the generic members beyond
//simple assignment or calling any methods not supported by System.Object, you will have to apply constraints
//to the type parameter.
//The reason for this behavior is that, at compile time, the compiler only knows that T is a reference type,
//and therefore must use the default operators that are valid for all reference types.If you must test for 
//value equality, the recommended way is to also apply the where T : IComparable<T> constraint and implement
//that interface in any class that will be used to construct the generic class. 

//The type 'dynamic' is a static type, but an object of type 'dynamic' bypasses static type checking.
//In most cases, it functions like it has type 'object'. At compile time, an element that is typed as 'dynamic'
//is assumed to support any operation.However, if the code is not valid, errors are caught at run time. 
//Any object can be converted to 'dynamic' type implicitly, conversely, an implicit conversion can be dynamically
//applied to any expression of type 'dynamic'. Overload resolution occurs at run time instead of at compile time
//if one or more of the arguments in a method call have the type 'dynamic, or if the receiver of the method call 
//is of type 'dynamic'.
