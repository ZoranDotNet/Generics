namespace Lab_8_Generic_collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create our objects 
            Employee e1 = new Employee(110, "Johan", "Male", 50000m);
            Employee e2 = new Employee(120, "Caroline", "Female", 45000m);
            Employee e3 = new Employee(130, "Tobias", "Male", 30000m);
            Employee e4 = new Employee(140, "Hanna", "Female", 55000m);
            Employee e5 = new Employee(150, "Stefan", "Male", 75000m);


            Stack<Employee> stack = new Stack<Employee>();
            List<Employee> employees = new List<Employee>();


            //push objects to stack
            stack.Push(e1);
            stack.Push(e2);
            stack.Push(e3);
            stack.Push(e4);
            stack.Push(e5);

            //loop through our stack and print objects
            foreach (Employee item in stack)
            {
                Console.WriteLine($"{item.Id} {item.Name} {item.Gender} {item.Salary}");
                Console.WriteLine($" Items left in the stack = {stack.Count}");
            }

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Retrieve using Pop method");

            //loop and pop objects
            while (stack.Count > 0)
            {
                Employee tempEmp = stack.Pop();
                Console.WriteLine($"{tempEmp.Id} {tempEmp.Name} {tempEmp.Gender} {tempEmp.Salary}");
                Console.WriteLine($"Items left in the stack = {stack.Count}");


            }

            //push back to stack
            stack.Push(e1);
            stack.Push(e2);
            stack.Push(e3);
            stack.Push(e4);
            stack.Push(e5);

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Retrieve using Peek method");
            Employee tempEmp2 = stack.Peek();
            Console.WriteLine($"{tempEmp2.Id} {tempEmp2.Name} {tempEmp2.Gender} {tempEmp2.Salary}");
            Console.WriteLine($"Items left in the stack = {stack.Count}");
            tempEmp2 = stack.Peek();
            Console.WriteLine($"{tempEmp2.Id} {tempEmp2.Name} {tempEmp2.Gender} {tempEmp2.Salary}");
            Console.WriteLine($"Items left in the stack = {stack.Count}");

            //check if object e3 is in the stack
            Console.WriteLine(stack.Contains(e3) ? "\nEmployee3 is in stack" : "\nEmployee3 is not in stack");
            Console.WriteLine("-----------------------------------------");

            //add to list
            employees.Add(e1);
            employees.Add(e2);
            employees.Add(e3);
            employees.Add(e4);
            employees.Add(e5);

            //look if object e2 is in the list
            Console.WriteLine(employees.Contains(e2) ? "Employee2 object exists in the list" : "Employee2 object does not exist in the list");

            Console.WriteLine();
            //find first object that is Male
            tempEmp2 = employees.Find(x => x.Gender == "Male");
            Console.WriteLine($"{tempEmp2.Id} {tempEmp2.Name} {tempEmp2.Gender} {tempEmp2.Salary}");

            Console.WriteLine("-----------------------------------------");

            //we find all Male and store in a new list
            List<Employee> maleList = employees.FindAll(x => x.Gender == "Male");

            //loop and print new list
            foreach (Employee item in maleList)
            {
                Console.WriteLine($"{item.Id} {item.Name} {item.Gender} {item.Salary}");
            }








        }
    }
}