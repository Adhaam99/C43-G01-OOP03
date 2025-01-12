using Assignment.Enums;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part01

            #region Q1 - Design and implement a Class for the employees in a company:

            //Employee emp01 = new Employee(1 , "Adham" , 1000M, 10 , 2 , 2020 , (SecurityPrivileges)2, (Gender)1);

            //Console.WriteLine(emp01);


            #endregion

            #region Q3

            //Employee EmpArr = new Employee(3);

            //EmpArr.addEmployee(0, 10, "Adham", (SecurityPrivileges)8, 3000M, (Gender)1, 10, 8, 2020);
            //EmpArr.addEmployee(1, 20, "Omar", (SecurityPrivileges)1, 1500M, (Gender)1, 20, 6, 2021);
            //EmpArr.addEmployee(2, 30, "Nada", (SecurityPrivileges)15, 10000M, (Gender)2, 15, 6, 2019);

            //Console.WriteLine(EmpArr[10]);

            //string[] arr = EmpArr.sortEmpBasedOnHD();

            //foreach (string str in arr) { Console.WriteLine(str); }  

            #endregion



            #endregion

            #region Q5 - Design a program for a library management system where:

            EBook EB = new EBook("C++", "Adham Yehia", 123, 4096);

            Console.WriteLine(EB);

            Console.WriteLine("===========================================");

            PrintedBook PB = new PrintedBook("Java", "Khaled Ahmed", 456, 1024);

            Console.WriteLine(PB);

            /*
             * 
             * I didn't have to re intialize the same attributes in the child classes , constructors and Functions .
             * 
             * 
             */

            #endregion

        }
    }
}
