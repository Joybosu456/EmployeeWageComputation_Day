﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class EmployeeCheck
    {
        ///<summary>
        /// UC1- the employee present or not.
        ///</summary>
        public static void EmployeePresentOrNot()
        {
            Random random = new Random();
            int number=random.Next(2);

            if(number == 1)
            {
                Console.WriteLine("Employee is Present :");
            }
            else
            {
                Console.WriteLine("Employee is not present :");
            }
            
        }
    }
}