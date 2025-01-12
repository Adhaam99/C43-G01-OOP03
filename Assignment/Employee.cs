using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.Enums;

namespace Assignment
{
    class Employee
    {
        #region Attributes

        #region Q1
        //private int id;
        //private string? name;
        //private SecurityPrivileges securityLevel;
        //private decimal salary;
        //private HiringDate hireDate;
        //private Gender gender; 
        #endregion

        #region Q3

        private int[]? id;
        private string[]? name;
        private SecurityPrivileges[] securityLevel;
        private decimal[] salary;
        private HiringDate[] hireDate;
        private Gender[] gender;
        private int size;

        #endregion

        #endregion

        #region Properties

        #region Q1
        //public int Id { get => id; set => id = value; }
        //public string? Name { get => name; set => name = value; }
        //public decimal Salary { get => salary; set => salary = value; }
        //public HiringDate HireDate { get => hireDate; set => hireDate = value; }
        //internal SecurityPrivileges SecurityLevel { get => securityLevel; set => securityLevel = value; }
        //internal Gender Gender { get => gender; set => gender = value; } 
        #endregion

        #endregion

        #region Constructors

        #region Q1

        //public Employee(int id, string? name, decimal salary, int day, int month, int year, SecurityPrivileges securityLevel, Gender gender)
        //{
        //    Id = id;
        //    Name = name;
        //    Salary = salary;
        //    HireDate = new HiringDate(day, month, year);
        //    SecurityLevel = securityLevel;
        //    Gender = gender;
        //} 

        #endregion

        #region Q3

        public Employee(int _size)
        {
            size = _size;
            id = new int[size];
            name = new string[size];
            securityLevel = new SecurityPrivileges[size];
            salary = new decimal[size];
            gender = new Gender[size];
            hireDate = new HiringDate[size];
        }

        #endregion

        #endregion

        #region Methods

        #region Q1
        //public override string ToString()
        //{
        //    return String.Format("Employee Salary is {0:c}", Salary);
        //} 
        #endregion

        #region Q4

        //public string[] sortEmpBasedOnHD()
        //{

        //    string[] result = new string[size];

        //    if (hireDate != null)
        //    {
        //        int count = 0;

        //        HiringDate oldHiringDate = hireDate[0];
        //        string firstEmp = name[0];
        //        for (int i = 1; i< size; i++)
        //        {
        //            if ( oldHiringDate.Year > hireDate[i].Year)
        //            {
        //                oldHiringDate = hireDate[i];
        //                firstEmp = name[i];
        //                result[i - 1] = firstEmp;
        //                count++;
        //            }
        //            else
        //            {
        //                result[ i - 1 ] = firstEmp;
        //            }
        //        }
                


        //    }

        //    return result;


        //}

        #endregion


        #region Q3

        public void addEmployee(int position , int _id, string _name , SecurityPrivileges SL, decimal _salary , Gender _gender, int year , int month , int day)
        {

            //Setter

            if ( id is not null && name is not null && securityLevel is not null && salary is not null && gender is not null && hireDate is not null)
                if ( position >=0 && position < size)
                {
                    id[position] = _id;
                    name[position] = _name;
                    securityLevel[position] = SL;   
                    salary[position] = _salary;
                    gender[position] = _gender;
                    hireDate[position] = new HiringDate(year , month , day);
                }

        }

        #endregion

        #endregion

        #region Getter Setter

        public string this[int position]
        {
            get
            {
                if( id is not null && name is not null)
                for (int i = 0; i < size; i++)
                {

                    if (id[i] == position)
                    {
                        return $"Employee name is {name[i]}, salary is {salary[i]}, Security level {securityLevel[i]}  hiring date ({hireDate[i]})";
                    }
                }
                return "";
            }


        }
        #endregion
    }
}
