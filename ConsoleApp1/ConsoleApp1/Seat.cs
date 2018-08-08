using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Seat
    {
        public int SeatId { get; set; }

        public int BranchId { get; set; }

        public int CollegeId { get; set; }

        public enum SeatStatus { Open, Closed }
    }

    static class SeatManager
    {
        public static void AddSeat(int BranchId, int CollegeId)
        {

        }

        public static int GetSeatsNumber(int BranchId, int CollegeId)
        {
            int seats = 0;
            return seats;
        }

        public static List<Seat> GetSeats (int BranchId, int CollegeId)
        {
            return new List<Seat>();
            
        }

        public static void UpdateSeat(int BranchId, int CollegeId)
        {

        }


    }
}
