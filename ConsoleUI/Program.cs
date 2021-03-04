using System;
using System.Collections.Generic;
using OCPLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IApplicantModel> applicants = new List<IApplicantModel>
            {
                new PersonModel { FirstName = "Tim", LastName = "Corey" },
                new ManagerModel { FirstName = "Sue", LastName = "Storm" },
                new ExecutiveModel { FirstName = "Nancy", LastName = "Roman" },
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();

            foreach (var person in applicants)
            {
                employees.Add(person.AccountProcessor.Create(person));
            }

            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}: {employee.EmailAddress} IsManager: {employee.IsManager} IsExecutive: {employee.IsExecutive}");
            }
            
            Console.ReadLine();
        }
    }
}