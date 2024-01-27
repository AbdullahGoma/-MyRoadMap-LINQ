using System.Linq;

namespace NewSecond
{
    // LINQ is a group of Extension Methods
    internal class Program
    {
        static string GetName(Course crs)
        {
            return crs.Name;
        }

        //static object GetData(Course crs)
        //{
        //    return new { crs.Name, crs.Hours };
        //}

        static void Main(string[] args)
        {
            //Arrays are implements IEnumrable
            //IEnumerable<Course> courses = SampleData.Courses.Filter(c => c.Hours > 30);

            //foreach (Course course in courses)
            //{
            //    Console.WriteLine($"Name: {course.Name} \t Hours: {course.Hours} \t Departmet: {course.Department.Name}");
            //}

            //IEnumerable<string> names = SampleData.Courses.Choose(GetName); //SampleData is the first Parameter 
            //IEnumerable<string> names = SampleData.Courses.Choose(c => c.Name);

            //foreach (string name in names)
            //{
            //    Console.WriteLine($"Name: {name}");
            //}

            //IEnumerable<Course> courses = SampleData.Courses.Filter(c => c.Hours > 30);
            //IEnumerable<string> names = courses.Choose(c => c.Name);
            //IEnumerable<string> names = courses.Choose(GetName);

            //foreach (string name in names)
            //{
            //    Console.WriteLine($"Name: {name}");
            //}



            //Pipeline
            //IEnumerable<string> names = SampleData.Courses.Filter(c => c.Hours > 30).Choose(c => c.Name);
            //IEnumerable<string> names = SampleData.Courses.Filter(c => c.Hours > 30).Choose(GetName);
            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}


            // Anonymous Object Used Here
            //var query = SampleData.Courses.Filter(c => c.Hours > 30).Choose(c => new { c.Name, c.Hours } /* Anonymous Object */);
            //IEnumerable<string> names = SampleData.Courses.Filter(c => c.Hours > 30).Choose(GetName);
            //foreach (var course in query) // foreach will use Iterator of Choose funtion
            //    // and movenext of Choose will ask movenext of Filter (MoveNext?)
            //    // and it will check condetion and will return current to current of Choose
            //    // and foreach will print it and this will iterate everytime
            //{ 
            //    Console.WriteLine($"Name: {course.Name} \t Hours: {course.Hours}");
            //}


            // There exist function named Where = Filter, There exist function named Select = Choose
            #region PipeLines
            //var query = 
            //    SampleData.Courses.Where(c => c.Hours > 30)
            //    .Select(c => new { c.Name, c.Hours } /* Anonymous Object */);

            //var query =
            //   SampleData.Courses.Select(c => new { c.Name, c.Hours } /* Anonymous Object */)
            //   .Where(c => c.Hours > 30); // Where will work with IEnumerable of Anonymous
            // And when we want to work with department 
            // it will not work because anonymous object 
            // have only Name and Hours

            //foreach (var course in query )
            //{
            //    Console.WriteLine($"Name: {course.Name} \t Hours: {course.Hours}");
            //} 
            #endregion


            #region Query Expression & Query Operator
            // Query Operator
            //var query =
            //    SampleData.Courses.Where(c => c.Hours > 30)
            //    .Select(c => new { c.Name, c.Hours } /* Anonymous Object */); // Where and Select 
            //                                                         // are called Operators
            //                                                         // We write with way named 
            //                                                         // Query Operator

            //foreach (var course in query)
            //{
            //    Console.WriteLine($"Name: {course.Name} \t Hours: {course.Hours}");
            //}



            // Query Expression: will return to Query Operator
            //var query =
            //    from crs in SampleData.Courses
            //    where crs.Hours > 30
            //    select new { crs.Hours, crs.Name } /* Anonymous Object */; 


            //foreach (var course in query)
            //{
            //    Console.WriteLine($"Name: {course.Name} \t Hours: {course.Hours}");
            //}

            #endregion



            #region Take & Skip
            // Top in SQL = Take

            //var query =
            //    SampleData.Courses.Where(c => c.Hours > 30)
            //    .Select(c => new { c.Name, c.Hours } /* Anonymous Object */).Take(2);
            // Take is extenssion method in IEnumerable

            //var query =
            //    (from crs in SampleData.Courses
            //    where crs.Hours > 30
            //    select new { crs.Hours, crs.Name } /* Anonymous Object */).Take(2);

            //foreach (var course in query)
            //{
            //    Console.WriteLine($"Name: {course.Name} \t Hours: {course.Hours}");
            //}


