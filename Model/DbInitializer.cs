using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public static class DbInitializer
    {
        public static void Initialize(NovelWebContext context)
        {
            // 数据库若不存在自动创建
            context.Database.EnsureCreated();

            // Look for any Accounts.
            if (context.Account.Any())
            {
                return;   // DB has been seeded
            }

            var Accounts = new Account[]
            {
                new Account{Name="Admin",Phone="Admin",IsAdmin=true, CreateDateTime=DateTime.Parse("2005-09-01")},
                new Account{Name="Carson",Phone="Alexander",CreateDateTime=DateTime.Parse("2005-09-01")},
                new Account{Name="Meredith",Phone="Alonso",CreateDateTime=DateTime.Parse("2002-09-01")},
                new Account{Name="Arturo",Phone="Anand",CreateDateTime=DateTime.Parse("2003-09-01")},
                new Account{Name="Gytis",Phone="Barzdukas",CreateDateTime=DateTime.Parse("2002-09-01")},
                new Account{Name="Yan",Phone="Li",CreateDateTime=DateTime.Parse("2002-09-01")},
                new Account{Name="Peggy",Phone="Justice",CreateDateTime=DateTime.Parse("2001-09-01")},
                new Account{Name="Laura",Phone="Norman",CreateDateTime=DateTime.Parse("2003-09-01")},
                new Account{Name="Nino",Phone="Olivetto",CreateDateTime=DateTime.Parse("2005-09-01")}
            };
            foreach (Account s in Accounts)
            {
                context.Account.Add(s);
            }
            context.SaveChanges();

            //var courses = new Course[]
            //{
            //new Course{CourseID=1050,Title="Chemistry",Credits=3},
            //new Course{CourseID=4022,Title="Microeconomics",Credits=3},
            //new Course{CourseID=4041,Title="Macroeconomics",Credits=3},
            //new Course{CourseID=1045,Title="Calculus",Credits=4},
            //new Course{CourseID=3141,Title="Trigonometry",Credits=4},
            //new Course{CourseID=2021,Title="Composition",Credits=3},
            //new Course{CourseID=2042,Title="Literature",Credits=4}
            //};
            //foreach (Course c in courses)
            //{
            //    context.Courses.Add(c);
            //}
            //context.SaveChanges();

            //var enrollments = new Enrollment[]
            //{
            //new Enrollment{AccountID=1,CourseID=1050,Grade=Grade.A},
            //new Enrollment{AccountID=1,CourseID=4022,Grade=Grade.C},
            //new Enrollment{AccountID=1,CourseID=4041,Grade=Grade.B},
            //new Enrollment{AccountID=2,CourseID=1045,Grade=Grade.B},
            //new Enrollment{AccountID=2,CourseID=3141,Grade=Grade.F},
            //new Enrollment{AccountID=2,CourseID=2021,Grade=Grade.F},
            //new Enrollment{AccountID=3,CourseID=1050},
            //new Enrollment{AccountID=4,CourseID=1050},
            //new Enrollment{AccountID=4,CourseID=4022,Grade=Grade.F},
            //new Enrollment{AccountID=5,CourseID=4041,Grade=Grade.C},
            //new Enrollment{AccountID=6,CourseID=1045},
            //new Enrollment{AccountID=7,CourseID=3141,Grade=Grade.A},
            //};
            //foreach (Enrollment e in enrollments)
            //{
            //    context.Enrollments.Add(e);
            //}
            context.SaveChanges();
        }
    }
}
