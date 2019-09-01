using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _89_Project_Part_B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Marvel Avengers Academy management application!");
            Console.WriteLine("This app will allow you to add and save data in the form of students, trainers, assignments and courses.");
            Console.WriteLine("");
            Console.WriteLine("You will also be able to have a display of: ");
            Console.WriteLine("- Students per course");
            Console.WriteLine("- Trainers per course");
            Console.WriteLine("- Assignments per course");
            Console.WriteLine("- Assignments per course per student");
            Console.WriteLine("- Students in more than one courses");
            Console.WriteLine("");

            Console.WriteLine("You will need to press the enter key everytime you select something in a menu by typing a number!");
            Console.WriteLine("Press any button to continue.");
            Console.ReadKey();

            Db_Manager_Add dbadd = new Db_Manager_Add();
            Db_Manager_View dbview = new Db_Manager_View();

            int choice1; 

            do
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("_1_Add_Data");
                Console.WriteLine("_2_View_Current_Data");
                Console.WriteLine("_3_Exit");
                Console.WriteLine("Choose your selection from above: ");
                bool checkchoice1 = int.TryParse(Console.ReadLine(), out choice1);

                while (checkchoice1 != true || (choice1 != 1 && choice1 != 2 && choice1 != 3))
                {
                    Console.WriteLine("Wrong Input! Please enter one of the suggested choices");
                    checkchoice1 = int.TryParse(Console.ReadLine(), out choice1);
                }

                switch (choice1)
                {
                    case 1:

                        int choice2; 

                        do
                        {
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.White;

                            Console.WriteLine("_1_Add_Student");
                            Console.WriteLine("_2_Add_Trainer");
                            Console.WriteLine("_3_Add_Course");
                            Console.WriteLine("_4_Add_Assignment_(including associated student and course)");
                            Console.WriteLine("_5_Add_Student_to_Course");
                            Console.WriteLine("_6_Add_Trainer_to_Course");
                            Console.WriteLine("_7_Go_Back");
                            bool checkchoice2 = int.TryParse(Console.ReadLine(), out choice2);

                            while (checkchoice2 != true || (choice2 != 1 && choice2 != 2 && choice2 != 3 && choice2 != 4
                                   && choice2 != 5 && choice2 != 6 && choice2 != 7))
                            {
                                Console.WriteLine("Wrong Input! Please enter one of the suggested choices");
                                checkchoice2 = int.TryParse(Console.ReadLine(), out choice2);
                            }

                            switch (choice2)
                            {
                                case 1:
                                    Console.WriteLine("Process initialised... Ready to add! Press any key to continue!");
                                    Console.ReadKey();
                                    int act0;
                                    do
                                    {
                                        Console.WriteLine("Enter the new student's name" +
                                            ", date of birth in dd/mm/yyyy format and tuition fees: ");
                                        string contact_name = Console.ReadLine();
                                        DateTime dob;
                                        bool checkdob = DateTime.TryParse(Console.ReadLine(), out dob);
                                        while (checkdob != true)
                                        {
                                            Console.WriteLine("Invalid Input! Please follow suggested format!");
                                            checkdob = DateTime.TryParse(Console.ReadLine(), out dob);
                                        }
                                        int tuition_fees;
                                        bool checktf = int.TryParse(Console.ReadLine(), out tuition_fees);
                                        while (checktf != true)
                                        {
                                            Console.WriteLine("Invalid Input! Please follow suggested format!");
                                            checktf = int.TryParse(Console.ReadLine(), out tuition_fees);
                                        }
                                        dbadd.AddStudent(contact_name, dob, tuition_fees);
                                        Console.WriteLine("Student added!");
                                        Console.WriteLine("Press 1 to add another student or any other number to proceed to the next step");
                                        bool checkact = int.TryParse(Console.ReadLine(), out act0);
                                        while (checkact != true)
                                        {
                                            Console.WriteLine("Wrong Input! Please press 1 to add another student or press any other number to continue");
                                            checkact = int.TryParse(Console.ReadLine(), out act0);
                                        }
                                    } while (act0 == 1);
                                    break;
                                case 2:
                                    Console.WriteLine("Process initialised... Ready to add! Press any key to continue!");
                                    Console.ReadKey();
                                    int act1;
                                    do
                                    {
                                        Console.WriteLine("Enter the new trainer's name and subject: ");
                                        string contact_name = Console.ReadLine();
                                        string subject = Console.ReadLine();
                                        dbadd.AddTrainer(contact_name, subject);
                                        Console.WriteLine("Trainer added!");
                                        Console.WriteLine("Press 1 to add another trainer or any other number to proceed to the next step");
                                        bool checkact = int.TryParse(Console.ReadLine(), out act1);
                                        while (checkact != true)
                                        {
                                            Console.WriteLine("Wrong Input! Please press 1 to add another trainer or press any other number to continue");
                                            checkact = int.TryParse(Console.ReadLine(), out act1);
                                        }
                                    } while (act1 == 1);
                                    break;
                                case 3:
                                    Console.WriteLine("Process initialised... Ready to add! Press any key to continue!");
                                    Console.ReadKey();
                                    int act2;
                                    do
                                    {
                                        Console.WriteLine("Enter the new courses's title, type, stream, start-date and end-date (both in dd/mm/yyyy format): ");
                                        string title = Console.ReadLine();
                                        string type = Console.ReadLine();
                                        string stream = Console.ReadLine();
                                        DateTime st_date;
                                        bool checkstdt = DateTime.TryParse(Console.ReadLine(), out st_date);
                                        while (checkstdt != true)
                                        {
                                            Console.WriteLine("Invalid Input! Please follow suggested format!");
                                            checkstdt = DateTime.TryParse(Console.ReadLine(), out st_date);
                                        }
                                        DateTime en_date;
                                        bool checkendt = DateTime.TryParse(Console.ReadLine(), out en_date);
                                        while (checkendt != true)
                                        {
                                            Console.WriteLine("Invalid Input! Please follow suggested format!");
                                            checkendt = DateTime.TryParse(Console.ReadLine(), out en_date);
                                        }
                                        dbadd.AddCourse(title, type, stream, st_date, en_date);
                                        Console.WriteLine("Course added!");
                                        Console.WriteLine("Press 1 to add another course or any other number to proceed to the next step");
                                        bool checkact = int.TryParse(Console.ReadLine(), out act2);
                                        while (checkact != true)
                                        {
                                            Console.WriteLine("Wrong Input! Please press 1 to add another course or press any other number to continue");
                                            checkact = int.TryParse(Console.ReadLine(), out act2);
                                        }
                                    } while (act2 == 1);
                                    break;
                                case 4:
                                    Console.WriteLine("Process initialised... Ready to add! Press any key to continue!");
                                    Console.ReadKey();
                                    int act3;
                                    do
                                    {
                                        Console.WriteLine("Enter the new Assignment's title, description, oral mark (e.g. 89.5), total mark (e.g. 89.5), student ID (e.g. 5), course ID (e.g. 5): ");
                                        string title = Console.ReadLine();
                                        string description = Console.ReadLine();
                                        decimal oral_mark;
                                        bool checkom = decimal.TryParse(Console.ReadLine(), out oral_mark);
                                        while (checkom != true)
                                        {
                                            Console.WriteLine("Invalid Input! Please follow suggested format!");
                                            checkom = decimal.TryParse(Console.ReadLine(), out oral_mark);
                                        }
                                        decimal total_mark;
                                        bool checktm = decimal.TryParse(Console.ReadLine(), out total_mark);
                                        while (checktm != true)
                                        {
                                            Console.WriteLine("Invalid Input! Please follow suggested format!");
                                            checktm = decimal.TryParse(Console.ReadLine(), out total_mark);
                                        }
                                        int student_id;
                                        bool checksid = int.TryParse(Console.ReadLine(), out student_id);
                                        while (checksid != true)
                                        {
                                            Console.WriteLine("Invalid Input! Please follow suggested format!");
                                            checksid = int.TryParse(Console.ReadLine(), out student_id);
                                        }
                                        int course_id;
                                        bool checkcid = int.TryParse(Console.ReadLine(), out course_id);
                                        while (checkcid != true)
                                        {
                                            Console.WriteLine("Invalid Input! Please follow suggested format!");
                                            checkcid = int.TryParse(Console.ReadLine(), out course_id);
                                        }
                                        dbadd.AddAssignment(title, description, oral_mark, total_mark, student_id, course_id);
                                        Console.WriteLine("Assignment added!");
                                        Console.WriteLine("Press 1 to add another Assignment or any other number to proceed to the next step");
                                        bool checkact = int.TryParse(Console.ReadLine(), out act3);
                                        while (checkact != true)
                                        {
                                            Console.WriteLine("Wrong Input! Please press 1 to add another Assignment or press any other number to continue");
                                            checkact = int.TryParse(Console.ReadLine(), out act3);
                                        }
                                    } while (act3 == 1);
                                    break;
                                case 5:
                                    Console.WriteLine("Process initialised... Ready to add! Press any key to continue!");
                                    Console.ReadKey();
                                    int act4;
                                    do
                                    {
                                        Console.WriteLine("Enter the course id, student id, course title, the student's name and whether they are in multiple courses" +
                                            "(enter True or False): ");
                                        int course_id;
                                        bool checkcid = int.TryParse(Console.ReadLine(), out course_id);
                                        while (checkcid != true)
                                        {
                                            Console.WriteLine("Invalid Input! Please follow suggested format!");
                                            checkcid = int.TryParse(Console.ReadLine(), out course_id);
                                        }
                                        int student_id;
                                        bool checksid = int.TryParse(Console.ReadLine(), out student_id);
                                        while (checksid != true)
                                        {
                                            Console.WriteLine("Invalid Input! Please follow suggested format!");
                                            checksid = int.TryParse(Console.ReadLine(), out student_id);
                                        }
                                        string course_title = Console.ReadLine();
                                        string student_name = Console.ReadLine();
                                        string multiple_course = Console.ReadLine();
                                        dbadd.AddStudentToCourse(course_id, student_id, course_title, student_name, multiple_course);
                                        Console.WriteLine("Student added to course!");
                                        Console.WriteLine("Press 1 to add another student to a course or any other number to proceed to the next step");
                                        bool checkact = int.TryParse(Console.ReadLine(), out act4);
                                        while (checkact != true)
                                        {
                                            Console.WriteLine("Wrong Input! Please press 1 to add another student or press any other number to continue");
                                            checkact = int.TryParse(Console.ReadLine(), out act4);
                                        }
                                    } while (act4 == 1);
                                    break;
                                case 6:
                                    Console.WriteLine("Process initialised... Ready to add! Press any key to continue!");
                                    Console.ReadKey();
                                    int act5;
                                    do
                                    {
                                        Console.WriteLine("Enter the course id, trainer id, trainer's name and the course title: ");
                                        int course_id;
                                        bool checkcid = int.TryParse(Console.ReadLine(), out course_id);
                                        while (checkcid != true)
                                        {
                                            Console.WriteLine("Invalid Input! Please follow suggested format!");
                                            checkcid = int.TryParse(Console.ReadLine(), out course_id);
                                        }
                                        int trainer_id;
                                        bool checktid = int.TryParse(Console.ReadLine(), out trainer_id);
                                        while (checktid != true)
                                        {
                                            Console.WriteLine("Invalid Input! Please follow suggested format!");
                                            checktid = int.TryParse(Console.ReadLine(), out trainer_id);
                                        }
                                        string course_title = Console.ReadLine();
                                        string trainer_name = Console.ReadLine();
                                        dbadd.AddTrainerToCourse(course_id, trainer_id, course_title, trainer_name);
                                        Console.WriteLine("Trainer added to course!");
                                        Console.WriteLine("Press 1 to add another trainer to a course or any other number to proceed to the next step");
                                        bool checkact = int.TryParse(Console.ReadLine(), out act5);
                                        while (checkact != true)
                                        {
                                            Console.WriteLine("Wrong Input! Please press 1 to add another trainer or press any other number to continue");
                                            checkact = int.TryParse(Console.ReadLine(), out act5);
                                        }
                                    } while (act5 == 1);
                                    break;
                            }

                        } while (choice2 == 1 || choice2 == 2 || choice2 == 3 || choice2 == 4 || choice2 == 5 || choice2 == 6);
                            break;
                    case 2:

                        int choice3;

                        do
                        {
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.White;

                            Console.WriteLine("_1_View_Students");
                            Console.WriteLine("_2_View_Trainers");
                            Console.WriteLine("_3_View_Courses");
                            Console.WriteLine("_4_View_Assignments");
                            Console.WriteLine("_5_View_Students_in_Courses");
                            Console.WriteLine("_6_View_Trainers_in_Courses");
                            Console.WriteLine("_7_View_Assignments_per_Students_in_Courses");
                            Console.WriteLine("_8_View_Students_in_multiple_Courses");
                            Console.WriteLine("_9_Go_Back");
                            bool checkchoice3 = int.TryParse(Console.ReadLine(), out choice3);

                            while (checkchoice3 != true || (choice3 != 1 && choice3 != 2 && choice3 != 3 && choice3 != 4
                                   && choice3 != 5 && choice3 != 6 && choice3 != 7 && choice3 != 8 && choice3 != 9))
                            {
                                Console.WriteLine("Wrong Input! Please enter one of the suggested choices");
                                checkchoice3 = int.TryParse(Console.ReadLine(), out choice3);
                            }

                            switch (choice3)
                            {
                                case 1:
                                    List<Student> students = dbview.ViewStudents();
                                    Console.Clear();
                                    foreach (var Student in students)
                                    {
                                        Console.WriteLine(Student);
                                    }
                                    Console.WriteLine("Press any key to continue!");
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    List<Trainer> trainers = dbview.ViewTrainers();
                                    Console.Clear();
                                    foreach (var Trainer in trainers)
                                    {
                                        Console.WriteLine(Trainer);
                                    }
                                    Console.WriteLine("Press any key to continue!");
                                    Console.ReadKey();
                                    break;
                                case 3:
                                    List<Course> courses = dbview.ViewCourses();
                                    Console.Clear();
                                    foreach (var Course in courses)
                                    {
                                        Console.WriteLine(Course);
                                    }
                                    Console.WriteLine("Press any key to continue!");
                                    Console.ReadKey();
                                    break;
                                case 4:
                                    List<Assignment> assignments = dbview.ViewAssignments();
                                    Console.Clear();
                                    foreach (var Assignment in assignments)
                                    {
                                        Console.WriteLine(Assignment);
                                    }
                                    Console.WriteLine("Press any key to continue!");
                                    Console.ReadKey();
                                    break;
                                case 5:
                                    List<Student_in_Course> studentscourses = dbview.ViewStudentsInCourses();
                                    Console.Clear();
                                    foreach (var Student_in_Course in studentscourses)
                                    {
                                        Console.WriteLine(Student_in_Course);
                                    }
                                    Console.WriteLine("Press any key to continue!");
                                    Console.ReadKey();
                                    break;
                                case 6:
                                    List<Trainer_in_Course> trainerscourses = dbview.ViewTrainersInCourses();
                                    Console.Clear();
                                    foreach (var Trainer_in_Course in trainerscourses)
                                    {
                                        Console.WriteLine(Trainer_in_Course);
                                    }
                                    Console.WriteLine("Press any key to continue!");
                                    Console.ReadKey();
                                    break;
                                case 7:
                                    List<Assignment> assignmentssc = dbview.ViewAssignmentsStudentsCourses();
                                    Console.Clear();
                                    foreach (var Assignment in assignmentssc)
                                    {
                                        Console.WriteLine(Assignment);
                                    }
                                    Console.WriteLine("Press any key to continue!");
                                    Console.ReadKey();

                                    break;
                                case 8:
                                    List<Student_in_Course> studentscoursesm = dbview.ViewStudentsInCourses(true);
                                    Console.Clear();
                                    foreach (var Student_In_Course in studentscoursesm)
                                    {
                                        Console.WriteLine(Student_In_Course);
                                    }
                                    Console.WriteLine("Press any key to continue!");
                                    Console.ReadKey();
                                    break;
                            }

                        } while (choice3 == 1 || choice3 == 2 || choice3 == 3 || choice3 == 4 || choice3 == 5 || choice3 == 6 || choice3 == 7 || choice3 == 8);
                        break;
                }
            } while (choice1 == 1 || choice1 == 2);

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Thank you for using the app!");
            Console.WriteLine("Press any key to close the window!");
            Console.ReadKey();
        }
    }
}
