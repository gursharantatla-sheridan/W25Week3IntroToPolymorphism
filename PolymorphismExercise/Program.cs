namespace PolymorphismExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // without polymorphism

            //SalariedEmployee salEmp = new SalariedEmployee(101, "John", 1000);
            //Console.WriteLine(salEmp);
            //Console.WriteLine($"Earnings: {salEmp.Earnings():C}\n\n");

            //HourlyEmployee hrEmp = new HourlyEmployee(102, "Anne", 55, 20);
            //Console.WriteLine(hrEmp);
            //Console.WriteLine($"Earnings: {hrEmp.Earnings():C}\n\n");

            //CommissionEmployee commEmp = new CommissionEmployee(103, "Mark", 10000, 0.12);
            //Console.WriteLine(commEmp);
            //Console.WriteLine($"Earnings: {commEmp.Earnings():C}\n\n");



            // with polyomrphism

            //Employee emp;

            //emp = new SalariedEmployee(101, "John", 1000);
            //Console.WriteLine(emp);
            //Console.WriteLine($"Earnings: {emp.Earnings():C}\n\n");

            //emp = new HourlyEmployee(102, "Anne", 55, 20);
            //Console.WriteLine(emp);
            //Console.WriteLine($"Earnings: {emp.Earnings():C}\n\n");

            //emp = new CommissionEmployee(103, "Mark", 10000, 0.12);
            //Console.WriteLine(emp);
            //Console.WriteLine($"Earnings: {emp.Earnings():C}\n\n");



            // polymorphism with a collection (array)

            Employee[] emps = new Employee[3];
            emps[0] = new SalariedEmployee(101, "John", 1000);
            emps[1] = new HourlyEmployee(102, "Anne", 55, 20);
            emps[2] = new CommissionEmployee(103, "Mark", 10000, 0.12);

            foreach (Employee emp in emps)
            {
                Console.WriteLine(emp);
                Console.WriteLine($"Earnings: {emp.Earnings():C}\n\n");
            }
        }
    }
}
