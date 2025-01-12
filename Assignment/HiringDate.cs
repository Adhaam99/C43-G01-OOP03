using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class HiringDate
    {
        #region Attributes

        private int day;
        private int month;
        private int year;

        #endregion

        #region Propreties
        public int Day { get => day; set => day = value; }
        public int Month { get => month; set => month = value; }
        public int Year { get => year; set => year = value; } 

        #endregion

        #region Constructors
        public HiringDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            DateOnly dateOnly = new DateOnly( year , month , day);
            return dateOnly.ToString();
        }
        #endregion
    }
}
