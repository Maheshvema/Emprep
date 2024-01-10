// See https://aka.ms/new-console-template for more information
using ConAppTwo;
List<Employee> employees = new List<Employee>()
{
    new Employee(){Id=1,Name="Vijay",Designation="Developer",Doj=new DateTime(day:12,month:11,year:2022)},
    new Employee(){Id=2,Name="Ravi",Designation="Tester",Doj=new DateTime(day:12,month:11,year:2021)},
    new Employee(){Id=3,Name="Simi",Designation="Manager",Doj=new DateTime(day:12,month:11,year:2023)},
};
Console.WriteLine("Id \t Name \tDesignation\tDate of joining");
foreach(Employee emp in employees)
{
    Console.Write(emp.Id+"\t \t");
    Console.Write(emp.Name + "\t\t");
    Console.Write(emp.Designation + "\t\t");
    Console.Write(emp.Doj.ToLongDateString());
    Console.WriteLine("\n");
}
Console.ReadKey();