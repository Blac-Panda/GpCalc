using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    WRITTEN BY: OYEFESO OLUWATUNMISE (BLAC_PANDA)
    DATE: JANUARY 2017
*/
namespace ssg313
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentInfo1 s = new StudentInfo1();
            s.showOptions();
        }

        class StudentInfo1
        {
            public void showOptions()
            {
                Console.WriteLine("\n\nEnter the number to grade student.\n\n1. John Doe\n2. Mary Doe\n3. Alias Tansadef\n4. Derek White\n5. Barack Obama\n6. EXIT");
                int result = Int32.Parse(Console.ReadLine());
                switch (result)
                {
                    case 1:
                        option1();
                        break;
                    case 2:
                        option2();
                        break;
                    case 3:
                        option3();
                        break;
                    case 4:
                        option4();
                        break;
                    case 5:
                        option5();
                        break;
                    case 6:
                        Console.Beep();
                        break;
                }
            }
            public void option1()
            { 
            Console.WriteLine(Details1());
            courses1();
            setCourseScores();
                showOptions();
            }
            public void option2()
            {
                Console.WriteLine(Details2());
                courses1();
                setCourseScores();
                showOptions();
            }
            public void option3()
            {
                Console.WriteLine(Details3());
                courses1();
                setCourseScores();
                showOptions();
            }
            public void option4()
            {
                Console.WriteLine(Details4());
                courses1();
                setCourseScores();
                showOptions();
            }
            public void option5()
            {
                Console.WriteLine(Details5());
                courses1();
                setCourseScores();
                showOptions();
            }
            string name1;
            string name2;
            string name3;
            string name4;
            string name5;
            // setting scores for student 1
            double[] ssg = { 70, 70, 70, 70, 70, 70 };
            string[] grd = { "A", "A", "A", "A", "A", "A" };
            int[] units = { 2, 3, 2, 3, 4, 2 };
            string[] courses = { "ssg301", "ssg302", "ssg303", "ssg304", "ssg305", "ssg306" };

            public string Details1()
            {
                name1 = "STUDENT NAME ----->  JOHN DOE";
                return name1;
            }
            public string Details2()
            {
                name1 = "STUDENT NAME -----> MARY DOE";
                return name1;
            }
            public string Details3()
            {
                name1 = "STUDENT NAME -----> ALIAST TRANSDENT";
                return name1;
            }
            public string Details4()
            {
                name1 = "STUDENT NAME -----> DEREK WHITE";
                return name1;
            }
            public string Details5()
            {
                name1 = "STUDENT NAME -----> BABARCK OBAMA";
                return name1;
            }

            public void courses1()
            {
                Console.WriteLine("\n---------------\nCOURSE LIST\n---------------\n");
                int i;
                for (i = 0; i < 6; i++)
                {
                    Console.Write("{0}\n", courses[i]);
                }

            }
            public void setCourseScores()
            {
                for(int i=0; i< ssg.Length; i++)
                {
                    while(true)
                    {
                        Console.WriteLine("Enter Score for {0}:", courses[i]);
                        double score = Double.Parse(Console.ReadLine());
                        if(score > 0 && score < 101)
                        {
                            ssg[i] = score;
                            grd[i] = courseGradeLetter(score);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid score entered. Try Again");
                            continue;
                        }
                    }
                }
                showGPA();
            }

            public void showGPA()
            {
                Console.WriteLine("\n");
                for(int i = 0; i < ssg.Length; i++)
                {
                    Console.WriteLine("COURSE - {0} || SCORE - {1} || GRADE - {2} || UNITS - {3}",courses[i], ssg[i], grd[i], units[i]);
                    
                }
                Console.WriteLine("\nStudent GPA is {0:0.00}", calculateGPA());
            }
            
            public double calculateGPA()
            {
                double gradeCount = 0, unitsCount = 0;
                for (int i = 0; i < ssg.Length; i++)
                {
                    int currentGrade = courseGrade(ssg[i]);
                    int currentUnit = units[i];
                    gradeCount = gradeCount + (currentGrade * currentUnit);
                }
                for (int i = 0; i < units.Length; i++)
                {
                    unitsCount = unitsCount + units[i];
                }
                return gradeCount / unitsCount;
            }
            public int courseGrade(double score)
            {
                if (score >= 70)
                {
                    return 5;
                }
                else if (score >= 60 && score < 70)
                {
                    return 4;
                }
                else if (score >= 50 && score < 60)
                {
                    return 3;
                }
                else if (score >= 45 && score < 50)
                {
                    return 2;
                }
                else if (score >= 40 && score < 45)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            public string courseGradeLetter(double score)
            {
                if (score >= 70)
                {
                    return "A";
                }
                else if (score >= 60 && score < 70)
                {
                    return "B";
                }
                else if (score >= 50 && score < 60)
                {
                    return "C";
                }
                else if (score >= 45 && score < 50)
                {
                    return "D";
                }
                else if (score >= 40 && score < 45)
                {
                    return "E";
                }
                else
                {
                    return "F";
                }
            }

        }
    }
}