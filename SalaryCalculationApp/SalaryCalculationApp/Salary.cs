using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculationApp
{
    class Salary
    {
        public string name;
        public double basicamount;
        public double houserent;
        public double medical;


        public double GetHouserent()
        {
            return (basicamount * houserent) / 100;
        }
        public double GetMedical()
        {
            return (basicamount * medical) / 100;
        }
        public double GetTotal()
        {
            double total= basicamount + GetHouserent() + GetMedical();
            return total;
        }


        //private double GetHouserent()
        //{
        //    return (basicamount * houserent) / 100;
        //}

        //private object GetMedical()
        //{
        //    return (basicamount * medical) / 100;
        //}
        

    }
}
