using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Modelklasser
{
    internal sealed class Courses : Schooling
    {

        public List<string> SchoolingCourses { get; set; }
        
        //derived klass -arv af schooling
        public Courses(SchoolingCatagory schoolingName) : base(schoolingName)
        {
            // SchoolingNames = schoolingName;
            SetCourses();


        }


        //klassen override sin parent setcourses method 
        public override void SetCourses()
        {
            List<string> schoolingCourses = new();
            SchoolingCourses = schoolingCourses;
            //List<string> coursesList = new List<string>();
            base.SetCourses();
            var enumtype=typeof(CourseCategory);
            Array array=Enum.GetValues(enumtype);
            
            if (SchoolingNames == SchoolingCatagory.Programmeringslinje)
            {

                List<string> schoolingcourses = Courses.Where(a => a.Contains("programmering")).ToList();

                SchoolingCourses = schoolingcourses;


            }
            else if (SchoolingNames == SchoolingCatagory.Supportlinje)
            {
                List<string> schoolingcourses = Courses.Where(a => a.Contains("server")).ToList();
                //Courses = courses;
                SchoolingCourses = schoolingcourses;
                //Console.WriteLine( schoolingcourses);

            }
            else
            {
                List<string> schoolingcourses = Courses.Where(a => a.Contains("Netværk")).ToList();
                SchoolingCourses = schoolingcourses;
                //Console.WriteLine( schoolingcourses);

            }

        }
        public override void GetTeacher()

        {
            List<TECPerson> displayteacher = new();
            Teachers = displayteacher;
            foreach (var displayteachers in Teachers)
            {
                if (SchoolingNames == displayteachers.Uddannelseslinje)
                {
                    if (displayteachers.FullName == "Niels Olsen")
                    {

                        displayteacher.Add(displayteachers);

                    }
                    else if (displayteachers.FullName == "Bo Hansen")

                    {
                        displayteacher.Add(displayteachers);
                    }

                    else
                    {

                        displayteacher.Add(displayteachers);

                    }
                }
                else

                    displayteacher.Add(displayteachers);
                //_ Console.WriteLine($"{displayteachers.FullName}");
            }



        }



        public override string ToString()
        {
            return " **OOP H1 afleveringb opgave ** ";
        }

    }
}
   

 
