namespace Sturct
{
    enum Gender
    {
        Male,
        Female
    }
    public struct Employee
    {
        public int ID;
        public string Name;
        public double Salary;
        //public string Birthdate;
        //public int Day, Month, Year;
        public Date BirthDate;
    }
    public struct Date
    {
        public int Day, Month, Year;
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Enum
            //1-Enum
            Gender gender = Gender.Female;
            if (gender == Gender.Male)
            {

            }
            #endregion
            #region Casting
            //2-Casting
            int x = 3;
            double y = 5.8;
            //>> implicit casting
            double a = 3;
            //>> explicit casting
            //int b = y; >> not approved
            int b = (int)y;
            int v = (int)6.3;
            #endregion
            #region Struct

            /*int id;
            string name;
            double salary;*/

            //Use Struct

            Employee employee1,employee2;
            Employee employee3 = new Employee();

            employee1.ID = 4567;
            employee1.Name = "Hisham";
            employee1.Salary = 70000;
            employee2.ID = 4561;
            employee2.Name = "Ali";
            employee2.Salary = 75000;

            //employee3 = employee1;

            Console.WriteLine($"Fisrt Emp = {employee1.Name}");

            //array from struct
            Employee[] employees = new Employee[10];
            //employees[1].Name = "hany";

            /*for (int i = 0; i < length; i++)
            {

            }*/
            //Birdate
            employee1.BirthDate = new Date();
            employee1.BirthDate.Day = 15;
            #endregion


        }
    }
}
