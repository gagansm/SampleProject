using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class College
    {
        private string _name;
        private int _collegeId;
        public string Name
        {
            get { return _name;}
            set {_name = value;}
        }

        public int CollegeId {
            get { return _collegeId; }
            set { _collegeId = value; }
        }

        public College(int collegeId, string name)
        {
            _name = name;
            _collegeId = collegeId;
        }

        public List<Branch> Branches { get; set; }

        public List<Seat> Seats { get; set; }
    }

    static class CollegeManager
    {
        public static List<College> Colleges = new List<College>();

        public static void AddCollege(int id, string name)
        {
            
            Colleges.Add(new College(id, name));
        }

        public static void Add()
        {
            Console.WriteLine("Enter collegeId");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            Colleges.Add(new College(id, name));
        }

        public static List<College> GetColleges()
        {
            return Colleges;
        }

        public static College GetCollege(int collegeId)
        {
            return Colleges.Find(c => c.CollegeId == collegeId);
        }

        public static void DisplayColleges()
        {
            foreach (var item in Colleges)
            {
                Console.WriteLine($"College Id is {item.CollegeId} and name is {item.Name}");
            }
            
        }
    }
}
