using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Week5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n*****************************\n*      Fun                  *\n*            with           *\n*                  Methods! *\n*****************************\n\n");
            string menuChoice = "16";
            bool exit = false;
            while (exit != true)
            {
                Console.Clear();
                Console.WriteLine("\n\n*****************************\n*      Fun                  *\n*            with           *\n*                  Methods! *\n*****************************\n\n");
                menuChoice = Menu();

                switch (menuChoice)
                {
                    case "1":
                        //Username method ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
                        Console.Clear();
                        Console.WriteLine("\n\n****************User name Method****************\n\n");
                        Console.WriteLine("Gimme your info!");
                        Console.WriteLine("Name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Phone: ");
                        string fon = Console.ReadLine();

                        Console.WriteLine("\n\nUser info was saved.  \n\nUser Info: ");
                        string[] moreinfo = UserName(name, fon);
                        PrintArray(moreinfo);

                        Console.WriteLine("\n\n\n\n\n\n\n\n***********************************Hit any key to return to the menu.");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "2":

                        //ProperName thing ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
                        Console.Clear();
                        Console.WriteLine("\n\n****************Proper Name Method****************\n\n");
                        Console.WriteLine("Gimme a name to capitalize:\n");
                        Console.WriteLine("First Name: ");
                        string fn = Console.ReadLine();
                        Console.WriteLine("Last Name: ");
                        string ln = Console.ReadLine();
                        Console.WriteLine("\n\nProper Name: \n");
                        Console.WriteLine(ProperName(fn, ln));

                        Console.WriteLine("\n\n\n\n\n\n\n\n***********************************Hit any key to return to the menu.");
                        Console.ReadKey();

                        Console.Clear();
                        break;

                    case "3":

                        //Print Array method ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
                        Console.Clear();
                        Console.WriteLine("\n\n****************Print String Array Method****************\n\n");
                        string[] prtAr = { "Don't", "BLINK!", "", "Blink", "and", "you're", "dead!" };

                        PrintArray(prtAr);
                        Console.WriteLine("\n\n\n\n***********************************Hit any key to continue.");
                        Console.ReadKey();

                        int rep4 = 1;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("\n\n****************Print String Array Method****************\n\n");
                            Console.WriteLine("Print your own array!\n\n");
                            Console.WriteLine("Type a long thing. Use many words. Maybe a Doctor Who quote? \nType: \n");
                            string thing = Console.ReadLine();

                            string[] thingSplit = thing.Split(' ');
                            PrintArray(thingSplit);

                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("\n\nTest again? Type \"Y\" for yes, or hit ENTER to continue");
                            Console.ResetColor();
                            string again = Console.ReadLine();
                            if (again == "Y" || again == "y")
                            {
                                rep4 = 1;
                            }
                            else
                            {
                                rep4 = 0;
                                break;
                            }

                        } while (rep4 == 1);




                        Console.WriteLine("\n\n\n\n\n\n\n\n***********************************Hit any key to return to the menu.");
                        Console.ReadKey();

                        Console.Clear();
                        break;




                    case "4":
                        //Family Guy method^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
                        Console.WriteLine("\n\n****************Family Guy Method****************\n\n");
                        FamilyGuy();


                        Console.WriteLine("\n\n\n\n\n\n\n\n***********************************Hit any key to return to the menu.");
                        Console.ReadKey();

                        Console.Clear();
                        break;

                    case "5":
                        //Top Student method ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
                        Console.WriteLine("\n\n****************Top Student Method****************\n\n");

                        int[] Johnny = { 85, 99, 74 };
                        int[] Pearl = { 67, 96, 98 };
                        Console.WriteLine("Johnny's scores:");
                        PrintArrayInt(Johnny);
                        Console.WriteLine("Pearl's scores:");
                        PrintArrayInt(Pearl);

                        Console.WriteLine(TopStudent(Johnny, Pearl));

                        Console.WriteLine("\n\n\n\n***********************************Hit any key to continue.");
                        Console.ReadKey();

                        int repTS = 1;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("\n\n****************Top Student Method****************\n\n");

                            Console.WriteLine("Enter your own scores:\n");
                            Console.WriteLine("Please enter 3 scores for student A:");
                            int[] studentA = new int[3];
                            studentA[0] = int.Parse(Console.ReadLine());
                            studentA[1] = int.Parse(Console.ReadLine());
                            studentA[2] = int.Parse(Console.ReadLine());

                            Console.WriteLine("\nPlease enter 3 scores for student B:");
                            int[] studentB = new int[3];
                            studentB[0] = int.Parse(Console.ReadLine());
                            studentB[1] = int.Parse(Console.ReadLine());
                            studentB[2] = int.Parse(Console.ReadLine());

                            Console.WriteLine(TopStudent(studentA, studentB));


                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("\n\nTest again? Type \"Y\" for yes, or hit ENTER to continue");
                            Console.ResetColor();
                            string again = Console.ReadLine();
                            if (again == "Y" || again == "y")
                            {
                                repTS = 1;
                            }
                            else
                            {
                                repTS = 0;
                                break;
                            }
                        } while (repTS == 1);
                        Console.WriteLine("\n\n\n\n\n\n\n\n***********************************Hit any key to return to the menu.");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "6":

                        //Alpha splitter method ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
                        int repAS = 1;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("\n\n****************Alpha Splitter Method****************\n\n");

                            Console.WriteLine("TYPE ALL THE THINGS! So wow! Many words!\n\nType a sentence or list of words.  Maybe your favorite Doctor Who characters?");
                            string alSplit = Console.ReadLine();
                            AlphaSplitter(alSplit);


                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("\n\nTest again? Type \"Y\" for yes, or hit ENTER to continue");
                            Console.ResetColor();
                            string again = Console.ReadLine();
                            if (again == "Y" || again == "y")
                            {
                                repAS = 1;
                            }
                            else
                            {
                                repAS = 0;
                                break;
                            }
                        } while (repAS == 1);

                        Console.WriteLine("\n\n\n\n\n\n\n\n***********************************Hit any key to return to the menu.");
                        Console.ReadKey();
                        Console.Clear();
                        break;



                    case "7":
                        //Sobriety Test method ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
                        Console.WriteLine("\n\n****************Sobriety Test Method****************\n\n");

                        SobrietyTest();
                        Console.WriteLine("\n\nWell, that was easy.");


                        Console.WriteLine("\n\n\n\n\n\n\n\n***********************************Hit any key to return to the menu.");
                        Console.ReadKey();
                        Console.Clear();
                        break;


                    case "8":
                        //Lost My Teeth method ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
                        int repLT = 1;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("\n\n****************Lost My Teeth Method****************\n\n");

                            Console.WriteLine("4/5 dentists recommend daily brushing and flossing.");
                            Console.WriteLine("\nPlease enter a year in the future to discover how many teeth \nyou may lose to decay if you DON'T floss regularly.\n");

                            Console.WriteLine("Enter a year: \n");
                            int year = 2016;
                            bool pass = false;
                            while (!pass || year <= 2016)
                            {
                                pass = int.TryParse(Console.ReadLine(), out year);
                                if (!pass || year <= 2016)
                                {
                                    Console.Clear();
                                    Console.WriteLine("\n\n****************Lost My Teeth Method****************\n\n");

                                    Console.WriteLine("4/5 dentists recommend daily brushing and flossing.");
                                    Console.WriteLine("\nPlease enter a year in the future to discover how many teeth \nyou may lose to decay if you DON'T floss regularly.\n");
                                    Console.WriteLine("Please enter a valid year in the future.\a");
                                }
                            }

                            LostMyTeeth(year);

                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("\n\nTest again? Type \"Y\" for yes, or hit ENTER to continue");
                            Console.ResetColor();
                            string again = Console.ReadLine();
                            if (again == "Y" || again == "y")
                            {
                                repLT = 1;
                            }
                            else
                            {
                                repLT = 0;
                                break;
                            }
                        } while (repLT == 1);



                        Console.WriteLine("\n\n\n\n\n\n\n\n***********************************Hit any key to return to the menu.");
                        Console.ReadKey();
                        Console.Clear();

                        break;




                    case "9":

                        //Build a House method ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
                        int repBH = 1;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("\n\n****************Build a House Method****************\n\n");
                            Console.WriteLine("Gimme a number");
                            bool pass = false;
                            int n = 0;
                            while (!pass)
                            {
                                pass = int.TryParse(Console.ReadLine(), out n);
                                if (!pass)
                                {
                                    Console.Clear();
                                    Console.WriteLine("\n\n****************Build a House Method****************\n\n");
                                    Console.WriteLine("Gimme a number");
                                    Console.WriteLine("Please enter a valid number.");
                                }
                            }




                            BuildAHouse(n);

                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("\n\nTest again? Type \"Y\" for yes, or hit ENTER to continue");
                            Console.ResetColor();
                            string again = Console.ReadLine();
                            if (again == "Y" || again == "y")
                            {
                                repBH = 1;
                            }
                            else
                            {
                                repBH = 0;
                                break;
                            }
                        } while (repBH == 1);



                        Console.WriteLine("\n\n\n\n\n\n\n\n***********************************Hit any key to return to the menu.");
                        Console.ReadKey();
                        Console.Clear();
                        break;



                    case "10":
                        //Timer Method^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
                        int repTM = 1;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("\n\n****************Timer Method****************\n\n");
                            Console.WriteLine("Gimme some days, hours, minutes, seconds. Hit enter after each.");
                            int w = int.Parse(Console.ReadLine());
                            int x = int.Parse(Console.ReadLine());
                            int y = int.Parse(Console.ReadLine());
                            int z = int.Parse(Console.ReadLine());
                            CountDownTimer(w, x, y, z);

                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("\n\nTest again? Type \"Y\" for yes, or hit ENTER to continue");
                            Console.ResetColor();
                            string again = Console.ReadLine();
                            if (again == "Y" || again == "y")
                            {
                                repTM = 1;
                            }
                            else
                            {
                                repTM = 0;
                                break;
                            }
                        } while (repTM == 1);


                        Console.WriteLine("\n\n\n\n\n\n\n\n***********************************Hit any key to return to the menu.");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "11":
                        //Name Age State Method^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
                        int repNAS = 1;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("\n\n****************Name Age State Method****************\n\n");

                            Console.WriteLine("\nWhat is your first name?\n");
                            string nam = Console.ReadLine();
                            Console.WriteLine("\nWhat is your age?\n");
                            string age = Console.ReadLine();
                            Console.WriteLine("\nIn what state do you live?\n");
                            string sta = Console.ReadLine();

                            NameAgeState(nam, age, sta);

                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("\n\nTest again? Type \"Y\" for yes, or hit ENTER to continue");
                            Console.ResetColor();
                            string again = Console.ReadLine();
                            if (again == "Y" || again == "y")
                            {
                                repNAS = 1;
                            }
                            else
                            {
                                repNAS = 0;
                                break;
                            }
                        } while (repNAS == 1);


                        Console.WriteLine("\n\n\n\n\n\n\n\n***********************************Hit any key to return to the menu.");
                        Console.ReadKey();
                        Console.Clear();

                        break;

                    case "12":

                        //Valid Name Method^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
                        int repVN = 1;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("\n\n****************Valid Name Method****************\n\n");

                            Console.WriteLine("Gimme a name to validate:");
                            Console.WriteLine("First Name: ");
                            string firstName = Console.ReadLine();
                            Console.WriteLine("Last Name: ");
                            string lastName = Console.ReadLine();
                            Console.WriteLine("\n\nProper Name: ");
                            ValidName(firstName, lastName);


                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("\n\nTest again? Type \"Y\" for yes, or hit ENTER to continue");
                            Console.ResetColor();
                            string again = Console.ReadLine();
                            if (again == "Y" || again == "y")
                            {
                                repVN = 1;
                            }
                            else
                            {
                                repVN = 0;
                                break;
                            }
                        } while (repVN == 1);


                        Console.WriteLine("\n\n\n\n\n\n\n\n***********************************Hit any key to return to the menu.");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "13":

                        //Circle Area Method^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
                        int repCA = 1;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("\n\n****************Circle Area Method****************\n\n");

                            Console.WriteLine("What is the radius of your circle?");

                            bool pass = false;
                            double radius = 0;
                            while (!pass)
                            {
                                pass = double.TryParse(Console.ReadLine(), out radius);
                                if (!pass)
                                {
                                    Console.WriteLine("Please enter a valid number.");
                                }
                            }

                            Console.WriteLine(CircleArea(radius));

                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("\n\nTest again? Type \"Y\" for yes, or hit ENTER to continue");
                            Console.ResetColor();
                            string again = Console.ReadLine();
                            if (again == "Y" || again == "y")
                            {
                                repTM = 1;
                            }
                            else
                            {
                                repTM = 0;
                                break;
                            }
                        } while (repTM == 1);


                        Console.WriteLine("\n\n\n\n\n\n\n\n***********************************Hit any key to return to the menu.");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "14":
                        //Number Check Method^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
                        int repNC = 1;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("\n\n****************Number Check Method****************\n\n");
                            Console.WriteLine("Gimme a number to test:\n");
                            string numTest = Console.ReadLine();
                            NumberCheck(numTest);

                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("\n\nTest again? Type \"Y\" for yes, or hit ENTER to continue");
                            Console.ResetColor();
                            string again = Console.ReadLine();
                            if (again == "Y" || again == "y")
                            {
                                repNC = 1;
                            }
                            else
                            {
                                repNC = 0;
                                break;
                            }
                        } while (repNC == 1);

                        Console.WriteLine("\n\n\n\n\n\n\n\n***********************************Hit any key to return to the menu.");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "15":
                        exit = true;
                        break;

                    default:
                        break;


                }
            }
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\n\n****************Goodbye!****************");
            System.Threading.Thread.Sleep(1000);
            return;


        }


        //Menu Method ************
        static string Menu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Choose a Method: ");
            Console.ResetColor();
            string[] menu = {"1. Username", "2. Proper Name", "3. Print Array", "4. Family Guy", "5. Top Student", "6. Alpha Splitter",
                    "7. Sobriety Test", "8. Lost My Teeth", "9. Build House", "10. Countdown Timer", "11. Name Age State", "12. Valid Name",
                    "13. Circle Area", "14. Number Check", "15. Exit" };

            PrintArray(menu);

            string menuChoice = Console.ReadLine();
            return menuChoice;
        }




        //Store user name method *********************************************************************
        static string[] UserName(string name, string fon)
        {
            string[] info = { name, fon };
            return info;

        }


        // Proper name method *********************************************************************
        static string ProperName(string firstName, string lastName)
        {
            string fNameEnd = firstName.Substring(1, firstName.Length - 1);
            string lNameEnd = lastName.Substring(1, lastName.Length - 1);
            string fn = Convert.ToString(firstName[0]);
            string ln = Convert.ToString(lastName[0]);

            string properName = fn.ToUpper() + fNameEnd.ToLower() + " " + ln.ToUpper() + lNameEnd.ToLower();
            return properName;
        }


        // Print Arry method *********************************************************************
        static void PrintArray(string[] x)
        {
            for (int k = 0; k <= x.Length - 1; k++)
            {
                Console.WriteLine(x[k]);
            }

        }
        static void PrintArrayInt(int[] x)
        {
            for (int k = 0; k <= x.Length - 1; k++)
            {
                Console.WriteLine(x[k]);
            }

        }

        //Family guy method *********************************************************************
        static void FamilyGuy()
        {
            string[] fg = { "Peter Griffin", "Lois", "Meg", "Chris", "Stewie", "Brian", "Giggity Dude", "Pedo Guy", "American Dad Guy", "Chicken Guy that fights with Peter" };
            for (int k = 0; k <= fg.Length - 1; k++)
            {
                Console.WriteLine(fg[k]);
            }
        }


        //Top student method *********************************************************************
        static string TopStudent(int[] x, int[] y)
        {
            int s1 = ((x[0] + x[1] + x[2]) / 3);
            int s2 = ((y[0] + y[1] + y[2]) / 3);
            string topstudent;
            if (s1 > s2)
            {
                topstudent = ("The first student was the Top Student, with an average of " + s1);
            }
            else
            {
                topstudent = ("The second student was the Top Student, with an average of " + s2);
            }

            return topstudent;
        }


        // Alpha Split method *********************************************************************
        static void AlphaSplitter(string x)
        {
            string[] split = x.Split(' ');
            Array.Sort(split);

            for (int i = 0; i < split.Length; i++)
            {
                Console.WriteLine(split[i]);
            }
        }



        // Sobriety Test method *********************************************************************
        static void SobrietyTest()
        {
            string[] abc = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            for (int i = 25; i >= 0; i--)
            {
                Console.Write(abc[i]+" ");
            }
        }



        // Name Age State to Sentence method *********************************************************************
        static void NameAgeState(string name, string age, string state)
        {
            Console.WriteLine(name + " is " + age + " years old and lives in " + state);
        }



        // Circle Area Method *********************************************************************
        static double CircleArea(double radius)
        {
            double area = radius * radius * 3.1415926535;
            return area;
        }



        //Lost Teeth Method  *********************************************************************
        static void LostMyTeeth(int year)
        {
            //Rate of loss: .34 teeth per year according to google search and linear regression on excel;
            double lost = ((year - 2016) * .34);
            Console.WriteLine("You will have lost " + lost + " teeth.\n\nDon't forget to floss.");
        }

        //Build House Method *********************************************************************
        static void BuildAHouse(int n)
        {
            //Make a list of odd numbers ...because reasons.
            List<int> odd = new List<int>();
            for (int i = 1; i < 99; i += 2)
            {
                odd.Add(i);
            }
            //Write preliminary star at top n spaces from the edge
            Console.WriteLine(Repeat(' ', n) + "*");
            //Declare a throwaway int to avoid decrementing n itself
            int a = n;
            //Decrement number of spaces before sloping roof star; Write odd[i] spaces; Write another star; repeat n times;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Repeat(' ', (a - 1)) + "*" + Repeat(' ', odd[i]) + "*");
                a--;
            }
            //Write a line odd[n] stars long
            Console.WriteLine(Repeat('*', odd[n]));
            //Write a star; write odd[n-1] spaces; write another star
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("*" + Repeat(' ', odd[n - 1]) + "*");
            }
            Console.WriteLine(Repeat('*', odd[n]));
        }

        //Repeat method to use in BuildAHouse method
        //Nothing to see here, move along
        static string Repeat(char x, int y)
        {
            string rep = new string(x, y);
            return rep;
        }



        //Timer Method....hopefully *********************************************************************
        static void CountDownTimer(int days, int hrs, int mins, int sec)
        {
            sec = sec + mins * 60 + hrs * 3600 + days * 86400;
            int secs;
            for (int i = sec; i >= 0; i--)
            {
                days = i / 86400;   //bloody heck: total sec/ sec in a day = days
                hrs = (i % 86400) / 3600; // get remainder seconds (i % 86400) / 3600 = hours
                mins = (i - (days * 86400) - hrs * 3600) / 60;
                secs = (i - (days * 86400) - (hrs * 3600) - (mins * 60));
                Console.Clear();
                Console.WriteLine(days + ":" + hrs + ":" + mins + ":" + secs);
 
                System.Threading.Thread.Sleep(1000);

            }
        }


        //NumberCheck method  *********************************************************************
        static void NumberCheck(string x)
        {
            int y;
            bool test = int.TryParse(x, out y);
            if (!test)
            {
                Console.WriteLine("Not a valid number");
            }
            else
            {
                Console.WriteLine(y + " is a valid number.");
            }
        }


        //Valid Name method  *********************************************************************
        static void ValidName(string fn, string ln)
        {
            string regMatch = @"^[A-Z]?[a-z]+$";
            Regex ver = new Regex(regMatch, RegexOptions.IgnoreCase);
            Match mFn = ver.Match(fn);
            bool verifyFn = mFn.Success;
            Match mLn = ver.Match(ln);
            bool verifyLn = mLn.Success;
            
            if (verifyFn && verifyLn)
            {
                Console.WriteLine(ProperName(fn, ln) + " is a valid name.");
            }
            else
            {
                Console.WriteLine(fn + " " + ln + " is not a valid name.");
            }
        }

    }
}
