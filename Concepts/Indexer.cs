using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPureCSharpConcept.Concepts
{
    public class Indexer
    {
        /*
        Indexer
        Creating the relationship between two or more classes
        Allows an object to be indexed such as an array
        Instance of this class can be accessed by using the array access operator
        Use get and set accessors for defining an indexer
        Index can only be defined by this keyword
        "This" keyword represent the current instance

        */
    }
    class Employee
    {
        public int Id { get; set; }
        public string EmpName { get; set; }
        public double Salary { get; set; }
    }
    class Department
    {
        public int DeptId { get; set; }
        public string DepartmentName { get; set; }
        public Employee[] EmpList;

        public Department()
        {
            DeptId = 10;
            DepartmentName = "Sales";
            EmpList =
            [
                new() { Id = 101, EmpName = "Opeyemi", Salary = 3000 },
                new() { Id = 102, EmpName = "Mathew", Salary = 2500},
                new() { Id = 103, EmpName = "Adewunmi", Salary = 4500 },
            ];
        }
        //public Employee GetEmployee(int id) 
        //{
        //    foreach (Employee emp in EmpList)
        //    {
        //        if (id == emp.Id)
        //            return emp;
        //    }
        //    return null;
        //}
        //public Employee GetEmployee(string name)
        //{
        //    foreach (Employee emp in EmpList)
        //    {
        //        if (name == emp.EmpName)
        //            return emp;
        //    }
        //    return null;
        //}
        public Employee this[int id]
        {
            get
            {
                foreach (Employee emp in EmpList)
                {
                    if (id == emp.Id)
                        return emp;
                }
                return null;
            }
        }
        public Employee this[string name]
        {
            get
            {
                foreach (Employee emp in EmpList)
                {
                    if (name == emp.EmpName)
                        return emp;
                }
                return null;
            }
        }
    }
}
