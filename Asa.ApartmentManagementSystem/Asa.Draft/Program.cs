using Asa.ApartmentSystem.ApplicationService;
using Asa.Draft.EF;
using System;
using System.Linq;
using System.Configuration;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Asa.Draft.Domain;

namespace Asa.Draft
{
    class Program
    {


        static AutoResetEvent autoResetEvent;
        static async Task Main(string[] args)
        {
            //autoResetEvent = new AutoResetEvent(false);
            //Console.WriteLine("Hello World!");

            ////Thread myWorker1 = new Thread(() => DoMyFirstJob());
            ////myWorker1Start();

            ////Thread myWorker2 = new Thread(() => DoMySecondJob());
            ////myWorker2.Start();

            //Console.WriteLine($"Main thread id { Thread.CurrentThread.ManagedThreadId} ");

            //var task1 = Task.Run(DoMyFirstJob);
            //var task2 = Task.Run(DoMySecondJob);
            //await Task.WhenAll(task1, task2);

            //var connectionString = ConfigurationManager.ConnectionStrings["AppartmentManagementCNX"].ConnectionString;

            //var baseInfoService = new BaseInfoApplicationService(connectionString);
            //var units = await baseInfoService.GetAllOwnerTenantByUnitId(1);



            #region EF
            IEnumerable<Student> students = null;
            //using (var dbContext = new StudentDbContext())
            //{
            //    students = dbContext.Students.Where(x => x.Name == "Ali").ToList();
            //    /*OK=>  var dateTime = new DateTime(1900, 1, 1);
            //     * students = dbContext.Students.Where(x => x.BirthDate > dateTime).ToList();
            //    */
            //    // OK=> students = dbContext.Students.Where(x => x.BirthDate.Year > 1900).ToList();
            //    //Don't do this => students = dbContext.Students.Where(x=> IsBithYearGraterThan(x.BirthDate.Year,1900)).ToList();
            //}
            //foreach (var item in students)
            //{
            //    Console.WriteLine($"{item.Id}. {item.Name}");
            //}

            //using (var dbContext = new StudentDbContext())
            //{
            //    var s = new Student { Name = "Nima", BirthDate = new DateTime(2007, 08, 09) };
            //    dbContext.Students.Add(s);
            //    dbContext.SaveChanges();
            //}

            //using (var dbContext = new StudentDbContext())
            //{
            //    var s = dbContext.Students.FirstOrDefault(x => x.Id == 1);

            //    if (s != null)
            //    {
            //        s.Name = "Nima";
            //    }

            //    dbContext.SaveChanges();
            //}

            //using (var dbContext = new StudentDbContext())
            //{
            //    var s = new Student { Id = 1 };
            //    dbContext.Students.Remove(s);
            //    dbContext.SaveChanges();
            //}

            //var s = new Student { Name = "Nima", BirthDate = new DateTime(2007, 08, 09), Id = 2 };
            //using (var dbContext = new StudentDbContext())
            //{
            //    dbContext.Attach<Student>(s);
            //    s.Name = "Hosein";
            //    dbContext.SaveChanges();
            //}

            //var s = new Student { Id = 2};
            //using (var dbContext = new StudentDbContext())
            //{

            //    dbContext.Students.Remove(s);
            //    dbContext.SaveChanges();
            //}


            //using (var dbContext = new StudentDbContext())
            //{

            //    var s1 = new Student { Id = 7 };
            //    var s2 = new Student { Id = 3 };
            //    dbContext.Attach<Student>(s1);
            //    dbContext.Attach<Student>(s2);
            //    s1.BirthDate = new DateTime(2000, 1, 1);
            //    s2.BirthDate = new DateTime(2001, 1, 1);
            //    dbContext.SaveChanges();
            //}



            //using (var dbContext = new StudentDbContext())
            //{

            //    var s1 = new Student { Id = 7 };
            //    var s2 = new Student { Id = 3 };
            //    //dbContext.Students.RemoveRange(new Student[] { s1, s2 });
            //    dbContext.Students.RemoveRange(s1, s2);
            //    dbContext.SaveChanges();
            //}
            #endregion EF

            var a = Add(1, 2, 3);
            var b = Add(1);
            var c = Add();
            var d = Add(new int[] { 1,2,3,4,5});

            Console.WriteLine("Done");
            Console.ReadLine();
        }

        private static int Add(params int[] numbers)
        {
            int i = 0;
            if (numbers != null)
            {
                foreach (var item in numbers)
                {
                    i += item;
                }
            }
            return i;
        }
        public static bool IsBithYearGraterThan(int studentBirthYear, int year) => studentBirthYear > year;
        private static void DoMyFirstJob()
        {
            for (int i = 0; i < 100; i++)
            {
                autoResetEvent.WaitOne();
                Console.WriteLine($"{ Thread.CurrentThread.ManagedThreadId} This is item # {i}");
                autoResetEvent.Set();
            }
        }

        private static void DoMySecondJob()
        {
            autoResetEvent.Set();
            for (int i = 101; i < 200; i++)
            {
                autoResetEvent.Set();
                Console.WriteLine($"{ Thread.CurrentThread.ManagedThreadId}  =====> # {i}");
                autoResetEvent.WaitOne();
            }
        }
    }
}