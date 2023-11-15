namespace Lab_8_Generic_collections
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public decimal Salary { get; set; }

        public Employee(int id, string name, string gender, decimal salary)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Salary = salary;
        }
    }
}
