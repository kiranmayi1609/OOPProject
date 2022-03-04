using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Modelklasser
{
    internal abstract class Schooling
    {
        public SchoolingCatagory SchoolingNames { get; set; }
       //public SchoolingName SchoolingName { get; set; }
        //public CourseCategory CourseName { get; set; }
        
        public List<TECPerson> Teachers { get; set; }
        public List<string> Courses { get; set; }
        //implementer en constructor 
        public Schooling(SchoolingCatagory schoolingName)
        {
           
            //Initialize the lists 
            List<TECPerson> Teacherlist = new()
            {
                new TECPerson() { FullName = "Niels olsen", Uddannelseslinje = SchoolingCatagory.Programmeringslinje },
                new TECPerson() { FullName = "Bo Hansen", Uddannelseslinje = SchoolingCatagory.Supportlinje },
                new TECPerson() { FullName = "Ole Nielsen", Uddannelseslinje = SchoolingCatagory.Infrastrukturlinje }
                 
            };
            Teachers = Teacherlist.ToList();
        }

        // virtual method inden loop enum klasse 
        public virtual void  SetCourses()
        {
            List<string> courses = new();
            Courses = courses;

            foreach (string courseslist in (Enum.GetNames(typeof(CourseCategory))))
            {
               
                courses.Add(courseslist);
                
            }
            

            

        }

        // abstract method 
        public abstract void GetTeacher();
        
    }
}

        


      
    

