using System;

 

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            CollegeManager.DisplayColleges();
            CollegeManager.AddCollege(1, "Global institute");
            CollegeManager.DisplayColleges();
            CollegeManager.Add();
            CollegeManager.DisplayColleges();



            Console.ReadKey();
        }
    }
}
