using ContosoUniversity.Models;

namespace ContosoUniversity.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
                new Student{FirstMidName="Lucca",LastName="Allison",EnrollmentDate=DateTime.Parse("2022-09-01")},
                new Student{FirstMidName="Jimmy",LastName="Amin",EnrollmentDate=DateTime.Parse("2021-09-01")},
                new Student{FirstMidName="Lori",LastName="Mackie",EnrollmentDate=DateTime.Parse("2020-09-01")},
                new Student{FirstMidName="Cory",LastName="Durham",EnrollmentDate=DateTime.Parse("2019-09-01")},
                new Student{FirstMidName="Jonny",LastName="Durham",EnrollmentDate=DateTime.Parse("2019-09-01")}
            };

            context.Students.AddRange(students);
            context.SaveChanges();

            var courses = new Course[]
            {
                new Course{CourseID=1050,Title="Database Design-22S1",Credits=3},
                new Course{CourseID=4022,Title="Object Oriented Analysis & Design-22S1",Credits=3},
                new Course{CourseID=4041,Title="Object Oriented Programming-22S1",Credits=3},
                new Course{CourseID=1045,Title="Web Applications-22S1",Credits=4},
                new Course{CourseID=3141,Title="Networking",Credits=4},
            };

            context.Courses.AddRange(courses);
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
                new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
                new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
                new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
                new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
                new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
                new Enrollment{StudentID=3,CourseID=1050},
                new Enrollment{StudentID=4,CourseID=1050},
                new Enrollment{StudentID=4,CourseID=1045,Grade=Grade.F},
                new Enrollment{StudentID=5,CourseID=1045,Grade=Grade.C},
            };

            context.Enrollments.AddRange(enrollments);
            context.SaveChanges();
        }
    }
}