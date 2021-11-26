using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ_Joining_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define variables
            string sLastStarter = string.Empty;

            //Prompt the user for a search value
            Console.WriteLine("Please enter any part of the last name to filter and press [Enter]");

            //Read the search value
            sLastStarter = Console.ReadLine();

            //Use LINQ to query the names
            var result = from emp in GetEmployees()
                         join sal in GetEmployeeSalaries() on emp.EmployeeID equals sal.EmployeeID 
                         where (emp.LastName.Contains(sLastStarter))
                         orderby sal.Salary descending
                         select string.Format("{0}, {1}. makes {2:C0} per year", emp.LastName, emp.FirstName.Substring(0, 1), sal.Salary);

            //Cycle through the results
            foreach (string emp in result)
            {
                //Display the Employee name
                Console.WriteLine(emp);
            }

            //Wait for a response from the user
            Console.ReadLine();
        }

        /// <summary>
        /// Simple method that adds a bunch of bogus salaries to the Employee Salary list
        /// </summary>
        /// <returns></returns>
        static List<EmployeeSalary> GetEmployeeSalaries()
        {
            //Define variables
            List<EmployeeSalary> lSalaryReturn = new List<EmployeeSalary>();

            //Add the Salary
            lSalaryReturn.Add(new EmployeeSalary(29573, 1));
            lSalaryReturn.Add(new EmployeeSalary(1000254, 99));
            lSalaryReturn.Add(new EmployeeSalary(45628, 2));
            lSalaryReturn.Add(new EmployeeSalary(53381, 3));
            lSalaryReturn.Add(new EmployeeSalary(34256, 4));
            lSalaryReturn.Add(new EmployeeSalary(49749, 5));
            lSalaryReturn.Add(new EmployeeSalary(49364, 6));
            lSalaryReturn.Add(new EmployeeSalary(50419, 7));
            lSalaryReturn.Add(new EmployeeSalary(43298, 8));
            lSalaryReturn.Add(new EmployeeSalary(54579, 9));
            lSalaryReturn.Add(new EmployeeSalary(25173, 10));
            lSalaryReturn.Add(new EmployeeSalary(29116, 11));
            lSalaryReturn.Add(new EmployeeSalary(36819, 12));
            lSalaryReturn.Add(new EmployeeSalary(31706, 13));
            lSalaryReturn.Add(new EmployeeSalary(50648, 14));
            lSalaryReturn.Add(new EmployeeSalary(44571, 15));
            lSalaryReturn.Add(new EmployeeSalary(28364, 16));
            lSalaryReturn.Add(new EmployeeSalary(53746, 17));
            lSalaryReturn.Add(new EmployeeSalary(37764, 18));
            lSalaryReturn.Add(new EmployeeSalary(54191, 19));
            lSalaryReturn.Add(new EmployeeSalary(34114, 20));
            lSalaryReturn.Add(new EmployeeSalary(37643, 21));
            lSalaryReturn.Add(new EmployeeSalary(29768, 22));
            lSalaryReturn.Add(new EmployeeSalary(55488, 23));
            lSalaryReturn.Add(new EmployeeSalary(38897, 24));
            lSalaryReturn.Add(new EmployeeSalary(50746, 25));
            lSalaryReturn.Add(new EmployeeSalary(46894, 26));
            lSalaryReturn.Add(new EmployeeSalary(42321, 27));
            lSalaryReturn.Add(new EmployeeSalary(31222, 28));
            lSalaryReturn.Add(new EmployeeSalary(24264, 29));
            lSalaryReturn.Add(new EmployeeSalary(47991, 30));
            lSalaryReturn.Add(new EmployeeSalary(33864, 31));
            lSalaryReturn.Add(new EmployeeSalary(44344, 32));
            lSalaryReturn.Add(new EmployeeSalary(44561, 33));
            lSalaryReturn.Add(new EmployeeSalary(40775, 34));
            lSalaryReturn.Add(new EmployeeSalary(27194, 35));
            lSalaryReturn.Add(new EmployeeSalary(36936, 36));
            lSalaryReturn.Add(new EmployeeSalary(42859, 37));
            lSalaryReturn.Add(new EmployeeSalary(48742, 38));
            lSalaryReturn.Add(new EmployeeSalary(23375, 39));
            lSalaryReturn.Add(new EmployeeSalary(40753, 40));
            lSalaryReturn.Add(new EmployeeSalary(24684, 41));
            lSalaryReturn.Add(new EmployeeSalary(38065, 42));
            lSalaryReturn.Add(new EmployeeSalary(34666, 43));
            lSalaryReturn.Add(new EmployeeSalary(40383, 44));
            lSalaryReturn.Add(new EmployeeSalary(27212, 45));
            lSalaryReturn.Add(new EmployeeSalary(35405, 46));
            lSalaryReturn.Add(new EmployeeSalary(47967, 47));
            lSalaryReturn.Add(new EmployeeSalary(30405, 48));
            lSalaryReturn.Add(new EmployeeSalary(27059, 49));
            lSalaryReturn.Add(new EmployeeSalary(27965, 50));
            lSalaryReturn.Add(new EmployeeSalary(38068, 51));
            lSalaryReturn.Add(new EmployeeSalary(32460, 52));
            lSalaryReturn.Add(new EmployeeSalary(52088, 53));
            lSalaryReturn.Add(new EmployeeSalary(34693, 54));
            lSalaryReturn.Add(new EmployeeSalary(26852, 55));
            lSalaryReturn.Add(new EmployeeSalary(22838, 56));
            lSalaryReturn.Add(new EmployeeSalary(54269, 57));
            lSalaryReturn.Add(new EmployeeSalary(33122, 58));
            lSalaryReturn.Add(new EmployeeSalary(35810, 59));
            lSalaryReturn.Add(new EmployeeSalary(36420, 60));
            lSalaryReturn.Add(new EmployeeSalary(35699, 61));
            lSalaryReturn.Add(new EmployeeSalary(45405, 62));
            lSalaryReturn.Add(new EmployeeSalary(47825, 63));
            lSalaryReturn.Add(new EmployeeSalary(40040, 64));
            lSalaryReturn.Add(new EmployeeSalary(26350, 65));
            lSalaryReturn.Add(new EmployeeSalary(34623, 66));
            lSalaryReturn.Add(new EmployeeSalary(54655, 67));
            lSalaryReturn.Add(new EmployeeSalary(36173, 68));
            lSalaryReturn.Add(new EmployeeSalary(52794, 69));
            lSalaryReturn.Add(new EmployeeSalary(44035, 70));
            lSalaryReturn.Add(new EmployeeSalary(52204, 71));
            lSalaryReturn.Add(new EmployeeSalary(48521, 72));
            lSalaryReturn.Add(new EmployeeSalary(35037, 73));
            lSalaryReturn.Add(new EmployeeSalary(22666, 74));
            lSalaryReturn.Add(new EmployeeSalary(45436, 75));
            lSalaryReturn.Add(new EmployeeSalary(24226, 76));

            //Return the result
            return lSalaryReturn;
        }

        /// <summary>
        /// Simple method that adds a bunch of random names to the Employee List
        /// </summary>
        /// <returns></returns>
        static List<Employee> GetEmployees()
        {
            //Define variables
            List<Employee> lReturnMe = new List<Employee>();

            //Add the employee
            lReturnMe.Add(new Employee("Timothy", "Miles", 99));
            lReturnMe.Add(new Employee("Kristina", "Chung", 1));
            lReturnMe.Add(new Employee("Paige", "Chen", 2));
            lReturnMe.Add(new Employee("Sherri", "Melton", 3));
            lReturnMe.Add(new Employee("Jerome", "Wallace", 16));
            lReturnMe.Add(new Employee("Neal", "Lawrence", 17));
            lReturnMe.Add(new Employee("Gretchen", "Hill", 4));
            lReturnMe.Add(new Employee("Karen", "Puckett", 5));
            lReturnMe.Add(new Employee("Patrick", "Song", 6));
            lReturnMe.Add(new Employee("Elsie", "Hamilton", 7));
            lReturnMe.Add(new Employee("Hazel", "Bender", 8));
            lReturnMe.Add(new Employee("Malcolm", "Wagner", 9));
            lReturnMe.Add(new Employee("Dolores", "McLaughlin", 10));
            lReturnMe.Add(new Employee("Francis", "McNamara", 11));
            lReturnMe.Add(new Employee("Sandy", "Raynor", 12));
            lReturnMe.Add(new Employee("Marion", "Moon", 13));
            lReturnMe.Add(new Employee("Wesley", "Teague", 23));
            lReturnMe.Add(new Employee("Franklin", "Vick", 24));
            lReturnMe.Add(new Employee("Claire", "Gallagher", 25));
            lReturnMe.Add(new Employee("Marian", "Solomon", 26));
            lReturnMe.Add(new Employee("Marcia", "Walsh", 27));
            lReturnMe.Add(new Employee("Dwight", "Monroe", 28));
            lReturnMe.Add(new Employee("Beth", "Woodard", 14));
            lReturnMe.Add(new Employee("Julia", "Desai", 15));
            lReturnMe.Add(new Employee("Jean", "Griffin", 18));
            lReturnMe.Add(new Employee("Kristine", "Dougherty", 19));
            lReturnMe.Add(new Employee("Crystal", "Powers", 20));
            lReturnMe.Add(new Employee("Alex", "May", 21));
            lReturnMe.Add(new Employee("Eric", "Steele", 22));
            lReturnMe.Add(new Employee("Wayne", "Connolly", 29));
            lReturnMe.Add(new Employee("Stephanie", "Hawkins", 30));
            lReturnMe.Add(new Employee("Neal", "Middleton", 31));
            lReturnMe.Add(new Employee("Gretchen", "Goldstein", 32));
            lReturnMe.Add(new Employee("Tim", "Watts", 33));
            lReturnMe.Add(new Employee("Jerome", "Johnston", 34));
            lReturnMe.Add(new Employee("Shelley", "Weeks", 35));
            lReturnMe.Add(new Employee("Priscilla", "Wilkerson", 36));
            lReturnMe.Add(new Employee("Elsie", "Barton", 37));
            lReturnMe.Add(new Employee("Beth", "Walton", 38));
            lReturnMe.Add(new Employee("Erica", "Hall", 39));
            lReturnMe.Add(new Employee("Douglas", "Ross", 40));
            lReturnMe.Add(new Employee("Donald", "Chung", 41));
            lReturnMe.Add(new Employee("Katherine", "Bender", 42));
            lReturnMe.Add(new Employee("Paul", "Woods", 43));
            lReturnMe.Add(new Employee("Patricia", "Mangum", 44));
            lReturnMe.Add(new Employee("Lois", "Joseph", 45));
            lReturnMe.Add(new Employee("Louis", "Rosenthal", 46));
            lReturnMe.Add(new Employee("Christina", "Bowden", 47));
            lReturnMe.Add(new Employee("Darlene", "Barton", 48));
            lReturnMe.Add(new Employee("Harvey", "Underwood", 49));
            lReturnMe.Add(new Employee("William", "Jones", 50));
            lReturnMe.Add(new Employee("Frederick", "Baker", 51));
            lReturnMe.Add(new Employee("Shirley", "Merritt", 52));
            lReturnMe.Add(new Employee("Jason", "Cross", 53));
            lReturnMe.Add(new Employee("Judith", "Cooper", 54));
            lReturnMe.Add(new Employee("Gretchen", "Holmes", 55));
            lReturnMe.Add(new Employee("Don", "Sharpe", 56));
            lReturnMe.Add(new Employee("Glenda", "Morgan", 57));
            lReturnMe.Add(new Employee("Scott", "Hoyle", 58));
            lReturnMe.Add(new Employee("Pat", "Allen", 59));
            lReturnMe.Add(new Employee("Michelle", "Rich", 60));
            lReturnMe.Add(new Employee("Jessica", "Rich", 61));
            lReturnMe.Add(new Employee("Evan", "Grant", 62));
            lReturnMe.Add(new Employee("Melinda", "Proctor", 63));
            lReturnMe.Add(new Employee("Calvin", "Diaz", 64));
            lReturnMe.Add(new Employee("Eugene", "Graham", 65));
            lReturnMe.Add(new Employee("Vickie", "Watkins", 66));
            lReturnMe.Add(new Employee("Luis", "Hinton", 67));
            lReturnMe.Add(new Employee("Allan", "Marsh", 68));
            lReturnMe.Add(new Employee("Melanie", "Hewitt", 69));
            lReturnMe.Add(new Employee("Marianne", "Branch", 70));
            lReturnMe.Add(new Employee("Natalie", "Walton", 71));
            lReturnMe.Add(new Employee("Caroline", "O'Brien", 72));
            lReturnMe.Add(new Employee("Arlene", "Case", 73));
            lReturnMe.Add(new Employee("Kyle", "Watts", 74));
            lReturnMe.Add(new Employee("Calvin", "Christensen", 75));
            lReturnMe.Add(new Employee("Gary", "Parks", 76));

            //Return the result
            return lReturnMe;
        }
    }

    /// <summary>
    /// Class storing Employee Salary detail
    /// </summary>
    public class EmployeeSalary
    {
        /// <summary>
        /// Unique Employee ID
        /// </summary>
        public int EmployeeID
        {
            get;
            set;
        }

        /// <summary>
        /// Employee Salary Amount
        /// </summary>
        public double Salary
        {
            get;
            set;
        }

        /// <summary>
        /// Constructor for the Employee Salary object
        /// </summary>
        /// <param name="dSalary">Annual Salary for Employee</param>
        /// <param name="iEmployeeID">Employee ID</param>
        public EmployeeSalary(double dSalary, int iEmployeeID)
        {
            //Set the private variables
            Salary = dSalary;
            EmployeeID = iEmployeeID;
        }

        /// <summary>
        /// Override the ToString method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            //Return the Salary
            return string.Format("{0:C}", Salary.ToString());
        }
    }

    /// <summary>
    /// Class to manage Employee data
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Unique Employee ID
        /// </summary>
        public int EmployeeID
        {
            get;
            set;
        }

        /// <summary>
        /// Employee First Name
        /// </summary>
        public string FirstName
        {
            get;
            set;
        }

        /// <summary>
        /// Employee Last Name
        /// </summary>
        public string LastName
        {
            get;
            set;
        }

        #region Constructor Overrides

        /// <summary>
        /// Instantiate the Employee
        /// </summary>
        public Employee()
        { }

        /// <summary>
        /// Instantiate the Employee with pertinent data
        /// </summary>
        /// <param name="sFirstName">Employee First Name</param>
        /// <param name="sLastName">Employee Last Name</param>
        /// <param name="iEmployeeID">Employee ID</param>
        public Employee(string sFirstName, string sLastName, int iEmployeeID)
        {
            //Set the private variables
            FirstName = sFirstName;
            LastName = sLastName;
            EmployeeID = iEmployeeID;
        }

        #endregion

        /// <summary>
        /// Override the ToString() method so it returns a whole string about the Employee
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            ///Return a formatted string with the Employee ID and the Last, First
            return string.Format("{0} - {1}, {2}", EmployeeID, LastName, FirstName);
        }
    }
}