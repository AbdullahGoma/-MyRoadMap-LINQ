using System.Collections.ObjectModel;

namespace NewFirst
{
    delegate int MyDelegate(string s);

    internal class Program
    {
        //var y = 3; //error

        // We want to change this function to extention method
        // Class static: All members inside it are static
        //static void Filter(List<int> list, Predicate<int> predicate)
        //{
        //    foreach (var item in list)
        //    {
        //        if (predicate(item)) Console.WriteLine(item);
        //    }
        //}


        
        static IEnumerable<int> Sequence() // Eager Execution vs deferred execution
        {
            // It Like Disconnected Mode
            // Eager Execution
            //List<int> list = new List<int> { 1, 2, 3};
            //return list;

            // Subroutine and Coroutine (Read about)
            // yield change Subroutine to Coroutine

            // Here function will call 3 times
            // Deferred execution: It does not mean when you call function =>
            // function will execute
            // Deferred execution like Connected Mode

            Console.WriteLine("Return 1");
            yield return 1;
            Console.WriteLine("Return 2");
            yield return 2;
            Console.WriteLine("Return 3");
            yield return 3;


        }

        static void Main(string[] args)
        {
            // Implicitly Typed local variable
            // Anonymous Object 
            // Extension Method
            // Sequence

            // C#: Strongly Typed Language

            #region Implicitly Typed Local variable
            //var x = 3; // Var is not data type, Must be initialized
            //var y = x;

            //List<Employee> emps = new List<Employee>(); // = var emps = new List<Employee>();
            //Dictionary<int, List<Employee>> dic = new Dictionary<int, List<Employee>>(); // = var dic = new Dictionary<int, List<Employee>>()
            // There is no function that return var because is not data type
            // var must be local variable 
            #endregion

            #region Anonymous Object
            //Employee emp = new Employee() { ID = 1, Name = "Mahmoud" };
            //var obj = new { ID = 1, Name = "Mahmoud" }; // Anonymous('a) Object
            //object obj = new { ID = 1, Name = "Mahmoud" };
            //var e = new { ID = 2, Name = "Ali" }; // The same data type of last object
            //var e = new { ID = 2, Name = "Ali", Phone = 010 }; // Another anonymous Object

            //List<object> list = new List<object>
            //{
            //    new { ID = 1, Name = "Mahmoud" },
            //    new { ID = 2, Name = "Ali" },
            //    new { ID = 3, Name = "Omar" }
            //};
            //or
            //var list = new List<object>
            //{
            //    new { ID = 1, Name = "Mahmoud" },
            //    new { ID = 2, Name = "Ali" },
            //    new { ID = 3, Name = "Omar" }
            //};


            //list[0]. 
            #endregion

            #region Extension Methods
            //var list = new List<int> { 1, 2, -3, 4, -5, 6, -7, 8, -9};

            //Filter(list, i => i > 0);

            //list.Filter(i => i > 0); // Extension Method: Is a function written in
            // our class but it shown as member in class list

            //Filter(list, i => i < 0);

            //Filter(list, i => i % 2 == 0);

            //Filter(list, i => i % 2 != 0);

            //string msg = "Hello Everybody";


            //string s = msg.RemoveVowels();
            //char ch = s.GetMiddleCharacter();
            //ch.PrintMe();

            //Extensions.PrintMe(Extensions.GetMiddleCharacter(Extensions.RemoveVowels(msg)));
            //msg.RemoveVowels().GetMiddleCharacter().PrintMe();

            //Console.WriteLine(s);   
            #endregion


            // IEnumerable

            //IEnumerable<int> list = Sequence(); // Compiler: when we write yield return
            // (there exist class with compiler implement IEnumerable)
            // then implement IEnumerator then have function movenext 
            // then property called current 
            // fuction movenext call function Sequence
            // and it return object from created class
            // and when we call sequence it will not 
            // execute in this line becuse it return
            // only reference 
            // then when we need to print it, we will
            // use foreach 

            //foreach (int i in list) // Function sequence call when we iterate on IEnumerable
            //{
            //    Console.WriteLine(i);
            //}


            var list = new List<int> { 1, 2, -3, 4, -5, 6, -7, 8, -9};


            // Eager Execution
            //IEnumerable<int> newList = list.Filter(x => x % 2 == 0); // In Eager Execution
            //newList referenced to List have all Elements

            //foreach (int item in newList)
            //{
            //    Console.WriteLine(item);
            //}
            //list[0] = 10;
            // Old Data == New Data
            //foreach (int item in newList)
            //{
            //    Console.WriteLine(item);
            //}



            //Deferred Execution
            //IEnumerable<int> newList = list.Filter(x => x % 2 == 0); // In Deferred Execution
            //// newList have only query

            //foreach (int item in /* Call MoveNext from IEnumerator */ newList)
            //// Here Execute Query
            //{
            //    Console.WriteLine(item);
            //}

            //// Advantages to Deferred Execution 
            //list[0] = 10;
            //// Old Data != New Data
            //foreach (int item in newList)
            //{
            //    Console.WriteLine(item);
            //}

            IEnumerable<int> newList = list.MyFilter();

            foreach (var item in newList)
            {
                Console.WriteLine(item);
            }



        }
    }
}