            //var query =
            //    SampleData.Courses.Where(c => c.Hours > 30)
            //    .Select(c => new { c.Name, c.Hours } /* Anonymous Object */).Skip(2);

            //var query =
            //    (from crs in SampleData.Courses
            //    where crs.Hours > 30
            //    select new { crs.Hours, crs.Name } /* Anonymous Object */).Skip(2);

            //foreach (var course in query)
            //{
            //    Console.WriteLine($"Name: {course.Name} \t Hours: {course.Hours}");
            //}


            //var query =
            //    SampleData.Courses.TakeWhile(c => c.Hours > 30); // When Condition is false 
            // it break

            //var query =
            //    SampleData.Courses.SkipWhile(c => c.Hours > 30);// When Condition is false 
            // it takes all after

            //var query =
            //    (from crs in SampleData.Courses
            //    where crs.Hours > 30
            //    select new { crs.Hours, crs.Name } /* Anonymous Object */).Skip(2);

            //foreach (var course in query)
            //{
            //    Console.WriteLine($"Name: {course.Name} \t Hours: {course.Hours}");
            //}

            #endregion


            #region Aggregate Functions
            // Aggregate Functions

            //int coursesCount = SampleData.Courses.Count(); // Count run as Eager Execution

            //int coursesCount = SampleData.Courses.Count(c => c.Hours > 30);
            ////==
            //int coursesCount = SampleData.Courses.Where(c => c.Hours > 30).Count();
            // Where deffered execution and Count Eager Execution

            //int totalHours = SampleData.Courses
            //    .Where(c => c.Department.Name == "SD")
            //    .Sum(c => c.Hours);

            //int totalHours = (from crs in SampleData.Courses
            //                  where crs.Department.Name == "SD"
            //                  select crs.Hours).Sum();

            //Course maxCourse = SampleData.Courses.Max(); // Exception, must Implement Icomparable

            //int maxHours = SampleData.Courses.Max(c => c.Hours);


            //foreach (var course in query)
            //{
            //    Console.WriteLine($"Name: {course.Name} \t Hours: {course.Hours}");
            //} 
            #endregion


            #region Join
            //var query = from dept in SampleData.Departments
            //            from crs in SampleData.Courses
            //            //where dept.ID == crs.DepartmentID
            //            select new { crs.Name, dept.Name }; // Objection because have 2 propnameerties have the same 


            //var query = from dept in SampleData.Departments
            //            from crs in SampleData.Courses
            //                //where dept.ID == crs.DepartmentID
            //            select new { DeptName = dept.Name, CrsName = crs.Name };

            //var query = from dept in SampleData.Departments
            //            join crs in SampleData.Courses
            //            on dept.ID equals crs.DepartmentID
            //            select new { DeptName = dept.Name, CrsName = crs.Name }; 
            #endregion


            #region First & Last
            //Course crs = SampleData.Courses.Where(c => c.Hours == 60).FirstOrDefault(); //.First() First return
            // first item of our result
            // .FirstOrDefault() : if function does not return any thing .FirstOrDefault()
            // will return Default value of datatype

            //Course crs = SampleData.Courses.Where(c => c.Hours == 60).LastOrDefault(); 
            #endregion




            #region MaxBy & MinBy
            Course maxCourse = SampleData.Courses.MaxBy(x => x.Hours);


            Course minCourse = SampleData.Courses.MinBy(x => x.Hours);
            #endregion


            #region SubQuery
            // Big Error here on performance because it will be O(n*n)
            //Course crs = SampleData.Courses.Where(c => c.Hours == SampleData.Courses.Max(c => c.Hours)).FirstOrDefault();
            // ==
            //IEnumerable<Course> crs = SampleData.Courses.Where(c => c.Hours == SampleData.Courses.Max(c => c.Hours));

            //var query = from sub in SampleData.Subjects
            //            select new
            //            {
            //                SubName = sub.Name,
            //                Courses = from crs in SampleData.Courses
            //                          where crs.Subject.Name == sub.Name
            //                          select crs
            //            };




            // foreach (var sub in query)
            // {
            //    Console.WriteLine($"Subject: {sub.SubName} \t Total Hours: {sub.Courses.Sum(c => c.Hours)}");
            //    foreach (var crs in sub.Courses)
            //        Console.WriteLine($"Name: {crs.Name} \t Hours: {crs.Hours}");
            //    Console.WriteLine("-----------------------------------------");
            // } 
            #endregion


