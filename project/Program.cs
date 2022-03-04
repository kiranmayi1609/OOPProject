
// Application starts
//SchoolingCatagory S = new();
//Courses display = new ();
SchoolingCatagory schoolingCatagory = new ();
List<TECPerson> people = new();
Courses display = new (schoolingCatagory);

while (true)
{

    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Vælger uddannelselinje ");
    Console.WriteLine("1.Programmering ");
    Console.WriteLine("2.Support");
    Console.WriteLine("3.Infrastructure");

    Console.WriteLine("vælge 1,2 eller 3 ");

    var Option = Console.ReadLine();

    switch (Option)
    {

        case "1":
            display.SchoolingNames = SchoolingCatagory.Programmeringslinje;
            display.SetCourses();

            break;
        case "2":
            display.SchoolingNames = SchoolingCatagory.Supportlinje;
            display.SetCourses();

            break;
        case "3":

            display.SchoolingNames = SchoolingCatagory.Infrastrukturlinje;
            display.SetCourses();

            break;
        default:
            Console.Clear();
            Console.WriteLine("It is not mached,Try again");
            Console.ReadKey();
            break;
    }

    Console.Clear();

    if (Option == "1" || Option == "2" || Option == "3")
    {
        Console.WriteLine($"{display.ToString()}");
        Console.WriteLine("----------------------------------------------------------------------");
        

            if (display.SchoolingNames == SchoolingCatagory.Programmeringslinje)
            {
                Console.Write("all fag  har");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(" Programmering");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" følegende fag ");

            }

            else if (display.SchoolingNames == SchoolingCatagory.Supportlinje)
            {


                Console.Write("all fag  har");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(" Supportlinje");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" følegende fag ");
            }



            else
            {
                Console.Write("all fag  har");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(" Infrastructurelinje ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" følegende fag ");

            }


        foreach (string item in display.Courses)

        {
            //foreach (var s in display.Teachers)
            //{
            //    Console.WriteLine($"{s.FullName}");
            //    Console.WriteLine("Teacher");

            //    display.GetTeacher();
            //}

                //Console.WriteLine($"{item}");
                //Console.WriteLine("--------------------------------------------------------------------------");
                //Console.WriteLine("Teacher:");
                //display.GetTeacher();
                Console.ForegroundColor = ConsoleColor.White;
                if (display.SchoolingNames == SchoolingCatagory.Programmeringslinje && item.Contains("programmering"))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{item}");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (display.SchoolingNames == SchoolingCatagory.Supportlinje && item.Contains("Server"))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    Console.WriteLine($"{item}");
                    Console.ForegroundColor = ConsoleColor.White;
                    //Console.WriteLine($"{display.SchoolingCourses}");
                }
                else if (display.SchoolingNames == SchoolingCatagory.Infrastrukturlinje && item.Contains("Netværk"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine($"{item}");
                    //Console.WriteLine($"{display.SchoolingCourses}");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"{item}");
                    Console.ForegroundColor = ConsoleColor.White;
                    //Console.WriteLine($"{display.SchoolingCourses}");
                }


            }
        
        Console.WriteLine("---------------------------------");





        //display.Teachers.Sort();
        Console.WriteLine("Teacher");

        foreach (var item1 in display.Teachers)

        {
            //Console.WriteLine("Teacher");
            foreach (var s in display.Teachers)
            {
                Console.WriteLine($"{s.FullName}");
                //display.Teachers.Sort();

            }
            display.Teachers.Sort();
            if (display.SchoolingNames == item1.Uddannelseslinje)
            {
                if (item1.FullName == "Niels Olsen")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{item1.FullName}");
                    Console.ForegroundColor = ConsoleColor.White;

                }
                else if (item1.FullName == "Bo Hansen")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{item1.FullName}");
                    Console.ForegroundColor = ConsoleColor.White;

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{item1.FullName}");
                    Console.ForegroundColor = ConsoleColor.White;

                }

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"{item1.FullName}");
            }

            

        }
        Console.ReadKey();
    }

    Console.Clear();
}



        

     
    

   


    
 

    


