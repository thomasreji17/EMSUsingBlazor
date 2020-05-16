using System;

namespace EMS.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string ImageUrl { get; set; }
        public Gender Gender { get; set; }

        public int Age { get; set; }
        public string Email { get; set; }
    }

    public enum Gender
    {
        Male,
        Female
    }
}
