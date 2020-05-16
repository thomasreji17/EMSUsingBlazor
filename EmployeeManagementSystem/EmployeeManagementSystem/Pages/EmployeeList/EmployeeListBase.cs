using EMS.Model;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Pages.EmployeeList
{
    public class EmployeeListBase:ComponentBase
    {
        protected IEnumerable<Employee> employees { get; set; }
        protected override async Task OnInitializedAsync()
        {
            await Task.Run(LoadEmployees);
        }
        private void LoadEmployees()
        {
            System.Threading.Thread.Sleep(3000);
            Employee e1 = new Employee()
            {
                Name = "Rose",
                Age = 25,
                Email = "Rose@hobbits.com",
                Gender = Gender.Female,
                Id = 1,
                ImageUrl = "images/e1.png"
            };

            Employee e2 = new Employee()
            {
                Name = "Jack",
                Age = 28,
                Email = "Jack@hobbits.com",
                Gender = Gender.Male,
                Id = 2,
                ImageUrl = "images/e3.jpg"
            };

            Employee e3 = new Employee()
            {
                Name = "Tony",
                Age = 30,
                Email = "Tony@hobbits.com",
                Gender = Gender.Male,
                Id = 3,
                ImageUrl = "images/e3.jpg"
            };

            Employee e4 = new Employee()
            {
                Name = "Steve",
                Age = 50,
                Email = "Steve@hobbits.com",
                Gender = Gender.Male,
                Id = 4,
                ImageUrl = "images/e3.jpg"
            };

            Employee e5 = new Employee()
            {
                Name = "Natasha",
                Age = 32,
                Email = "Natasha@hobbits.com",
                Gender = Gender.Female,
                Id = 5,
                ImageUrl = "images/e4.png"
            };
            this.employees = new List<Employee>() { e1, e2, e3, e4, e5 };
        }
    }
}
