﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] developers = new Employee[]
            {
                new Employee()
                {
                    Id = 1,
                    Name = "Zebby"
                },
                new Employee()
                {
                    Id = 2,
                    Name = "Kannu"
                }
            };

            List<Employee> sales = new List<Employee>()
            {
                new Employee()
                {
                    Id = 3,
                    Name = "Harry"
                }
            };

        }
    }
}
