using Team24_Final_Project.DAL;
using System;
using System.Linq;

namespace Team24_Final_Project.Utilities
{
    public static class GeneratePropertyNumber
    {
        public static Int32 GetNextPropertyNumber(AppDbContext _context)
        {
            //Set a number where the course numbers should start
            const Int32 START_NUMBER = 3000;

            Int32 intMaxPropertyNumber; //the current maximum course number
            Int32 intNextPropertyNumber; //the course number for the next class

            if (_context.Properties.Count() == 0) //there are no courses in the database yet
            {
                intMaxPropertyNumber = START_NUMBER; //course numbers start at 3001
            }
            else
            {
                intMaxPropertyNumber = _context.Properties.Max(c => c.PropertyNumber); //this is the highest number in the database right now
            }

            //You added courses before you realized that you needed this code
            //and now you have some course numbers less than 3000
            if (intMaxPropertyNumber < START_NUMBER)
            {
                intMaxPropertyNumber = START_NUMBER;
            }

            //add one to the current max to find the next one
            intNextPropertyNumber = intMaxPropertyNumber + 1;

            //return the value
            return intNextPropertyNumber;
        }

    }
}