            #region OrderBy
            //var query =
            //    SampleData.Courses.Where(c => c.Hours > 30)
            //    .OrderBy(c => c.Department)
            //    .Select(c => new { c.Name, c.Hours } /* Anonymous Object */);

            //var query =
            //    SampleData.Courses.Where(c => c.Hours > 30)
            //    .Select(c => new { c.Name, c.Hours } /* Anonymous Object */).OrderBy(c => c.Hours);

            //var query =
            //    from crs in SampleData.Courses
            //    where crs.Hours > 30
            //    orderby crs.Hours
            //    select new { crs.Hours, crs.Name } /* Anonymous Object */;

            //var query =
            //    from crs in SampleData.Courses
            //    where crs.Hours > 30
            //    orderby crs.Hours, crs.Name
            //    select new { crs.Hours, crs.Name } /* Anonymous Object */;

            //var query =
            //    from crs in SampleData.Courses
            //    //where crs.Hours > 30
            //    orderby crs.Hours descending, crs.Name
            //    select new { crs.Hours, crs.Name } /* Anonymous Object */;


            //var query =
            //    SampleData.Courses
            //    //.Where(c => c.Hours > 30)
            //    .Select(c => new { c.Name, c.Hours } /* Anonymous Object */)
            //    .OrderByDescending(c => c.Hours).OrderBy(c => c.Name); // It will order by name

            //var query =
            //    SampleData.Courses
            //    //.Where(c => c.Hours > 30)
            //    .Select(c => new { c.Name, c.Hours } /* Anonymous Object */)
            //    .OrderByDescending(c => c.Hours).ThenBy(c => c.Name);


            //foreach (var course in query)
            //{
            //    Console.WriteLine($"Name: {course.Name} \t Hours: {course.Hours}");
            //} 
            #endregion


            #region Deffered Execution vs Eager Execution
            //// This Deffered Execution
            //var query =
            //    SampleData.Courses
            //    //.Where(c => c.Hours > 30)
            //    .Select(c => new { c.Name, c.Hours } /* Anonymous Object */)
            //    .OrderByDescending(c => c.Hours)
            //    .ThenBy(c => c.Name);

            //// This Eager Execution
            //var query =
            //    SampleData.Courses
            //    //.Where(c => c.Hours > 30)
            //    .Select(c => new { c.Name, c.Hours } /* Anonymous Object */)
            //    .OrderByDescending(c => c.Hours)
            //    .ThenBy(c => c.Name).ToList(); // (List of Anonymous)


            //foreach (var course in query)
            //{
            //    Console.WriteLine($"Name: {course.Name} \t Hours: {course.Hours}");
            //} 
            #endregion


            #region Group By
            //var query = from crs in SampleData.Courses
            //            group crs by crs.Subject;


            //foreach (var grp in query)
            //{
            //    Console.WriteLine($"Subject: {grp.Key.Name} \t Total Hours: {grp.Sum(c => c.Hours)}");
            //    foreach (var crs in grp)
            //        Console.WriteLine($"Name: {crs.Name} \t Hours: {crs.Hours}");
            //    Console.WriteLine("-----------------------------------------");
            //}

            //var query = from crs in SampleData.Courses
            //            group crs by crs.Subject into grp
            //            let totalHours = grp.Sum(x => x.Hours)
            //            where totalHours > 50
            //            select new { SubjectName = grp.Key.Name, Courses = grp, TotalHours = totalHours };


            //foreach (var grp in query)
            //{
            //    Console.WriteLine($"Subject: {grp.SubjectName} \t Total Hours: {grp.TotalHours}");
            //    foreach (var crs in grp.Courses)
            //        Console.WriteLine($"Name: {crs.Name} \t Hours: {crs.Hours}");
            //    Console.WriteLine("-----------------------------------------");
            //} 
            #endregion


            //var query = SampleData.GetCourses(); // When we do this:
                                                 // var query = SampleData.GetCourses().Where
                                                 // it will give error because ArrayList is implement 
                                                 // non generic version of IEnumerable


            var query = from Course crs in  SampleData.GetCourses()
                        select crs;

            foreach (var course in query)
            {
                Console.WriteLine($"Name: {course.Name} \t Hours: {course.Hours}");
            }

            //var MostFrequentChar = Most.Where(word => word.GroupBy(x => x).OrderByDescending(x => x).First().Key); 

            //string[] list = new string[]
            //{
            //    "Ali", "Abdullah", "Mahmoud"
            //};

            //var res = from name in list
            //          select name.Length;
            //foreach ( var len in res )
            //{
            //    Console.WriteLine( len );
            //}


        }
    }
}