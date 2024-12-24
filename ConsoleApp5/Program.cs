using System;
using System.Xml.Schema;

namespace ConsoleApp5
{
    internal class Program
    {
        //static void DoSomeCode()
        //{
        //    try
        //    {
        //        int x, y, z;
        //        x = int.Parse(Console.ReadLine()); // formatException
        //        y = int.Parse(Console.ReadLine());
        //        z = int.Parse(Console.ReadLine());
        //        z = x / y;
        //        int[] arr = { 1, 2, 3 };
        //        arr[99] = 100;
        //    }
        //    catch (DivideByZeroException E)
        //    {
        //        Console.WriteLine(E.Message);
        //    }
        //    catch (FormatException E)
        //    {
        //        Console.WriteLine(E.Message);
        //    }
        //    finally
        //    {
        //        Console.WriteLine("Finally"); // hytnfz lw fe exception aw la
        //        // Deallocate
        //        // Disconncet | Dispose Unmanaged Resource (file, DB)
        //    }
        //}
        //static void DosomeProtectiveCode()
        //{
        //    int x, y, z;
        //    bool Flag;
        //    do
        //    {
        //        Console.WriteLine("Enter First Number");
        //        Flag = int.TryParse(Console.ReadLine(), out x);
        //    } while (!Flag);

        //    x = int.Parse(Console.ReadLine());
        //    y = int.Parse(Console.ReadLine());
        //    z = int.Parse(Console.ReadLine());
        //    z = x / y;
        //    int[] arr = { 1, 2, 3 };
        //    arr[99] = 100;
        //}
        static void Main(string[] args)
        {
            #region Boxing and UnBoxing
            // Booking : casting from datatyor (Value type( to Datatype (Reference Type)
            // UnBokxing : casting from datatyor (reference type )to Datatype (value Type)

            // Boxing 
            //object o1;
            // o1= (object)1; // Casting From Int (Value type) to Object
            //int x = 12;
            //object o1 =(object) x;
            // Implicit Casting  / Safe casting 
            // UnBoxing

            //object o1 = 1;
            //int x = (int) o1;
            //// Explixit Casting 
            //// unsafe Castig : May Throw exception 
            //// chilf => parent
            //Console.WriteLine(x);
            #endregion

            #region Nuulable Value Types
            // Value type
            //int x = 12;
            //Console.WriteLine(x);

            //int age = 30;
            //age = null // Invalid: Int dont allow null as a valid value
            //Console.WriteLine(age);

            // Nullable Value Type: Allow Null as Valid Value 
            //int? age = 30; // Nullable integer -> allow int + null
            // memory -->save in stack 4 bytes emptyyyyyyyyy
            //age = null;
            //Console.WriteLine(age);

            //double? Salary = 20000; // Nullable double
            //Salary = null;
            //Console.WriteLine(Salary);

            //int X = 12;
            //// Y is Nullable int 
            ////int? Y = X; // Valid 
            //int? Y = (int?)X;

            //int? X = 12;
            //// Y : allow int only

            //int Y = (int)X; // invalid

            //Defensive Code
            //int? X = 12;
            //int Y;
            //if (X != null)
            //{
            //    Y = (int)X;
            //}
            //else
            //{
            //    Y = 0;
            //}
            //if (X.HasValue)
            //    Y = X.Value;
            //else
            //    Y = 0;
            //// Ternery 
            //Y = X.HasValue ? X.Value : 0;

            // Null Coalesing Opertator
            //Y = X ?? 0;
            //Console.WriteLine(Y);
            #endregion

            #region Nullable Reference Type 
            // Reference Type : Allow Null as valid
            //string Message01 =null; // Required 
            //string? Message02 =null; // Optional ==> Dotnet 6.0
            // Two is the same in the memory
            //Console.WriteLine(Message01);
            //Console.WriteLine(Message02);
            #endregion

            #region Null Propagition Operator
            // ?
            //int X = default;
            //Console.WriteLine(X); // 0
            //int[] Arr = default; // null
            //NullreferenceExpextion 
            //for (int i = 0; (Arr is not null) && i < Arr.Length; i++)
            //{
            //    Console.WriteLine(Arr[i]);
            //}
            // ==> defensive code 

            //int[] Arr = default;

            //for (int i = 0;  i < Arr?.Length; i++)
            //{
            //    Console.WriteLine(Arr[i]);
            //}
            //if (Arr is not null)
            //{
            //    for (int i = 0; i < Arr.Length; i++)
            //    {
            //        Console.WriteLine(Arr[i]);
            //    }
            //}

            //int len = Arr is not null? Arr.Length:0;
            //int len = Arr?.Length ?? 0;
            //Console.WriteLine(len);

            #endregion

            #region Exception
            //Console.WriteLine("Hello");
            //throw new Exception();
            //Console.WriteLine("Hello after exeption"); // msh hyshtghl
            // How to habndle exception
            //DoSomeCode();
            // Exception: --> Parent
            // 1. SystemException
            // 1.1 NullReferenceException
            // 1.2 Formate
            // 1.3 IndexOutOfRange
            // 1.4 Arithimatic (DivideByZero - OverFlow)
            //             // 2. ApplicationException
            #endregion

            #region Access Modifiers 
            // C# Keyword Indicate The Accessability Scope
            // 1. private
            // 2. private protected
            // 3. protected
            // 4. internal
            // 5. internal protected
            // 6. public
            // Inside the namespace

            // Acess Modifiers that can use in namspace:
            // 1. internal 
            // 2. public 

            // What can i Write on Class or Struct?
            // 1. attributes
            // 2. Methodes
            // 3. properties 
            // 4. Events
            #endregion
           
        }
    }
}
