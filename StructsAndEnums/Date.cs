using System;
using System.Net.NetworkInformation;

namespace StructsAndEnums
{
    //method advances the date in the structure by one month
    //after Dec., code will resets the month to January and
    //advances the value of the year field by 1
    struct Date
    {
        private int year;
        private Month month;
        private int day;

        //public constructor that takes three parameters (int for year, enum month, int for day)
        public Date(int ccyy, Month mm, int dd)
        {
            this.year = ccyy - 1900;
            this.month = mm;
            this.day = dd - 1;
        }

        public override string ToString()
        {
            string data = $"{this.month} {this.day + 1} {this.year + 1900}";
            return data;
        }

       public void AdvanceMonth()
        {
            this.month++;
            if (this.month == Month.December + 1)
            {
                this.month = Month.January;
                this.year++;
            }
        }
    }
}
